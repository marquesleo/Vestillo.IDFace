using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace Vestillo.IDFace.Entidade
{
    public class Device
    {
        public static string IPAddress;
        public static string ServerIp;
        private string session = null;
        Util config = new Util();
        public Device()
        {
            var ip_terminal = config.ipServer;
            var ip_servidor = config.ipTerminal;
        }

        public Device(string IPTerminal, string IPServer)
        {
            IPAddress = IPTerminal;
            ServerIp = IPServer;
        }

        public string[] CadastrarNoSevidor(out bool success)
        {
            List<string> response = new List<string>();
            response.Add("Cadastrando Servidor no equipamento.\r\n");
            try
            {
                //Verifica se o equipamento já está cadastrado no servidor e cadastra caso seja necessário
                if (ListObjects("{" +
                        "\"object\" : \"devices\"," +
                        "\"where\" : [{" +
                                "\"field\" : \"id\"," +
                                "\"value\" : -1" +

                            "}]" +
                        "}").Length == 0)
                {
                    try
                    {
                        sendJson("create_objects", "{" +
                                "\"object\" : \"devices\"," +
                                "\"values\" : [{" +
                                        "\"id\" : -1," +
                                        "\"name\" : \"Servidor\"," +
                                        "\"ip\" : \"" + ServerIp + "\"," +
                                        "\"public_key\" : \"anA=\"" +

                                    "}]" +
                                "}");
                        response.Add("Equipamento Servidor cadastrado com sucesso no Cliente.\r\n");
                    }
                    catch (Exception ex)
                    {
                        response.Add("Erro ao cadastrar Servidor, Device.cs, L65:");
                        response.Add("  - " + ex.Message + "\r\n");

                    }
                }
                else
                {
                    try
                    {
                        string jsonToSend = "";
                        jsonToSend += "{";
                        jsonToSend += "\"object\":\"devices\",";
                        jsonToSend += "\"values\":{\"name\":\"Servidor\",\"ip\":\"" + ServerIp + "\",\"public_key\":\"anA=\"},";
                        jsonToSend += "\"where\":{\"devices\":{\"id\":-1}}";
                        jsonToSend += "}";

                        sendJson("modify_objects", jsonToSend);
                        response.Add("Equipamento Servidor alterado com sucesso no Cliente.\r\n");
                    }
                    catch (Exception ex)
                    {
                        response.Add("Erro ao cadastrar Servidor, Device.cs, L65:");
                        response.Add("  - " + ex.Message + "\r\n");

                    }
                }
                ChangeType(true);
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
                response.Add("Erro ao cadastrar Servidor, Device.cs, L79:");
                response.Add("  - " + ex.Message + "\r\n");
                return response.ToArray();
            }

            //Inicia o monitoramento de identificações do equipamento
            try
            {
                // basic wcf web http service
                var binding = new WebHttpBinding();
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                binding.MaxBufferPoolSize = 2147483647;

                WebServiceHost host = new WebServiceHost(typeof(Server), new Uri("http://localhost:8000/"));
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IServer), binding, "");
                ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
                sdb.HttpHelpPageEnabled = false;
                host.Open();
                response.Add("Servidor iniciado no IP " + ServerIp + ", verifique se o firewall está liberado na porta 8000");
            }
            catch (Exception ex)
            {
                success = false;
                response.Add("Erro ao monitorar identificações:");
                response.Add("  - " + ex.Message + "\r\n");
                return response.ToArray();
            }

            return response.ToArray();
        }

        public string[] ChangeType(bool isOnline)
        {
            List<string> response = new List<string>();
            response.Add("Alterando modo de operação do equipamento\r\n");
            try
            {
                sendJson("set_configuration",
                    "{" +
                        "\"online_client\" : {" +
                                "\"server_id\" : \"-1\"," +
                                "\"extract_template\" : \"1\"" + /* se estiver com zero vai enviar a imagem ao invés do template biométrico para o servidor */

                            "}," +
                         "\"general\" : {" +
                            "\"online\" : \"" + (isOnline ? 1 : 0) + "\"," +

                            "\"local_identification\" : \"1\"" + /* se estiver com zero chama as funções "new_card" e " UserTemplate" */
                            /* se estiver com valor 1 chama a função "UserIdentified", na qual já vem o id do usuário no caso de biometria */

                            "}" +
                        "}"
                );
                response.Add("Modo de operação alteredo\r\n");
            }
            catch (Exception ex)
            {
                response.Add("Erro ao alterar Modo de Operação:");
                response.Add("  - " + ex.Message + "\r\n");
            }
            return response.ToArray();
        }

        public string Login()
        {
            if (session == null)
            {
                string response = sendJson("login", "{\"login\":\"admin\",\"password\":\"admin\"}", false);
                session = response.Split('"')[3];
            }
            return session;
        }


        private long UnixTimeStamp ()
        {
            DateTime now = DateTime.UtcNow;

            // Defina a data inicial do Unix Timestamp (1 de janeiro de 1970)
            DateTime unixEpochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Calcule a diferença entre a data atual e a data inicial
            long unixTimestamp = (long)(now - unixEpochStart).TotalSeconds;
            return unixTimestamp;
        }
        public string sendImagemUsuario(string uri, Usuario usuario, bool checkLogin  = true)
        {
            if (checkLogin)
            {
                Login();
                uri += ".fcgi?session=" + session;
            }
            else
                uri += ".fcgi";

            uri += "&user_id=" + usuario.Id + "&timestamp=" + UnixTimeStamp() +"&match=0";

            ServicePointManager.Expect100Continue = false;

            try
            {
                byte[] fileData = null;
                if (!string.IsNullOrEmpty(usuario.DiretorioImagem))
                    // Load the image file into a byte array
                    fileData = File.ReadAllBytes(usuario.DiretorioImagem);
                else
                    fileData = usuario.Imagem;

                using (var client = new HttpClient())
                {
                    var url = "http://" + IPAddress + "/" + uri;
                    var requestContent = new ByteArrayContent(fileData);
                    requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    HttpResponseMessage response = client.PostAsync(url, requestContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Image uploaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Error uploading image. Status code: " + response.StatusCode);
                    }
                }
                return "";


                /*var request = (HttpWebRequest)WebRequest.Create("http://" + IPAddress + "/" + uri);
                request.ContentType = "application/octet-stream";
                request.Method = "POST";
              


                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileData, 0, fileData.Length);
                   
                }
             
                var response = (HttpWebResponse)request.GetResponse();
                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    string responseData = responseStream.ReadToEnd();
                    return responseData;

                }*/
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    if (httpResponse == null)
                    {
                        throw new Exception("O servidor referente ao IP indicado não pôde ser encontrado");
                    }
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream responseData = response.GetResponseStream())
                    using (var reader = new StreamReader(responseData))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                        throw new Exception(text);
                    }
                }
            }
        }

        public byte[] getImagemUsuario(string uri, string id, bool checkLogin = true)
        {
            byte[] responseBody = null;
            if (checkLogin)
            {
                Login();
                uri += ".fcgi?session=" + session;
            }
            else
                uri += ".fcgi";

            uri += "&user_id=" + id;

            ServicePointManager.Expect100Continue = false;
          
            try
            {

                using (var client = new HttpClient())
                {
                    var url = "http://" + IPAddress + "/" + uri;

                    var content = new StringContent(string.Empty);
                    HttpResponseMessage response = client.PostAsync(url, content).Result;

                    if (response.IsSuccessStatusCode)
                    {

                        responseBody = response.Content.ReadAsByteArrayAsync().Result;
                    }
                    else
                    {
                        Console.WriteLine("Error uploading image. Status code: " + response.StatusCode);
                    }
                }
                return responseBody;
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    if (httpResponse == null)
                    {
                        throw new Exception("O servidor referente ao IP indicado não pôde ser encontrado");
                    }
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream responseData = response.GetResponseStream())
                    using (var reader = new StreamReader(responseData))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                        throw new Exception(text);
                    }
                }
            }
        }


       


        public string sendJson(string uri, string data, bool checkLogin = true)
        {
            if (checkLogin)
            {
                Login();
                uri += ".fcgi?session=" + session;
            }
            else
                uri += ".fcgi";
            ServicePointManager.Expect100Continue = false;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://" + IPAddress + "/" + uri);
                request.ContentType = "application/json";
                request.Method = "POST";

                               using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string responseData = streamReader.ReadToEnd();
                    Console.WriteLine(responseData);
                    return responseData;
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    if (httpResponse == null)
                    {
                        throw new Exception("O servidor referente ao IP indicado não pôde ser encontrado");
                    }
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream responseData = response.GetResponseStream())
                    using (var reader = new StreamReader(responseData))
                    {
                        string text = reader.ReadToEnd();
                        Console.WriteLine(text);
                        throw new Exception(text);
                    }
                }
            }
        }


        public Dictionary<string, string>[] ListObjects(string data)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            string response = sendJson("load_objects", data);
            int i = response.IndexOf("[") + 1;
            response = response.Substring(i, response.Length - 1 - i).Replace("\"", "");
            string[] listObjects = response.Split('}', '{');
            foreach (string sObj in listObjects)
            {
                if (sObj.Length <= 1)
                    continue;
                Dictionary<string, string> obj = new Dictionary<string, string>();
                string[] objFilds = sObj.Split(',');
                foreach (string field in objFilds)
                {
                    string[] value = field.Split(':');
                    obj.Add(value[0], value[1]);
                }
                list.Add(obj);
            }
            return list.ToArray();
        }

    }
}

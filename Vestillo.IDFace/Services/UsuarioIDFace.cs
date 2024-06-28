
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Vestillo.IDFace.Entidade;
using Vestillo.IDFace.Services;

namespace Vestillo.IDFace
{
    public class UsuarioIDFace
    {
        private Device _device;
        private Device device
        {
            get
            {
                if (_device == null)
                {
                    _device = new Device();
                    var IOConfiguracao = new IOConfiguracao();
                    var conectIDFace = new ConectaIDFace();
                    _device = conectIDFace.IniciarConexao(IOConfiguracao.GetIPTerminal());
                    _device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
                }

                return _device;
            }
        }

        private void ValidarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Id))
                throw new Exception("Id do usuário deve ser preenchido");

            if (string.IsNullOrEmpty(usuario.Name))
                throw new Exception("Nome do usuário deve ser preenchido");
        }


        public void IncluirUsuario(Usuario usuario)
        {
            try
            {
                IncluirUsuario(usuario, "","");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public class Action
        {
            [JsonProperty("action")]
            public string ActionName { get; set; }

            [JsonProperty("parameters")]
            public string Parameters { get; set; }
        }

        public class Data
        {
            [JsonProperty("actions")]
            public List<Action> Actions { get; set; }
        }



        public void LiberarAcesso()
        {
            try
            {

               
                var Result = new Result();
                Result.Event = 7;
                Result.user_id = 0;
                Result.user_name = "Portaria";
                Result.message = "Entrada Liberada";
                Result.portal_id = 1;
                Result.actions = new List<Entidade.Action>();
                Result.actions.Add(new Entidade.Action()
                {
                    ActionName = "sec_box",
                    Parameters = "id=65793, reason=1"
                });
                string jsonString = JsonConvert.SerializeObject(Result); 
                
                device.sendJson("remote_user_authorization", jsonString);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void IncluirUsuario(Usuario usuario, string servidor, string servidorAPI)
        {
            try
            {
                ValidarUsuario(usuario);
                var IOConfiguracao = new IOConfiguracao();


                if (!string.IsNullOrEmpty(servidor))
                    IOConfiguracao.SalvarArquivo(servidor, servidorAPI);

                if (!IsUsuarioExiste(usuario))
                {

                    sendUsuarioJson(usuario);
                    sendGrupoDeUsuarioJson(usuario);

                    if (usuario.Imagem != null || !string.IsNullOrEmpty(usuario.DiretorioImagem))
                    {

                        device.sendImagemUsuario("user_set_image", usuario, true);
                    }
                }
                else
                    throw new Exception("Usuário já cadastrado!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarUsuario(Usuario usuario)
        {
            AlterarUsuario(usuario, "", "" );
        }

        public void AlterarUsuario(Usuario usuario, string servidor, string servidorAPI)
        {
            try
            {
                ValidarUsuario(usuario);
                var IOConfiguracao = new IOConfiguracao();


                if (!string.IsNullOrEmpty(servidor))
                    IOConfiguracao.SalvarArquivo(servidor, servidorAPI);

                AlterarUsuarioJson(usuario);


                if (usuario.Imagem != null || !string.IsNullOrEmpty(usuario.DiretorioImagem))
                {

                    device.sendImagemUsuario("user_set_image", usuario, true);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public byte[] GetImagemUsuario(Usuario usuario)
        {
            var retorno = device.getImagemUsuario("user_get_image", usuario.Id, true);
            return retorno;
        }

        private bool IsUsuarioExiste(Usuario usuario)
        {
            bool retorno = false;
            var list = RetornarUsuarios();
            foreach (var user in list)
            {

                if (user.Id == usuario.Id)
                {
                    retorno = true;
                    break;
                }
                else if (user.Id == usuario.Id && usuario.Name.ToLower() == usuario.Name.ToLower())
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public Dictionary<string, string>[] RetornarTodosUsuarios()
        {
            // checar se já existe usuário registrado com o ID especificado
            Dictionary<string, string>[] list = device.ListObjects("{\"object\":\"users\"}");

            return list;
        }


        public List<Usuario> RetornarUsuarios()
        {
            var retorno = new List<Usuario>();
            Dictionary<string, string>[] list = device.ListObjects("{\"object\":\"users\"}");

            if (list != null)
            {

                for (int i = 0; i < list.Length; i++)
                {

                    var reg = list[i];
                    var usuario = new Usuario();

                    if (reg.ContainsKey("id"))
                    {
                        var id = "";
                        reg.TryGetValue("id", out id);
                        usuario.Id = id;

                    }
                    if (reg.ContainsKey("name"))
                    {
                        var name = "";
                        reg.TryGetValue("name", out name);
                        usuario.Name = name;
                    }
                    if (reg.ContainsKey("registration"))
                    {
                        var registration = "";
                        reg.TryGetValue("registration", out registration);
                        usuario.Matricula = registration;
                    }
                    retorno.Add(usuario);


                }


            }
            return retorno;
        }
        private void sendUsuarioJson(Usuario usuario)
        {

            try
            {
                string strJson = "{" +
                      "\"object\" : \"users\"," +
                      "\"values\" : [{" +
                              "\"id\" :" + usuario.Id + "," +
                              "\"name\" :\"" + usuario.Name + "\"," +
                              "\"registration\" : \"" + usuario.Matricula + "\"" +
                          "}]" +
                      "}";

                device.sendJson("create_objects", strJson);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void AlterarUsuarioJson(Usuario usuario)
        {

            try
            {
                string jsonToSend = "{" +
                      "\"object\": \"users\"," +
                      "\"values\": {" +
                      "\"name\": \"" + usuario.Name + "\"," +
                      "\"registration\": \"" + usuario.Matricula + "\"" +

                      "}," +
                      "\"where\": {" +
                      "\"users\": {" +
                        "\"id\" :" + usuario.Id +
                      "}" +
                      "}" +
                      "}";




                device.sendJson("modify_objects", jsonToSend);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        private void sendGrupoDeUsuarioJson(Usuario usuario)
        {

            try
            {
                string strJson = "{" +
       "\"object\" : \"user_groups\"," +
       "\"values\" : [{" +
               "\"user_id\" :" + usuario.Id + "," +
               "\"group_id\" :" + "1" + // Removed the extra quotes around the 1
             "}]" +
       "}";

                device.sendJson("create_objects", strJson);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}

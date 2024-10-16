﻿
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
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
                    var config = IOConfiguracao.GetIPTerminal();
                    _device = conectIDFace.IniciarConexao(config.Servidor,
                                                          config.ComputadorAPI,
                                                          false);

                    _device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
                }

                return _device;
            }
        }

        private void ValidarUsuario(Usuario usuario, ref string msgErro)
        {
            var lstErro = new StringBuilder();
            if (usuario.Id == 0)
                lstErro.AppendLine("Id do usuário deve ser preenchido");

            if (string.IsNullOrEmpty(usuario.Name))
                lstErro.AppendLine("Nome do usuário deve ser preenchido");


            msgErro = lstErro.ToString();   
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
                LoggerInitializer.ConfigureLogger();
                Log.Information("Iniciando liberacao de acesso");

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
                Log.Information("Iniciando serializacao do objeto result");

                string jsonString = JsonConvert.SerializeObject(Result);

                Log.Information("Objeto result serializado :" + jsonString);

                device.sendJson("remote_user_authorization", jsonString);


                Log.Information("comando para liberar porta feito !!!");

            }
            catch (Exception ex)
            {
                Log.Information("erro " + ex.Message);
                throw ex;
            }
        }



        public bool IncluirUsuario(Usuario usuario, ref string msgErro)
        {
            bool retorno = false;
            try
            {
                ValidarUsuario(usuario, ref msgErro);

                if (!IsUsuarioExiste(usuario))
                {

                    sendUsuarioJson(usuario);
                    sendGrupoDeUsuarioJson(usuario);

                    if (usuario.Imagem != null || !string.IsNullOrEmpty(usuario.DiretorioImagem))
                    {

                        device.sendImagemUsuario("user_set_image", usuario, true);
                    }
                    retorno = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(msgErro))
                    {
                        msgErro += "\r";
                    }
                    msgErro += "Usuário já cadastrado!";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

       

        public bool AlterarUsuario(Usuario usuario, ref string msgErro)
        {
            bool retorno = false;
            try
            {
                ValidarUsuario(usuario, ref msgErro);
              
                AlterarUsuarioJson(usuario);

                if (usuario.Imagem != null || !string.IsNullOrEmpty(usuario.DiretorioImagem))
                {

                    device.sendImagemUsuario("user_set_image", usuario, true);
                }
                retorno = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public void ExcluirUsuario(Usuario usuario)
        {
            try
            {
                string jsonString = @"
            {
                    ""object"": ""users"",
                    ""where"": [
                        {
                             ""object"": ""users"",
                            ""field"": ""id"",
                             ""operator"": ""="",
                            ""value"": " + usuario.Id + " }]} ";

                device.sendJson("destroy_objects", jsonString);
            }
            catch (Exception ex)
            {

                throw;
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
                        string id = "";
                        reg.TryGetValue("id", out id);
                        usuario.Id = Convert.ToInt32(id);

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

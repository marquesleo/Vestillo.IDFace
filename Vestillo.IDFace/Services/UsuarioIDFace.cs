
using System;
using System.Collections.Generic;
using Vestillo.IDFace.Entidade;
using Vestillo.IDFace.Services;

namespace Vestillo.IDFace
{
    public class UsuarioIDFace
    {
        private Device device;

        private void ValidarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Id))
                throw new Exception("Id do usuário deve ser preenchido");

            if (string.IsNullOrEmpty(usuario.Name))
                throw new Exception("Nome do usuário deve ser preenchido");
        }

        public void IncluirUsuario(Usuario usuario, string servidor )
        {
            try
            {
                ValidarUsuario(usuario);
                var IOConfiguracao = new IOConfiguracao();
                var conectIDFace = new ConectaIDFace();

                if (!string.IsNullOrEmpty(servidor))
                  IOConfiguracao.SalvarArquivo(servidor);
            
                device = conectIDFace.IniciarConexao(IOConfiguracao.GetIPTerminal());

                 
                device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
                if (!IsUsuarioExiste(usuario))
                {
                    
                    sendUsuarioJson(usuario);
                    sendGrupoDeUsuarioJson(usuario);

                    if (usuario.Imagem != null)
                    {
                        device.sendImagemUsuario("user_set_image", usuario, true);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

          

        }
       
        private bool IsUsuarioExiste(Usuario usuario)
        {
            bool retorno = false;
            Dictionary<string, string>[] list = RetornarUsuarios();
            foreach (var user in list)
            {

                if (String.Equals(user["id"].ToString(), usuario.Id))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public Dictionary<string, string>[] RetornarUsuarios()
        {
            // checar se já existe usuário registrado com o ID especificado
            Dictionary<string, string>[] list = device.ListObjects("{\"object\":\"users\"}");
                      
            return list;
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

using System;
using System.Net.Sockets;
using System.Net;
using Vestillo.IDFace.Entidade;
using System.Web;

namespace Vestillo.IDFace
{
    public class ConectaIDFace
    {

        private static string ip_server;
    
        public Device IniciarConexao(string ip_terminal)
        {
            Device device = null;

            try
            {
                foreach (var ip in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork && string.IsNullOrEmpty(ip_server))
                    {
                        ip_server = ip.ToString() + ":8000";
                        
                    }
                }

                device = new Device(ip_terminal, ip_server);
                bool success = true;
                var retorno = device.CadastrarNoSevidor(out success);
                return device;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
           
        }


        


    }
}

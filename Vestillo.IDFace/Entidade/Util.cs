using System;


namespace Vestillo.IDFace.Entidade
{
    class Util
    {

        public string ipServer;
        public string ipTerminal;

        public String GetIpServer()
        {
            return ipServer = Device.ServerIp;

        }
        public String GetIpTerminal()
        {

            return ipTerminal = Device.IPAddress;
        }
    }
}

using System.IO;
using System.Xml.Serialization;
using Vestillo.IDFace.Entidade;

namespace Vestillo.IDFace.Services
{
    public class IOConfiguracao
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


        private const string filePath = "configuracao.xml";
        private void SalvarArquivo(Configuracao configuracao)
        {
            try
            {

                if (!File.Exists(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuracao));
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, configuracao);
                    }
                }

                var conectIDFace = new ConectaIDFace();
               var _device = conectIDFace.IniciarConexao(configuracao.Servidor,configuracao.ComputadorAPI);
                _device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
            }
            catch (System.Exception)
            {

                throw;
            }
          
        }

        public void SalvarArquivo(string  ipdoaparelho, string apiServidor)
        {

            var configuracao = new Configuracao 
            {
                Servidor = ipdoaparelho,
                 ComputadorAPI =apiServidor
            };

            SalvarArquivo(configuracao);

        }


        public  string GetIPTerminal()
        {
            var config = RetornarConfiguracao();
            return config.Servidor;
        }

        public Configuracao RetornarConfiguracao()
        {
            Configuracao config = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Configuracao));

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    config = (Configuracao)serializer.Deserialize(reader);

                }
            }

            return config;
        }
    }

  



}

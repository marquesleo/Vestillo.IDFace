using System.Configuration;
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
                    var config = IOConfiguracao.GetIPTerminal();
                    _device = conectIDFace.IniciarConexao(config.Servidor,
                                                          config.ComputadorAPI,
                                                          false);

                    _device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
                }

                return _device;
            }
        }


        private const string filePath =  "configuracao.xml";
        private void SalvarArquivo(Configuracao configuracao)
        {
            try
            {
                var diretorio = ConfigurationSettings.AppSettings["diretorio"];

                if (!File.Exists(diretorio + "\\" + filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuracao));
                    using (StreamWriter writer = new StreamWriter(diretorio + "\\" + filePath))
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


        public  Configuracao GetIPTerminal()
        {
            return RetornarConfiguracao();
           
        }

        public Configuracao RetornarConfiguracao()
        {
            Configuracao config = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Configuracao));
            var diretorio = ConfigurationSettings.AppSettings["diretorio"];
            if (File.Exists(diretorio + "\\" + filePath))
            {
                using (StreamReader reader = new StreamReader(diretorio + "\\" + filePath))
                {
                    config = (Configuracao)serializer.Deserialize(reader);

                }
            }

            return config;
        }
    }

  



}

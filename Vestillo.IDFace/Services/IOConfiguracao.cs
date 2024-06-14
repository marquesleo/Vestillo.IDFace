using System.IO;
using System.Xml.Serialization;
using Vestillo.IDFace.Entidade;

namespace Vestillo.IDFace.Services
{
    public class IOConfiguracao
    {

        private const string filePath = "configuracao.xml";
        private void SalvarArquivo(Configuracao configuracao)
        {

            if (!File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuracao));
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, configuracao);
                }
            }
        }

        public void SalvarArquivo(string  servidor)
        {

            var configuracao = new Configuracao
            {
                Servidor = servidor
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

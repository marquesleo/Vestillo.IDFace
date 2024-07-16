using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.ServiceProcess;
using Vestillo.IDFace.Entidade;
using System.Diagnostics;
using NLog;

namespace Vestillo.IDFace.Service
{
    public partial class Service : ServiceBase
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        const string servico = "Vestillo.IDFACE.Service";
        public Service()
        {
            InitializeComponent();
          
        }

        public WebServiceHost host;

       

        protected override void OnStart(string[] args)
        {
            try
            {

                logger.Info(servico + " iniciado.");
                var IOConfiguracao = new Services.IOConfiguracao();

                var config = IOConfiguracao.GetIPTerminal();
                if (config == null)
                {
                    logger.Info("Nao tem configuracao");
                }
                logger.Info("config idface=" + config.Servidor);
                logger.Info("config api server=" + config.ComputadorAPI);

                // basic wcf web http service
                var binding = new WebHttpBinding();
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                binding.MaxBufferPoolSize = 2147483647;

                host = new WebServiceHost(typeof(Server), new Uri("http://" + config.ComputadorAPI + "/api"));
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IServer), binding, "");
                ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
                sdb.HttpHelpPageEnabled = false;
                host.Open();
                logger.Info("Configuracao feita!");
                // Log or handle your response here
            }
            catch (Exception ex)
            {
                logger.Info(ex.Message);
            }
        }

        protected override void OnStop()
        {
            logger.Info(servico + " finalizado");
            if (host != null)
            {
                host.Close();
                host = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Vestillo.IDFace.Service
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            // Criação de um serviço processInstaller
            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller();
            ServiceInstaller serviceInstaller = new ServiceInstaller();

            // Defina as propriedades do processInstaller
            processInstaller.Account = ServiceAccount.LocalSystem;

            // Defina as propriedades do serviceInstaller
            serviceInstaller.DisplayName = "Vestillo.IDFACE.Service";
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            // O nome do serviço deve corresponder ao nome do serviço na sua classe de serviço
            serviceInstaller.ServiceName = "Vestillo.IDFACE.Service";

            // Adiciona os instaladores ao Installers Collection
            this.Installers.Add(processInstaller);
            this.Installers.Add(serviceInstaller);
        }
    }
}

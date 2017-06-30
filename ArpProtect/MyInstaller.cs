using System.Configuration.Install;
using System.ComponentModel;
using System.ServiceProcess;

namespace ArpProtect
{
    [RunInstaller(true)]

    public class MyInstaller:Installer
    {
         public MyInstaller()
  {
    var processInstaller = new ServiceProcessInstaller();
    var serviceInstaller = new ServiceInstaller();

    //set the privileges
    processInstaller.Account = ServiceAccount.LocalSystem;

    serviceInstaller.DisplayName = "ArpProtect";
    serviceInstaller.StartType = ServiceStartMode.Automatic;             

    //must be the same as what was set in Program's constructor
    serviceInstaller.ServiceName = "ArpProtect";

    this.Installers.Add(processInstaller);
    this.Installers.Add(serviceInstaller);
  }

    }
}

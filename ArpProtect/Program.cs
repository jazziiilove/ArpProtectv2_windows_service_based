using System.ServiceProcess;

namespace ArpProtect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new ArpProtect() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}

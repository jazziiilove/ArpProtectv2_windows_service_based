using System.ServiceProcess;
using System.Threading;
/*
 *King is Baran Topal 
 */
namespace ArpProtect
{

    public partial class ArpProtect : ServiceBase
    {
        /*
          Register this service from command line. 
          run->cmd
          Go to InstallUtil:
          C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe is the default location 
         
          Apply the command to install the service
           
          InstallUtil C:\ArpProtect\ArpProtect\ArpProtect\bin\Debug\ArpProtect.exe
          
          You use /u option to uninstall the service. 
          
          InstallUtil /u C:\ArpProtect\ArpProtect\ArpProtect\bin\Debug\ArpProtect.exe
          
          
        */
        public ArpProtect()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            while (true)
            {

                Thread.Sleep(120000);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
                info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                info.FileName = "arp.exe";
                info.Arguments = " -s 139.179.33.1 00-15-f2-64-a3-38";
                process.StartInfo = info;
                process.Start();

            }
            //Process p = new Process();
            
            /*
            p.StartInfo.FileName = "arp.exe";
            //p.StartInfo.Arguments = " -s 139.179.33.1 00-15-f2-64-a3-38";
            p.StartInfo.Arguments = "-d";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.RedirectStandardOutput = true;
            */
            /*
            p.StartInfo.FileName = "IPCONFIG"; 
            p.StartInfo.UseShellExecute = false; 
            p.StartInfo.Arguments = "/all"; 
            p.StartInfo.RedirectStandardOutput = true; 
            */
            //p.Start();
            
            //textBox1.Text = p.StandardOutput.ReadToEnd();
            /*
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
            FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Started \n");
            m_streamWriter.Flush();
            m_streamWriter.Close(); 
            */
        }

        protected override void OnStop()
        {
            base.OnStop();
            /*
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
           FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Stopped \n");
            m_streamWriter.Flush();
            m_streamWriter.Close(); 
             */
        }
    }
}

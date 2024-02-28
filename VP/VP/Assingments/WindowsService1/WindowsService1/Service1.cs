using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        public Service1()
        {
            InitializeComponent();
        }


        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace('/', '_') + ".text"; 
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

      

        protected override void OnStart(string[] args)
        {
            WriteToFile("services is Started at :" + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElaspedTime);
            timer.Interval = 5000;
            timer.Enabled = true;
        }

        public void OnElaspedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile("Service is recal at: " + DateTime.Now);
        }

        protected override void OnStop()
        {
            WriteToFile("Service is Stoped at: " + DateTime.Now);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public static class Protection
    {
        internal static void Start()
          => new Thread(new ThreadStart(DetectFiddler)) { IsBackground = true }.Start();
        public static int a = 0;
        public static bool NichtLUL;
        private static IList<string> blackListed = new List<string>()
        {
            "Fiddler",
            "Process Hacker",
            "Cheat Engine",
            "dnSpy",
            "IDA",
            "DNView"
        };
        //public static void cmdAN()
        //{
        //    System.Diagnostics.Process process = new System.Diagnostics.Process();
        //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        //    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        //    startInfo.FileName = "cmd.exe";
        //    startInfo.Arguments = "echo Debugger Detected:" +process.ProcessName;
        //    process.StartInfo = startInfo;
        //    process.Start();
        //}
            public static void DetectFiddler()
            {
           
            var currentMainWindowTitle = Process.GetCurrentProcess().MainWindowTitle;
            while (true)
            {
                foreach (var process in Process.GetProcesses())
                {
                    if (process.MainWindowTitle == null) continue;
                    if (currentMainWindowTitle == process.MainWindowTitle) continue;
                    if (!Contains(process.MainWindowTitle)) continue;
                    try
                    {
                        process.Kill();
                      
                        
                        //process.Kill();
                        //Debugger db = new Debugger();
                        //db.Show();
                    }
                    catch
                    {
                        Environment.FailFast("");
                    }
                }
            }
        }
        private static bool Contains(string mainWindowTitle)
        {
            foreach (var element in blackListed)
                if (mainWindowTitle.ToLower().Contains(element.ToLower()))
                    return true;

            return false;
        }
    }
}

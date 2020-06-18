using E3Modz.Black_Ops_3;
using E3Modz.Login___Home;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace E3Modz
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string resource1 = "E3Modz.Bunifu_UI_v1.52.dll";
            EmbeddedAssembly.Load(resource1, "Bunifu_UI_v1.52.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Protection.Start();
            //Protection.StartDebugger();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login2());
            
            
        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}

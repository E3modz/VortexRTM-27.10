using E3Modz.Login___Home;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace E3Modz
{
    public partial class Login2 : Form
    {
        public bool AutoLogin = E3Modz.Properties.Settings.Default.AutoLogin;
        public static Point newpoint = new Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor,
        uint nLength, out uint lpnLengthNeeded);

        public static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
        {
            const int DACL_SECURITY_INFORMATION = 0x00000004;
            byte[] psd = new byte[0];
            uint bufSizeNeeded;
            // Call with 0 size to obtain the actual size needed in bufSizeNeeded
            GetKernelObjectSecurity(processHandle, DACL_SECURITY_INFORMATION, psd, 0, out bufSizeNeeded);
            if (bufSizeNeeded < 0 || bufSizeNeeded > short.MaxValue)
                throw new Win32Exception();
            // Allocate the required bytes and obtain the DACL
            if (!GetKernelObjectSecurity(processHandle, DACL_SECURITY_INFORMATION,
            psd = new byte[bufSizeNeeded], bufSizeNeeded, out bufSizeNeeded))
                throw new Win32Exception();
            // Use the RawSecurityDescriptor class from System.Security.AccessControl to parse the bytes:
            return new RawSecurityDescriptor(psd, 0);
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentProcess();

        [Flags]
        public enum ProcessAccessRights
        {
            PROCESS_CREATE_PROCESS = 0x0080, //  Required to create a process.
            PROCESS_CREATE_THREAD = 0x0002, //  Required to create a thread.
            PROCESS_DUP_HANDLE = 0x0040, // Required to duplicate a handle using DuplicateHandle.
            PROCESS_QUERY_INFORMATION = 0x0400, //  Required to retrieve certain information about a process, such as its token, exit code, and priority class (see OpenProcessToken, GetExitCodeProcess, GetPriorityClass, and IsProcessInJob).
            PROCESS_QUERY_LIMITED_INFORMATION = 0x1000, //  Required to retrieve certain information about a process (see QueryFullProcessImageName). A handle that has the PROCESS_QUERY_INFORMATION access right is automatically granted PROCESS_QUERY_LIMITED_INFORMATION. Windows Server 2003 and Windows XP/2000:  This access right is not supported.
            PROCESS_SET_INFORMATION = 0x0200, //    Required to set certain information about a process, such as its priority class (see SetPriorityClass).
            PROCESS_SET_QUOTA = 0x0100, //  Required to set memory limits using SetProcessWorkingSetSize.
            PROCESS_SUSPEND_RESUME = 0x0800, // Required to suspend or resume a process.
            PROCESS_TERMINATE = 0x0001, //  Required to terminate a process using TerminateProcess.
            PROCESS_VM_OPERATION = 0x0008, //   Required to perform an operation on the address space of a process (see VirtualProtectEx and WriteProcessMemory).
            PROCESS_VM_READ = 0x0010, //    Required to read memory in a process using ReadProcessMemory.
            PROCESS_VM_WRITE = 0x0020, //   Required to write to memory in a process using WriteProcessMemory.
            DELETE = 0x00010000, // Required to delete the object.
            READ_CONTROL = 0x00020000, //   Required to read information in the security descriptor for the object, not including the information in the SACL. To read or write the SACL, you must request the ACCESS_SYSTEM_SECURITY access right. For more information, see SACL Access Right.
            SYNCHRONIZE = 0x00100000, //    The right to use the object for synchronization. This enables a thread to wait until the object is in the signaled state.
            WRITE_DAC = 0x00040000, //  Required to modify the DACL in the security descriptor for the object.
            WRITE_OWNER = 0x00080000, //    Required to change the owner in the security descriptor for the object.
            STANDARD_RIGHTS_REQUIRED = 0x000f0000,
            PROCESS_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFF),//    All possible access rights for a process object.
        }
        public static void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
        {
            const int DACL_SECURITY_INFORMATION = 0x00000004;
            byte[] rawsd = new byte[dacl.BinaryLength];
            dacl.GetBinaryForm(rawsd, 0);
            if (!SetKernelObjectSecurity(processHandle, DACL_SECURITY_INFORMATION, rawsd))
                throw new Win32Exception();
        }
        public Login2()
        {
            InitializeComponent();
            // Get the current process handle
            IntPtr hProcess = GetCurrentProcess();
            // Read the DACL
            var dacl = GetProcessSecurityDescriptor(hProcess);
            // Insert the new ACE
            dacl.DiscretionaryAcl.InsertAce(
            0,
            new CommonAce(
            AceFlags.None,
            AceQualifier.AccessDenied,
            (int)ProcessAccessRights.PROCESS_ALL_ACCESS,
            new SecurityIdentifier(WellKnownSidType.WorldSid, null),
            false,
            null)
            );
            // Save the DACL
            SetProcessSecurityDescriptor(hProcess, dacl);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }
        //public static void ToggleTaskManager(bool toggle)
        //{
        //    Microsoft.Win32.RegistryKey HKCU = Microsoft.Win32.Registry.LocalMachine;
        //    Microsoft.Win32.RegistryKey key = HKCU.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
        //    key.SetValue("DisableTaskMgr", toggle ? 0 : 1, Microsoft.Win32.RegistryValueKind.DWord);
        //}
        public string getVersion()
        {
            return Home.Version;
        }
        static string GetAll =  "Machinename: " + Environment.MachineName + Environment.NewLine + "HWID: " + GetMachineGuid() + Environment.NewLine + "Windowskey: " + GetKey().ToString();
        static string GetAll2 = "Username: " + Environment.UserName + Environment.NewLine + "Machinename: " + Environment.MachineName + Environment.NewLine + "HWID: " + GetMachineGuid() + Environment.NewLine + "Windowskey: " + GetKey().ToString() + Environment.NewLine + "Serialnumber: " + GetSerial(string.Empty);
        //Methode zum Anmelden
        string hwidstr = "";
        private void Login()
        {
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {

                    if (Execute("accessAccount", "userName=" + bunifuMaterialTextbox1.Text + "&password=" + bunifuMaterialTextbox2.Text + "&hwid=" + hwidstr) == 1)
                    {
                        WebClient fetchInfo = new WebClient();
                        string debug = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + bunifuMaterialTextbox1.Text);
                        if (debug == "")
                        {
                            DialogResult result = MessageBox.Show("There is no computer for the license registered you want to enter this computer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                
                                hwidstr = GetAll;
                            }
                            else if (result == DialogResult.No)
                            {
                                
                                hwidstr = "";
                            }
                        }

                    
                        string str = "https://dayz.planb-life.com/";
                        string str2 = "Vortex Multi RTM Tool.exe";
                        string str3 = "version.txt";
                        WebRequest webRequest = WebRequest.Create(str + str3);
                        WebResponse response = webRequest.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        StreamReader streamReader = new StreamReader(responseStream);
                        string text = streamReader.ReadLine();
                        Username = bunifuMaterialTextbox1.Text; //To pass it to any other froms (=global)
                        Password = bunifuMaterialTextbox2.Text;
                        //same for pass
                        string premiumState = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hasVortex&userName=" + Username);
                        string HWID = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + Username);
                        if (HWID == GetAll)
                        {
                            if (premiumState == "1")
                            {

                                bool flag = this.getVersion() != text;
                                if (flag)
                                {
                                    MessageBox.Show("You are logged in, but there is an Update avaible!", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Updater u = new Updater();
                                    u.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("You are logged in!", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Dashboard f2 = new Dashboard();
                                    f2.Show();
                                    this.Hide();
                                }

                            }
                            else
                            {
                                Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                                MessageBox.Show("You don't have the license to loggin!\n Please Buy it on the Website or close the Application!", "License Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (hwidstr == GetAll)
                        {

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Login failed \nDo you want to reset the license?", "VortexRTM",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("https://powermoddingteam.com");
                                Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";

                            }
                            else if (result == DialogResult.No)
                            {
                                MessageBox.Show("You are not allowed to use the application the program will exit now automatically\nContact the Support for help!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                                AutoLogin = false;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                                MessageBox.Show("You are not allowed to use the application the program will exit now automatically\nContact the Support for help!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                                AutoLogin = false;
                            }
                        }
                    }

                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Internet Connection Lost! Check your Internet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutoLoginMethod()
        {

            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {

                    if (Execute("accessAccount", "userName=" + bunifuMaterialTextbox1.Text + "&password=" + bunifuMaterialTextbox2.Text + "&hwid=" + hwidstr) == 1)
                    {
                        WebClient fetchInfo = new WebClient();
                        string debug = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + bunifuMaterialTextbox1.Text);
                        if (debug == "")
                        {
                            DialogResult result = MessageBox.Show("There is no computer for the license registered you want to enter this computer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                hwidstr = GetAll;
                            }
                            else if (result == DialogResult.No)
                            {
                                hwidstr = "0";
                            }
                        }
                        string str = "https://dayz.planb-life.com/";
                        string str2 = "Vortex Multi RTM Tool.exe";
                        string str3 = "version.txt";
                        WebRequest webRequest = WebRequest.Create(str + str3);
                        WebResponse response = webRequest.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        StreamReader streamReader = new StreamReader(responseStream);
                        string text = streamReader.ReadLine();
                        E3Modz.Properties.Settings.Default["username"] = bunifuMaterialTextbox1.Text;
                        E3Modz.Properties.Settings.Default["password"] = bunifuMaterialTextbox2.Text;
                        E3Modz.Properties.Settings.Default.Save();
                        Username = bunifuMaterialTextbox1.Text; //To pass it to any other froms (=global)
                        Password = bunifuMaterialTextbox2.Text;
                        //same for pass
                        string premiumState = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hasVortex&userName=" + Username);
                        string HWID = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + Username);
                        if (HWID == GetAll)
                        {
                            if (premiumState == "1")
                            {

                                bool flag = this.getVersion() != text;
                                if (flag)
                                {

                                    Updater u = new Updater();
                                    u.Show();
                                    this.Hide();

                                }
                                else
                                {

                                    Dashboard f2 = new Dashboard();
                                    f2.Show();
                                    this.Hide();

                                }

                            }
                            else
                            {
                                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                                E3Modz.Properties.Settings.Default.Save();
                                MessageBox.Show("You don't have the license to loggin!\n Please Buy it on the Website or close the Application!", "License Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (hwidstr == GetAll)
                        {

                        }
                        else
                        {
                            
                            DialogResult result = MessageBox.Show("Login failed \nDo you want to reset the license?", "VortexRTM",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("https://powermoddingteam.com");

                            }
                            else if (result == DialogResult.No)
                            {
                                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                                E3Modz.Properties.Settings.Default.Save();
                                MessageBox.Show("You are not allowed to use the application the program will exit now automatically\nContact the Support for help!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                                E3Modz.Properties.Settings.Default.Save();
                                MessageBox.Show("You are not allowed to use the application the program will exit now automatically\nContact the Support for help!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                            }
                        }
                    }

                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Internet Connection Lost! Check your Internet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string Identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }

        static string GetKey()
        {
            return KeyDecoder.GetWindowsProductKeyFromRegistry();
        }

        static string GetSerial(string serialNumber)
        {

            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString();
            }
            return serialNumber;
        }

        public static string GetMachineGuid()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                        throw new KeyNotFoundException(string.Format("Key not found: {0}", location));

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index not found: {0}", name));

                    return machineGuid.ToString();
                }
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //The main function
        public static int Execute(string action, string args)
        {

            WebClient requests = new WebClient();
            string url = "https://dayz.planb-life.com/execute.php";
            string urlaction = "?action=" + action;
            string urlargs = "&" + args;
            string buildurl = url + urlaction + urlargs;

            string response = requests.DownloadString(buildurl);
            if (response == null)
            {
                return 0;
            }

            if (!response.StartsWith("OK"))
            {
                CheckError(response);
                return 0;
            }

            return 1;
        }


        public static void RaiseError(string error)
        {
            MessageBox.Show(error, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static int CheckError(string error)
        {

            Dictionary<string, string> Errors = new Dictionary<string, string>();
            Errors.Add("MISSING_PARAMETERS", "Missing parameters");
            Errors.Add("INVALID_KEY", "The registration key is not valid");
            Errors.Add("USERNAME_TOO_SHORT", "Your username is too short");
            Errors.Add("PASSWORD_TOO_SHORT", "Your password is too short");
            Errors.Add("USERNAME_TAKEN", "The username you choose is already taken");
            Errors.Add("PASSWORDS_NOT_MATCH", "Passwords do not match");
            Errors.Add("USER_BANNED", "YOU HAVE BEEN BANNED!\n\n Contact The Support!");
            Errors.Add("NO_ACTION", "No action");
            Errors.Add("Hiwd_NotSame", "Your license is not avaible for this computer! You can ask for a resett if you have an new Computer!");
            Errors.Add("NOT_ENOUGH_PRIVILEGES", "You do not have enough privileges");
            Errors.Add("INVALID_CREDENTIALS", "Username or password is wrong");
            Errors.Add("New_Hwid", "New HWID");

            if (!error.StartsWith("ERROR"))
            {
                RaiseError(error);
                return 0;
            }
            
            string message = "Undefined error";
            string[] array = error.Split(':');
            if (array.Length == 2 && Errors.ContainsKey(array[1]))
            {
                string key = array[1];
                message = Errors[key];
            }

            RaiseError(message);
            return 1;
        }
     
        private void welcome()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipTitle = "Welcome to Vortex RTM Mutli Tool";
            notifyIcon1.BalloonTipText = "Developed by: E3Modz\nCopyright:PowerModdingTeam\n---Welcome---\n" + Environment.UserName;
            notifyIcon1.Text = "Vortex Multi RTM Tool";
            notifyIcon1.Text = "Vortex Multi RTM Tool";
            notifyIcon1.Icon = Properties.Resources.PMT_Test;
            notifyIcon1.ShowBalloonTip(800);
        }


        public static void fehler()
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("https://powermoddingteam.com/assets/Vortex/Fehler.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                string meldung = reader.ReadToEnd();
                if (meldung != "")
                {
                    MessageBox.Show(meldung, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void CrackSchutz()
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("https://powermoddingteam.com/assets/Vortex/Schutz.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String text = reader.ReadToEnd();
                if (text == "Unlocked")
                {

                }
                else
                {
                    fehler();
                    Environment.Exit(0);
                }
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {
            //ToggleTaskManager(true);
            bunifuMaterialTextbox1.Text = E3Modz.Properties.Settings.Default["username"].ToString();
            bunifuMaterialTextbox2.Text = E3Modz.Properties.Settings.Default["password"].ToString();

            //CrackSchutz();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }



        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void Login2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Login2.newpoint = Control.MousePosition;
                Login2.newpoint.X -= Login2.x;
                Login2.newpoint.Y -= Login2.y;
                base.Location = Login2.newpoint;
            }
        }

        private void Panel7_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void Debugger()
        {
            Thread thread = new Thread(Debugger);
            thread.Start();
        }

       
        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel7_MouseDown_1(object sender, MouseEventArgs e)
        {
            Login2.x = Control.MousePosition.X - base.Location.X;
            Login2.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Login();
                }
                catch
                {
                    MessageBox.Show("Error:E3Modz Not Avaible! Contact the Support!");
                }
            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button268_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Language_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            base.Hide();
            timer2.Stop();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Vortex now free!!");
                Dashboard f2 = new Dashboard();
                f2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton22.ButtonText == "Show Settings")
            {
                //Login2 l2 = new Login2();
                //l2.Size = new Size(417, 399);
                //l2.Refresh();
                this.Size = new Size(417, 383);
                bunifuThinButton22.ButtonText = "Hide Settings";
            }
            else if (bunifuThinButton22.ButtonText == "Hide Settings")
            {
                //Login2 l2 = new Login2();
                //l2.Size = new Size(417, 314);
                //l2.Refresh();
                this.Size = new Size(417, 314);
                bunifuThinButton22.ButtonText = "Show Settings";
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                bunifuMaterialTextbox2.isPassword = false;
                
            }
            else if (bunifuiOSSwitch1.Value == false)
            {
                bunifuMaterialTextbox2.isPassword = true;

            }
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (RemMe.Value == false)
            {
                E3Modz.Properties.Settings.Default.username = bunifuMaterialTextbox1.Text;
                E3Modz.Properties.Settings.Default.password = bunifuMaterialTextbox2.Text;
                E3Modz.Properties.Settings.Default.CheckBoxLogin = RemMe.Value = true;
                E3Modz.Properties.Settings.Default.Save();

            }
            else if (RemMe.Value == true)
            {
                E3Modz.Properties.Settings.Default["username"] = "username";
                E3Modz.Properties.Settings.Default["password"] = "password";
                E3Modz.Properties.Settings.Default.CheckBoxLogin = RemMe.Value = false;
                E3Modz.Properties.Settings.Default.Save();

            }
        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (AutoLogSwitch.Value == false)
            {

            }
            else if (AutoLogSwitch.Value == true)
            {
                if (Username != "username")
                {
                    MessageBox.Show("AutoLogin is now Enabled!\nReflect on next tool start!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login ON";
                    E3Modz.Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("AutoLogin cant Enable!\nSave your Username and password befor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void bunifuiOSSwitch2_OnValueChange_1(object sender, EventArgs e)
        {
            if (RemMe.Value == true)
            {
                E3Modz.Properties.Settings.Default.username = bunifuMaterialTextbox1.Text;
                E3Modz.Properties.Settings.Default.password = bunifuMaterialTextbox2.Text;
                E3Modz.Properties.Settings.Default.Save();

            }
            else if (RemMe.Value == false)
            {
                E3Modz.Properties.Settings.Default["username"] = "username";
                E3Modz.Properties.Settings.Default["password"] = "password";
                E3Modz.Properties.Settings.Default.Save();

            }
        }
       
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Login();
                }
                catch
                {
                    MessageBox.Show("Error:E3Modz Not Avaible! Contact the Support!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void powerModdingTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://powermoddingteam.com");
        }

        private void aboutThatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vortex RTM Tool\nThis is a Programm what allow you to connect to your PS3 and mod some Games!\nDeveloped by E3Modz!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void powerModdingTeamToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            
        }
    }
}
       

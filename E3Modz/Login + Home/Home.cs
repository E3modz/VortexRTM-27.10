using E3Modz.Black_Ops_2;
using E3Modz.Black_Ops_3;
using E3Modz.BO1;
using E3Modz.GTA5;
using Microsoft.Win32;
using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Home : Form
    {
        public bool red = E3Modz.Properties.Settings.Default.Red;
        public bool green = E3Modz.Properties.Settings.Default.Green;
        public bool blue = E3Modz.Properties.Settings.Default.Blue;
        public bool orange = E3Modz.Properties.Settings.Default.Orange;
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static string Version = "4.0";
        Login2 frm;
        public Home()
        {
            InitializeComponent();
            frm = new Login2();
        }

        private void GamesButton_Click(object sender, EventArgs e)
        {
            
            
            if (red == true)
            {
                
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Red;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (green == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Green;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (blue == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Blue;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (orange == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Orange;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.DeepSkyBlue;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }

        }
        //method to Check Activ Bools
        private void checkActivColor()
        {
            if (red == true)
            {
                ToolColorRed();
            }
            else if (green == true)
            {
                ToolColorGreen();
            }
            else if (blue == true)
            {
                ToolColorBlue();
            }
            else if (orange == true)
            {
                ToolColorOrange();
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (red == true)
            {
                this.tabControl1.SelectedTab = tabPage2;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.Red;
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (green == true)
            {
                this.tabControl1.SelectedTab = tabPage2;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.Green;
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (blue == true)
            {
                this.tabControl1.SelectedTab = tabPage2;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.Blue;
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (orange == true)
            {
                this.tabControl1.SelectedTab = tabPage2;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.Orange;
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                this.tabControl1.SelectedTab = tabPage2;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.DeepSkyBlue;
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
        }

        private void StuffButton_Click(object sender, EventArgs e)
        {
            if (red == true)
            {
                this.tabControl1.SelectedTab = tabPage3;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.Red;
            }
            else if (green == true)
            {
                this.tabControl1.SelectedTab = tabPage3;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.Green;
            }
            else if (blue == true)
            {
                this.tabControl1.SelectedTab = tabPage3;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.Blue;
            }
            else if (orange == true)
            {
                this.tabControl1.SelectedTab = tabPage3;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.Orange;
            }
            else
            {
                this.tabControl1.SelectedTab = tabPage3;
                this.GamesButton.BackColor = Color.FromArgb(35, 35, 35);
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.DeepSkyBlue;
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        private string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();

        }
       
        private void Home_Load(object sender, EventArgs e)
        {
            
            checkActivColor();
            label3.Text = Login2.Username;
            label8.Text = Login2.Username;
            label11.Text = GetIP();
            label14.Text = getVersion();
            label16.Text = Version;
            label14.ForeColor = Color.Green;
            if (red == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Red;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (green == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Green;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (blue == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Blue;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (orange == true)
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.Orange;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
            else
            {
                this.tabControl1.SelectedTab = tabPage1;
                this.GamesButton.BackColor = Color.DeepSkyBlue;
                this.SettingsButton.BackColor = Color.FromArgb(35, 35, 35);
                this.StuffButton.BackColor = Color.FromArgb(35, 35, 35);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            BO1Selector s = new BO1Selector();
            s.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Selector bo2 = new Selector();
            bo2.Show();
            this.Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            BO3_Selector selectGames = new BO3_Selector();
            selectGames.Show();
            this.Hide();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
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
        private void Button5_Click(object sender, EventArgs e)
        {

            label9.Text = Login2.Password;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string getVersion()
        {
            return Home.Version;
        }
        private void checkForUpdate2()
        {
            string str = "https://dayz.planb-life.com/";
            string str2 = "ProjektVortex.exe";
            string str3 = "RTMTOOLUPDATE.txt";
            WebRequest webRequest = WebRequest.Create(str + str3);
            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string text = streamReader.ReadLine();
            bool flag = this.getVersion() != text;
            if (flag)
            {
                this.label14.Visible = true;
                this.label14.Text = text;
                DialogResult dialogResult = MessageBox.Show("Update Avaible, You want do download it?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                bool flag2 = dialogResult == DialogResult.Yes;
                if (flag2)
                {
                    WebClient webClient = new WebClient();
                    byte[] array = webClient.DownloadData(str + str2);
                    bool flag3 = this.saveFileDialog1.ShowDialog() == DialogResult.OK;
                    if (flag3)
                    {
                        using (FileStream fileStream = File.Create(this.saveFileDialog1.FileName))
                        {
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                }
                else
                {
                    bool flag4 = dialogResult == DialogResult.No;
                    if (!flag4)
                    {
                        bool flag5 = dialogResult == DialogResult.Cancel;
                        if (flag5)
                        {
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Update Avaible", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void checkForUpdate()
        {
            string str = "https://dayz.planb-life.com/";
            string str2 = "ProjectVotex.exe";
            string str3 = "version.txt";
            WebRequest webRequest = WebRequest.Create(str + str3);
            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string text = streamReader.ReadLine();
            bool flag = this.getVersion() != text;
            if (flag)
            {
                this.label14.Visible = true;
                this.label14.Text = text;
                DialogResult dialogResult = MessageBox.Show("Update Avaible, You want do download it?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                bool flag2 = dialogResult == DialogResult.Yes;
                if (flag2)
                {
                    WebClient webClient = new WebClient();
                    byte[] array = webClient.DownloadData(str + str2);
                    bool flag3 = this.saveFileDialog1.ShowDialog() == DialogResult.OK;
                    if (flag3)
                    {
                        using (FileStream fileStream = File.Create(this.saveFileDialog1.FileName))
                        {
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                }
                else
                {
                    bool flag4 = dialogResult == DialogResult.No;
                    if (flag4)
                    {
                        MessageBox.Show("Sorry, but you must Download it!", "Download!");
                        Application.Exit();
                    }
                    else
                    {
                        bool flag5 = dialogResult == DialogResult.Cancel;
                        if (flag5)
                        {
                            MessageBox.Show("Sorry, but you must Download it!", "Download!");
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            checkForUpdate2();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Secure Updates was deactivated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.Show();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            SpamBotcs bot = new SpamBotcs();
            bot.Show();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            mainForm snake = new mainForm();
            snake.Show();
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            MecommentUploader me = new MecommentUploader();
            me.Show();
            this.Hide();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            Home.x = Control.MousePosition.X - base.Location.X;
            Home.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Home.newpoint = Control.MousePosition;
                Home.newpoint.X -= Home.x;
                Home.newpoint.Y -= Home.y;
                base.Location = Home.newpoint;
            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }
        private void ChangeTabColor()
        {

        }
        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            PS3Exploit ex = new PS3Exploit();
            ex.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            MW2 mw2 = new MW2();
            mw2.Show();
            this.Hide();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MW3.MW3 mw = new MW3.MW3();
            mw.Show();
            this.Hide();
        }

        private void Label21_Click(object sender, EventArgs e)
        {
            ChangeLog ch = new ChangeLog();
            ch.Show();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            GTA5Main gta = new GTA5Main();
            gta.Show();
            this.Hide();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            HenCidChanger h = new HenCidChanger();
            h.Show();
            this.Hide();
        }
        //Color Methods
        private void ToolColorGreen()
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
            button10.BackColor = Color.Green;
            button11.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button13.BackColor = Color.Green;
            button14.BackColor = Color.Green;
            button15.BackColor = Color.Green;
            button16.BackColor = Color.Green;
            button17.BackColor = Color.Green;
            button18.BackColor = Color.Green;
            button19.BackColor = Color.Green;
            button20.BackColor = Color.Green;
            button21.BackColor = Color.Green;
            button22.BackColor = Color.Green;
            button23.BackColor = Color.Green;
            button24.BackColor = Color.Green;
            button25.BackColor = Color.Green;
            button26.BackColor = Color.Green;

            //////////Label//////////
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Green;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            label24.ForeColor = Color.White;
            label25.ForeColor = Color.White;
            ////////Groupbox////////
            groupBox1.ForeColor = Color.Green;
            groupBox2.ForeColor = Color.Green;
            groupBox3.ForeColor = Color.Green;
            groupBox4.ForeColor = Color.Green;
            groupBox5.ForeColor = Color.Green;
            groupBox6.ForeColor = Color.Green;
            ////////Pannel////////
            panel1.BackColor = Color.Green;
            panel2.BackColor = Color.Green;
            panel3.BackColor = Color.Green;
            panel4.BackColor = Color.Green;
            panel5.BackColor = Color.Green;
            panel6.BackColor = Color.Green;
            panel7.BackColor = Color.Green;
        }
        private void ToolColorOrange()
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            button4.BackColor = Color.Orange;
            button5.BackColor = Color.Orange;
            button6.BackColor = Color.Orange;
            button7.BackColor = Color.Orange;
            button8.BackColor = Color.Orange;
            button9.BackColor = Color.Orange;
            button10.BackColor = Color.Orange;
            button11.BackColor = Color.Orange;
            button12.BackColor = Color.Orange;
            button13.BackColor = Color.Orange;
            button14.BackColor = Color.Orange;
            button15.BackColor = Color.Orange;
            button16.BackColor = Color.Orange;
            button17.BackColor = Color.Orange;
            button18.BackColor = Color.Orange;
            button19.BackColor = Color.Orange;
            button20.BackColor = Color.Orange;
            button21.BackColor = Color.Orange;
            button22.BackColor = Color.Orange;
            button23.BackColor = Color.Orange;
            button24.BackColor = Color.Orange;
            button25.BackColor = Color.Orange;
            button26.BackColor = Color.Orange;
            //////////FORCE///////////
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button10.ForeColor = Color.White;
            button11.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button21.ForeColor = Color.White;
            button22.ForeColor = Color.White;
            button23.ForeColor = Color.White;
            button24.ForeColor = Color.White;
            button25.ForeColor = Color.White;
            button26.ForeColor = Color.White;
            //////////Label//////////
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Orange;
            label2.ForeColor = Color.Orange;
            label3.ForeColor = Color.Orange;
            label4.ForeColor = Color.Orange;
            label5.ForeColor = Color.Orange;
            label7.ForeColor = Color.Orange;
            label8.ForeColor = Color.Orange;
            label9.ForeColor = Color.Orange;
            label11.ForeColor = Color.Orange;
            label12.ForeColor = Color.Orange;
            label13.ForeColor = Color.Orange;
            label14.ForeColor = Color.Orange;
            label15.ForeColor = Color.Orange;
            label16.ForeColor = Color.Orange;
            label17.ForeColor = Color.Orange;
            label18.ForeColor = Color.Orange;
            label19.ForeColor = Color.Orange;
            label20.ForeColor = Color.Orange;
            label21.ForeColor = Color.Orange;
            label22.ForeColor = Color.Orange;
            label23.ForeColor = Color.Orange;
            label24.ForeColor = Color.Orange;
            label25.ForeColor = Color.Orange;
            ////////Groupbox////////
            groupBox1.ForeColor = Color.Orange;
            groupBox2.ForeColor = Color.Orange;
            groupBox3.ForeColor = Color.Orange;
            groupBox4.ForeColor = Color.Orange;
            groupBox5.ForeColor = Color.Orange;
            groupBox6.ForeColor = Color.Orange;
            ////////Pannel////////
            panel1.BackColor = Color.Orange;
            panel2.BackColor = Color.Orange;
            panel3.BackColor = Color.Orange;
            panel4.BackColor = Color.Orange;
            panel5.BackColor = Color.Orange;
            panel6.BackColor = Color.Orange;
            panel7.BackColor = Color.Orange;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E3Modz -> Owner/Developer\n AssumingAgate -> Helper on BO3 \n DexCFW -> Design and RCE in BO2 thanks bro <3 \nPaladin -> Hen Tester -> \nB777x Stats and Unlockall BO2", "Thanks to all!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ToolColorBlue()
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Blue;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Blue;
            button10.BackColor = Color.Blue;
            button11.BackColor = Color.Blue;
            button12.BackColor = Color.Blue;
            button13.BackColor = Color.Blue;
            button14.BackColor = Color.Blue;
            button15.BackColor = Color.Blue;
            button16.BackColor = Color.Blue;
            button17.BackColor = Color.Blue;
            button18.BackColor = Color.Blue;
            button19.BackColor = Color.Blue;
            button20.BackColor = Color.Blue;
            button21.BackColor = Color.Blue;
            button22.BackColor = Color.Blue;
            button23.BackColor = Color.Blue;
            button24.BackColor = Color.Blue;
            button25.BackColor = Color.Blue;
            button26.BackColor = Color.Blue;
            //////////FORCE///////////
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button10.ForeColor = Color.White;
            button11.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button21.ForeColor = Color.White;
            button22.ForeColor = Color.White;
            button23.ForeColor = Color.White;
            button24.ForeColor = Color.White;
            //////////Label//////////
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            label3.ForeColor = Color.Blue;
            label4.ForeColor = Color.Blue;
            label5.ForeColor = Color.Blue;
            label7.ForeColor = Color.Blue;
            label8.ForeColor = Color.Blue;
            label9.ForeColor = Color.Blue;
            label11.ForeColor = Color.Blue;
            label12.ForeColor = Color.Blue;
            label13.ForeColor = Color.Blue;
            label14.ForeColor = Color.Blue;
            label15.ForeColor = Color.Blue;
            label16.ForeColor = Color.Blue;
            label17.ForeColor = Color.Blue;
            label18.ForeColor = Color.Blue;
            label19.ForeColor = Color.Blue;
            label20.ForeColor = Color.Blue;
            label21.ForeColor = Color.Blue;
            label22.ForeColor = Color.Blue;
            label23.ForeColor = Color.Blue;
            label24.ForeColor = Color.Blue;
            label25.ForeColor = Color.Blue;
            ////////Groupbox////////
            groupBox1.ForeColor = Color.Blue;
            groupBox2.ForeColor = Color.Blue;
            groupBox3.ForeColor = Color.Blue;
            groupBox4.ForeColor = Color.Blue;
            groupBox5.ForeColor = Color.Blue;
            groupBox6.ForeColor = Color.Blue;
            ////////Pannel////////
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
            panel6.BackColor = Color.Blue;
            panel7.BackColor = Color.Blue;
        }
        private void ToolColorRed()
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button18.BackColor = Color.Red;
            button19.BackColor = Color.Red;
            button20.BackColor = Color.Red;
            button21.BackColor = Color.Red;
            button22.BackColor = Color.Red;
            button23.BackColor = Color.Red;
            button24.BackColor = Color.Red;
            button25.BackColor = Color.Red;
            button26.BackColor = Color.Red;
            //////////FORCE///////////
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button10.ForeColor = Color.White;
            button11.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button21.ForeColor = Color.White;
            button22.ForeColor = Color.White;
            button23.ForeColor = Color.White;
            button24.ForeColor = Color.White;
            button25.ForeColor = Color.White;
            button26.ForeColor = Color.White;
            //////////Label//////////
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Red;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.Red;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.Red;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.Red;
            label23.ForeColor = Color.White;
            label24.ForeColor = Color.Red;
            label25.ForeColor = Color.White;
            ////////Groupbox////////
            groupBox1.ForeColor = Color.Red;
            groupBox2.ForeColor = Color.Red;
            groupBox3.ForeColor = Color.Red;
            groupBox4.ForeColor = Color.Red;
            groupBox5.ForeColor = Color.Red;
            groupBox6.ForeColor = Color.Red;
            ////////Pannel////////
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Red;
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.Red;
            panel6.BackColor = Color.Red;
            panel7.BackColor = Color.Red;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            ToolColorGreen();
            E3Modz.Properties.Settings.Default.Green = true;
            E3Modz.Properties.Settings.Default.Red = false;
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Blue = false;
            E3Modz.Properties.Settings.Default.Save();
            E3Modz.Properties.Settings.Default.Reload();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolColorOrange();
            E3Modz.Properties.Settings.Default.Orange = true;
            E3Modz.Properties.Settings.Default.Red = false;
            E3Modz.Properties.Settings.Default.Blue = false;
            E3Modz.Properties.Settings.Default.Green = false;
            E3Modz.Properties.Settings.Default.Save();
            E3Modz.Properties.Settings.Default.Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToolColorBlue();
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Red = false;
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Blue = true;
            E3Modz.Properties.Settings.Default.Green = false;
            E3Modz.Properties.Settings.Default.Save();
            E3Modz.Properties.Settings.Default.Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToolColorRed();
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Red = true;
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Blue = false;
            E3Modz.Properties.Settings.Default.Green = false;
            E3Modz.Properties.Settings.Default.Save();
            E3Modz.Properties.Settings.Default.Reload(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Red = false;
            E3Modz.Properties.Settings.Default.Orange = false;
            E3Modz.Properties.Settings.Default.Blue = false;
            E3Modz.Properties.Settings.Default.Green = false;
            E3Modz.Properties.Settings.Default.Save();
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=B9v7ippMaZ8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=7o9bf1qOz6A");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cant Bypass it! You must have an old account to play Modern Warfare 3!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=SvK9uMmtM6M");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frm.Hide();
            //System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=tmpexUf9eK0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            XMBChanger changer = new XMBChanger();
            changer.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GhostMP ghost = new GhostMP();
            ghost.Show();
            this.Hide();
        }

        private void button36_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button36_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (E3Modz.Properties.Settings.Default.AutoLoginstring != "Auto Login ON")
            {
                MessageBox.Show("Auto Login is not activated\nActivate it on the login page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                E3Modz.Properties.Settings.Default.Save();
                MessageBox.Show("Auto Login Disabled!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.label11.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://powermoddingteam.com");
        }
    }
}

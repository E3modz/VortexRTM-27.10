using E3Modz.Black_Ops_2;
using E3Modz.Black_Ops_3;
using E3Modz.GTA5;
using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Dashboard : Form
    {
        private bool isOpen;
        public static bool hasVerifed;
        public static int x;
        public static int y;
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void methodeZumZumachen()
        {
            sidemenu.Size = new Size(56, 553);
            bunifuImageButton2.Visible = true;
            bunifuImageButton1.Visible = false;
            pictureBox3.Visible = false;
            sidemenu.Visible = false;
            SideMenuAnimator.ShowSync(sidemenu);
            isOpen = false;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            methodeZumZumachen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            isOpen = true;
            bunifuImageButton1.Visible = true;
            bunifuImageButton2.Visible = false;
            sidemenu.Size = new Size(254, 553);
            LogoAni1.ShowSync(pictureBox3);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }
        private void Opacity(ref Bitmap image)
        {
            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    Color c = image.GetPixel(w, h);
                    if (c != Color.Transparent) /*<- it only change colours different than transparency color.*/
                    {
                        Color newC = Color.FromArgb(c.A / 2, c.R / 2, c.G / 2, c.B); /*<- this gives real opacity.*/
                        image.SetPixel(w, h, newC);
                    }
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            if (E3Modz.Properties.Settings.Default.AutoLoginstring != "Auto Login ON")
            {
                bunifuFlatButton17.Text = "Enable Auto Login";
            }
            //LoadChangelog();
            panel5.Size = new Size(863, 110);
            lblusername.Text = Login2.Username;
            label6.Text = Login2.Username;
            tabControl1.SelectedTab = tabPage1;
            label8.Text = Environment.UserName;
            string IP = "www.google.com";
            IPAddress[] addresslist = Dns.GetHostAddresses(IP);

            foreach (IPAddress theaddress in addresslist)
            {
                label7.Text = theaddress.ToString();
            }
            label12.Text = Properties.Settings.Default.IP1;
            if (isOpen == true)
            {
                bunifuFlatButton2.BackColor = Color.SteelBlue;
                bunifuFlatButton2.Refresh();
                tabControl1.SelectedTab = tabPage1;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton2.BackColor = Color.SteelBlue;
                bunifuFlatButton2.Refresh();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dashboard.x = Control.MousePosition.X - base.Location.X;
            Dashboard.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dashboard.newpoint = Control.MousePosition;
                Dashboard.newpoint.X -= Dashboard.x;
                Dashboard.newpoint.Y -= Dashboard.y;
                base.Location = Dashboard.newpoint;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button35_MouseHover(object sender, EventArgs e)
        {
            button35.BackColor = Color.FromArgb(219, 7, 42);
        }

        private void button35_MouseLeave(object sender, EventArgs e)
        {
            button35.BackColor = Color.SteelBlue;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://powermoddingteam.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            BO1 booo = new BO1();
            booo.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Selector bo2 = new Selector();
            bo2.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            BO3_Selector select = new BO3_Selector();
            select.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MW2 mw2 = new MW2();
            mw2.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MW3.MW3 mw = new MW3.MW3();
            mw.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GhostMP mp = new GhostMP();
            mp.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GTA5Main gta = new GTA5Main();
            gta.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Minecraft mc = new Minecraft();
            mc.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            mainForm snake = new mainForm();
            snake.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            HenCidChanger cn = new HenCidChanger();
            cn.Show();
            this.Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            MecommentUploader up = new MecommentUploader();
            up.Show();
            this.Hide();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            SpamBotcs cs = new SpamBotcs();
            cs.Show();
            this.Hide();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon!");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                methodeZumZumachen();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                bunifuFlatButton2.BackColor = Color.SteelBlue;
                bunifuFlatButton2.Refresh();
                tabControl1.SelectedTab = tabPage1;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton2.BackColor = Color.SteelBlue;
                bunifuFlatButton2.Refresh();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                bunifuFlatButton1.BackColor = Color.SteelBlue;
                bunifuFlatButton1.Refresh();
                tabControl1.SelectedTab = tabPage2;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton1.BackColor = Color.SteelBlue;
                bunifuFlatButton1.Refresh();
                tabControl1.SelectedTab = tabPage2;
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

            if (Realy.failed == "3")
            {
                MessageBox.Show("You dont have more trys! try in 15 minutes again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasVerifed == true)
            {
                label5.Text = Login2.Password;
                label21.Text = "Hide Password?";
            }
            else
            {
                new Realy().Show();
                this.Hide();
            }
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                bunifuFlatButton3.BackColor = Color.SteelBlue;
                bunifuFlatButton3.Refresh();
                tabControl1.SelectedTab = tabPage3;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton3.BackColor = Color.SteelBlue;
                bunifuFlatButton3.Refresh();
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                bunifuFlatButton5.BackColor = Color.SteelBlue;
                bunifuFlatButton5.Refresh();
                tabControl1.SelectedTab = tabPage4;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton5.BackColor = Color.SteelBlue;
                bunifuFlatButton5.Refresh();
                tabControl1.SelectedTab = tabPage4;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                bunifuFlatButton4.BackColor = Color.SteelBlue;
                bunifuFlatButton4.Refresh();
                tabControl1.SelectedTab = tabPage5;
                methodeZumZumachen();
            }
            else
            {



                bunifuFlatButton4.BackColor = Color.SteelBlue;
                bunifuFlatButton4.Refresh();
                tabControl1.SelectedTab = tabPage5;
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }
        public string OperatingSystem()
        {
            object obj = (from ManagementObject x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
                          select x.GetPropertyValue("Caption")).FirstOrDefault<object>();
            return (obj != null) ? obj.ToString() : "Unknown";
        }
        private void LoadChangelog()
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("https://powermoddingteam.com/assets/Vortex/News.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String text = reader.ReadToEnd();

                changelogbox.Text = text;

            }
        }
        private void sendBug()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage = new MailMessage();
            try
            {
                mailMessage.Subject = "";
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct"))
                {
                    ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                    foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                    {
                        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                        RegionInfo regionInfo = new RegionInfo(currentCulture.LCID);
                        regionInfo = new RegionInfo(currentCulture.Name);
                        string englishName = regionInfo.EnglishName;
                        string Virus = "\n★  AV Program: " + managementBaseObject["displayName"].ToString();
                        string OsVersion = "\n★  OS Version: " + this.OperatingSystem();
                        string region = "\n★  PCs Region: " + englishName;
                        string reason = "\n★  Bug Reason: " + bunifuMaterialTextbox2.Text;
                        string bug = "\n★  Bug Description: " + richTextBox4.Text;
                        string body = string.Concat(new string[]
                        {
                            Virus,
                            OsVersion,
                            region,
                            reason,
                            Environment.NewLine,
                            bug
                        });
                        mailMessage.Body = body;
                    }
                }
                mailMessage.From = new MailAddress("sendermail@gmx.net");
                mailMessage.To.Add("e3modz@gmx.net");
                ContentType contentType = new ContentType();
                new SmtpClient("mail.gmx.net")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("sendermail@gmx.net", "0jdNXsdvHmbSvLezJGSPfEUs4p9bYk8zW20")
                }.Send(mailMessage);
                MessageStringHead.Text = "Bug-Report sucessfully sendet!";
                MessageStringBody.Text = "Thank You for your report, a supporter will check your ticket soon!";
                panel5.Visible = false;
                panel5.BackColor = Color.OliveDrab;
                ShowMessage.ShowSync(panel5);
                panel5.Visible = false;
            }
            catch (Exception ex)
            {
                MessageStringHead.Text = "Bug-Report Failed!";
                MessageStringBody.Text = "Your Report failed:" + ex.ToString();
                panel5.Visible = false;
                panel5.BackColor = Color.Red;
                ShowMessage.ShowSync(panel5);
            }
        }
        private void SendWish()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage = new MailMessage();
            try
            {
                mailMessage.Subject = Login2.Username + "Hat einen wunsch";
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct"))
                {
                    ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                    foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                    {
                        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                        RegionInfo regionInfo = new RegionInfo(currentCulture.LCID);
                        regionInfo = new RegionInfo(currentCulture.Name);
                        string englishName = regionInfo.EnglishName;
                        string Virus = "\n★  AV Program: " + managementBaseObject["displayName"].ToString();
                        string Wish = "\n★  Wish: " + WishTest.Text;
                        string body = string.Concat(new string[]
                        {
                            Virus,
                            Environment.NewLine,
                            Wish
                        });
                        mailMessage.Body = body;
                    }
                }
                mailMessage.From = new MailAddress("sendermail@gmx.net");
                mailMessage.To.Add("e3modz@gmx.net");
                ContentType contentType = new ContentType();
                new SmtpClient("mail.gmx.net")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("sendermail@gmx.net", "0jdNXsdvHmbSvLezJGSPfEUs4p9bYk8zW20")
                }.Send(mailMessage);
                MessageBox.Show("Wish Sucessfully sendet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {

            sendBug();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void CLosePopUp_Tick(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                methodeZumZumachen();
            }
        }
        private void sendFeedback()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage = new MailMessage();
            try
            {
                mailMessage.Subject = "Rating from" + Login2.Username;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct"))
                {
                    ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                    foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                    {
                        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                        RegionInfo regionInfo = new RegionInfo(currentCulture.LCID);
                        regionInfo = new RegionInfo(currentCulture.Name);
                        string username = "★user:" + Login2.Username;
                        string stars = "\n★Stars:" + bunifuRating1.Value.ToString();
                        string body = string.Concat(new string[]
                        {
                            username,
                            stars
                        });
                        mailMessage.Body = body;
                    }
                }
                mailMessage.From = new MailAddress("sendermail@gmx.net");
                mailMessage.To.Add("e3modz@gmx.net");
                ContentType contentType = new ContentType();
                new SmtpClient("mail.gmx.net")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("sendermail@gmx.net", "0jdNXsdvHmbSvLezJGSPfEUs4p9bYk8zW20")
                }.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delet your saved Login Credentials?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.username = "Username";
                Properties.Settings.Default.password = "Password";
                Properties.Settings.Default.Save();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void bunifuFlatButton19_Click_1(object sender, EventArgs e)
        {
            if (WishTest.Text == "please enter your wish here" || WishTest.Text == "")
            {
                MessageBox.Show("List was not sendet! wishList was emty!");
                WishTest.Focus();
            }
            else
            {
                SendWish();
            }
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            if (bunifuFlatButton17.Text == " Disable Auto Login")
            {
                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login OFF";
                E3Modz.Properties.Settings.Default.Save();
                MessageBox.Show("Auto Login Disabled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                E3Modz.Properties.Settings.Default.AutoLoginstring = "Auto Login ON";
                E3Modz.Properties.Settings.Default.Save();
                MessageBox.Show("Auto Login Enabled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WishTest_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void WishTest_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void WishTest_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void WishTest_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!", "VortexRTM");
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            string test = bunifuRating1.Value.ToString();
           
            if (bunifuRating1.Value <3)
            {
                MessageBox.Show("You Rate the tool with:" + test + "Stars!\nWhat can i do to get more Stars from you?\nPlease write your feedback on Wishlist!");
                sendFeedback();
                WishTest.Focus();
            }
            else
            {
                MessageBox.Show("You Rate the tool with:" + test + "Stars!\nThank you for you feedback!");
                sendFeedback();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                methodeZumZumachen();
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                methodeZumZumachen();
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                methodeZumZumachen();
            }
        }
    }
}
    
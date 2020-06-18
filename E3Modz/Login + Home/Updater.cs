using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Updater : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        int valuep = 1;
        public Updater()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void GetAvaibleNw()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                pictureBox1.Image = E3Modz.Properties.Resources._1178502_preview_preview;
            }
            else
            {
                pictureBox1.Image = E3Modz.Properties.Resources.Wifi_Red;

            }
        }
        public string getVersion()
        {
            return Home.Version;
        }
        private void Updater_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void checkForUpdate()
        {
            
            string str = "https://dayz.planb-life.com/";
            string str2 = "Vortex Multi RTM Tool.exe";
            string str3 = "version.txt";
            WebRequest webRequest = WebRequest.Create(str + str3);
            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream);
            string text = streamReader.ReadLine();
            
                bool flag = this.getVersion() != text;
            if (flag)
            {
                WebClient webClient = new WebClient();
                byte[] array = webClient.DownloadData(str + str2);
                //var bytes = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);

                bool flag3 = this.saveFileDialog1.ShowDialog() == DialogResult.OK;
                if (flag3)
                {
                    using (FileStream fileStream = File.Create(this.saveFileDialog1.FileName))
                    {
                        

                        fileStream.Write(array, 0, array.Length);

                        timer2.Start();
                        string directoryPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                        //label3.Text = fileStream.Length.ToString() + "of: " + bytes.ToString();
                    }

                }
            }

            else
            {
                MessageBox.Show("Error: 0x40532", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.GetAvaibleNw();
        }

        private void UpdateLebel_Tick(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = "Download is done! Application will now exit!";
            MessageBox.Show("Download completed!\n Application will now exit! Start the new one!", "Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
        }
        private static void RunCMD(string cmd)
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments = cmd;
            process.Start();
        }
        public static void OnProcessExit()
        {
            string res = Assembly.GetExecutingAssembly().Location;
            if (res == "" || res == null)
            {
                res = Assembly.GetEntryAssembly().Location;
            }
            RunCMD("START CMD /C \"TIMEOUT 3 *Nul & Del \"" + res + "\"");
            Environment.Exit(0);
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            string directoryPath = this.saveFileDialog1.FileName;
            label4.Text = "Download progress:" + bunifuCircleProgressbar1.Value.ToString() + "%";

            valuep += 1;
            bunifuCircleProgressbar1.Value = valuep;
            if (bunifuCircleProgressbar1.Value == 100)
            {

               
                timer2.Stop();
                bunifuImageButton1.Enabled = true;
                MessageBox.Show("Update Done!\nUpdate saved at:" + directoryPath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnProcessExit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://powermoddingteam.com");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value != 0)
            {
                bunifuImageButton1.Enabled = false;
            }
            else
            {
                bunifuCircleProgressbar1.Value = 0;

                checkForUpdate();
            }
        }
    }
}


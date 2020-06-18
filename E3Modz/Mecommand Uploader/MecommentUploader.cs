using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class MecommentUploader : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static int x;
        public static int y;
        public MecommentUploader()
        {
            InitializeComponent();
        }

        private void MecommentUploader_Load(object sender, EventArgs e)
        {
            textBox1.Text = E3Modz.Properties.Settings.Default.DefaultIP;
        }

        public string datfile = Directory.GetCurrentDirectory() + "\\mecomment.dat";
        //Symbole 
        public string Circle = "";
        public string Cross = "";
        public string Square = "";
        public string Triangle = "";
        public string DPADUp = "";
        public string DPADDown = "";
        public string DPADLeft = "";
        public string DPADRight = "";
        public string L1 = "";
        public string L2 = "";
        public string L3 = "";
        public string R1 = "";
        public string R2 = "";
        public string R3 = "";
        public string SelectBTN = "";
        public string Start = "";
        public string PSButton = "";
        public string L2DPADleft = "";
        public string R2DPADRight = "";
        public string Speaker0 = "";
        public string Speaker1 = "";
        public string Speaker2 = "";
        public string Speaker3 = "";
        public string MicMuted = "";
        public string HQ = "";
        public string ArrowRight = "";
        public string Battery1 = "";
        public string Battery2 = "";
        public string Battery3 = "";
        public string Battery4 = "";
        public string BatteryMove = "";
        public string BronzeTrophy = "";
        public string SilverTrophy = "";
        public string GoldTrophy = "";
        public string PlatinTrophy = "";
        public string Caps = "";
        public string Keyboard = "";
        public string FingerMouse = "";
        public string CircleinCircle = "";
        public string Circle2 = "";
        public string PSPlus = "";
        public string Headset = "";
        public string HeadsetinCircle = "";
        public string HeartsMoving = "";
        public string BrokenHeartMoving = "";
        public string HeartwithArrowMoving = "";
        public string Heart = "";
        public string Spades = "";
        public string Clubs = "";
        public string Diamond = "";
        public string rufezeichen = "";
        public string rufezeichen2 = "";
        public string fragezeichen = "";
        public string fragezeichenmitruf = "";
        public string LightBulb = "";
        public string ExplosionMoving = "";
        public string DropsMoving3 = "";
        public string DropMoving = "";
        public string Blast = "";
        public string Flower = "";
        public string Skull = "";
        public string StarsMoving = "";
        public string FireMoving = "";
        public string Note = "";
        public string Note1 = "";
        public string Note2 = "";
        public string Note3 = "";
        public string Notes2 = "";
        public string Notes21 = "";
        public string Lips = "";
        public string LipsWithTongue = "";
        public string KissingLips = "";
        public string Nose = "";
        public string Ear = "";
        public string Feet = "";
        public string Feet1 = "";
        public string SunMoving = "";
        public string FlowersMoving = "";
        public string Umbrella = "";
        public string Rainbow = "";
        public string UmbreallRainingMoving = "";
        public string SnowmanMoving = "";
        public string StormMoving = "";
        public string Tornado = "";
        public string ClosedUmbrella = "";
        public string Snowflake = "";
        public string Bouquet = "";
        public string Ring = "";
        public string Loop = "";
        public string Present = "";
        public string Cake = "";
        public string Money = "";
        public string sonder1 = "";
        public string dollar = "";




        private void button35_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button268_Click(object sender, EventArgs e)
        {
            comboBox10.DroppedDown = true;
        }

        private void getFileList(string FTPAddress, string username, string password)
        {
            string uri = "ftp://" + textBox1.Text + "/dev_hdd0/home";
            List<string> files = new List<string>();

            try
            {

                //Create FTP request
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(uri);

                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential("anonymous", "");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;


                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }
                label8.Text = "Connected!";
                label8.ForeColor = Color.Green;
                //Clean-up
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error", "Error");
            }

            if (files.Count != 0)
            {
                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                    listBox1.Items.Remove(".");
                    listBox1.Items.Remove("..");

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string uri = "ftp://" + textBox1.Text + "/dev_hdd0/home";
            E3Modz.Properties.Settings.Default.DefaultIP = textBox1.Text;
            E3Modz.Properties.Settings.Default.Save();
            listBox1.Enabled = true;
            getFileList(uri, "anonymous", "");



        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "Circle")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Circle + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Circle;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Circle + textBox2.Text + Circle;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Cross")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Cross + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Cross;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Cross + textBox2.Text + Cross;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Square")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Square + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Square;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Square + textBox2.Text + Square;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Triangle")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Triangle + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Triangle;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Triangle + textBox2.Text + Triangle;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "DPAD Up")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DPADUp + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DPADUp;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DPADUp + textBox2.Text + DPADUp;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "DPAD Down")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DPADDown + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DPADDown;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DPADDown + textBox2.Text + DPADDown;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "DPAD Left")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DPADLeft + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DPADLeft;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DPADLeft + textBox2.Text + DPADLeft;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "DPAD Right")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DPADRight + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DPADRight;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DPADRight + textBox2.Text + DPADRight;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "L1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = L1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + L1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = L1 + textBox2.Text + L1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "L2")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = L2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + L2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = L2 + textBox2.Text + L2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "L3")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = L3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + L3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = L3 + textBox2.Text + L3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "R1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = R1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + R1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = R1 + textBox2.Text + R1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "R2")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = R2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + R2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = R2 + textBox2.Text + R2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "R3")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = R3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + R3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = R3 + textBox2.Text + R3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Select")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = SelectBTN + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + SelectBTN;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = SelectBTN + textBox2.Text + SelectBTN;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Start")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Start + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Start;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Start + textBox2.Text + Start;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "PSButton")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = PSButton + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + PSButton;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = PSButton + textBox2.Text + PSButton;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "L2/DPAD Left")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = L2DPADleft + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + L2DPADleft;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = L2DPADleft + textBox2.Text + L2DPADleft;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "R2/DPAD Right")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = R2DPADRight + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + R2DPADRight;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = R2DPADRight + textBox2.Text + R2DPADRight;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Speaker0")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Speaker0 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Speaker0;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Speaker0 + textBox2.Text + Speaker0;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Speaker1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Speaker1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Speaker1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Speaker1 + textBox2.Text + Speaker1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Speaker2")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Speaker2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Speaker2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Speaker2 + textBox2.Text + Speaker2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Speaker3")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Speaker3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Speaker3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Speaker3 + textBox2.Text + Speaker3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Mic Muted")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = MicMuted + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + MicMuted;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = MicMuted + textBox2.Text + MicMuted;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "HQ")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = HQ + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + HQ;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = HQ + textBox2.Text + HQ;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Arrow Right")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = ArrowRight + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + ArrowRight;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = ArrowRight + textBox2.Text + ArrowRight;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "0/3 Battery")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Battery1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Battery1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Battery1 + textBox2.Text + Battery1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "1/3 Battery")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Battery2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Battery2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Battery2 + textBox2.Text + Battery2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "2/3 Battery")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Battery3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Battery3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Battery3 + textBox2.Text + Battery3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "3/3 Battery")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Battery4 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Battery4;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Battery4 + textBox2.Text + Battery4;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Loading Battery (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = BatteryMove + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + BatteryMove;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = BatteryMove + textBox2.Text + BatteryMove;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Bronze Trophy")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = BronzeTrophy + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + BronzeTrophy;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = BronzeTrophy + textBox2.Text + BronzeTrophy;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Silver Trophy")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = SilverTrophy + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + SilverTrophy;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = SilverTrophy + textBox2.Text + SilverTrophy;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Gold Trophy")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = GoldTrophy + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + GoldTrophy;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = GoldTrophy + textBox2.Text + GoldTrophy;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Platin Trophy")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = PlatinTrophy + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + PlatinTrophy;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = PlatinTrophy + textBox2.Text + PlatinTrophy;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Caps")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Caps + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Caps;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Caps + textBox2.Text + Caps;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Keyboard")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Keyboard + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Keyboard;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Keyboard + textBox2.Text + Keyboard;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Finger/Mouse")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = FingerMouse + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + FingerMouse;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = FingerMouse + textBox2.Text + FingerMouse;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Circle in Circle")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = CircleinCircle + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + CircleinCircle;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = CircleinCircle + textBox2.Text + CircleinCircle;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Circle")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Circle + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Circle;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Circle + textBox2.Text + Circle;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "PSPlus")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = PSPlus + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + PSPlus;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = PSPlus + textBox2.Text + PSPlus;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Headset")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Headset + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Headset;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Headset + textBox2.Text + Headset;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Headset in Circle")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = HeadsetinCircle + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + HeadsetinCircle;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = HeadsetinCircle + textBox2.Text + HeadsetinCircle;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "2 Hearts (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = HeartsMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + HeartsMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = HeartsMoving + textBox2.Text + HeartsMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Broken Heart (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = BrokenHeartMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + BrokenHeartMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = BrokenHeartMoving + textBox2.Text + BrokenHeartMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Heart with Arrow (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = HeartwithArrowMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + HeartwithArrowMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = HeartwithArrowMoving + textBox2.Text + HeartwithArrowMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Heart")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Heart + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Heart;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Heart + textBox2.Text + Heart;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Spades")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Spades + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Spades;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Spades + textBox2.Text + Spades;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Clubs")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Clubs + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Clubs;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Clubs + textBox2.Text + Clubs;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Diamond")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Diamond + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Diamond;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Diamond + textBox2.Text + Diamond;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "!")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = rufezeichen + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + rufezeichen;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = rufezeichen + textBox2.Text + rufezeichen;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "!!")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = rufezeichen2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + rufezeichen2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = rufezeichen2 + textBox2.Text + rufezeichen2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "?")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = fragezeichen + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + fragezeichen;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = fragezeichen + textBox2.Text + fragezeichen;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "?!")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = fragezeichenmitruf + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + fragezeichenmitruf;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = fragezeichenmitruf + textBox2.Text + fragezeichenmitruf;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Light Bulb")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = LightBulb + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + LightBulb;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = LightBulb + textBox2.Text + LightBulb;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Explosion (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = ExplosionMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + ExplosionMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = ExplosionMoving + textBox2.Text + ExplosionMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "3 Drops (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DropsMoving3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DropsMoving3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DropsMoving3 + textBox2.Text + DropsMoving3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Drop (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = DropMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + DropMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = DropMoving + textBox2.Text + DropMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Blast")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Blast + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Blast;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Blast + textBox2.Text + Blast;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Flower")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Flower + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Flower;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Flower + textBox2.Text + Flower;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Skull")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Skull + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Skull;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Skull + textBox2.Text + Skull;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Stars (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = StarsMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + StarsMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = StarsMoving + textBox2.Text + StarsMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Fire (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = FireMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + FireMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = FireMoving + textBox2.Text + FireMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Note")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Note + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Note;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Note + textBox2.Text + Note;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Note1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Note1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Note1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Note1 + textBox2.Text + Note1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Note2")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Note2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Note2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Note2 + textBox2.Text + Note2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Note3")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Note3 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Note3;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Note3 + textBox2.Text + Note3;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "2Notes")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Notes2 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Notes2;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Notes2 + textBox2.Text + Notes2;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "2Notes1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Notes21 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Notes21;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Notes21 + textBox2.Text + Notes21;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Lips")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Lips + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Lips;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Lips + textBox2.Text + Lips;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Lips with Tongue")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = LipsWithTongue + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + LipsWithTongue;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = LipsWithTongue + textBox2.Text + LipsWithTongue;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Kissing Lips")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = KissingLips + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + KissingLips;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = KissingLips + textBox2.Text + KissingLips;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Nose")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Nose + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Nose;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Nose + textBox2.Text + Nose;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Ear")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Ear + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Ear;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Ear + textBox2.Text + Ear;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Feet")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Feet + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Feet;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Feet + textBox2.Text + Feet;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Feet1")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Feet1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Feet1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Feet1 + textBox2.Text + Feet1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Sun (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = SunMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + SunMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = SunMoving + textBox2.Text + SunMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Flowers (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = FlowersMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + FlowersMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = FlowersMoving + textBox2.Text + FlowersMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Umbrella")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Umbrella + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Umbrella;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Umbrella + textBox2.Text + Umbrella;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Rainbow")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Rainbow + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Rainbow;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Rainbow + textBox2.Text + Rainbow;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Umbreall Raining (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = UmbreallRainingMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + UmbreallRainingMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = UmbreallRainingMoving + textBox2.Text + UmbreallRainingMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Snowman (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = SnowmanMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + SnowmanMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = SnowmanMoving + textBox2.Text + SnowmanMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Storm (Moving)")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = StormMoving + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + StormMoving;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = StormMoving + textBox2.Text + StormMoving;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Tornado")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Tornado + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Tornado;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Tornado + textBox2.Text + Tornado;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Closed Umbrella")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = ClosedUmbrella + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + ClosedUmbrella;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = ClosedUmbrella + textBox2.Text + ClosedUmbrella;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Snowflake")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Snowflake + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Snowflake;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Snowflake + textBox2.Text + Snowflake;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Bouquet")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Bouquet + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Bouquet;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Bouquet + textBox2.Text + Bouquet;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Ring")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Ring + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Ring;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Ring + textBox2.Text + Ring;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Loop")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Loop + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Loop;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Loop + textBox2.Text + Loop;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Present")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Present + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Present;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Present + textBox2.Text + Present;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Cake")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Cake + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Cake;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Cake + textBox2.Text + Cake;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "Money")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = Money + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + Money;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = Money + textBox2.Text + Money;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "¥")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = sonder1 + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + sonder1;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = sonder1 + textBox2.Text + sonder1;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox10.Text == "$")
            {                    //Vor Name
                if (textBox3.Text == "1")
                {
                    textBox2.Text = dollar + textBox2.Text;
                }                  //Danach
                else if (textBox3.Text == "2")
                {
                    textBox2.Text = textBox2.Text + dollar;
                }
                else if (textBox3.Text == "3")
                {
                    textBox2.Text = dollar + textBox2.Text + dollar;
                }
                else if (textBox3.Text == "ERROR")
                {

                }
                else
                {
                    MessageBox.Show("Please choose first select Place!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button124_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text == "Befor")
            {
                textBox3.Text = "1";
            }
            else if (comboBox3.Text == "After")
            {
                textBox3.Text = "2";
            }
            else if (comboBox3.Text == "Both")
            {
                textBox3.Text = "3";
            }
            else
            {
                textBox3.Text = "ERROR";
            }
        }
        private void CreateMeComment()
        {
            string FileName = "mecomment.dat";

            try
            {
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }

                using (FileStream fs = File.Create(FileName))
                {

                    Byte[] title = new UTF8Encoding(true).GetBytes("\n\n\n\n\n\n\n\n\n\n\n" + textBox2.Text);
                    fs.Write(title, 0, title.Length);

                }
                using (StreamReader sr = File.OpenText(FileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void DeleteFileFromPS3()
        {
            try
            {

                string filename = "/dev_hdd0/home/" + listBox1.SelectedItem.ToString() + "/friendim/mecomment.dat";
                string host = "ftp://" + textBox1.Text;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + filename);

                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential("anonymous", "");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                UploadFiletoPS3();
            }
            catch
            {
                UploadFiletoPS3();
            }

        }
        public void UploadFiletoPS3()
        {

            string filename = Path.GetFileName(datfile);
            string host = "ftp://" + textBox1.Text;
            string pathzumordnerAMK = "/dev_hdd0/home/" + listBox1.SelectedItem.ToString() + "/friendim/mecomment.dat";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + pathzumordnerAMK);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("anonymous", "");

            StreamReader sourceStream = new StreamReader(datfile);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            // FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            MessageBox.Show("Comment sucessfully send to:" + listBox1.SelectedItem.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            requestStream.Close();
            sourceStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateMeComment();
            DeleteFileFromPS3();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(datfile);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MecommentUploader.x = Control.MousePosition.X - base.Location.X;
            MecommentUploader.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MecommentUploader.newpoint = Control.MousePosition;
                MecommentUploader.newpoint.X -= MecommentUploader.x;
                MecommentUploader.newpoint.Y -= MecommentUploader.y;
                base.Location = MecommentUploader.newpoint;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
    }
}

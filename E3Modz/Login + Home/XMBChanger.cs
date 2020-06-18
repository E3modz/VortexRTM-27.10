using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class XMBChanger : Form
    {
        public string path = Directory.GetCurrentDirectory() + "\\lines.qrc";
        public XMBChanger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "ftp://" + textBox1.Text + "/dev_flash/vsh/resource/lines.qrc";
                label4.ForeColor = Color.Green;
                label4.Text = "Connected!";
                MessageBox.Show("Connected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                E3Modz.Properties.Settings.Default.DefaultIP = textBox1.Text;
                E3Modz.Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Connection Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FtpUploadFile(string filename, string to_uri,
        string user_name, string password)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create(to_uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // Get network credentials.
            request.Credentials =
                new NetworkCredential(user_name, password);

            // Read the file's contents into a byte array.
            byte[] bytes = System.IO.File.ReadAllBytes(filename);

            // Write the bytes into the request stream.
            request.ContentLength = bytes.Length;
            using (Stream request_stream = request.GetRequestStream())
            {
                request_stream.Write(bytes, 0, bytes.Length);
                request_stream.Close();
            }
        }
        public void UploadFiletoPS3()
        {

            string filename = Path.GetFileName(path);
            string host = "ftp://" + textBox1.Text;
            string pathzumordnerAMK = "/dev_rebug/vsh/resource/qgl/lines.qrc";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + pathzumordnerAMK);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("anonymous", "");

            StreamReader sourceStream = new StreamReader(path);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            // FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            MessageBox.Show("XMB Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            requestStream.Close();
            sourceStream.Close();
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "Blue_Sporadic")
            {
                pictureBox1.Image = E3Modz.Properties.Resources.Blue_Sporadic;
                pictureBox1.Refresh();
                UploadFiletoPS3();
                timer1.Start();
                MessageBox.Show("Done");
            }
        }

        private void button268_Click(object sender, EventArgs e)
        {
            comboBox10.DroppedDown = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(100);
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(path);
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }
    }
}

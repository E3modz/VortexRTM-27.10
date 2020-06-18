using E3Modz.ConsoleManager;
using E3Modz.Login___Home;
using PS3Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_3
{

    public partial class HenCidChanger : Form
    {
        public string PS3IP = "";
        public static bool Console1 = Properties.Settings.Default.bool1;
        public static bool Console2 = Properties.Settings.Default.bool2;
        public static bool Console3 = Properties.Settings.Default.bool3;
        public static bool Console4 = Properties.Settings.Default.bool4;
        public static bool Console5 = Properties.Settings.Default.bool5;
        public static bool Console6 = Properties.Settings.Default.bool6;
        public string PS3NAME = "";
        PS3API E3modz = new PS3API();
        private int num;
        public static uint NameAddress = 0x5DB0;
        uint G_Client = (0x18C6220);
        bool RPC_Enabled = (false);
        bool forceHostLoopOn = (false);
        uint G_Client_Size = (0x6200);
        uint selected_client = (0);
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public HenCidChanger()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PS3M_API.PS3.SetIDPS(textBox1.Text);
        }
        public static void  LoadConsole()
        {
           
        }
        private void HenCidChanger_Load(object sender, EventArgs e)
        {
            ConsoleIP1.Text = Properties.Settings.Default.IP1;
            
            groupBox1.Refresh();
            tabControl1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddNewConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP1 = "Console Not Found";
            Properties.Settings.Default.bool1 = false;
            Properties.Settings.Default.Save();
            groupBox1.Refresh();
            ConsoleIP1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void ConnectToPS3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3M_API.ConnectTarget(Properties.Settings.Default.IP1, Convert.ToInt32(7887));
            try
            {
                foreach (uint num in PS3M_API.Process.GetPidProcesses())
                {
                    if (num == 0u)
                    {
                        break;

                    }

                    label19.Text = "Connected!";
                    label19.ForeColor = Color.Green;
                    tabControl1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox4.Enabled = true;
                    getInfos();
                }
                MessageBox.Show("Connection Succes", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3M_API.DisconnectTarget();
            MessageBox.Show("Disconnected", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label19.Text = "Disconnected!";
            label19.ForeColor = Color.White;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (HardRadio.Checked == true)
            {
                PS3M_API.PS3.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.HardReboot);
            }
        }
        private void TimedOutConsole()
        {
            tabControl1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShutdownRadio.Checked == true)
                {
                    PS3M_API.PS3.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
                }
                else if (SoftRadio.Checked == true)
                {
                    PS3M_API.PS3.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.SoftReboot);
                }
                else if (HardRadio.Checked == true)
                {
                    PS3M_API.PS3.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.HardReboot);
                }
                else if (QuickRebootReadio.Checked == true)
                {
                    PS3M_API.PS3.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.QuickReboot);
                }
            }
            catch
            {
                TimedOutConsole();
            }
        }
        private void getInfos()
        {
            uint rsxtemp, cputemp;
            PS3M_API.PS3.GetTemperature(out cputemp, out rsxtemp);
            if (rsxtemp != 0 || cputemp != 0)
            {
                consoleInfoLabel.Text = string.Format("Firmware: {0}\n\nCPU Temp: {1}°\n\nRSX Temp: {2}°", PS3M_API.PS3.GetFirmwareVersion_Str(), cputemp, rsxtemp);
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            getInfos();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            PS3M_API.PS3.SetPSID(textBox2.Text);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            PS3M_API.PS3.DisableSyscall(num);
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            PS3M_API.PS3.ClearHistory();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                PS3M_API.PS3.DisableSyscall(num);
                PS3M_API.PS3.ClearHistory();

            }
            catch
            {
                TimedOutConsole();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = Details;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (GreenOFF.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
            }
            else if (GreenON.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
            }
            else if (Blink.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
            }
            else if (RedOFF.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
            }
            else if (RedON.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
            }
            else if (RedBlink.Checked == true)
            {
                PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
            }

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (Single.Checked == true)
            {
                PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Single);
            }
            else if (Double.Checked == true)
            {
                PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Double);
            }
            else if (Continous.Checked == true)
            {
                PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Triple);
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            foreach (uint num in PS3M_API.Process.GetPidProcesses())
            {
                if (num == 0u)
                {
                    break;

                }
                comboBox1.Items.Add(PS3M_API.Process.GetName(num));
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error!");
        }

        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            HenCidChanger.x = Control.MousePosition.X - base.Location.X;
            HenCidChanger.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HenCidChanger.newpoint = Control.MousePosition;
                HenCidChanger.newpoint.X -= HenCidChanger.x;
                HenCidChanger.newpoint.Y -= HenCidChanger.y;
                base.Location = HenCidChanger.newpoint;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void PS3Name_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void PS3Name_Click(object sender, EventArgs e)
        {
            ConsoleIP1.BackColor = Color.DimGray;
            ConsoleIP1.ForeColor = Color.White;
            Console1 = true;
            
        }

        private void PS3Name_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Console1.ToString());
            MessageBox.Show(Console2.ToString());
            MessageBox.Show(Console3.ToString());
        }

        private void addANewConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewConsole h = new AddNewConsole();
            h.Show();
            this.Hide();
        }
    }
}

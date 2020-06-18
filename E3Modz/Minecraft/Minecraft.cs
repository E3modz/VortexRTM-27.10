using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_3
{
    public partial class Minecraft : Form
    {
        public int CLIENT = 0;
        public static string hencon = E3Modz.Properties.Settings.Default.IP1;
        private string ps3Ip;
        private readonly string errorStatus = "Process failed";
        PS3API E3modz = new PS3API();
        public string string_3 = "N/A";
        public string string_0;
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public Minecraft()
        {
            InitializeComponent();
        }

        private void CCAPICheck_OnValueChange(object sender, EventArgs e)
        {
            if (CCAPICheck.Value == true)
            {
                TMAPICheck.Value = false;
                HenCheck.Value = false;
                E3modz.ChangeAPI(SelectAPI.ControlConsole);
                label13.Text = "CCAPI";
            }
            else
            {
                label13.Text = "?";
            }
        }

        private void TMAPICheck_OnValueChange(object sender, EventArgs e)
        {
            if (TMAPICheck.Value == true)
            {
                CCAPICheck.Value = false;
                HenCheck.Value = false;
                E3modz.ChangeAPI(SelectAPI.TargetManager);
                label13.Text = "TMAPI";
            }
            else
            {
                label13.Text = "?";
            }
        }

        private void HenCheck_OnValueChange(object sender, EventArgs e)
        {
            if (HenCheck.Value == true)
            {
                CCAPICheck.Value = false;
                TMAPICheck.Value = false;
                if (hencon.Length == 0)
                {
                    MessageBox.Show("Please Add first a Console on Hen Console Manager!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label13.Text = "HEN";
                }
            }
            else
            {

            }
        }
        private string method_66(string string_3)
        {
            string result;
            if (string_3 == "NPUB-31419" | string_3 == "NPEB-01899" | string_3 == "NPEB-01899" | string_3 == "NPEB-01899" | string_3 == "BLES-01976" | string_3 == "BLUS-31426" | string_3 == "3000386" | string_3 == "BLES-01976" | string_3 == "NPJB-00549" | string_3 == "NPUB31419" | string_3 == "NPEB01899")
            {
                byte[] array = new byte[1];
                PS5.GetMemoryR(2265001u, ref array);
                if (array[0] == 33)
                {
                    result = string_3;
                }
                else
                {
                    result = string_3;
                }

            }
            else
            {
                result = "Unknown";
            }
            return result;
        }
        private void method_65()
        {
            byte[] byte_ = new byte[16];
            PS5.GetMemoryR(268501585u, ref byte_);
            string string_ = Main.smethod_9(byte_).Replace(Convert.ToChar(0).ToString(), string.Empty);
            this.string_0 = this.method_66(string_);
            this.label14.Text = this.string_0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (HenCheck.Value == true)
            {
                if (E3Modz.Properties.Settings.Default.bool1 == true)
                {
                    PS3M_API.ConnectTarget(hencon, Convert.ToInt32(7887));
                    try
                    {
                        this.comboBox1.Items.Clear();
                        foreach (uint num in PS3M_API.Process.GetPidProcesses())
                        {
                            if (num == 0u)
                            {
                                break;

                            }
                            comboBox1.Items.Add(PS3M_API.Process.GetName(num));
                            label13.Text = "Connected!";
                            button13.Enabled = true;

                            label13.ForeColor = Color.Green;
                        }
                        this.comboBox1.SelectedIndex = 0;
                        bunifuGauge1.Value = 50;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No Console found!\nPlease add it on hen console manager!\n If you Click Yes you come to the Console Manager\nEROOR:0x7761A", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HenCidChanger henman = new HenCidChanger();
                        henman.Show();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            else
            {
                label16.Text = "Connecting..";
                if (E3modz.ConnectTarget())
                {
                    label13.Refresh();
                    label16.Text = "Connected";
                    button4.Enabled = true;
                    label13.Text = "Connected!";
                    label13.ForeColor = Color.Green;
                    MessageBox.Show("Connected!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(100);
                    label16.Text = "Awaiting attach..";
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Connected with E3modz Tool :D");
                    cell.Text = E3modz.CCAPI.GetTemperatureCELL();
                    rsx.Text = E3modz.CCAPI.GetTemperatureRSX();
                    Fw.Text = E3modz.CCAPI.GetFirmwareVersion();
                    Lv2.Text = E3modz.CCAPI.GetFirmwareType();
                    bunifuGauge1.Value = 50;

                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label16.Text = errorStatus;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (HenCheck.Value == true)
            {
                PS3.ChangeAPI(SelectAPI.PS3Manager);
                if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
                {
                    MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    PS3M_API.DisconnectTarget();
                }
                PSN.Text = PS3.Extension.ReadString(805350372u);
                PS3M_API.PS3.Notify("Successfully Attached");
                PS6.Attach();
                label16.Refresh();
                this.method_65();
                label16.Text = "Attached";
                label16.Text = "Connected + Attached!";
                label16.ForeColor = Color.Green;
                MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(100);
                label16.Text = "Ready to Mod!";
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with VortexRTM Tool, Have Fun! :D");
                bunifuGauge1.Value = 100;


            }

            else
            {
                label16.Text = "Attaching..";
                if (E3modz.AttachProcess())
                {
                    PS6.Attach();
                    label16.Refresh();
                    PSN.Text = PS3.Extension.ReadString(805350372u);
                    this.method_65();
                    label16.Text = "Attached";
                    label16.Text = "Connected + Attached!";
                    label16.ForeColor = Color.Green;
                    MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(100);
                    label16.Text = "Ready to Mod!";
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with VortexRTM Tool, Have Fun! :D");
                    bunifuGauge1.Value = 100;
                }
                else
                {
                    MessageBox.Show("Attaching failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = NonHostTab;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (button103.Text == "OFF")
            {
                button103.ForeColor = Color.Green;
                button103.Text = "ON";
                PS3.SetMemory(4908817u, new byte[]
                {
                    252,
                    128,
                    248,
                    144
                });
            }
            else if (button103.Text == "ON")
            {
                button103.ForeColor = Color.Red;
                button103.Text = "OFF";
                PS3.SetMemory(4908817u, new byte[]
            {
                252,
                32,
                248,
                144
            });
            }
        }

        private void NonHostTab_Click(object sender, EventArgs e)
        {

        }
    }
}
    
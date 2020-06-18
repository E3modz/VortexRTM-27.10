using E3Modz.Ghost;
using PS3Lib;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class GhostMP : Form
    {
        public static string hencon = Properties.Settings.Default.IP1;
        private string ps3Ip;
        PS3API E3modz = new PS3API();
        private bool hen = false;
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public GhostMP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (Henradio.Checked == true)
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
                        ConnectionStatus.Text = "Connected!";
                        button13.Enabled = true;
                        PS3M_API.PS3.Notify("Ghost Connected!");
                        ConnectionStatus.ForeColor = Color.Green;
                    }
                    this.comboBox1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                ConnectionStatus.Text = "Connecting..";
                if (E3modz.ConnectTarget())
                {
                    ConnectionStatus.Refresh();
                    ConnectionStatus.Text = "Connected!";
                    ConnectionStatus.ForeColor = Color.Green;
                    MessageBox.Show("Connected!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Connected with E3modz Tool :D");
                    Cell.Text = E3modz.CCAPI.GetTemperatureCELL();
                    Rsx.Text = E3modz.CCAPI.GetTemperatureRSX();
                    fw.Text = E3modz.CCAPI.GetFirmwareVersion();
                    Lv2.Text = E3modz.CCAPI.GetFirmwareType();
                    button13.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionStatus.Text = "Operation failed!";
                }

            }
        }

        private void conTabPage_Click(object sender, System.EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cell.Text = E3modz.CCAPI.GetTemperatureCELL();
            Rsx.Text = E3modz.CCAPI.GetTemperatureRSX();
            fw.Text = E3modz.CCAPI.GetFirmwareVersion();
            Lv2.Text = E3modz.CCAPI.GetFirmwareType();
            PS3.CCAPI.ClearTargetInfo();
        }

        private void CCAPIRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CCAPIRadio.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
            else
            {

            }
        }

        private void TmapiRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (TmapiRadio.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
            }
            else
            {

            }
        }
        public static void ToggleFPS(bool Status)
        {
            PS3.Extension.WriteBool(3595022u, Status);
        }

        // Token: 0x06000021 RID: 33 RVA: 0x0000337E File Offset: 0x0000157E
        public static void InitalizeFPS(string Text)
        {
            PS3.SetMemory(8747944u, Encoding.ASCII.GetBytes(Text + "\0"));
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Henradio.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.PS3Manager);
                if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
                {
                    MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    PS3M_API.DisconnectTarget();
                }
                hen = true;
                PS3M_API.PS3.Notify("Successfully Attached");
                PS6.Attach();
                GhostMP.ToggleFPS(true);
                GhostMP.InitalizeFPS("^1Vortex^2RTM");
                RPCGhost.Enable_RPC();
                ConnectionStatus.Refresh();
                Cell.Text = E3modz.CCAPI.GetTemperatureCELL();
                Rsx.Text = E3modz.CCAPI.GetTemperatureRSX();
                Lv2.Text = E3modz.CCAPI.GetFirmwareVersion();
                fw.Text = E3modz.CCAPI.GetFirmwareType();
                ConnectionStatus.Text = "Attached";
                PSNName.Text = PS3.Extension.ReadString(0x177A238);
                RPCStatus.Text = "Enabled";
                ConnectionStatus.Text = "Connected + Attached!";
                ConnectionStatus.ForeColor = Color.Green;
                MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with VortexRTM Tool, Have Fun! :D");

            }

            else
            {
                ConnectionStatus.Text = "Attaching..";
                if (E3modz.AttachProcess())
                {
                    GhostMP.ToggleFPS(true);
                    GhostMP.InitalizeFPS("^1Vortex^2RTM");
                    ConnectionStatus.Refresh();
                    RPCGhost.Enable_RPC();
                    ConnectionStatus.Text = "Attached";
                    PSNName.Text = PS3.Extension.ReadString(0x177A238);
                    ConnectionStatus.Text = "Connected + Attached!";
                    ConnectionStatus.ForeColor = Color.Green;
                    RPCStatus.Text = "Enabled";
                    MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with E3Modz Tool, Have Fun! :D");
                }
                else
                {
                    MessageBox.Show("Attaching failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[4];
            array[0] = 48;
            array[1] = 165;
            PS3.SetMemory(7342812u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 192;
            PS3.SetMemory(7342804u, array);
            array = new byte[4];
            array[0] = 57;
            PS3.SetMemory(7337176u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(7336292u, array);
            array = new byte[4];
            array[0] = 48;
            array[1] = 231;
            PS3.SetMemory(7342808u, array);
            array = new byte[4];
            array[0] = 59;
            array[1] = 160;
            PS3.SetMemory(7291368u, array);

        }
        public static string GetName(uint uint_11)
        {
            return PS3.Extension.ReadString(16022044u + uint_11 * 14080u);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 1)
            {
                this.dataGridView1.Rows.Add(11);
            }
            for (uint num = 0u; num < 12u; num += 1u)
            {
                this.dataGridView1[0, Convert.ToInt32(num)].Value = num;
                this.dataGridView1[1, Convert.ToInt32(num)].Value = GetName(num);
            }
        }

        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 14080), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 14720), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 15360), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 16000), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 16640), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 17280), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 17920), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 18560), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 19200), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 19840), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 20480), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(14699306 + this.dataGridView1.CurrentRow.Index * 21120), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            RPCGhost.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^2Enabled");
        }

        private void disableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PS3API ps3API = PS3;
            uint num = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 14080);
            byte[] array = new byte[4];
            array[2] = 100;
            ps3API.SetMemory(num, array);
            PS3API ps3API2 = PS3;
            uint num2 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 14720);
            array = new byte[4];
            array[2] = 100;
            ps3API2.SetMemory(num2, array);
            PS3API ps3API3 = PS3;
            uint num3 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 15360);
            array = new byte[4];
            array[2] = 100;
            ps3API3.SetMemory(num3, array);
            PS3API ps3API4 = PS3;
            uint num4 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 16000);
            array = new byte[4];
            array[2] = 100;
            ps3API4.SetMemory(num4, array);
            PS3API ps3API5 = PS3;
            uint num5 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 16640);
            array = new byte[4];
            array[2] = 100;
            ps3API5.SetMemory(num5, array);
            PS3API ps3API6 = PS3;
            uint num6 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 17280);
            array = new byte[4];
            array[2] = 100;
            ps3API6.SetMemory(num6, array);
            PS3API ps3API7 = PS3;
            uint num7 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 17920);
            array = new byte[4];
            array[2] = 100;
            ps3API7.SetMemory(num7, array);
            PS3API ps3API8 = PS3;
            uint num8 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 18560);
            array = new byte[4];
            array[2] = 100;
            ps3API8.SetMemory(num8, array);
            PS3API ps3API9 = PS3;
            uint num9 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 19200);
            array = new byte[4];
            array[2] = 100;
            ps3API9.SetMemory(num9, array);
            PS3API ps3API10 = PS3;
            uint num10 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 19840);
            array = new byte[4];
            array[2] = 100;
            ps3API10.SetMemory(num10, array);
            PS3API ps3API11 = PS3;
            uint num11 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 20480);
            array = new byte[4];
            array[2] = 100;
            ps3API11.SetMemory(num11, array);
            PS3API ps3API12 = PS3;
            uint num12 = (uint)(14699306 + this.dataGridView1.CurrentRow.Index * 21120);
            array = new byte[4];
            array[2] = 100;
            ps3API12.SetMemory(num12, array);
            RPCGhost.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^1Disabled");
        }

        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 14080), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 14720), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 15360), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 16000), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 16640), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 17280), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 17920), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 18560), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 19200), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 19840), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 20480), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010970 + this.dataGridView1.CurrentRow.Index * 21120), new byte[]
             {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 14080), new byte[]
             {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
             });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 14720), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 15360), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 16000), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 16640), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 17280), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 17920), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 18560), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 19200), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 19840), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 20480), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            PS3.SetMemory((uint)(16010986 + this.dataGridView1.CurrentRow.Index * 21120), new byte[]
            {
                15,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            });
            RPCGhost.Call(0x23D674, dataGridView1.CurrentRow.Index, 1, "O " + "make a label with a> " + "text here to print");
        }
        private void tookAmoSecondary()
        {
            PS3API ps3API = PS3;
            uint num = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 14080);
            byte[] array = new byte[4];
            ps3API.SetMemory(num, array);
            PS3API ps3API2 = PS3;
            uint num2 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 14720);
            array = new byte[4];
            ps3API2.SetMemory(num2, array);
            PS3API ps3API3 = PS3;
            uint num3 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 15360);
            array = new byte[4];
            ps3API3.SetMemory(num3, array);
            PS3API ps3API4 = PS3;
            uint num4 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 16000);
            array = new byte[4];
            ps3API4.SetMemory(num4, array);
            PS3API ps3API5 = PS3;
            uint num5 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 16640);
            array = new byte[4];
            ps3API5.SetMemory(num5, array);
            PS3API ps3API6 = PS3;
            uint num6 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 17280);
            array = new byte[4];
            ps3API6.SetMemory(num6, array);
            PS3API ps3API7 = PS3;
            uint num7 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 17920);
            array = new byte[4];
            ps3API7.SetMemory(num7, array);
            PS3API ps3API8 = PS3;
            uint num8 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 18560);
            array = new byte[4];
            ps3API8.SetMemory(num8, array);
            PS3API ps3API9 = PS3;
            uint num9 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 19200);
            array = new byte[4];
            ps3API9.SetMemory(num9, array);
            PS3API ps3API10 = PS3;
            uint num10 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 19840);
            array = new byte[4];
            ps3API10.SetMemory(num10, array);
            PS3API ps3API11 = PS3;
            uint num11 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 20480);
            array = new byte[4];
            ps3API11.SetMemory(num11, array);
            PS3API ps3API12 = PS3;
            uint num12 = (uint)(16010986 + this.dataGridView1.CurrentRow.Index * 21120);
            array = new byte[4];
            ps3API12.SetMemory(num12, array);
        }
        private void tookAmoPrimary()
        {
            PS3API ps3API = PS3;
            uint num = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 14080);
            byte[] array = new byte[4];
            ps3API.SetMemory(num, array);
            PS3API ps3API2 = PS3;
            uint num2 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 14720);
            array = new byte[4];
            ps3API2.SetMemory(num2, array);
            PS3API ps3API3 = PS3;
            uint num3 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 15360);
            array = new byte[4];
            ps3API3.SetMemory(num3, array);
            PS3API ps3API4 = PS3;
            uint num4 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 16000);
            array = new byte[4];
            ps3API4.SetMemory(num4, array);
            PS3API ps3API5 = PS3;
            uint num5 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 16640);
            array = new byte[4];
            ps3API5.SetMemory(num5, array);
            PS3API ps3API6 = PS3;
            uint num6 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 17280);
            array = new byte[4];
            ps3API6.SetMemory(num6, array);
            PS3API ps3API7 = PS3;
            uint num7 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 17920);
            array = new byte[4];
            ps3API7.SetMemory(num7, array);
            PS3API ps3API8 = PS3;
            uint num8 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 18560);
            array = new byte[4];
            ps3API8.SetMemory(num8, array);
            PS3API ps3API9 = PS3;
            uint num9 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 19200);
            array = new byte[4];
            ps3API9.SetMemory(num9, array);
            PS3API ps3API10 = PS3;
            uint num10 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 19840);
            array = new byte[4];
            ps3API10.SetMemory(num10, array);
            PS3API ps3API11 = PS3;
            uint num11 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 20480);
            array = new byte[4];
            ps3API11.SetMemory(num11, array);
            PS3API ps3API12 = PS3;
            uint num12 = (uint)(16010970 + this.dataGridView1.CurrentRow.Index * 21120);
            array = new byte[4];
            ps3API12.SetMemory(num12, array);
        }
        private void disableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tookAmoPrimary();
            tookAmoSecondary();
            RPCGhost.iPrintln(this.dataGridView1.CurrentRow.Index, "Unlimited Ammo ^1Disabled");
        }

        private void enableToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Aimbot.setClientViewAngles(dataGridView1.CurrentRow.Index);
        }
        public class RPCText
        {
            // Token: 0x060002D5 RID: 725 RVA: 0x00096F08 File Offset: 0x00095108
            public static void Set(int Client, string Text)
            {
               
              RPCGhost.iPrintln(Client, Text);
                
            }
        }
        public static void ImpactBulletsOn(int Client)
        {
            PS3.SetMemory(16022099u + (uint)(14080 * Client), new byte[]
            {
                byte.MaxValue
            });
        }
            private void explosivV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhostMP.ImpactBulletsOn(dataGridView1.CurrentRow.Index);
            RPCText.Set(dataGridView1.CurrentRow.Index, "Explosiv V1 Bullets ^2On");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.Text == "OFF")
            {
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] array2 = array;
                PS3.SetMemory(1347892u, array2);
                button44.Text = "ON";
            }
            else if (button44.Text == "ON")
            {
                button44.Text = "OFF";
                byte[] array2 = new byte[]
                {
                    65,
                    130,
                    0,
                    12
                };
                PS3.SetMemory(1347892u, array2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

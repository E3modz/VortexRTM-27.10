using E3Modz.Login___Home;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace E3Modz.BO1
{
    public partial class BO1E3bootBuilder : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public BO1E3bootBuilder()
        {
            InitializeComponent();
        }

        private void BO1E3bootBuilder_Load(object sender, EventArgs e)
        {

        }
        private OpenFileDialog openFileDialog_0 = new OpenFileDialog();
        private void Button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;
            this.button1.BackColor = Color.Green;
            this.button2.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
            this.button2.BackColor = Color.Green;
            this.button1.BackColor = Color.FromArgb(35, 35, 35);
        }
        private void method_0(bool bool_0)
        {
            this.BO1Debug.Enabled = bool_0;
            this.BO1BlackBird.Enabled = bool_0;
            this.BO1FPS.Enabled = bool_0;
            this.BO1PerkCheck.Enabled = bool_0;
            this.checkBox_1.Enabled = bool_0;
            this.checkBox_0.Enabled = bool_0;
            this.BO1SteadyAim.Enabled = bool_0;
            this.checkBox_2.Enabled = bool_0;
            this.BO1ChromePlayer.Enabled = bool_0;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.Filter = ".ELF Files|*.elf";
            if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog_0.SafeFileName != "EBOOT.ELF")
                {
                    MessageBox.Show("Your .ELF needs to be named EBOOT.ELF!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.textBox_2.Text = this.openFileDialog_0.FileName;
                    MessageBox.Show("Successfully Loaded EBOOT.ELF!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.method_0(true);
                    this.label2.Text = "Welcome, " + Environment.MachineName;
                }
            }
            this.control3_0.Enabled = true;
        }
        public static void ThreadProg()
        {
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (File.Exists("EBOOT.BIN"))
            {
                File.Delete("EBOOT.BIN");
            }
            if (!File.Exists("EBOOT.ELF"))
            {
                MessageBox.Show("EBOOT.ELF Not Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                File.Copy("EBOOT.ELF", "EBOOT.ELF.bak");
            }
            if (File.Exists("EBOOT.BIN"))
            {
                if (File.Exists("EBOOT.BIN.bak"))
                {
                    File.Delete("EBOOT.BIN.bak");
                }
                else
                {
                    File.Copy("EBOOT.BIN", "EBOOT.BIN.bak");
                }
            }
            if (this.BO1BlackBird.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] buffer = new byte[]
                {
                    64,
                    154,
                    0,
                    196
                };
                binaryWriter.BaseStream.Position = 900596L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.checkBox_1.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 1115584L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.BO1PerkCheck.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 1115848L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.checkBox_0.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 1618500L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.BO1SteadyAim.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 637164L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.checkBox_2.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] buffer = new byte[]
                {
                    56,
                    192,
                    240,
                    3
                };
                binaryWriter.BaseStream.Position = 1184068L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.BO1ChromePlayer.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] buffer = new byte[]
                {
                    56,
                    192,
                    byte.MaxValue,
                    byte.MaxValue
                };
                binaryWriter.BaseStream.Position = 1184068L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.BO1FPS.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[2];
                array[0] = 64;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 4547224L;
                binaryWriter.Write(buffer);
                binaryWriter.BaseStream.Position = 9488480L;
                binaryWriter.Write("\n" + this.textBox_0.Text + "\0");
                byte[] buffer2 = new byte[]
                {
                    67,
                    224
                };
                binaryWriter.BaseStream.Position = 9486136L;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (this.BO1Debug.Checked)
            {
                if (File.Exists("Encrypt.bat"))
                {
                    this.label2.Text = "Building...";
                    File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", "@echo off\nmake_fself.exe EBOOT.elf EBOOT.BIN");
                    new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                    new Process
                    {
                        StartInfo =
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            FileName = "Encrypt.bat"
                        }
                    }.Start();
                    MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.label2.Text = "Build complete!";
                }
                else
                {
                    MessageBox.Show("You're Missing The Targeted File! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (!this.BO1Debug.Checked)
            {
                if (File.Exists("Encrypt.bat"))
                {
                    string text = Interaction.InputBox("Enter a Region\n'BLES01031' - 'BLES01035' Or\n 'BLES01105' Or 'BLUS30591'", "Enter Region Code", "", -1, -1);
                    if (text != "BLES01031" && text != "BLES01032" && text != "BLES01033" && text != "BLES01034" && text != "BLES01035" && text != "BLES01105" && text != "BLUS30591")
                    {
                        MessageBox.Show("Not a Valid Region, Please Try Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.label2.Text = "Build Error!";
                    }
                    string contents = "@echo off\nscetool.exe -v --sce-type=SELF --compress-data=TRUE --skip-sections=TRUE --key-revision=10 --self-auth-id=1010000001000003 --self-add-shdrs=TRUE --self-vendor-id=01000002 --self-type=NPDRM --self-app-version=0001000000000000 --self-fw-version=0003006000000000 --np-license-type=FREE --np-content-id=UP0002-" + text + "_00-CODBLOPSPATCH012 --np-app-type=EXEC --np-real-fname=EBOOT.BIN --encrypt EBOOT.elf EBOOT.BIN";
                    File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", contents);
                    if (text != "BLES01031")
                    {
                        if (text != "BLES01032")
                        {
                            if (text != "BLES01033")
                            {
                                if (text != "BLES01034")
                                {
                                    if (text != "BLES01035")
                                    {
                                        if (text != "BLES01105")
                                        {
                                            if (!(text != "BLUS30591"))
                                            {
                                                this.label2.Text = "Building...";
                                                new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                                new Process
                                                {
                                                    StartInfo =
                                                    {
                                                        WindowStyle = ProcessWindowStyle.Hidden,
                                                        FileName = "Encrypt.bat"
                                                    }
                                                }.Start();
                                                MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                this.label2.Text = "Build complete!";
                                            }
                                        }
                                        else
                                        {
                                            this.label2.Text = "Building...";
                                            new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                            new Process
                                            {
                                                StartInfo =
                                                {
                                                    WindowStyle = ProcessWindowStyle.Hidden,
                                                    FileName = "Encrypt.bat"
                                                }
                                            }.Start();
                                            MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                            this.label2.Text = "Build complete!";
                                        }
                                    }
                                    else
                                    {
                                        this.label2.Text = "Building...";
                                        new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                        new Process
                                        {
                                            StartInfo =
                                            {
                                                WindowStyle = ProcessWindowStyle.Hidden,
                                                FileName = "Encrypt.bat"
                                            }
                                        }.Start();
                                        MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        this.label2.Text = "Build complete!";
                                    }
                                }
                                else
                                {
                                    this.label2.Text = "Building...";
                                    new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                    new Process
                                    {
                                        StartInfo =
                                        {
                                            WindowStyle = ProcessWindowStyle.Hidden,
                                            FileName = "Encrypt.bat"
                                        }
                                    }.Start();
                                    MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.label2.Text = "Build complete!";
                                }
                            }
                            else
                            {
                                this.label2.Text = "Building...";
                                new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                new Process
                                {
                                    StartInfo =
                                    {
                                        WindowStyle = ProcessWindowStyle.Hidden,
                                        FileName = "Encrypt.bat"
                                    }
                                }.Start();
                                MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.label2.Text = "Build complete!";
                            }
                        }
                        else
                        {
                            this.label2.Text = "Building...";
                            new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                            new Process
                            {
                                StartInfo =
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    FileName = "Encrypt.bat"
                                }
                            }.Start();
                            MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.label2.Text = "Build complete!";
                        }
                    }
                    else
                    {
                        this.label2.Text = "Building...";
                        new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                        new Process
                        {
                            StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "Encrypt.bat"
                            }
                        }.Start();
                        MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.label2.Text = "Build complete!";
                    }
                }
                else
                {
                    MessageBox.Show("You're Missing The Targeted File! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (File.Exists("EBOOT.ELF.bak"))
            {
                File.Delete("EBOOT.ELF.bak");
            }
            if (File.Exists("EBOOT.BIN.bak"))
            {
                File.Delete("EBOOT.BIN.bak");
            }
            Thread.Sleep(1000);
            if (File.Exists("EBOOT.ELF"))
            {
                File.Delete("EBOOT.ELF");
            }
            File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", " ");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("First Load an Eboot.ELF, then it works!");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.Filter = ".ELF Files|*.elf";
            if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog_0.SafeFileName != "EBOOT.ELF")
                {
                    MessageBox.Show("Your .ELF needs to be named EBOOT.ELF!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.textBox_3.Text = this.openFileDialog_0.FileName;
                    MessageBox.Show("Successfully Loaded EBOOT.ELF!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.method_1(true);
                    this.ehrBoNevI.Text = "Welcome, " + Environment.MachineName;
                }
            }
            this.control3_0.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (File.Exists("EBOOT.BIN"))
            {
                File.Delete("EBOOT.BIN");
            }
            if (!File.Exists("EBOOT.ELF"))
            {
                MessageBox.Show("EBOOT.ELF Not Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                File.Copy("EBOOT.ELF", "EBOOT.ELF.bak");
            }
            if (File.Exists("EBOOT.BIN"))
            {
                if (File.Exists("EBOOT.BIN.bak"))
                {
                    File.Delete("EBOOT.BIN.bak");
                }
                else
                {
                    File.Copy("EBOOT.BIN", "EBOOT.BIN.bak");
                }
            }
            if (this.BO1zSteadyAim.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 47;
                array[1] = 128;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 528404L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.checkBox_4.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 1352480L;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (this.BO1zSuperJump.Checked)
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog_0.FileName));
                byte[] array = new byte[3];
                array[0] = 73;
                byte[] buffer = array;
                binaryWriter.BaseStream.Position = 8205464L;
                binaryWriter.Write(buffer);
                byte[] buffer2 = new byte[]
                {
                    64
                };
                binaryWriter.BaseStream.Position = 430136L;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (this.checkBox_3.Checked)
            {
                if (File.Exists("Encrypt.bat"))
                {
                    this.ehrBoNevI.Text = "Building...";
                    File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", "@echo off\nmake_fself.exe EBOOT.elf EBOOT.BIN");
                    new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                    new Process
                    {
                        StartInfo =
                        {
                            WindowStyle = ProcessWindowStyle.Hidden,
                            FileName = "Encrypt.bat"
                        }
                    }.Start();
                    MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.ehrBoNevI.Text = "Build complete!";
                }
                else
                {
                    MessageBox.Show("You're Missing The Targeted File! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (!this.checkBox_3.Checked)
            {
                if (File.Exists("Encrypt.bat"))
                {
                    string text = Interaction.InputBox("Enter a Region\n'BLES01031' - 'BLES01035' Or\n 'BLES01105' Or 'BLUS30591'", "Enter Region Code", "", -1, -1);
                    if (text != "BLES01031" && text != "BLES01032" && text != "BLES01033" && text != "BLES01034" && text != "BLES01035" && text != "BLES01105" && text != "BLUS30591")
                    {
                        MessageBox.Show("Not a Valid Region, Please Try Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.ehrBoNevI.Text = "Build Error!";
                    }
                    string contents = "@echo off\nscetool.exe -v --sce-type=SELF --compress-data=TRUE --skip-sections=TRUE --key-revision=10 --self-auth-id=1010000001000003 --self-add-shdrs=TRUE --self-vendor-id=01000002 --self-type=NPDRM --self-app-version=0001000000000000 --self-fw-version=0003006000000000 --np-license-type=FREE --np-content-id=UP0002-" + text + "_00-CODBLOPSPATCH012 --np-app-type=EXEC --np-real-fname=EBOOT.BIN --encrypt EBOOT.elf EBOOT.BIN";
                    File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", contents);
                    if (text != "BLES01031")
                    {
                        if (text != "BLES01032")
                        {
                            if (text != "BLES01033")
                            {
                                if (text != "BLES01034")
                                {
                                    if (text != "BLES01035")
                                    {
                                        if (text != "BLES01105")
                                        {
                                            if (!(text != "BLUS30591"))
                                            {
                                                this.ehrBoNevI.Text = "Building...";
                                                new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                                new Process
                                                {
                                                    StartInfo =
                                                    {
                                                        WindowStyle = ProcessWindowStyle.Hidden,
                                                        FileName = "Encrypt.bat"
                                                    }
                                                }.Start();
                                                MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                this.ehrBoNevI.Text = "Build complete!";
                                            }
                                        }
                                        else
                                        {
                                            this.ehrBoNevI.Text = "Building...";
                                            new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                            new Process
                                            {
                                                StartInfo =
                                                {
                                                    WindowStyle = ProcessWindowStyle.Hidden,
                                                    FileName = "Encrypt.bat"
                                                }
                                            }.Start();
                                            MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                            this.ehrBoNevI.Text = "Build complete!";
                                        }
                                    }
                                    else
                                    {
                                        this.ehrBoNevI.Text = "Building...";
                                        new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                        new Process
                                        {
                                            StartInfo =
                                            {
                                                WindowStyle = ProcessWindowStyle.Hidden,
                                                FileName = "Encrypt.bat"
                                            }
                                        }.Start();
                                        MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        this.ehrBoNevI.Text = "Build complete!";
                                    }
                                }
                                else
                                {
                                    this.ehrBoNevI.Text = "Building...";
                                    new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                    new Process
                                    {
                                        StartInfo =
                                        {
                                            WindowStyle = ProcessWindowStyle.Hidden,
                                            FileName = "Encrypt.bat"
                                        }
                                    }.Start();
                                    MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.ehrBoNevI.Text = "Build complete!";
                                }
                            }
                            else
                            {
                                this.ehrBoNevI.Text = "Building...";
                                new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                                new Process
                                {
                                    StartInfo =
                                    {
                                        WindowStyle = ProcessWindowStyle.Hidden,
                                        FileName = "Encrypt.bat"
                                    }
                                }.Start();
                                MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.ehrBoNevI.Text = "Build complete!";
                            }
                        }
                        else
                        {
                            this.ehrBoNevI.Text = "Building...";
                            new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                            new Process
                            {
                                StartInfo =
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    FileName = "Encrypt.bat"
                                }
                            }.Start();
                            MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.ehrBoNevI.Text = "Build complete!";
                        }
                    }
                    else
                    {
                        this.ehrBoNevI.Text = "Building...";
                        new Thread(new ThreadStart(BO1E3bootBuilder.ThreadProg));
                        new Process
                        {
                            StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "Encrypt.bat"
                            }
                        }.Start();
                        MessageBox.Show("EBOOT.BIN Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.ehrBoNevI.Text = "Build complete!";
                    }
                }
                else
                {
                    MessageBox.Show("You're Missing The Targeted File! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (File.Exists("EBOOT.ELF.bak"))
            {
                File.Delete("EBOOT.ELF.bak");
            }
            if (File.Exists("EBOOT.BIN.bak"))
            {
                File.Delete("EBOOT.BIN.bak");
            }
            Thread.Sleep(1000);
            if (File.Exists("EBOOT.ELF"))
            {
                File.Delete("EBOOT.ELF");
            }
            File.WriteAllText(Environment.CurrentDirectory + "\\Encrypt.bat", "");
        }
        private void method_1(bool bool_0)
        {
            this.checkBox_3.Enabled = bool_0;
            this.checkBox_4.Enabled = bool_0;
            this.BO1zSteadyAim.Enabled = bool_0;
            this.BO1zSuperJump.Enabled = bool_0;
        }

        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            BO1E3bootBuilder.x = Control.MousePosition.X - base.Location.X;
            BO1E3bootBuilder.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BO1E3bootBuilder.newpoint = Control.MousePosition;
                BO1E3bootBuilder.newpoint.X -= BO1E3bootBuilder.x;
                BO1E3bootBuilder.newpoint.Y -= BO1E3bootBuilder.y;
                base.Location = BO1E3bootBuilder.newpoint;
            }
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
    }
}

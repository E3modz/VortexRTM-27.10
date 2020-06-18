using E3Modz.Login___Home;
using System;
using System.Diagnostics;
using System.IO;

namespace E3Modz.Klassen
{
    // Token: 0x02000003 RID: 3
    internal class Bo3EbootBuilderFunctions
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
        public static bool verify_magic(byte[] imagic)
        {
            Array.Reverse(imagic);
            uint num = BitConverter.ToUInt32(imagic, 0);
            return num == 2135247942u;
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
        public static byte[] write_bytes(byte[] buffer, uint address, uint data)
        {
            byte[] bytes = BitConverter.GetBytes(data);
            Array.Reverse(bytes);
            for (int i = 0; i < bytes.Length; i++)
            {
                buffer[(int)(checked((IntPtr)(unchecked((ulong)address + (ulong)((long)i)))))] = bytes[i];
            }
            return buffer;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
        public static string compile(byte[] buffer, Bo3EbootBuilder.Mods mod_buffer, Bo3EbootBuilder.Build type)
        {
            if (File.Exists("EBOOT-DEX.BIN.bak"))
            {
                File.Delete("EBOOT-DEX.BIN.bak");
            }
            if (File.Exists("EBOOT-CEX.BIN.bak"))
            {
                File.Delete("EBOOT-CEX.BIN.bak");
            }
            if (File.Exists("EBOOT-DEX.BIN"))
            {
                File.Move("EBOOT-DEX.BIN", "EBOOT-DEX.BIN.bak");
            }
            if (File.Exists("EBOOT-CEX.BIN"))
            {
                File.Move("EBOOT-CEX.BIN", "EBOOT-CEX.BIN.bak");
            }
            bool flag = false;
            string str = E3Modz.Properties.Settings.Default.compress ? "-c " : "";
            string text;
            if (type != Bo3EbootBuilder.Build.npeb_cex)
            {
                text = "EBOOT-DEX.ELF";
            }
            else
            {
                text = "EBOOT-CEX.ELF";
            }
            if (mod_buffer.steady_aim != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 7659340u, mod_buffer.steady_aim.Value);
            }
            if (mod_buffer.no_recoil != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 1565136u, mod_buffer.no_recoil.Value);
            }
            if (mod_buffer.fif_level != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 948928094u, mod_buffer.fif_level.Value);
            }
            if (mod_buffer.ten_prestige != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 59246401u, mod_buffer.ten_prestige.Value);
            }
            if (mod_buffer.wallhack != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 1064000u, mod_buffer.wallhack.Value);
            }
            if (mod_buffer.vsat != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 751624u, mod_buffer.vsat.Value);
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 751652u, mod_buffer.vsat.Value);
            }
            if (mod_buffer.red_box != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 5712488u, mod_buffer.red_box.Value);
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 5712544u, mod_buffer.red_box.Value);
            }
            if (mod_buffer.rl_antiban != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 7962040u, mod_buffer.rl_antiban.Value);
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 7732816u, mod_buffer.rl_antiban.Value);
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 7961788u, mod_buffer.rl_antiban.Value);
            }
            if (mod_buffer.fps != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 767004u, mod_buffer.fps.Value);
            }
            if (mod_buffer.weapons_flag != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 514184u, mod_buffer.weapons_flag.Value);
            }
            if (mod_buffer.dead_bodies_flag != null)
            {
                buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 1068864u, mod_buffer.dead_bodies_flag.Value);
            }
            buffer = Bo3EbootBuilderFunctions.write_bytes(buffer, 4106076u, mod_buffer.no_blur);
            File.WriteAllBytes(text, buffer);
            if (!string.IsNullOrEmpty(mod_buffer.load_sprx))
            {
                if (mod_buffer.load_sprx.IndexOf(".sprx") == -1)
                {
                    mod_buffer.load_sprx += ".sprx";
                }
                Process process = new Process();
                flag = true;
                process.StartInfo.FileName = "ingame_loader.exe";
                process.StartInfo.Arguments = text + " /dev_hdd0/tmp/" + mod_buffer.load_sprx + " EBOOT-SPRX.ELF";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.WaitForExit();
            }
            Process process2 = new Process();
            if (flag)
            {
                text = "EBOOT-SPRX.ELF";
            }
            switch (type)
            {
                case Bo3EbootBuilder.Build.npeb_debug:
                    process2.StartInfo.FileName = "make_fself.exe";
                    process2.StartInfo.Arguments = str + text + " EBOOT.BIN";
                    process2.StartInfo.CreateNoWindow = true;
                    process2.StartInfo.UseShellExecute = false;
                    process2.Start();
                    break;
                case Bo3EbootBuilder.Build.npeb_debug_npdrm:
                    process2.StartInfo.FileName = "make_fself_npdrm.exe";
                    process2.StartInfo.Arguments = str + text + " EBOOT.BIN";
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.CreateNoWindow = true;
                    process2.Start();
                    break;
            }
            process2.WaitForExit();
            string result;
            if (File.Exists("EBOOT.BIN") || File.Exists("EBOOT.BIN"))
            {
                if (File.Exists("EBOOT-SPRX.ELF"))
                {
                    File.Delete("EBOOT-SPRX.ELF");
                }
                if (File.Exists("EBOOT-CEX.ELF"))
                {
                    File.Delete("EBOOT-CEX.ELF");
                }
                if (File.Exists("EBOOT-DEX.ELF"))
                {
                    File.Delete("EBOOT-DEX.ELF");
                }
                result = "good";
            }
            else
            {
                result = "noeboot";
            }
            return result;
        }
    }
}

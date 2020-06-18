using E3Modz.Black_Ops_2;
using System;
using System.Threading;

namespace E3_Modz_V5
{
    // Token: 0x02000010 RID: 16
    internal class iNgameName
    {
        // Token: 0x0600009B RID: 155 RVA: 0x00009D9C File Offset: 0x00007F9C
        public static int Call(uint func_address, params object[] parameters)
        {
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            while (i < num)
            {
                if (parameters[i] is int)
                {
                    BO2.PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is uint)
                {
                    BO2.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is string)
                {
                    uint num6 = 268574720u + num3 * 1024u;
                    BO2.PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                    BO2.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                    num2 += 1u;
                    num3 += 1u;
                }
                else if (parameters[i] is float)
                {
                    BO2.PS3.Extension.WriteFloat(268566564u + num4 * 4u, (float)parameters[i]);
                    num4 += 1u;
                }
                else if (parameters[i] is float[])
                {
                    float[] array = (float[])parameters[i];
                    uint num6 = 268570624u + num5 * 4u;
                    BO2.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                    num2 += 1u;
                    num5 += (uint)array.Length;
                }
                i++;
            }
            BO2.PS3.Extension.WriteUInt32(268566604u, func_address);
            Thread.Sleep(20);
            return BO2.PS3.Extension.ReadInt32(268566608u);
        }

        // Token: 0x0600009C RID: 156 RVA: 0x00009F30 File Offset: 0x00008130
        private static void Enable()
        {
            uint num = 8036432u;
            BO2.PS3.SetMemory(num, new byte[]
             {
                78,
                128,
                0,
                32
             });
            Thread.Sleep(20);
            byte[] buffer = new byte[]
            {
                124,
                8,
                2,
                166,
                248,
                1,
                0,
                128,
                60,
                96,
                16,
                2,
                129,
                131,
                0,
                76,
                44,
                12,
                0,
                0,
                65,
                130,
                0,
                100,
                128,
                131,
                0,
                4,
                128,
                163,
                0,
                8,
                128,
                195,
                0,
                12,
                128,
                227,
                0,
                16,
                129,
                3,
                0,
                20,
                129,
                35,
                0,
                24,
                129,
                67,
                0,
                28,
                129,
                99,
                0,
                32,
                192,
                35,
                0,
                36,
                192,
                67,
                0,
                40,
                192,
                99,
                0,
                44,
                192,
                131,
                0,
                48,
                192,
                163,
                0,
                52,
                192,
                195,
                0,
                56,
                192,
                227,
                0,
                60,
                193,
                3,
                0,
                64,
                193,
                35,
                0,
                72,
                128,
                99,
                0,
                0,
                125,
                137,
                3,
                166,
                78,
                128,
                4,
                33,
                60,
                128,
                16,
                2,
                56,
                160,
                0,
                0,
                144,
                164,
                0,
                76,
                144,
                100,
                0,
                80,
                232,
                1,
                0,
                128,
                124,
                8,
                3,
                166,
                56,
                33,
                0,
                112,
                78,
                128,
                0,
                32
            };
            BO2.PS3.SetMemory(num + 4u, buffer);
            BO2.PS3.SetMemory(268566528u, new byte[10324]);
            BO2.PS3.SetMemory(num, new byte[]
             {
                248,
                33,
                byte.MaxValue,
                145
             });
            BO2.PS3.SetMemory(805371904u, new byte[]
             {
                1
             });
        }

        // Token: 0x0600009D RID: 157 RVA: 0x00009FD8 File Offset: 0x000081D8
        public static void Init()
        {
            if (BO2.PS3.Extension.ReadByte(805371904u) == 1)
            {
                Console.Write("RPC Already Enabled");
                return;
            }
            iNgameName.Enable();
        }

        // Token: 0x0600009E RID: 158 RVA: 0x0000A001 File Offset: 0x00008201
        public static void iPrintln(int Client, string Text)
        {
            iNgameName.SV_GameSendServerCommand(Client, "O \"" + Text + "\"");
        }

        // Token: 0x0600009F RID: 159 RVA: 0x0000A019 File Offset: 0x00008219
        public static void iPrintlnBold(int Client, string Text)
        {
            iNgameName.SV_GameSendServerCommand(Client, "< \"" + Text + "\"");
        }

        // Token: 0x060000A0 RID: 160 RVA: 0x0000A031 File Offset: 0x00008231
        public static void CBuf_Addtext(string Command)
        {
            iNgameName.Call(3226648u, new object[]
            {
                0,
                Command
            });
        }

        // Token: 0x060000A1 RID: 161 RVA: 0x0000A051 File Offset: 0x00008251
        public static void SV_GameSendServerCommand(int Client, string Command)
        {
            iNgameName.Call(3448684u, new object[]
            {
                Client,
                1,
                Command
            });
        }
    }
}

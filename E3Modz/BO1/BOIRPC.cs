using PS3Lib;
using System;
using System.Text;
using System.Threading;
namespace E3Modz.Login___Home
{
    // Token: 0x0200014C RID: 332
    class BO1RPC
    {
        public static PS3API PS5 = (BO1.PS3);
        // Token: 0x06000D4D RID: 3405 RVA: 0x000C3DE8 File Offset: 0x000C1FE8
        public static uint Call(uint func_address, params object[] parameters)
        {
            int num = parameters.Length;
            uint num2 = 0u;
            uint num3 = 0u;
            while ((ulong)num3 < (ulong)((long)num))
            {
                if (parameters[(int)num3] is int)
                {
                    byte[] bytes = BitConverter.GetBytes((int)parameters[(int)num3]);
                    Array.Reverse(bytes);
                    PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes);
                }
                else if (parameters[(int)num3] is uint)
                {
                    byte[] bytes2 = BitConverter.GetBytes((uint)parameters[(int)num3]);
                    Array.Reverse(bytes2);
                    PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes2);
                }
                else if (parameters[(int)num3] is string)
                {
                    byte[] bytes3 = Encoding.UTF8.GetBytes(Convert.ToString(parameters[(int)num3]) + "\0");
                    PS3.SetMemory(268763220u + num3 * 1024u, bytes3);
                    byte[] bytes4 = BitConverter.GetBytes(268763220u + num3 * 1024u);
                    Array.Reverse(bytes4);
                    PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes4);
                }
                else if (parameters[(int)num3] is float)
                {
                    num2 += 1u;
                    byte[] bytes5 = BitConverter.GetBytes((float)parameters[(int)num3]);
                    Array.Reverse(bytes5);
                    PS3.SetMemory(268763172u + (num2 - 1u) * 4u, bytes5);
                }
                num3 += 1u;
            }
            byte[] bytes6 = BitConverter.GetBytes(func_address);
            Array.Reverse(bytes6);
            PS3.SetMemory(268763212u, bytes6);
            Thread.Sleep(20);
            byte[] array = new byte[4];
            PS3.SetMemory(268763216u, array);
            Array.Reverse(array);
            return BitConverter.ToUInt32(array, 0);
        }

        // Token: 0x06000D4E RID: 3406 RVA: 0x000C3F90 File Offset: 0x000C2190
        public static void Disable_RPC()
        {
            PS3.SetMemory(BO1RPC.function_address, new byte[]
            {
                78,
                128,
                0,
                32
            });
        }

        // Token: 0x06000D4F RID: 3407 RVA: 0x000C3FB4 File Offset: 0x000C21B4
        public static void Enable_RPC()
        {
            PS3.SetMemory(BO1RPC.function_address, new byte[]
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
                5,
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
                5,
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
            PS3.SetMemory(BO1RPC.function_address + 4u, buffer);
            PS3.SetMemory(268763136u, new byte[10324]);
            PS3.SetMemory(BO1RPC.function_address, new byte[]
            {
                248,
                33,
                byte.MaxValue,
                145
            });
        }

        // Token: 0x04001754 RID: 5972
        public static uint function_address = 8004064u;

        public static PS3API PS3;

        // Token: 0x0200014D RID: 333
        public class GameSendServerMP
        {
            // Token: 0x06000D52 RID: 3410 RVA: 0x000C4055 File Offset: 0x000C2255
            public static byte[] SendServer(string string_3)
            {
                return new ASCIIEncoding().GetBytes(string_3);
            }

            // Token: 0x06000D53 RID: 3411 RVA: 0x000C4064 File Offset: 0x000C2264
            public static void smethod_0(int int_0, string string_0)
            {
                PS3.SetMemory(33554432u, BO1RPC.GameSendServerMP.SendServer(string_0));
                PS3.SetMemory(4614068u, new byte[]
                {
                    56,
                    96,
                    0,
                    0,
                    60,
                    128,
                    2,
                    0,
                    75,
                    243,
                    53,
                    13,
                    75,
                    byte.MaxValue,
                    251,
                    129
                });
                PS3.SetMemory(4612760u, new byte[]
                {
                    65
                });
                Thread.Sleep(10);
                PS3.SetMemory(33554432u, new byte[100]);
                PS3.SetMemory(4612760u, new byte[]
                {
                    64
                });
                PS3.SetMemory(4614068u, BO1RPC.GameSendServerMP.byte_0);
            }

            // Token: 0x04001755 RID: 5973
            public static byte[] byte_0 = new byte[]
            {
                130,
                185,
                0,
                0,
                60,
                224,
                0,
                215,
                61,
                128,
                0,
                146,
                86,
                164,
                56,
                48,
                86,
                187,
                24,
                56
            };
        }
    }
}

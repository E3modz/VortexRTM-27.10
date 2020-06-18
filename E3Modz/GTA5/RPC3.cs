using PS3Lib;
using System;
using System.Collections.Generic;
using System.Threading;

namespace E3Modz.GTA5
{
    // Token: 0x02000014 RID: 20
    public static class RPC3
    {
        // Token: 0x06000345 RID: 837 RVA: 0x00084BA4 File Offset: 0x00082DA4
        static RPC3()
        {
            RPC3.PS3 = GTA5Main.PS3;
            RPC3.uint_0 = 29315072u;
            RPC3.uint_1 = 29315208u;
            RPC3.uint_2 = 99860u;
            RPC3.uint_3 = 99872u;
        }

        // Token: 0x06000346 RID: 838 RVA: 0x00084BE0 File Offset: 0x00082DE0
        public static void CompleteReq()
        {
            while (RPC3.calling)
            {
            }
        }

        // Token: 0x06000347 RID: 839 RVA: 0x00084BFC File Offset: 0x00082DFC
        public static uint CBAB(uint F, uint T)
        {
            return (F <= T) ? ((F >= T) ? 1207959552u : (T - F + 1207959552u)) : (1275068416u - (F - T));
        }

        // Token: 0x06000348 RID: 840 RVA: 0x00084C34 File Offset: 0x00082E34
        public static void Enable()
        {
            byte[] buffer = new byte[]
            {
                248,
                33,
                byte.MaxValue,
                145,
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
                4,
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
                4,
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
                112
            };
            RPC3.PS3.SetMemory(RPC3.uint_0, buffer);
            RPC3.PS3.Extension.WriteUInt32(RPC3.uint_1, RPC3.CBAB(RPC3.uint_1, RPC3.uint_3));
            RPC3.PS3.Extension.WriteUInt32(RPC3.uint_2, RPC3.CBAB(RPC3.uint_2, RPC3.uint_0));
        }

        // Token: 0x06000349 RID: 841 RVA: 0x00084CB4 File Offset: 0x00082EB4
        public static int Call(uint func_address, params object[] parameters)
        {
            bool flag = RPC3.calling;
            if (flag)
            {
                RPC3.CompleteReq();
            }
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            RPC3.calling = true;
            while (i < num)
            {
                bool flag2 = parameters[i] is int;
                if (flag2)
                {
                    RPC3.PS3.Extension.WriteInt32(268697600u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag3 = parameters[i] is uint;
                    if (flag3)
                    {
                        RPC3.PS3.Extension.WriteUInt32(268697600u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag4 = parameters[i] is string;
                        if (flag4)
                        {
                            uint num6 = 268705792u + num3 * 1024u;
                            RPC3.PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            RPC3.PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag5 = parameters[i] is float;
                            if (flag5)
                            {
                                RPC3.smethod_0(268697636u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag6 = parameters[i] is float[];
                                if (flag6)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num7 = 268701696u + num5 * 4u;
                                    RPC3.smethod_1(num7, array);
                                    RPC3.PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num7);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            RPC3.PS3.Extension.WriteUInt32(268697676u, func_address);
            while (RPC3.PS3.Extension.ReadUInt32(268697676u) > 0u)
            {
            }
            RPC3.calling = false;
            return RPC3.PS3.Extension.ReadInt32(268697680u);
        }

        // Token: 0x0600034A RID: 842 RVA: 0x00084EC4 File Offset: 0x000830C4
        public static T Call2<T>(uint func_address, params object[] parameters)
        {
            bool flag = RPC3.calling;
            if (flag)
            {
                RPC3.CompleteReq();
            }
            bool flag2 = false;
            bool flag3 = typeof(T).ToString() == "System.Single[]";
            if (flag3)
            {
                flag2 = true;
                List<object> list = new List<object>
                {
                    268636160
                };
                list.AddRange(parameters);
                list.Add(268636160);
                parameters = list.ToArray();
            }
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            RPC3.calling = true;
            while (i < num)
            {
                bool flag4 = parameters[i] is bool;
                if (flag4)
                {
                    parameters[i] = Convert.ToInt32(parameters[i]);
                }
                bool flag5 = parameters[i] is int;
                if (flag5)
                {
                    RPC3.PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag6 = parameters[i] is uint;
                    if (flag6)
                    {
                        RPC3.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag7 = parameters[i] is string;
                        if (flag7)
                        {
                            uint num6 = 268574720u + num3 * 1024u;
                            RPC3.PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            RPC3.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag8 = parameters[i] is float;
                            if (flag8)
                            {
                                bool flag9 = flag2;
                                if (flag9)
                                {
                                    RPC3.PS3.Extension.WriteFloat(268636160u + num4 * 4u, (float)parameters[i]);
                                }
                                RPC3.smethod_0(268566564u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag10 = parameters[i] is float[];
                                if (flag10)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num7 = 268570624u + num5 * 4u;
                                    RPC3.smethod_1(num7, array);
                                    RPC3.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num7);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            RPC3.PS3.Extension.WriteUInt32(268566604u, func_address);
            while (RPC3.PS3.Extension.ReadUInt32(268566604u) > 0u)
            {
            }
            Thread.Sleep(20);
            object obj = 0;
            bool flag11 = typeof(T).ToString() == "System.Int32";
            if (flag11)
            {
                obj = (T)((object)Convert.ChangeType(RPC3.PS3.Extension.ReadInt32(268566608u), typeof(T)));
            }
            bool flag12 = typeof(T).ToString() == "System.UInt32";
            if (flag12)
            {
                obj = (T)((object)Convert.ChangeType(RPC3.PS3.Extension.ReadUInt32(268566608u), typeof(T)));
            }
            bool flag13 = typeof(T).ToString() == "System.String";
            if (flag13)
            {
                obj = (T)((object)Convert.ChangeType(RPC3.PS3.Extension.ReadString(268566608u), typeof(T)));
            }
            bool flag14 = typeof(T).ToString() == "System.Single";
            if (flag14)
            {
                obj = (T)((object)Convert.ChangeType(RPC3.PS3.Extension.ReadFloat(268566608u), typeof(T)));
            }
            bool flag15 = typeof(T).ToString() == "System.Boolean";
            if (flag15)
            {
                obj = (T)((object)Convert.ChangeType(RPC3.PS3.Extension.ReadInt32(268566608u), typeof(T)));
            }
            bool flag16 = flag2;
            if (flag16)
            {
                byte[] bytes = RPC3.PS3.GetBytes(268636160u, 12);
                Array.Reverse(bytes);
                float[] array2 = new float[]
                {
                    0f,
                    0f,
                    BitConverter.ToSingle(bytes, 0)
                };
                array2[1] = BitConverter.ToSingle(bytes, 4);
                array2[0] = BitConverter.ToSingle(bytes, 8);
                obj = (T)((object)Convert.ChangeType(array2, typeof(T)));
            }
            RPC3.calling = false;
            return (T)((object)obj);
        }

        // Token: 0x0600034B RID: 843 RVA: 0x0008538C File Offset: 0x0008358C
        private static void smethod_0(uint uint_4, float float_0)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            RPC3.PS3.SetMemory(uint_4, array);
        }

        // Token: 0x0600034C RID: 844 RVA: 0x000853C8 File Offset: 0x000835C8
        private static void smethod_1(uint uint_4, float[] float_0)
        {
            int num = float_0.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                RPC3.smethod_2(BitConverter.GetBytes(float_0[i])).CopyTo(array, i * 4);
            }
            RPC3.PS3.SetMemory(uint_4, array);
        }

        // Token: 0x0600034D RID: 845 RVA: 0x00085418 File Offset: 0x00083618
        private static byte[] smethod_2(byte[] byte_0)
        {
            Array.Reverse(byte_0);
            return byte_0;
        }

        // Token: 0x04000F87 RID: 3975
        public static PS3API PS3;

        // Token: 0x04000F88 RID: 3976
        private static uint uint_0;

        // Token: 0x04000F89 RID: 3977
        private static uint uint_1;

        // Token: 0x04000F8A RID: 3978
        private static uint uint_2;

        // Token: 0x04000F8B RID: 3979
        private static uint uint_3;

        // Token: 0x04000F8C RID: 3980
        private static bool calling = false;
    }
}

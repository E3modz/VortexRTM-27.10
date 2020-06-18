using E3Modz.GTA5;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PylezZo_GTAV_Extreme_Tool.Pylo
{
    // Token: 0x02000013 RID: 19
    public static class RPCHook
    {
        // Token: 0x0600033D RID: 829 RVA: 0x000843D9 File Offset: 0x000825D9
        static RPCHook()
        {
            RPCHook.PS3 = GTA5Main.PS3;
        }

        // Token: 0x0600033E RID: 830 RVA: 0x000843F0 File Offset: 0x000825F0
        public static void CompleteReq()
        {
            while (RPCHook.Calling)
            {
            }
        }

        // Token: 0x0600033F RID: 831 RVA: 0x0008440C File Offset: 0x0008260C
        private static byte[] smethod_0(byte[] byte_0)
        {
            Array.Reverse(byte_0);
            return byte_0;
        }

        // Token: 0x06000340 RID: 832 RVA: 0x00084428 File Offset: 0x00082628
        private static void smethod_1(uint uint_0, float float_0)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            PS3.SetMemory(uint_0, array);
        }

        // Token: 0x06000341 RID: 833 RVA: 0x00084464 File Offset: 0x00082664
        private static void smethod_2(uint uint_0, float[] float_0)
        {
            int num = float_0.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                smethod_0(BitConverter.GetBytes(float_0[i])).CopyTo(array, i * 4);
            }
            PS3.SetMemory(uint_0, array);
        }

        // Token: 0x06000342 RID: 834 RVA: 0x000844B4 File Offset: 0x000826B4
        public static int Call(uint func_address, params object[] parameters)
        {
            bool calling = Calling;
            if (calling)
            {
                CompleteReq();
            }
            Calling = true;
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            while (i < num)
            {
                bool flag = parameters[i] is int;
                if (flag)
                {
                    PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag2 = parameters[i] is uint;
                    if (flag2)
                    {
                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag3 = parameters[i] is string;
                        if (flag3)
                        {
                            uint num6 = 268574720u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag4 = parameters[i] is float;
                            if (flag4)
                            {
                                smethod_1(268566564u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag5 = parameters[i] is float[];
                                if (flag5)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num7 = 268570624u + num5 * 4u;
                                    smethod_2(num7, array);
                                    PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num7);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268566604u, func_address);
            while (PS3.Extension.ReadUInt32(268566604u) > 0u)
            {
            }
            Thread.Sleep(20);
            RPCHook.Calling = false;
            return PS3.Extension.ReadInt32(268566608u);
        }

        // Token: 0x06000343 RID: 835 RVA: 0x000846CB File Offset: 0x000828CB
        public static T Call2<T>(string Native, params object[] Params)
        {
            return Call2<T>(GTA5Main.GetHash(Native), Params);
        }

        // Token: 0x06000344 RID: 836 RVA: 0x000846DC File Offset: 0x000828DC
        public static T Call2<T>(uint func_address, params object[] parameters)
        {
            bool calling = Calling;
            if (calling)
            {
                CompleteReq();
            }
            Calling = true;
            bool flag = false;
            bool flag2 = typeof(T).ToString() == "System.Single[]";
            if (flag2)
            {
                flag = true;
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
            while (i < num)
            {
                bool flag3 = parameters[i] is bool;
                if (flag3)
                {
                    parameters[i] = Convert.ToInt32(parameters[i]);
                }
                bool flag4 = parameters[i] is int;
                if (flag4)
                {
                    PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag5 = parameters[i] is uint;
                    if (flag5)
                    {
                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag6 = parameters[i] is string;
                        if (flag6)
                        {
                            uint num6 = 268574720u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag7 = parameters[i] is float;
                            if (flag7)
                            {
                                bool flag8 = flag;
                                if (flag8)
                                {
                                    PS3.Extension.WriteFloat(268636160u + num4 * 4u, (float)parameters[i]);
                                }
                                smethod_1(268566564u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag9 = parameters[i] is float[];
                                if (flag9)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num7 = 268570624u + num5 * 4u;
                                    smethod_2(num7, array);
                                    PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num7);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268566604u, func_address);
            while (PS3.Extension.ReadUInt32(268566604u) > 0u)
            {
            }
            Thread.Sleep(20);
            object obj = 0;
            bool flag10 = typeof(T).ToString() == "System.Int32";
            if (flag10)
            {
                obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadInt32(268566608u), typeof(T)));
            }
            bool flag11 = typeof(T).ToString() == "System.UInt32";
            if (flag11)
            {
                obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadUInt32(268566608u), typeof(T)));
            }
            bool flag12 = typeof(T).ToString() == "System.String";
            if (flag12)
            {
                obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadString(268566608u), typeof(T)));
            }
            bool flag13 = typeof(T).ToString() == "System.Single";
            if (flag13)
            {
                obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadFloat(268566608u), typeof(T)));
            }
            bool flag14 = typeof(T).ToString() == "System.Boolean";
            if (flag14)
            {
                obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadInt32(268566608u), typeof(T)));
            }
            bool flag15 = flag;
            if (flag15)
            {
                byte[] bytes = PS3.GetBytes(268636160u, 12);
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
            RPCHook.Calling = false;
            return (T)((object)obj);
        }

        // Token: 0x04000F85 RID: 3973
        public static PS3API PS3;

        // Token: 0x04000F86 RID: 3974
        private static bool Calling = false;

        // Token: 0x02000044 RID: 68
        public class IS_PLAYER_ONLINE
        {
            // Token: 0x060004A8 RID: 1192 RVA: 0x000AEE00 File Offset: 0x000AD000
            public static int Call(uint func_address, params object[] parameters)
            {
                bool calling = Calling;
                if (calling)
                {
                    CompleteReq();
                }
                Calling = true;
                int num = parameters.Length;
                int i = 0;
                uint num2 = 0u;
                uint num3 = 0u;
                uint num4 = 0u;
                uint num5 = 0u;
                while (i < num)
                {
                    bool flag = parameters[i] is int;
                    if (flag)
                    {
                        PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag2 = parameters[i] is uint;
                        if (flag2)
                        {
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                            num2 += 1u;
                        }
                        else
                        {
                            bool flag3 = parameters[i] is string;
                            if (flag3)
                            {
                                uint num6 = 268574720u + num3 * 1024u;
                                PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                                PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                                num2 += 1u;
                                num3 += 1u;
                            }
                            else
                            {
                                bool flag4 = parameters[i] is float;
                                if (flag4)
                                {
                                    smethod_3(268566564u + num4 * 4u, (float)parameters[i]);
                                    num4 += 1u;
                                }
                                else
                                {
                                    bool flag5 = parameters[i] is float[];
                                    if (flag5)
                                    {
                                        float[] array = (float[])parameters[i];
                                        uint num7 = 268570624u + num5 * 4u;
                                        smethod_4(num7, array);
                                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num7);
                                        num2 += 1u;
                                        num5 += (uint)array.Length;
                                    }
                                }
                            }
                        }
                    }
                    i++;
                }
                PS3.Extension.WriteUInt32(268566604u, func_address);
                while (PS3.Extension.ReadUInt32(268566604u) > 0u)
                {
                }
                Thread.Sleep(20);
                RPCHook.Calling = false;
                return PS3.Extension.ReadInt32(268566608u);
            }

            // Token: 0x060004A9 RID: 1193 RVA: 0x000AF018 File Offset: 0x000AD218
            public static T Call2<T>(uint func_address, params object[] parameters)
            {
                bool calling = RPCHook.Calling;
                if (calling)
                {
                    RPCHook.CompleteReq();
                }
                RPCHook.Calling = true;
                bool flag = false;
                bool flag2 = typeof(T).ToString() == "System.Single[]";
                if (flag2)
                {
                    flag = true;
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
                while (i < num)
                {
                    bool flag3 = parameters[i] is bool;
                    if (flag3)
                    {
                        parameters[i] = Convert.ToInt32(parameters[i]);
                    }
                    bool flag4 = parameters[i] is int;
                    if (flag4)
                    {
                        PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag5 = parameters[i] is uint;
                        if (flag5)
                        {
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                            num2 += 1u;
                        }
                        else
                        {
                            bool flag6 = parameters[i] is string;
                            if (flag6)
                            {
                                uint num6 = 268574720u + num3 * 1024u;
                                PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                                PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                                num2 += 1u;
                                num3 += 1u;
                            }
                            else
                            {
                                bool flag7 = parameters[i] is float;
                                if (flag7)
                                {
                                    bool flag8 = flag;
                                    if (flag8)
                                    {
                                        PS3.Extension.WriteFloat(268636160u + num4 * 4u, (float)parameters[i]);
                                    }
                                    RPCHook.IS_PLAYER_ONLINE.smethod_3(268566564u + num4 * 4u, (float)parameters[i]);
                                    num4 += 1u;
                                }
                                else
                                {
                                    bool flag9 = parameters[i] is float[];
                                    if (flag9)
                                    {
                                        float[] array = (float[])parameters[i];
                                        uint num7 = 268570624u + num5 * 4u;
                                        RPCHook.IS_PLAYER_ONLINE.smethod_4(num7, array);
                                        RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num7);
                                        num2 += 1u;
                                        num5 += (uint)array.Length;
                                    }
                                }
                            }
                        }
                    }
                    i++;
                }
                RPCHook.IS_PLAYER_ONLINE.PS3.Extension.WriteUInt32(268566604u, func_address);
                while (RPCHook.IS_PLAYER_ONLINE.PS3.Extension.ReadUInt32(268566604u) > 0u)
                {
                }
                Thread.Sleep(20);
                object obj = 0;
                bool flag10 = typeof(T).ToString() == "System.Int32";
                if (flag10)
                {
                    obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadInt32(268566608u), typeof(T)));
                }
                bool flag11 = typeof(T).ToString() == "System.UInt32";
                if (flag11)
                {
                    obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadUInt32(268566608u), typeof(T)));
                }
                bool flag12 = typeof(T).ToString() == "System.String";
                if (flag12)
                {
                    obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadString(268566608u), typeof(T)));
                }
                bool flag13 = typeof(T).ToString() == "System.Single";
                if (flag13)
                {
                    obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadFloat(268566608u), typeof(T)));
                }
                bool flag14 = typeof(T).ToString() == "System.Boolean";
                if (flag14)
                {
                    obj = (T)((object)Convert.ChangeType(PS3.Extension.ReadInt32(268566608u), typeof(T)));
                }
                bool flag15 = flag;
                if (flag15)
                {
                    byte[] bytes = PS3.GetBytes(268636160u, 12);
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
                RPCHook.Calling = false;
                return (T)((object)obj);
            }

            // Token: 0x060004AA RID: 1194 RVA: 0x000AF4E0 File Offset: 0x000AD6E0
            public static void Enable(uint is_player_online)
            {
                byte[] buffer = new byte[]
                {
                    248,
                    33,
                    253,
                    161,
                    124,
                    8,
                    2,
                    166,
                    248,
                    1,
                    2,
                    112,
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
                    2,
                    112,
                    124,
                    8,
                    3,
                    166,
                    56,
                    33,
                    2,
                    96,
                    56,
                    96,
                    0,
                    3,
                    78,
                    128,
                    0,
                    32
                };
                PS3.SetMemory(25617264u, new byte[]
                {
                    61,
                    96,
                    16,
                    5,
                    129,
                    107,
                    0,
                    0,
                    125,
                    105,
                    3,
                    166,
                    78,
                    128,
                    4,
                    32
                });
                PS3.SetMemory(RPCHook.IS_PLAYER_ONLINE.uint_0, buffer);
                PS3.Extension.WriteUInt32(268763136u, 25617296u);
                byte[] array = RPCHook.IS_PLAYER_ONLINE.smethod_0(is_player_online);
                PS3.SetMemory(is_player_online, new byte[]
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
                    0,
                    0,
                    0,
                    0
                });
                PS3.SetMemory(is_player_online + 24u, new byte[]
                {
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
                });
            }

            // Token: 0x060004AB RID: 1195 RVA: 0x000AF5B4 File Offset: 0x000AD7B4
            private static byte[] smethod_0(uint uint_1)
            {
                uint_1 += 12u;
                uint num = 25617264u - uint_1;
                byte[] array = new byte[4];
                byte[] array2 = new byte[4];
                array[3] = (byte)(num >> 24);
                array[2] = (byte)(num >> 16);
                array[1] = (byte)(num >> 8);
                array[0] = (byte)num;
                array2[3] = array[0];
                array2[2] = array[1];
                array2[1] = array[2];
                array2[0] = 73;
                return array2;
            }

            // Token: 0x060004AC RID: 1196 RVA: 0x000AF61C File Offset: 0x000AD81C
            public static bool IsEnable()
            {
                bool result = false;
                bool flag = PS3.GetBytes(25617264u, 4).SequenceEqual(new byte[]
                {
                    61,
                    96,
                    16,
                    5
                });
                if (flag)
                {
                    result = true;
                }
                return result;
            }

            // Token: 0x060004AD RID: 1197 RVA: 0x000AF660 File Offset: 0x000AD860
            private static float[] smethod_1(uint uint_1, int int_0)
            {
                byte[] array = PS3.Extension.ReadBytes(uint_1, int_0 * 4);
                RPCHook.IS_PLAYER_ONLINE.smethod_2(array);
                float[] array2 = new float[int_0];
                for (int i = 0; i < int_0; i++)
                {
                    array2[i] = BitConverter.ToSingle(array, (int_0 - 1 - i) * 4);
                }
                return array2;
            }

            // Token: 0x060004AE RID: 1198 RVA: 0x000AF6B8 File Offset: 0x000AD8B8
            private static byte[] smethod_2(byte[] byte_0)
            {
                Array.Reverse(byte_0);
                return byte_0;
            }

            // Token: 0x060004AF RID: 1199 RVA: 0x000AF6D4 File Offset: 0x000AD8D4
            private static void smethod_3(uint uint_1, float float_0)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(float_0).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS3.SetMemory(uint_1, array);
            }

            // Token: 0x060004B0 RID: 1200 RVA: 0x000AF710 File Offset: 0x000AD910
            private static void smethod_4(uint uint_1, float[] float_0)
            {
                int num = float_0.Length;
                byte[] array = new byte[num * 4];
                for (int i = 0; i < num; i++)
                {
                    RPCHook.IS_PLAYER_ONLINE.smethod_2(BitConverter.GetBytes(float_0[i])).CopyTo(array, i * 4);
                }
                PS3.SetMemory(uint_1, array);
            }

            // Token: 0x0400266A RID: 9834
            public static PS3API PS3 = new PS3API(SelectAPI.TargetManager);

            // Token: 0x0400266B RID: 9835
            private static uint uint_0 = 25617296u;
        }

        // Token: 0x02000045 RID: 69
        public class _GET_ACTIVE_NOTIFICATION_HANDLE
        {
            // Token: 0x060004B2 RID: 1202 RVA: 0x000AF760 File Offset: 0x000AD960
            public static void Enable(uint anyhook)
            {
                byte[] buffer = new byte[]
                {
                    49,
                    51,
                    51,
                    55,
                    32,
                    104,
                    97,
                    120,
                    48,
                    114,
                    32,
                    119,
                    97,
                    115,
                    32,
                    104,
                    101,
                    114,
                    101,
                    101,
                    101,
                    101,
                    101,
                    101,
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
                    68,
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
                    56,
                    96,
                    0,
                    1,
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
                PS3.SetMemory(29345408u, buffer);
                byte[] buffer2 = new byte[]
                {
                    61,
                    96,
                    1,
                    191,
                    97,
                    107,
                    198,
                    152,
                    125,
                    105,
                    3,
                    166,
                    78,
                    128,
                    4,
                    32
                };
                PS3.SetMemory(anyhook, buffer2);
            }
        }
    }
}

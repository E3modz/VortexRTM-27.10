using PS3Lib;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace E3Modz.GTA5
{
    // Token: 0x02000012 RID: 18
    public static class ClassicRPC
    {
        // Token: 0x0600032E RID: 814 RVA: 0x00083670 File Offset: 0x00081870
        public static void CompleteReq()
        {
            while (ClassicRPC.Calling)
            {
            }
        }

        // Token: 0x0600032F RID: 815 RVA: 0x0008368C File Offset: 0x0008188C
        public static uint CBAB(uint F, uint T)
        {
            bool flag = F > T;
            uint result;
            if (flag)
            {
                result = 1275068416u - (F - T);
            }
            else
            {
                bool flag2 = F < T;
                if (flag2)
                {
                    result = T - F + 1207959552u;
                }
                else
                {
                    result = 1207959552u;
                }
            }
            return result;
        }

        // Token: 0x06000330 RID: 816 RVA: 0x000836CC File Offset: 0x000818CC
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
            PS3.SetMemory(ClassicRPC.SFA1, buffer);
            PS3.Extension.WriteUInt32(ClassicRPC.EFA1, ClassicRPC.CBAB(ClassicRPC.EFA1, ClassicRPC.BAB1));
            PS3.Extension.WriteUInt32(ClassicRPC.BFA1, ClassicRPC.CBAB(ClassicRPC.BFA1, ClassicRPC.SFA1));
        }

        // Token: 0x06000331 RID: 817 RVA: 0x0008374C File Offset: 0x0008194C
        public static int Call(uint func_address, params object[] parameters)
        {
            bool calling = ClassicRPC.Calling;
            if (calling)
            {
                ClassicRPC.CompleteReq();
            }
            ClassicRPC.Calling = true;
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
                    PS3.Extension.WriteInt32(268697600u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag2 = parameters[i] is uint;
                    if (flag2)
                    {
                        PS3.Extension.WriteUInt32(268697600u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag3 = parameters[i] is string;
                        if (flag3)
                        {
                            uint num6 = 268705792u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag4 = parameters[i] is float;
                            if (flag4)
                            {
                                ClassicRPC.WriteSingle(268697636u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag5 = parameters[i] is float[];
                                if (flag5)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num6 = 268701696u + num5 * 4u;
                                    ClassicRPC.WriteSingle(num6, array);
                                    PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num6);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268697676u, func_address);
            ClassicRPC.Calling = false;
            while (PS3.Extension.ReadUInt32(268697676u) > 0u)
            {
            }
            return PS3.Extension.ReadInt32(268697680u);
        }

        // Token: 0x06000332 RID: 818 RVA: 0x00083968 File Offset: 0x00081B68
        public static int CallwHash<T>(T address, params object[] parameters)
        {
            object obj = 0;
            bool flag = typeof(T) == typeof(string);
            if (flag)
            {
                obj = ClassicRPC.FindAddress((string)((object)address));
            }
            else
            {
                obj = Convert.ChangeType(address, TypeCode.UInt32);
            }
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            while (i < num)
            {
                bool flag2 = parameters[i] is int;
                if (flag2)
                {
                    PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag3 = parameters[i] is bool;
                    if (flag3)
                    {
                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, Convert.ToUInt32(parameters[i]));
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag4 = parameters[i] is uint;
                        if (flag4)
                        {
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                            num2 += 1u;
                        }
                        else
                        {
                            bool flag5 = parameters[i] is string;
                            if (flag5)
                            {
                                uint num6 = 268574720u + num3 * 1024u;
                                PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                                PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                                num2 += 1u;
                                num3 += 1u;
                            }
                            else
                            {
                                bool flag6 = parameters[i] is float;
                                if (flag6)
                                {
                                    ClassicRPC.WriteSingle(268566564u + num4 * 4u, (float)parameters[i]);
                                    num4 += 1u;
                                }
                                else
                                {
                                    bool flag7 = parameters[i] is float[];
                                    if (flag7)
                                    {
                                        float[] array = (float[])parameters[i];
                                        uint num6 = 268570624u + num5 * 4u;
                                        ClassicRPC.WriteSingle(num6, array);
                                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                                        num2 += 1u;
                                        num5 += (uint)array.Length;
                                    }
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268566604u, (uint)obj);
            int num7 = 0;
            while (PS3.Extension.ReadUInt32(268566604u) > 0u)
            {
                Thread.Sleep(10);
                num7++;
                bool flag8 = num7 == 60;
                if (flag8)
                {
                    break;
                }
                Application.DoEvents();
            }
            return PS3.Extension.ReadInt32(268566608u);
        }

        // Token: 0x06000333 RID: 819 RVA: 0x00083C14 File Offset: 0x00081E14
        private static uint FindAddress(string NativeString)
        {
            object obj = 0;
            bool flag = NativeString.ToString().Any((char c) => char.IsDigit(c));
            if (flag)
            {
                obj = Convert.ToUInt32(NativeString.ToString(), 16);
            }
            else
            {
                obj = Functions.RPCFunc.STRINGHASH((string)NativeString);
            }
            short[] array = new short[]
            {
                19173,
                19172,
                19179,
                19177,
                19174,
                19112,
                19178,
                19176,
                19171,
                19169,
                19170,
                19175,
                19129,
                19128,
                19127,
                19126,
                19125,
                19124,
                19123,
                19122,
                19121
            };
            uint num = (uint)obj & 255u;
            for (uint num2 = PS3.Extension.ReadUInt32(31915832u + num * 4u); num2 > 0u; num2 = ClassicRPC.PS3.Extension.ReadUInt32(num2))
            {
                int num3 = PS3.Extension.ReadInt32(num2 + 32u);
                uint num4 = 0u;
                while ((ulong)num4 < (ulong)((long)num3))
                {
                    bool flag2 = PS3.Extension.ReadUInt32(num2 + 36u + num4 * 4u) == (uint)obj;
                    if (flag2)
                    {
                        uint num5 = PS3.Extension.ReadUInt32(ClassicRPC.PS3.Extension.ReadUInt32(num2 + 4u + num4 * 4u));
                        for (uint num6 = 0u; num6 < 100u; num6 += 1u)
                        {
                            short num7 = PS3.Extension.ReadInt16(num5 + num6 * 4u);
                            for (int i = 0; i < array.Length; i++)
                            {
                                bool flag3 = array[i] == num7;
                                if (flag3)
                                {
                                    byte[] bytes = PS3.GetBytes(num5 + num6 * 4u, 4);
                                    Array.Reverse(bytes);
                                    return BitConverter.ToUInt32(bytes, 0) - 1207959553u + num5 + num6 * 4u - 67108864u;
                                }
                            }
                        }
                    }
                    num4 += 1u;
                }
            }
            return 255u;
        }

        // Token: 0x06000334 RID: 820 RVA: 0x00083E14 File Offset: 0x00082014
        public static int HookCall(uint uint_2, params object[] object_0)
        {
            bool calling = ClassicRPC.Calling;
            if (calling)
            {
                ClassicRPC.CompleteReq();
            }
            ClassicRPC.Calling = true;
            int num = object_0.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            while (i < num)
            {
                bool flag = object_0[i] is int;
                if (flag)
                {
                    PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)object_0[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag2 = object_0[i] is uint;
                    if (flag2)
                    {
                        PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)object_0[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag3 = object_0[i] is string;
                        if (flag3)
                        {
                            uint num6 = 268574720u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(object_0[i]));
                            PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag4 = object_0[i] is float;
                            if (flag4)
                            {
                                ClassicRPC.smethod_5(268566564u + num4 * 4u, (float)object_0[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag5 = object_0[i] is float[];
                                if (flag5)
                                {
                                    float[] array = (float[])object_0[i];
                                    uint num6 = 268570624u + num5 * 4u;
                                    ClassicRPC.smethod_6(num6, array);
                                    PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num6);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268566604u, uint_2);
            while (PS3.Extension.ReadUInt32(268566604u) > 0u)
            {
            }
            Thread.Sleep(8);
            ClassicRPC.Calling = false;
            return PS3.Extension.ReadInt32(268566608u);
        }

        // Token: 0x06000335 RID: 821 RVA: 0x00084030 File Offset: 0x00082230
        public static int NCall(NewNatives func_address, params object[] parameters)
        {
            bool calling = ClassicRPC.Calling;
            if (calling)
            {
                ClassicRPC.CompleteReq();
            }
            ClassicRPC.Calling = true;
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
                    PS3.Extension.WriteInt32(268697600u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag2 = parameters[i] is uint;
                    if (flag2)
                    {
                        PS3.Extension.WriteUInt32(268697600u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag3 = parameters[i] is string;
                        if (flag3)
                        {
                            uint num6 = 268705792u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag4 = parameters[i] is float;
                            if (flag4)
                            {
                                ClassicRPC.WriteSingle(268697636u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag5 = parameters[i] is float[];
                                if (flag5)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num6 = 268701696u + num5 * 4u;
                                    ClassicRPC.WriteSingle(num6, array);
                                    PS3.Extension.WriteUInt32(268697600u + num2 * 4u, num6);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268697676u, (uint)func_address);
            ClassicRPC.Calling = false;
            while (PS3.Extension.ReadUInt32(268697676u) > 0u)
            {
            }
            return PS3.Extension.ReadInt32(268697680u);
        }

        // Token: 0x06000336 RID: 822 RVA: 0x0008424C File Offset: 0x0008244C
        private static byte[] smethod_4(byte[] byte_0)
        {
            Array.Reverse(byte_0);
            return byte_0;
        }

        // Token: 0x06000337 RID: 823 RVA: 0x00084268 File Offset: 0x00082468
        private static void smethod_5(uint uint_2, float float_0)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(float_0).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            PS3.SetMemory(uint_2, array);
        }

        // Token: 0x06000338 RID: 824 RVA: 0x000842A4 File Offset: 0x000824A4
        private static void smethod_6(uint uint_2, float[] float_0)
        {
            int num = float_0.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                ClassicRPC.smethod_4(BitConverter.GetBytes(float_0[i])).CopyTo(array, i * 4);
            }
            PS3.SetMemory(uint_2, array);
        }

        // Token: 0x06000339 RID: 825 RVA: 0x000842F8 File Offset: 0x000824F8
        private static void WriteSingle(uint address, float input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            PS3.SetMemory(address, array);
        }

        // Token: 0x0600033A RID: 826 RVA: 0x00084334 File Offset: 0x00082534
        private static void WriteSingle(uint address, float[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                ClassicRPC.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            PS3.SetMemory(address, array);
        }

        // Token: 0x0600033B RID: 827 RVA: 0x00084384 File Offset: 0x00082584
        private static byte[] ReverseBytes(byte[] toReverse)
        {
            Array.Reverse(toReverse);
            return toReverse;
        }

        // Token: 0x04000F7F RID: 3967
        public static uint SFA1 = 29248640u;

        // Token: 0x04000F80 RID: 3968
        public static uint EFA1 = 29248776u;

        // Token: 0x04000F81 RID: 3969
        public static uint BFA1 = 99860u;

        // Token: 0x04000F82 RID: 3970
        public static uint BAB1 = 99872u;

        // Token: 0x04000F83 RID: 3971
        public static PS3API PS3 = GTA5Main.PS3;

        // Token: 0x04000F84 RID: 3972
        private static bool Calling = false;
    }
}

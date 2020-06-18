using System;
using System.Threading;

namespace E3Modz.MW3
{
    internal class MW3RPC
    {
        private static uint func_address = 2585096;

        public static int Call(uint address, params object[] parameters)
        {
            int length = parameters.Length;
            int index = 0;
            uint num1 = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = 0;
            for (; index < length; ++index)
            {
                if (parameters[index] is int)
                {
                    PS5.Extension.WriteInt32((uint)(268763136 + (int)num1 * 4), (int)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is uint)
                {
                    PS5.Extension.WriteUInt32((uint)(268763136 + (int)num1 * 4), (uint)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is short)
                {
                    PS5.Extension.WriteInt16((uint)(268763136 + (int)num1 * 4), (short)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is ushort)
                {
                    PS5.Extension.WriteInt32((uint)(268763136 + (int)num1 * 4), (ushort)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is byte)
                {
                    PS5.Extension.WriteByte((uint)(268763136 + (int)num1 * 4), (byte)parameters[index]);
                    ++num1;
                }
                else if (parameters[index] is string)
                {
                    uint num5 = (uint)(268771328 + (int)num2 * 1024);
                    PS5.Extension.WriteString(num5, Convert.ToString(parameters[index]));
                    PS5.Extension.WriteUInt32((uint)(268763136 + (int)num1 * 4), num5);
                    ++num1;
                    ++num2;
                }
                else if (parameters[index] is float)
                {
                    PS5.Extension.WriteFloat((uint)(268763172 + (int)num3 * 4), (float)parameters[index]);
                    ++num3;
                }
                else if (parameters[index] is float[])
                {
                    float[] Array = (float[])parameters[index];
                    uint num5 = (uint)(268767232 + (int)num4 * 4);
                    PS5.Extension.WriteFloatArray(num5, Array);
                    PS5.Extension.WriteUInt32((uint)(268763136 + (int)num1 * 4), num5);
                    ++num1;
                    num4 += (uint)Array.Length;
                }
            }
            PS5.Extension.WriteUInt32(268763208U, address);
            Thread.Sleep(20);
            return PS5.Extension.ReadInt32(268763212U);
        }

        public static void Enable()
        {
            if ((int)PS5.Extension.ReadByte(MW3RPC.func_address + 4U) == 63)
                return;
            byte[] bytes = new byte[116]
            {
        (byte) 63,
        (byte) 128,
        (byte) 16,
        (byte) 5,
        (byte) 129,
        (byte) 156,
        (byte) 0,
        (byte) 72,
        (byte) 44,
        (byte) 12,
        (byte) 0,
        (byte) 0,
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 120,
        (byte) 128,
        (byte) 124,
        (byte) 0,
        (byte) 0,
        (byte) 128,
        (byte) 156,
        (byte) 0,
        (byte) 4,
        (byte) 128,
        (byte) 188,
        (byte) 0,
        (byte) 8,
        (byte) 128,
        (byte) 220,
        (byte) 0,
        (byte) 12,
        (byte) 128,
        (byte) 252,
        (byte) 0,
        (byte) 16,
        (byte) 129,
        (byte) 28,
        (byte) 0,
        (byte) 20,
        (byte) 129,
        (byte) 60,
        (byte) 0,
        (byte) 24,
        (byte) 129,
        (byte) 92,
        (byte) 0,
        (byte) 28,
        (byte) 129,
        (byte) 124,
        (byte) 0,
        (byte) 32,
        (byte) 192,
        (byte) 60,
        (byte) 0,
        (byte) 36,
        (byte) 192,
        (byte) 92,
        (byte) 0,
        (byte) 40,
        (byte) 192,
        (byte) 124,
        (byte) 0,
        (byte) 44,
        (byte) 192,
        (byte) 156,
        (byte) 0,
        (byte) 48,
        (byte) 192,
        (byte) 188,
        (byte) 0,
        (byte) 52,
        (byte) 192,
        (byte) 220,
        (byte) 0,
        (byte) 56,
        (byte) 192,
        (byte) 252,
        (byte) 0,
        (byte) 60,
        (byte) 193,
        (byte) 28,
        (byte) 0,
        (byte) 64,
        (byte) 193,
        (byte) 60,
        (byte) 0,
        (byte) 68,
        (byte) 125,
        (byte) 137,
        (byte) 3,
        (byte) 166,
        (byte) 78,
        (byte) 128,
        (byte) 4,
        (byte) 33,
        (byte) 56,
        (byte) 128,
        (byte) 0,
        (byte) 0,
        (byte) 144,
        (byte) 156,
        (byte) 0,
        (byte) 72,
        (byte) 144,
        (byte) 124,
        (byte) 0,
        (byte) 76,
        (byte) 208,
        (byte) 60,
        (byte) 0,
        (byte) 80,
        (byte) 72,
        (byte) 0,
        (byte) 0,
        (byte) 20
            };
            PS5.SetMemory(MW3RPC.func_address, new byte[1] { (byte)65 });
            PS5.SetMemory(MW3RPC.func_address + 4U, bytes);
            PS5.SetMemory(MW3RPC.func_address, new byte[1] { (byte)64 });
        }
    }
}

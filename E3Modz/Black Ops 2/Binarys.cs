using System.Text.RegularExpressions;

internal static class Binary
{
    private static char ToChar(byte value)
    {
        int num = 0;
        if ((int)value >= 0 && (int)value <= 9)
            num = (int)value + 48;
        else if ((int)value >= 10 && (int)value <= 15)
            num = (int)value + 65 - 10;
        return (char)num;
    }

    private static byte ToByte(char value)
    {
        int num = 0;
        if ((int)value >= 48 && (int)value <= 57)
            num = (int)value - 48;
        else if ((int)value >= 65 && (int)value <= 70)
            num = (int)value - 65 + 10;
        else if ((int)value >= 97 && (int)value <= 102)
            num = (int)value - 97 + 10;
        return (byte)num;
    }

    public static string ToString(byte[] value)
    {
        if (value == null || value.Length == 0)
            return (string)null;
        string str = "";
        for (int index = 0; index < value.Length; ++index)
            str += new string(new char[2]
            {
        Binary.ToChar((byte) ((uint) value[index] >> 4)),
        Binary.ToChar((byte) ((uint) value[index] & 15U))
            });
        return str;
    }

    public static byte[] ToBytes(string value)
    {
        if (value != null && value.Length != 0)
        {
            value = (value.Length % 2 == 1 ? "0" : "") + value;
            if (Regex.IsMatch(value, "^[a-fA-F0-9]+$"))
            {
                byte[] numArray = new byte[value.Length / 2];
                int index1 = 0;
                int index2 = 0;
                while (index1 < value.Length)
                {
                    numArray[index2] = (byte)(((uint)Binary.ToByte(value[index1]) << 4) + (uint)Binary.ToByte(value[index1 + 1]));
                    index1 += 2;
                    ++index2;
                }
                return numArray;
            }
        }
        return (byte[])null;
    }

    public static unsafe byte* Reverse(byte* value, int size)
    {
        fixed (byte* numPtr = new byte[size])
        {
            int num1 = 0;
            int num2 = size;
            while (num1 < size)
                numPtr[num1++] = value[--num2];
            return numPtr;
        }
    }

    public static unsafe short Reverse(short value)
    {
        return *(short*)Binary.Reverse((byte*)&value, 2);
    }

    public static unsafe int Reverse(int value)
    {
        return *(int*)Binary.Reverse((byte*)&value, 4);
    }

    public static unsafe long Reverse(long value)
    {
        return *(long*)Binary.Reverse((byte*)&value, 8);
    }

    public static unsafe ushort Reverse(ushort value)
    {
        return *(ushort*)Binary.Reverse((byte*)&value, 2);
    }

    public static unsafe uint Reverse(uint value)
    {
        return *(uint*)Binary.Reverse((byte*)&value, 4);
    }

    public static unsafe ulong Reverse(ulong value)
    {
        return (ulong)*(long*)Binary.Reverse((byte*)&value, 8);
    }

    public static unsafe float Reverse(float value)
    {
        return *(float*)Binary.Reverse((byte*)&value, 4);
    }

    public static unsafe double Reverse(double value)
    {
        return *(double*)Binary.Reverse((byte*)&value, 8);
    }

    public static unsafe short GetInt16(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        short num;
        fixed (byte* numPtr = source)
            num = *(short*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe int GetInt32(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        int num;
        fixed (byte* numPtr = source)
            num = *(int*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe long GetInt64(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        long num;
        fixed (byte* numPtr = source)
            num = *(long*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe ushort GetUInt16(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        ushort num;
        fixed (byte* numPtr = source)
            num = *(ushort*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe uint GetUInt32(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        uint num;
        fixed (byte* numPtr = source)
            num = *(uint*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe ulong GetUInt64(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        ulong num;
        fixed (byte* numPtr = source)
            num = (ulong)*(long*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe float GetFloat(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        float num;
        fixed (byte* numPtr = source)
            num = *(float*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe double GetDouble(byte[] source, int index = 0, bool IsBigEndian = true)
    {
        double num;
        fixed (byte* numPtr = source)
            num = *(double*)(numPtr + index);
        if (!IsBigEndian)
            return num;
        return Binary.Reverse(num);
    }

    public static unsafe byte[] SetInt16(byte[] source, short value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(short*)(numPtr + index) = IsBigEndian ? Binary.Reverse(value) : value;
        return source;
    }

    public static unsafe byte[] SetInt32(byte[] source, int value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(int*)(numPtr + index) = IsBigEndian ? Binary.Reverse(value) : value;
        return source;
    }

    public static unsafe byte[] SetInt64(byte[] source, long value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(long*)(numPtr + index) = IsBigEndian ? Binary.Reverse(value) : value;
        return source;
    }

    public static unsafe byte[] SetUInt16(byte[] source, ushort value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(short*)(numPtr + index) = IsBigEndian ? (short)Binary.Reverse(value) : (short)value;
        return source;
    }

    public static unsafe byte[] SetUInt32(byte[] source, uint value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(int*)(numPtr + index) = IsBigEndian ? (int)Binary.Reverse(value) : (int)value;
        return source;
    }

    public static unsafe byte[] SetUInt64(byte[] source, ulong value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(long*)(numPtr + index) = IsBigEndian ? (long)Binary.Reverse(value) : (long)value;
        return source;
    }

    public static unsafe byte[] SetFloat(byte[] source, float value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(float*)(numPtr + index) = IsBigEndian ? Binary.Reverse(value) : value;
        return source;
    }

    public static unsafe byte[] SetDouble(byte[] source, double value, int index = 0, bool IsBigEndian = true)
    {
        fixed (byte* numPtr = source)
            *(double*)(numPtr + index) = IsBigEndian ? Binary.Reverse(value) : value;
        return source;
    }
}

using E3Modz;
using PS3Lib;
using System;
using System.Text;
using System.Threading;

// Token: 0x02000056 RID: 86
internal class Class10
{
    // Token: 0x0600030F RID: 783 RVA: 0x0000485B File Offset: 0x00002A5B
    public static int smethod_0()
    {
        if (Class10.uint_0 == 0u)
        {
            return -1;
        }
        Class10.smethod_1();
        return 0;
    }

    // Token: 0x06000310 RID: 784 RVA: 0x0001B7DC File Offset: 0x000199DC
    public static void smethod_1()
    {
        Class10.ps3API_0.SetMemory(Class10.uint_0, new byte[]
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
        Class10.ps3API_0.SetMemory(Class10.uint_0 + 4u, buffer);
        Class10.ps3API_0.SetMemory(268763136u, new byte[10324]);
        Class10.ps3API_0.SetMemory(Class10.uint_0, new byte[]
        {
            248,
            33,
            byte.MaxValue,
            145
        });
    }

    // Token: 0x06000311 RID: 785 RVA: 0x0001B874 File Offset: 0x00019A74
    public static int smethod_2(uint uint_1, params object[] parameters)
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
                Class10.ps3API_0.SetMemory(268763136u + (num3 + num2) * 4u, bytes);
            }
            else if (parameters[(int)num3] is uint)
            {
                byte[] bytes2 = BitConverter.GetBytes((uint)parameters[(int)num3]);
                Array.Reverse(bytes2);
                Class10.ps3API_0.SetMemory(268763136u + (num3 + num2) * 4u, bytes2);
            }
            else if (parameters[(int)num3] is string)
            {
                byte[] bytes3 = Encoding.UTF8.GetBytes(Convert.ToString(parameters[(int)num3]) + "\0");
                Class10.ps3API_0.SetMemory(268763220u + num3 * 1024u, bytes3);
                byte[] bytes4 = BitConverter.GetBytes(268763220u + num3 * 1024u);
                Array.Reverse(bytes4);
                Class10.ps3API_0.SetMemory(268763136u + (num3 + num2) * 4u, bytes4);
            }
            else if (parameters[(int)num3] is float)
            {
                num2 += 1u;
                byte[] bytes5 = BitConverter.GetBytes((float)parameters[(int)num3]);
                Array.Reverse(bytes5);
                Class10.ps3API_0.SetMemory(268763172u + (num2 - 1u) * 4u, bytes5);
            }
            num3 += 1u;
        }
        byte[] bytes6 = BitConverter.GetBytes(uint_1);
        Array.Reverse(bytes6);
        Class10.ps3API_0.SetMemory(268763212u, bytes6);
        Thread.Sleep(20);
        byte[] array = Class10.ps3API_0.Extension.ReadBytes(268763216u, 4);
        Array.Reverse(array);
        return BitConverter.ToInt32(array, 0);
    }

    // Token: 0x06000312 RID: 786 RVA: 0x0000486C File Offset: 0x00002A6C
    public static void smethod_3(int int_0, object object_0)
    {
        Class10.smethod_2(6210884u, new object[]
        {
            int_0,
            1,
            object_0
        });
    }

    // Token: 0x06000313 RID: 787 RVA: 0x00004895 File Offset: 0x00002A95
    public static void smethod_4(int int_0, object object_0)
    {
        Class10.smethod_2(6232708u, new object[]
        {
            int_0,
            1,
            object_0
        });
    }

    // Token: 0x06000314 RID: 788 RVA: 0x000048BE File Offset: 0x00002ABE
    public static void smethod_5(object object_0)
    {
        Class10.smethod_2(5970556u, new object[]
        {
            0,
            object_0
        });
    }

    // Token: 0x06000315 RID: 789 RVA: 0x000048DE File Offset: 0x00002ADE
    public static void smethod_6(int int_0, string string_0)
    {
        Class10.smethod_3(int_0, "O \"" + string_0 + "\"");
    }

    // Token: 0x06000316 RID: 790 RVA: 0x000048F6 File Offset: 0x00002AF6
    public static void smethod_7(int int_0, string string_0)
    {
        Class10.smethod_3(int_0, "< \"" + string_0 + "\"");
    }

    // Token: 0x06000317 RID: 791 RVA: 0x000026FA File Offset: 0x000008FA


    // Token: 0x06000318 RID: 792 RVA: 0x0000490E File Offset: 0x00002B0E
    static Class10()
    {
        Class10.ps3API_0 = Main.PS3;
        Class10.uint_0 = 4000552u;
    }

    // Token: 0x0400023F RID: 575
    public static PS3API ps3API_0;

    // Token: 0x04000240 RID: 576
    public static uint uint_0;
}

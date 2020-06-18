using PS3Lib;
using System;
using System.Linq;
using System.Text;

// Token: 0x02000042 RID: 66
internal class PS6
{
    // Token: 0x060001ED RID: 493 RVA: 0x0004250C File Offset: 0x0004070C
    public static bool Attach()
    {
        bool result;
        if (PS6.DCC == "DEX")
        {
            result = DEX.Attach();
        }
        else
        {
            result = (PS6.CEX.AttachProcess() > -1);
        }
        return result;
    }

    // Token: 0x060001EE RID: 494 RVA: 0x0004254A File Offset: 0x0004074A
    public static void Check(string Value)
    {
        PS6.DCC = Value;
    }

    // Token: 0x060001EF RID: 495 RVA: 0x00042554 File Offset: 0x00040754
    public static bool Connect(string IP)
    {
        bool result;
        if (PS6.DCC == "DEX")
        {
            result = DEX.Connect();
        }
        else
        {
            result = (PS6.CEX.ConnectTarget(IP) > -1);
        }
        return result;
    }

    // Token: 0x060001F0 RID: 496 RVA: 0x00042594 File Offset: 0x00040794
    public static bool Disconnect()
    {
        bool result;
        if (PS6.DCC == "DEX")
        {
            result = DEX.Disconnect();
        }
        else
        {
            result = (PS6.CEX.DisconnectTarget() > -1);
        }
        return result;
    }

    // Token: 0x060001F1 RID: 497 RVA: 0x000425D4 File Offset: 0x000407D4
    public static byte[] CCGetMemory(uint offset, uint length)
    {
        byte[] array = new byte[length];
        PS6.CEX.GetMemory(offset, array);
        return array;
    }

    // Token: 0x060001F2 RID: 498 RVA: 0x000425FC File Offset: 0x000407FC
    public static byte[] GetMemory(uint offset, uint length)
    {
        byte[] result;
        if (PS6.DCC == "DEX")
        {
            result = DEX.GetMemory(offset, length);
        }
        else
        {
            result = PS6.CCGetMemory(offset, length);
        }
        return result;
    }

    // Token: 0x060001F3 RID: 499 RVA: 0x00042638 File Offset: 0x00040838
    public static void SetMemory(uint offset, byte[] buffer)
    {
        if (PS6.DCC == "DEX")
        {
            DEX.SetMemory(offset, buffer);
        }
        else
        {
            PS6.CEX.SetMemory(offset, buffer);
        }
    }

    // Token: 0x0400059C RID: 1436
    private static CCAPI CEX = new CCAPI();

    // Token: 0x0400059D RID: 1437
    private static string DCC;

    // Token: 0x02000043 RID: 67
    public class Func
    {
        // Token: 0x060001F6 RID: 502 RVA: 0x0004268C File Offset: 0x0004088C
        public static byte GetByte(uint offset)
        {
            return PS6.GetMemory(offset, 1u)[0];
        }

        // Token: 0x060001F7 RID: 503 RVA: 0x000426A8 File Offset: 0x000408A8
        public static string GetString(uint offset, uint length)
        {
            return Encoding.ASCII.GetString(PS6.GetMemory(offset, length));
        }

        // Token: 0x060001F8 RID: 504 RVA: 0x000426CC File Offset: 0x000408CC
        public static ushort GetUInt16(uint offset, bool Reverse = false)
        {
            ushort result;
            if (!Reverse)
            {
                result = BitConverter.ToUInt16(PS6.GetMemory(offset, 2u).Reverse<byte>().ToArray<byte>(), 0);
            }
            else
            {
                result = BitConverter.ToUInt16(PS6.GetMemory(offset, 2u), 0);
            }
            return result;
        }

        // Token: 0x060001F9 RID: 505 RVA: 0x0004270C File Offset: 0x0004090C
        public static uint GetUInt32(uint offset, bool Reverse = false)
        {
            uint result;
            if (!Reverse)
            {
                result = BitConverter.ToUInt32(PS6.GetMemory(offset, 4u).Reverse<byte>().ToArray<byte>(), 0);
            }
            else
            {
                result = BitConverter.ToUInt32(PS6.GetMemory(offset, 4u), 0);
            }
            return result;
        }

        // Token: 0x060001FA RID: 506 RVA: 0x0004274C File Offset: 0x0004094C
        public static ulong GetUInt64(uint offset, bool Reverse = false)
        {
            ulong result;
            if (!Reverse)
            {
                result = BitConverter.ToUInt64(PS6.GetMemory(offset, 8u).Reverse<byte>().ToArray<byte>(), 0);
            }
            else
            {
                result = BitConverter.ToUInt64(PS6.GetMemory(offset, 8u), 0);
            }
            return result;
        }

        // Token: 0x060001FB RID: 507 RVA: 0x0004278C File Offset: 0x0004098C
        public static void SetByte(uint offset, byte Value)
        {
            PS6.SetMemory(offset, new byte[]
            {
                Value
            });
        }

        // Token: 0x060001FC RID: 508 RVA: 0x000427B0 File Offset: 0x000409B0
        public static void SetString(uint offset, string text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS6.SetMemory(offset, bytes);
        }

        // Token: 0x060001FD RID: 509 RVA: 0x000427E0 File Offset: 0x000409E0
        public static void SetUInt16(uint offset, ushort Value, bool Reverse = false)
        {
            if (!Reverse)
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value).Reverse<byte>().ToArray<byte>());
            }
            else
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value));
            }
        }

        // Token: 0x060001FE RID: 510 RVA: 0x00042820 File Offset: 0x00040A20
        public static void SetUInt32(uint offset, uint Value, bool Reverse = false)
        {
            if (!Reverse)
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value).Reverse<byte>().ToArray<byte>());
            }
            else
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value));
            }
        }

        // Token: 0x060001FF RID: 511 RVA: 0x00042860 File Offset: 0x00040A60
        public static void SetUInt64(uint offset, ulong Value, bool Reverse = false)
        {
            if (!Reverse)
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value).Reverse<byte>().ToArray<byte>());
            }
            else
            {
                PS6.SetMemory(offset, BitConverter.GetBytes(Value));
            }
        }
    }
}

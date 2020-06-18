using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000026 RID: 38
internal class DEX
{
    // Token: 0x060000B9 RID: 185 RVA: 0x00004024 File Offset: 0x00002224
    public static bool Attach()
    {
        bool result;
        try
        {
            DEX.TMAPI.GetProcessList(0, out DEX.Prs.processIDs);
            ulong num = (ulong)DEX.Prs.processIDs[0];
            DEX.Prs.ProcessID = (uint)num;
            DEX.TMAPI.ProcessAttach(0, DEX.TMAPI.UnitType.PPU, DEX.Prs.ProcessID);
            DEX.TMAPI.ProcessContinue(0, DEX.Prs.ProcessID);
            result = true;
        }
        catch
        {
            result = false;
        }
        return result;
    }

    // Token: 0x060000BA RID: 186 RVA: 0x00004084 File Offset: 0x00002284
    public static bool Connect()
    {
        bool result;
        try
        {
            DEX.TMAPI.InitTargetComms();
            DEX.TMAPI.Connect(0, null);
            result = true;
        }
        catch
        {
            result = false;
        }
        return result;
    }

    // Token: 0x060000BB RID: 187 RVA: 0x000040C0 File Offset: 0x000022C0
    public static bool Disconnect()
    {
        bool result;
        try
        {
            DEX.TMAPI.Disconnect(0);
            result = true;
        }
        catch
        {
            result = false;
        }
        return result;
    }

    // Token: 0x060000BC RID: 188 RVA: 0x000040F4 File Offset: 0x000022F4
    public static byte[] GetMemory(uint offset, uint length)
    {
        byte[] result = new byte[length];
        DEX.TMAPI.ProcessGetMemory(0, DEX.TMAPI.UnitType.PPU, DEX.Prs.ProcessID, 0UL, (ulong)offset, ref result);
        return result;
    }

    // Token: 0x060000BD RID: 189 RVA: 0x00004122 File Offset: 0x00002322
    public static void SetMemory(uint offset, byte[] buffer)
    {
        DEX.TMAPI.ProcessSetMemory(0, DEX.TMAPI.UnitType.PPU, DEX.Prs.ProcessID, 0UL, (ulong)offset, buffer);
    }

    // Token: 0x02000027 RID: 39
    private class Prs
    {
        // Token: 0x0400005E RID: 94
        public static string ConsoleName;

        // Token: 0x0400005F RID: 95
        public static string Info;

        // Token: 0x04000060 RID: 96
        public static string MemStatus;

        // Token: 0x04000061 RID: 97
        public static uint ProcessID;

        // Token: 0x04000062 RID: 98
        public static uint[] processIDs;

        // Token: 0x04000063 RID: 99
        public static string snresult;

        // Token: 0x04000064 RID: 100
        public static string Status;

        // Token: 0x04000065 RID: 101
        public static string usage;
    }

    // Token: 0x02000028 RID: 40
    public static class TMAPI
    {
        // Token: 0x060000C0 RID: 192 RVA: 0x00004148 File Offset: 0x00002348
        private static IntPtr AllocUtf8FromString(string wcharString)
        {
            IntPtr result;
            if (wcharString == null)
            {
                result = IntPtr.Zero;
            }
            else
            {
                byte[] bytes = Encoding.UTF8.GetBytes(wcharString);
                IntPtr intPtr = Marshal.AllocHGlobal(bytes.Length + 1);
                Marshal.Copy(bytes, 0, intPtr, bytes.Length);
                Marshal.WriteByte((IntPtr)(intPtr.ToInt64() + (long)bytes.Length), 0);
                result = intPtr;
            }
            return result;
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x000041AC File Offset: 0x000023AC
        public static DEX.TMAPI.SNRESULT Connect(int target, string application)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ConnectX64(target, application);
            }
            else
            {
                result = DEX.TMAPI.ConnectX86(target, application);
            }
            return result;
        }

        // Token: 0x060000C2 RID: 194
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Connect")]
        private static extern DEX.TMAPI.SNRESULT ConnectX64(int target, string application);

        // Token: 0x060000C3 RID: 195
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Connect")]
        private static extern DEX.TMAPI.SNRESULT ConnectX86(int target, string application);

        // Token: 0x060000C4 RID: 196 RVA: 0x000041DC File Offset: 0x000023DC
        public static DEX.TMAPI.SNRESULT Disconnect(int target)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.DisconnectX64(target);
            }
            else
            {
                result = DEX.TMAPI.DisconnectX86(target);
            }
            return result;
        }

        // Token: 0x060000C5 RID: 197
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Disconnect")]
        private static extern DEX.TMAPI.SNRESULT DisconnectX64(int target);

        // Token: 0x060000C6 RID: 198
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Disconnect")]
        private static extern DEX.TMAPI.SNRESULT DisconnectX86(int target);

        // Token: 0x060000C7 RID: 199 RVA: 0x00004208 File Offset: 0x00002408
        public static bool FAILED(DEX.TMAPI.SNRESULT res)
        {
            return !DEX.TMAPI.SUCCEEDED(res);
        }

        // Token: 0x060000C8 RID: 200 RVA: 0x00004224 File Offset: 0x00002424
        public static DEX.TMAPI.SNRESULT GetConnectionInfo(int target, out DEX.TMAPI.TCPIPConnectProperties connectProperties)
        {
            connectProperties = null;
            DEX.TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new DEX.TMAPI.ScopedGlobalHeapPtr(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DEX.TMAPI.TCPIPConnectProperties))));
            DEX.TMAPI.SNRESULT snresult = DEX.TMAPI.Is32Bit() ? DEX.TMAPI.GetConnectionInfoX86(target, scopedGlobalHeapPtr.Get()) : DEX.TMAPI.GetConnectionInfoX64(target, scopedGlobalHeapPtr.Get());
            if (DEX.TMAPI.SUCCEEDED(snresult))
            {
                connectProperties = new DEX.TMAPI.TCPIPConnectProperties();
                Marshal.PtrToStructure(scopedGlobalHeapPtr.Get(), connectProperties);
            }
            return snresult;
        }

        // Token: 0x060000C9 RID: 201
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetConnectionInfo")]
        private static extern DEX.TMAPI.SNRESULT GetConnectionInfoX64(int target, IntPtr connectProperties);

        // Token: 0x060000CA RID: 202
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetConnectionInfo")]
        private static extern DEX.TMAPI.SNRESULT GetConnectionInfoX86(int target, IntPtr connectProperties);

        // Token: 0x060000CB RID: 203 RVA: 0x0000429C File Offset: 0x0000249C
        public static DEX.TMAPI.SNRESULT GetConnectStatus(int target, out DEX.TMAPI.ConnectStatus status, out string usage)
        {
            uint num;
            IntPtr utf;
            DEX.TMAPI.SNRESULT result = DEX.TMAPI.Is32Bit() ? DEX.TMAPI.GetConnectStatusX86(target, out num, out utf) : DEX.TMAPI.GetConnectStatusX64(target, out num, out utf);
            status = (DEX.TMAPI.ConnectStatus)num;
            usage = DEX.TMAPI.Utf8ToString(utf, uint.MaxValue);
            return result;
        }

        // Token: 0x060000CC RID: 204
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetConnectStatus")]
        private static extern DEX.TMAPI.SNRESULT GetConnectStatusX64(int target, out uint status, out IntPtr usage);

        // Token: 0x060000CD RID: 205
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetConnectStatus")]
        private static extern DEX.TMAPI.SNRESULT GetConnectStatusX86(int target, out uint status, out IntPtr usage);

        // Token: 0x060000CE RID: 206 RVA: 0x000042DC File Offset: 0x000024DC
        public static DEX.TMAPI.SNRESULT GetProcessList(int target, out uint[] processIDs)
        {
            processIDs = null;
            uint num = 0u;
            DEX.TMAPI.SNRESULT snresult = DEX.TMAPI.Is32Bit() ? DEX.TMAPI.GetProcessListX86(target, ref num, IntPtr.Zero) : DEX.TMAPI.GetProcessListX64(target, ref num, IntPtr.Zero);
            if (!DEX.TMAPI.FAILED(snresult))
            {
                DEX.TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new DEX.TMAPI.ScopedGlobalHeapPtr(Marshal.AllocHGlobal((int)(4u * num)));
                snresult = (DEX.TMAPI.Is32Bit() ? DEX.TMAPI.GetProcessListX86(target, ref num, scopedGlobalHeapPtr.Get()) : DEX.TMAPI.GetProcessListX64(target, ref num, scopedGlobalHeapPtr.Get()));
                if (DEX.TMAPI.FAILED(snresult))
                {
                    return snresult;
                }
                IntPtr unmanagedBuf = scopedGlobalHeapPtr.Get();
                processIDs = new uint[num];
                for (uint num2 = 0u; num2 < num; num2 += 1u)
                {
                    unmanagedBuf = DEX.TMAPI.ReadDataFromUnmanagedIncPtr<uint>(unmanagedBuf, ref processIDs[(int)((UIntPtr)((uint)((UIntPtr)num2)))]);
                }
            }
            return snresult;
        }

        // Token: 0x060000CF RID: 207
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessList")]
        private static extern DEX.TMAPI.SNRESULT GetProcessListX64(int target, ref uint count, IntPtr processIdArray);

        // Token: 0x060000D0 RID: 208
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessList")]
        private static extern DEX.TMAPI.SNRESULT GetProcessListX86(int target, ref uint count, IntPtr processIdArray);

        // Token: 0x060000D1 RID: 209 RVA: 0x000043BC File Offset: 0x000025BC
        public static DEX.TMAPI.SNRESULT GetTargetFromName(string name, out int target)
        {
            DEX.TMAPI.ScopedGlobalHeapPtr scopedGlobalHeapPtr = new DEX.TMAPI.ScopedGlobalHeapPtr(DEX.TMAPI.AllocUtf8FromString(name));
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.GetTargetFromNameX64(scopedGlobalHeapPtr.Get(), out target);
            }
            else
            {
                result = DEX.TMAPI.GetTargetFromNameX86(scopedGlobalHeapPtr.Get(), out target);
            }
            return result;
        }

        // Token: 0x060000D2 RID: 210
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetTargetFromName")]
        private static extern DEX.TMAPI.SNRESULT GetTargetFromNameX64(IntPtr name, out int target);

        // Token: 0x060000D3 RID: 211
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetTargetFromName")]
        private static extern DEX.TMAPI.SNRESULT GetTargetFromNameX86(IntPtr name, out int target);

        // Token: 0x060000D4 RID: 212 RVA: 0x00004400 File Offset: 0x00002600
        public static DEX.TMAPI.SNRESULT GetTargetInfo(ref DEX.TMAPI.TargetInfo targetInfo)
        {
            DEX.TMAPI.TargetInfoPriv targetInfoPriv = new DEX.TMAPI.TargetInfoPriv
            {
                Flags = targetInfo.Flags,
                Target = targetInfo.Target
            };
            DEX.TMAPI.SNRESULT snresult = DEX.TMAPI.Is32Bit() ? DEX.TMAPI.GetTargetInfoX86(ref targetInfoPriv) : DEX.TMAPI.GetTargetInfoX64(ref targetInfoPriv);
            if (!DEX.TMAPI.FAILED(snresult))
            {
                targetInfo.Flags = targetInfoPriv.Flags;
                targetInfo.Target = targetInfoPriv.Target;
                targetInfo.Name = DEX.TMAPI.Utf8ToString(targetInfoPriv.Name, uint.MaxValue);
                targetInfo.Type = DEX.TMAPI.Utf8ToString(targetInfoPriv.Type, uint.MaxValue);
                targetInfo.Info = DEX.TMAPI.Utf8ToString(targetInfoPriv.Info, uint.MaxValue);
                targetInfo.HomeDir = DEX.TMAPI.Utf8ToString(targetInfoPriv.HomeDir, uint.MaxValue);
                targetInfo.FSDir = DEX.TMAPI.Utf8ToString(targetInfoPriv.FSDir, uint.MaxValue);
                targetInfo.Boot = targetInfoPriv.Boot;
            }
            return snresult;
        }

        // Token: 0x060000D5 RID: 213
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetTargetInfo")]
        private static extern DEX.TMAPI.SNRESULT GetTargetInfoX64(ref DEX.TMAPI.TargetInfoPriv targetInfoPriv);

        // Token: 0x060000D6 RID: 214
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3GetTargetInfo")]
        private static extern DEX.TMAPI.SNRESULT GetTargetInfoX86(ref DEX.TMAPI.TargetInfoPriv targetInfoPriv);

        // Token: 0x060000D7 RID: 215 RVA: 0x000044E8 File Offset: 0x000026E8
        public static DEX.TMAPI.SNRESULT InitTargetComms()
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.InitTargetCommsX64();
            }
            else
            {
                result = DEX.TMAPI.InitTargetCommsX86();
            }
            return result;
        }

        // Token: 0x060000D8 RID: 216
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3InitTargetComms")]
        private static extern DEX.TMAPI.SNRESULT InitTargetCommsX64();

        // Token: 0x060000D9 RID: 217
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3InitTargetComms")]
        private static extern DEX.TMAPI.SNRESULT InitTargetCommsX86();

        // Token: 0x060000DA RID: 218 RVA: 0x00004514 File Offset: 0x00002714
        private static bool Is32Bit()
        {
            return IntPtr.Size == 4;
        }

        // Token: 0x060000DB RID: 219
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int MultiByteToWideChar(int codepage, int flags, IntPtr utf8, int utf8len, StringBuilder buffer, int buflen);

        // Token: 0x060000DC RID: 220
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3PowerOff")]
        private static extern DEX.TMAPI.SNRESULT PowerOffX64(int target, uint force);

        // Token: 0x060000DD RID: 221
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3PowerOff")]
        private static extern DEX.TMAPI.SNRESULT PowerOffX86(int target, uint force);

        // Token: 0x060000DE RID: 222 RVA: 0x00004530 File Offset: 0x00002730
        public static DEX.TMAPI.SNRESULT PowerOn(int target)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.PowerOnX64(target);
            }
            else
            {
                result = DEX.TMAPI.PowerOnX86(target);
            }
            return result;
        }

        // Token: 0x060000DF RID: 223
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3PowerOn")]
        private static extern DEX.TMAPI.SNRESULT PowerOnX64(int target);

        // Token: 0x060000E0 RID: 224
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3PowerOn")]
        private static extern DEX.TMAPI.SNRESULT PowerOnX86(int target);

        // Token: 0x060000E1 RID: 225 RVA: 0x0000455C File Offset: 0x0000275C
        public static DEX.TMAPI.SNRESULT ProcessAttach(int target, DEX.TMAPI.UnitType unit, uint processID)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ProcessAttachX64(target, (uint)unit, processID);
            }
            else
            {
                result = DEX.TMAPI.ProcessAttachX86(target, (uint)unit, processID);
            }
            return result;
        }

        // Token: 0x060000E2 RID: 226
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessAttach")]
        private static extern DEX.TMAPI.SNRESULT ProcessAttachX64(int target, uint unitId, uint processId);

        // Token: 0x060000E3 RID: 227
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessAttach")]
        private static extern DEX.TMAPI.SNRESULT ProcessAttachX86(int target, uint unitId, uint processId);

        // Token: 0x060000E4 RID: 228 RVA: 0x0000458C File Offset: 0x0000278C
        public static DEX.TMAPI.SNRESULT ProcessContinue(int target, uint processID)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ProcessContinueX64(target, processID);
            }
            else
            {
                result = DEX.TMAPI.ProcessContinueX86(target, processID);
            }
            return result;
        }

        // Token: 0x060000E5 RID: 229
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessContinue")]
        private static extern DEX.TMAPI.SNRESULT ProcessContinueX64(int target, uint processId);

        // Token: 0x060000E6 RID: 230
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessContinue")]
        private static extern DEX.TMAPI.SNRESULT ProcessContinueX86(int target, uint processId);

        // Token: 0x060000E7 RID: 231 RVA: 0x000045BC File Offset: 0x000027BC
        public static DEX.TMAPI.SNRESULT ProcessGetMemory(int target, DEX.TMAPI.UnitType unit, uint processID, ulong threadID, ulong address, ref byte[] buffer)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ProcessGetMemoryX64(target, unit, processID, threadID, address, buffer.Length, buffer);
            }
            else
            {
                result = DEX.TMAPI.ProcessGetMemoryX86(target, unit, processID, threadID, address, buffer.Length, buffer);
            }
            return result;
        }

        // Token: 0x060000E8 RID: 232
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessGetMemory")]
        private static extern DEX.TMAPI.SNRESULT ProcessGetMemoryX64(int target, DEX.TMAPI.UnitType unit, uint processId, ulong threadId, ulong address, int count, byte[] buffer);

        // Token: 0x060000E9 RID: 233
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessGetMemory")]
        private static extern DEX.TMAPI.SNRESULT ProcessGetMemoryX86(int target, DEX.TMAPI.UnitType unit, uint processId, ulong threadId, ulong address, int count, byte[] buffer);

        // Token: 0x060000EA RID: 234 RVA: 0x00004604 File Offset: 0x00002804
        public static DEX.TMAPI.SNRESULT ProcessSetMemory(int target, DEX.TMAPI.UnitType unit, uint processID, ulong threadID, ulong address, byte[] buffer)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ProcessSetMemoryX64(target, unit, processID, threadID, address, buffer.Length, buffer);
            }
            else
            {
                result = DEX.TMAPI.ProcessSetMemoryX86(target, unit, processID, threadID, address, buffer.Length, buffer);
            }
            return result;
        }

        // Token: 0x060000EB RID: 235
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessSetMemory")]
        private static extern DEX.TMAPI.SNRESULT ProcessSetMemoryX64(int target, DEX.TMAPI.UnitType unit, uint processId, ulong threadId, ulong address, int count, byte[] buffer);

        // Token: 0x060000EC RID: 236
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3ProcessSetMemory")]
        private static extern DEX.TMAPI.SNRESULT ProcessSetMemoryX86(int target, DEX.TMAPI.UnitType unit, uint processId, ulong threadId, ulong address, int count, byte[] buffer);

        // Token: 0x060000ED RID: 237 RVA: 0x00004648 File Offset: 0x00002848
        private static IntPtr ReadDataFromUnmanagedIncPtr<T>(IntPtr unmanagedBuf, ref T storage)
        {
            storage = (T)((object)Marshal.PtrToStructure(unmanagedBuf, typeof(T)));
            return new IntPtr(unmanagedBuf.ToInt64() + (long)Marshal.SizeOf(storage));
        }

        // Token: 0x060000EE RID: 238 RVA: 0x00004694 File Offset: 0x00002894
        public static DEX.TMAPI.SNRESULT Reset(int target, DEX.TMAPI.ResetParameter resetParameter)
        {
            DEX.TMAPI.SNRESULT result;
            if (!DEX.TMAPI.Is32Bit())
            {
                result = DEX.TMAPI.ResetX64(target, (ulong)resetParameter);
            }
            else
            {
                result = DEX.TMAPI.ResetX86(target, (ulong)resetParameter);
            }
            return result;
        }

        // Token: 0x060000EF RID: 239
        [DllImport("PS3TMAPIX64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Reset")]
        private static extern DEX.TMAPI.SNRESULT ResetX64(int target, ulong resetParameter);

        // Token: 0x060000F0 RID: 240
        [DllImport("PS3TMAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SNPS3Reset")]
        private static extern DEX.TMAPI.SNRESULT ResetX86(int target, ulong resetParameter);

        // Token: 0x060000F1 RID: 241 RVA: 0x000046C4 File Offset: 0x000028C4
        public static bool SUCCEEDED(DEX.TMAPI.SNRESULT res)
        {
            return res >= DEX.TMAPI.SNRESULT.SN_S_OK;
        }

        // Token: 0x060000F2 RID: 242 RVA: 0x000046E0 File Offset: 0x000028E0
        public static string Utf8ToString(IntPtr utf8, uint maxLength)
        {
            int num = DEX.TMAPI.MultiByteToWideChar(65001, 0, utf8, -1, null, 0);
            if (num == 0)
            {
                throw new Win32Exception();
            }
            StringBuilder stringBuilder = new StringBuilder(num);
            num = DEX.TMAPI.MultiByteToWideChar(65001, 0, utf8, -1, stringBuilder, num);
            return stringBuilder.ToString();
        }

        // Token: 0x02000029 RID: 41
        [Flags]
        public enum BootParameter : ulong
        {
            // Token: 0x04000067 RID: 103
            BluRayEmuOff = 4UL,
            // Token: 0x04000068 RID: 104
            BluRayEmuUSB = 32UL,
            // Token: 0x04000069 RID: 105
            DebugMode = 16UL,
            // Token: 0x0400006A RID: 106
            Default = 0UL,
            // Token: 0x0400006B RID: 107
            DualNIC = 128UL,
            // Token: 0x0400006C RID: 108
            HDDSpeedBluRayEmu = 8UL,
            // Token: 0x0400006D RID: 109
            HostFSTarget = 64UL,
            // Token: 0x0400006E RID: 110
            MemSizeConsole = 2UL,
            // Token: 0x0400006F RID: 111
            ReleaseMode = 1UL,
            // Token: 0x04000070 RID: 112
            SystemMode = 17UL
        }

        // Token: 0x0200002A RID: 42
        public enum ConnectStatus
        {
            // Token: 0x04000072 RID: 114
            Connected,
            // Token: 0x04000073 RID: 115
            Connecting,
            // Token: 0x04000074 RID: 116
            NotConnected,
            // Token: 0x04000075 RID: 117
            InUse,
            // Token: 0x04000076 RID: 118
            Unavailable
        }

        // Token: 0x0200002B RID: 43
        [Flags]
        public enum ResetParameter : ulong
        {
            // Token: 0x04000078 RID: 120
            Hard = 1UL,
            // Token: 0x04000079 RID: 121
            Quick = 2UL,
            // Token: 0x0400007A RID: 122
            ResetEx = 9223372036854775808UL,
            // Token: 0x0400007B RID: 123
            Soft = 0UL
        }

        // Token: 0x0200002C RID: 44
        private class ScopedGlobalHeapPtr
        {
            // Token: 0x060000F3 RID: 243 RVA: 0x00004731 File Offset: 0x00002931
            public ScopedGlobalHeapPtr(IntPtr intPtr)
            {
                this.m_intPtr = intPtr;
            }

            // Token: 0x060000F4 RID: 244 RVA: 0x00004750 File Offset: 0x00002950
            ~ScopedGlobalHeapPtr()
            {
                if (this.m_intPtr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(this.m_intPtr);
                }
            }

            // Token: 0x060000F5 RID: 245 RVA: 0x000047A0 File Offset: 0x000029A0
            public IntPtr Get()
            {
                return this.m_intPtr;
            }

            // Token: 0x0400007C RID: 124
            private IntPtr m_intPtr = IntPtr.Zero;
        }

        // Token: 0x0200002D RID: 45
        public enum SNRESULT
        {
            // Token: 0x0400007E RID: 126
            SN_E_BAD_ALIGN = -28,
            // Token: 0x0400007F RID: 127
            SN_E_BAD_MEMSPACE = -18,
            // Token: 0x04000080 RID: 128
            SN_E_BAD_PARAM = -21,
            // Token: 0x04000081 RID: 129
            SN_E_BAD_TARGET = -3,
            // Token: 0x04000082 RID: 130
            SN_E_BAD_UNIT = -11,
            // Token: 0x04000083 RID: 131
            SN_E_BUSY = -22,
            // Token: 0x04000084 RID: 132
            SN_E_CHECK_TARGET_CONFIGURATION = -33,
            // Token: 0x04000085 RID: 133
            SN_E_COMMAND_CANCELLED = -36,
            // Token: 0x04000086 RID: 134
            SN_E_COMMS_ERR = -5,
            // Token: 0x04000087 RID: 135
            SN_E_COMMS_EVENT_MISMATCHED_ERR = -39,
            // Token: 0x04000088 RID: 136
            SN_E_CONNECT_TO_GAMEPORT_FAILED = -35,
            // Token: 0x04000089 RID: 137
            SN_E_CONNECTED = -38,
            // Token: 0x0400008A RID: 138
            SN_E_DATA_TOO_LONG = -26,
            // Token: 0x0400008B RID: 139
            SN_E_DECI_ERROR = -23,
            // Token: 0x0400008C RID: 140
            SN_E_DEPRECATED = -27,
            // Token: 0x0400008D RID: 141
            SN_E_DLL_NOT_INITIALISED = -15,
            // Token: 0x0400008E RID: 142
            SN_E_ERROR = -2147483648,
            // Token: 0x0400008F RID: 143
            SN_E_EXISTING_CALLBACK = -24,
            // Token: 0x04000090 RID: 144
            SN_E_FILE_ERROR = -29,
            // Token: 0x04000091 RID: 145
            SN_E_HOST_NOT_FOUND = -8,
            // Token: 0x04000092 RID: 146
            SN_E_INSUFFICIENT_DATA = -25,
            // Token: 0x04000093 RID: 147
            SN_E_LICENSE_ERROR = -32,
            // Token: 0x04000094 RID: 148
            SN_E_LOAD_ELF_FAILED = -10,
            // Token: 0x04000095 RID: 149
            SN_E_LOAD_MODULE_FAILED = -31,
            // Token: 0x04000096 RID: 150
            SN_E_MODULE_NOT_FOUND = -34,
            // Token: 0x04000097 RID: 151
            SN_E_NO_SEL = -20,
            // Token: 0x04000098 RID: 152
            SN_E_NO_TARGETS,
            // Token: 0x04000099 RID: 153
            SN_E_NOT_CONNECTED = -4,
            // Token: 0x0400009A RID: 154
            SN_E_NOT_IMPL = -1,
            // Token: 0x0400009B RID: 155
            SN_E_NOT_LISTED = -13,
            // Token: 0x0400009C RID: 156
            SN_E_NOT_SUPPORTED_IN_SDK_VERSION = -30,
            // Token: 0x0400009D RID: 157
            SN_E_OUT_OF_MEM = -12,
            // Token: 0x0400009E RID: 158
            SN_E_PROTOCOL_ALREADY_REGISTERED = -37,
            // Token: 0x0400009F RID: 159
            SN_E_TARGET_IN_USE = -9,
            // Token: 0x040000A0 RID: 160
            SN_E_TARGET_RUNNING = -17,
            // Token: 0x040000A1 RID: 161
            SN_E_TIMEOUT = -7,
            // Token: 0x040000A2 RID: 162
            SN_E_TM_COMMS_ERR,
            // Token: 0x040000A3 RID: 163
            SN_E_TM_NOT_RUNNING = -2,
            // Token: 0x040000A4 RID: 164
            SN_E_TM_VERSION = -14,
            // Token: 0x040000A5 RID: 165
            SN_S_NO_ACTION = 6,
            // Token: 0x040000A6 RID: 166
            SN_S_NO_MSG = 3,
            // Token: 0x040000A7 RID: 167
            SN_S_OK = 0,
            // Token: 0x040000A8 RID: 168
            SN_S_PENDING,
            // Token: 0x040000A9 RID: 169
            SN_S_REPLACED = 5,
            // Token: 0x040000AA RID: 170
            SN_S_TARGET_STILL_REGISTERED = 7,
            // Token: 0x040000AB RID: 171
            SN_S_TM_VERSION = 4
        }

        // Token: 0x0200002E RID: 46
        public struct TargetInfo
        {
            // Token: 0x040000AC RID: 172
            public DEX.TMAPI.TargetInfoFlag Flags;

            // Token: 0x040000AD RID: 173
            public int Target;

            // Token: 0x040000AE RID: 174
            public string Name;

            // Token: 0x040000AF RID: 175
            public string Type;

            // Token: 0x040000B0 RID: 176
            public string Info;

            // Token: 0x040000B1 RID: 177
            public string HomeDir;

            // Token: 0x040000B2 RID: 178
            public string FSDir;

            // Token: 0x040000B3 RID: 179
            public DEX.TMAPI.BootParameter Boot;
        }

        // Token: 0x0200002F RID: 47
        [Flags]
        public enum TargetInfoFlag : uint
        {
            // Token: 0x040000B5 RID: 181
            Boot = 32u,
            // Token: 0x040000B6 RID: 182
            FileServingDir = 16u,
            // Token: 0x040000B7 RID: 183
            HomeDir = 8u,
            // Token: 0x040000B8 RID: 184
            Info = 4u,
            // Token: 0x040000B9 RID: 185
            Name = 2u,
            // Token: 0x040000BA RID: 186
            TargetID = 1u
        }

        // Token: 0x02000030 RID: 48
        private struct TargetInfoPriv
        {
            // Token: 0x040000BB RID: 187
            public DEX.TMAPI.TargetInfoFlag Flags;

            // Token: 0x040000BC RID: 188
            public int Target;

            // Token: 0x040000BD RID: 189
            public IntPtr Name;

            // Token: 0x040000BE RID: 190
            public IntPtr Type;

            // Token: 0x040000BF RID: 191
            public IntPtr Info;

            // Token: 0x040000C0 RID: 192
            public IntPtr HomeDir;

            // Token: 0x040000C1 RID: 193
            public IntPtr FSDir;

            // Token: 0x040000C2 RID: 194
            public DEX.TMAPI.BootParameter Boot;
        }

        // Token: 0x02000031 RID: 49
        [StructLayout(LayoutKind.Sequential)]
        public class TCPIPConnectProperties
        {
            // Token: 0x040000C3 RID: 195
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string IPAddress;

            // Token: 0x040000C4 RID: 196
            public uint Port;
        }

        // Token: 0x02000032 RID: 50
        public enum UnitType
        {
            // Token: 0x040000C6 RID: 198
            PPU,
            // Token: 0x040000C7 RID: 199
            SPU,
            // Token: 0x040000C8 RID: 200
            SPURAW
        }
    }
}

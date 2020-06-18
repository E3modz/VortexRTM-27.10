using PS3Lib;
using System;
using System.Linq;
using System.Text;
namespace E3Modz
{
    internal class PS5
    {
        public class Extension
        {
            private static SelectAPI CurrentAPI;
            private static byte[] GetBytes(uint offset, int length, SelectAPI API)
            {
                byte[] array = new byte[length];
                byte[] result;
                if (API == SelectAPI.ControlConsole)
                {
                    PS5.Extension.CurrentAPI = PS5.GetCurrentAPI();
                    result = PS5.DEX.GetBytes(offset, length);
                }
                else
                {
                    if (API == SelectAPI.TargetManager)
                    {
                        PS5.Extension.CurrentAPI = PS5.GetCurrentAPI();
                        array = PS5.DEX.GetBytes(offset, length);
                    }
                    result = array;
                }
                return result;
            }
            public static byte[] GetMem(uint Address, int Length)
            {
                byte[] buffer = new byte[Length];
                PS5.GetMemoryR(Address, ref buffer);
                return buffer;
            }
            public static void GetMem(uint offset, byte[] buffer, SelectAPI API)
            {
                if (API == SelectAPI.ControlConsole)
                {
                    PS5.GetMemoryR(offset, ref buffer);
                }
                else
                {
                    if (API == SelectAPI.TargetManager)
                    {
                        PS5.GetMemoryR(offset, ref buffer);
                    }
                }
            }
            public void WriteDouble(uint offset, double input)
            {
                byte[] buff = new byte[8];
                BitConverter.GetBytes(input).CopyTo(buff, 0);
                Array.Reverse(buff, 0, 8);
                PS5.Extension.WriteBytes(offset, buff);
            }
            public enum UnitType
            {
                PPU = 0,
                SPU = 1,
                SPURAW = 2
            }
            public static bool ReadBool(uint offset)
            {
                byte[] array = new byte[1];
                PS5.Extension.GetMem(offset, array, PS5.Extension.CurrentAPI);
                return array[0] != 0;
            }
            public static byte ReadByte(uint offset)
            {
                return PS5.Extension.GetBytes(offset, 1, PS5.Extension.CurrentAPI)[0];
            }
            public static byte[] ReadBytes(uint offset, int length)
            {
                return PS5.Extension.GetBytes(offset, length, PS5.Extension.CurrentAPI);
            }

            public static float ReadFloat(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 4, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToSingle(bytes, 0);
            }
            public static short ReadInt16(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 2, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 2);
                return BitConverter.ToInt16(bytes, 0);
            }
            public static int ReadInt32(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 4, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToInt32(bytes, 0);
            }
            public static void WriteSingle(uint address, float input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS5.SetMemory(address, array);
            }
            public static void WriteSingle(uint address, float[] input)
            {
                int num = input.Length;
                byte[] array = new byte[num * 4];
                for (int i = 0; i < num; i++)
                {
                    PS5.Extension.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
                }
                PS5.SetMemory(address, array);
            }
            public static long ReadInt64(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 8, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 8);
                return BitConverter.ToInt64(bytes, 0);
            }
            public static sbyte ReadSByte(uint offset)
            {
                byte[] array = new byte[1];
                PS5.Extension.GetMem(offset, array, PS5.Extension.CurrentAPI);
                return (sbyte)array[0];
            }
            public static string ReadString(uint offset)
            {
                int num = 40;
                int num2 = 0;
                string text = "";
                do
                {
                    byte[] bytes = PS5.Extension.ReadBytes(offset + (uint)num2, num);
                    text += Encoding.UTF8.GetString(bytes);
                    num2 += num;
                }
                while (!text.Contains('\0'));
                int length = text.IndexOf('\0');
                string result = text.Substring(0, length);
                text = string.Empty;
                return result;
            }
            public static byte[] ReverseArray(float float_0)
            {
                byte[] bytes = BitConverter.GetBytes(float_0);
                Array.Reverse(bytes);
                return bytes;
            }
            public static byte[] uintBytes(uint input)
            {
                byte[] bytes = BitConverter.GetBytes(input);
                Array.Reverse(bytes);
                return bytes;
            }
            public static byte[] ReverseBytes(byte[] inArray)
            {
                Array.Reverse(inArray);
                return inArray;
            }
            public static byte[] ToHexFloat(float Axis)
            {
                byte[] bytes = BitConverter.GetBytes(Axis);
                Array.Reverse(bytes);
                return bytes;
            }
            public static ushort ReadUInt16(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 2, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 2);
                return BitConverter.ToUInt16(bytes, 0);
            }
            public static uint ReadUInt32(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 4, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 4);
                return BitConverter.ToUInt32(bytes, 0);
            }
            public static ulong ReadUInt64(uint offset)
            {
                byte[] bytes = PS5.Extension.GetBytes(offset, 8, PS5.Extension.CurrentAPI);
                Array.Reverse(bytes, 0, 8);
                return BitConverter.ToUInt64(bytes, 0);
            }
            private static void SetMem(uint Address, byte[] buffer, SelectAPI API)
            {
                PS5.DEX.SetMemory(Address, buffer);
            }
            public static void WriteBool(uint offset, bool input)
            {
                byte[] buffer = new byte[]
                {

                };
                PS5.Extension.SetMem(offset, buffer, PS5.Extension.CurrentAPI);
            }
            public static void WriteByte(uint offset, byte input)
            {
                byte[] buffer = new byte[]
                {
                    input
                };
                PS5.Extension.SetMem(offset, buffer, PS5.Extension.CurrentAPI);
            }
            public static void WriteBytes(uint offset, byte[] input)
            {
                PS5.Extension.SetMem(offset, input, PS5.Extension.CurrentAPI);
            }
            public static void WriteFloat(uint offset, float input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteInt16(uint offset, short input)
            {
                byte[] array = new byte[2];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 2);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteInt32(uint offset, int input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteInt64(uint offset, long input)
            {
                byte[] array = new byte[8];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 8);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteSByte(uint offset, sbyte input)
            {
                byte[] buffer = new byte[]
                {
                    (byte)input
                };
                PS5.Extension.SetMem(offset, buffer, PS5.Extension.CurrentAPI);
            }
            public static void WriteString(uint offset, string input)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS5.Extension.SetMem(offset, bytes, PS5.Extension.CurrentAPI);
            }
            public static void WriteUInt16(uint offset, ushort input)
            {
                byte[] array = new byte[2];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 2);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteUInt32(uint offset, uint input)
            {
                byte[] array = new byte[4];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 4);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static void WriteUInt64(uint offset, ulong input)
            {
                byte[] array = new byte[8];
                BitConverter.GetBytes(input).CopyTo(array, 0);
                Array.Reverse(array, 0, 8);
                PS5.Extension.SetMem(offset, array, PS5.Extension.CurrentAPI);
            }
            public static float[] ReadFloatArray(uint addr, int length)
            {
                float[] numArray = new float[length];
                for (int index = 0; index < length; ++index)
                {
                    byte[] memory = PS5.GetMemory(addr + (uint)(index * 4), 4);
                    Array.Reverse((Array)memory);
                    numArray[index] = BitConverter.ToSingle(memory, 0);
                }
                return numArray;
            }
            public static void WriteFloatArray(uint Offset, float[] Array)
            {
                byte[] bytes = new byte[Array.Length * 4];
                for (int index = 0; index < Array.Length; ++index)
                    PS5.Extension.ReverseBytes(BitConverter.GetBytes(Array[index])).CopyTo((Array)bytes, index * 4);
                PS5.SetMemory(Offset, bytes);
            }
        }

        internal static void GetMemory(uint offset, byte[] array)
        {
            throw new NotImplementedException();
        }

        private class Conversions
        {
            public static byte[] ReverseBytes(byte[] input)
            {
                Array.Reverse(input);
                return input;
            }
            public static byte[] RandomizeRGBA()
            {
                byte[] array = new byte[4];
                Random random = new Random();
                array[0] = BitConverter.GetBytes(random.Next(0, 255))[0];
                array[1] = BitConverter.GetBytes(random.Next(0, 255))[0];
                array[2] = BitConverter.GetBytes(random.Next(0, 255))[0];
                array[3] = BitConverter.GetBytes(random.Next(0, 255))[0];
                return array;
            }
        }
        private static PS3API DEX = new PS3API(SelectAPI.TargetManager);
        public static void Connect()
        {

            PS5.DEX.AttachProcess();
        }
        private static PS3API CEX = new PS3API(SelectAPI.ControlConsole);
        public static void Connect1()
        {
            PS5.CEX.ConnectTarget(0);
            PS5.CEX.AttachProcess();
        }
        public static string ByteArrayToString(byte[] bytes)
        {
            return new ASCIIEncoding().GetString(bytes);
        }
        public static void Reconnect()
        {
            PS5.DEX.ConnectTarget(0);
        }
        public static byte[] GetMemory(uint offset, int length)
        {
            byte[] array = new byte[length];
            PS5.DEX.GetMemory(offset, array);
            return array;
        }
        public static void ChangeAPI(SelectAPI API)
        {
            PS5.DEX.ChangeAPI(API);
        }
        public static SelectAPI GetCurrentAPI()
        {
            return PS5.DEX.GetCurrentAPI();
        }
        public static byte[] GetMemoryL(uint address, int length)
        {
            byte[] array = new byte[length];
            PS5.DEX.GetMemory(address, array);
            return array;
        }
        public static void SetMemory(uint Address, byte[] Bytes)
        {
            PS5.DEX.SetMemory(Address, Bytes);
        }
        public static void GetMemoryR(uint Address, ref byte[] Bytes)
        {
            PS5.DEX.GetMemory(Address, Bytes);
        }
    }
}

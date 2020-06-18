using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;
using System.Threading;
using E3Modz.MW3;

namespace MW3RCE
{
    public class RCE
    {
        public static PS3API PS3 = (MW3.PS3);


        public static void WriteUInt32(uint Address, uint Value)
        {
            PS3.Extension.WriteUInt32(0x10055010, Address);
            PS3.Extension.WriteUInt32(0x10055014, Value);
            PS3.Extension.WriteUInt32(0x10055000, 2);
            while (PS3.Extension.ReadUInt32(0x10055000) != 0x0)
                Thread.Sleep(10);
        }

        public static void WriteChar(uint Address, uint Value)
        {
            PS3.Extension.WriteUInt32(0x10055010, Address);
            PS3.SetMemory(0x10055014, new byte[] { Convert.ToByte(Value) });
            PS3.Extension.WriteUInt32(0x10055000, 2);
            while (PS3.Extension.ReadUInt32(0x10055000) != 0x0)
                Thread.Sleep(10);
        }

        internal static void Init()
        {
            throw new NotImplementedException();
        }
    }
}
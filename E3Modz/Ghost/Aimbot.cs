using E3Modz.Login___Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3Modz.Ghost
{
    public static class Aimbot
    {
        // Token: 0x06000004 RID: 4 RVA: 0x00002118 File Offset: 0x00000318
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] array = GhostMP.PS3.Extension.ReadBytes(address, length * 4);
            Aimbot.ReverseBytes(array);
            float[] array2 = new float[length];
            for (int i = 0; i < length; i++)
            {
                array2[i] = BitConverter.ToSingle(array, (length - 1 - i) * 4);
            }
            return array2;
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002170 File Offset: 0x00000370
        public static void WriteSingle(uint address, float[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                Aimbot.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            GhostMP.PS3.SetMemory(address, array);
        }

        // Token: 0x06000006 RID: 6 RVA: 0x000021C4 File Offset: 0x000003C4
        public static byte[] ReverseBytes(byte[] toReverse)
        {
            Array.Reverse(toReverse);
            return toReverse;
        }

        // Token: 0x06000007 RID: 7 RVA: 0x000021E0 File Offset: 0x000003E0
        public static uint G_Client(int client)
        {
            return Aimbot.Offsets.g_client + Aimbot.Offsets.clientSize * (uint)client;
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002200 File Offset: 0x00000400
        public static uint G_Entity(int client)
        {
            return Aimbot.Offsets.g_entity + Aimbot.Offsets.entitySize * (uint)client;
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002220 File Offset: 0x00000420
        public static float[] getOrigin(int client)
        {
            return Aimbot.ReadSingle(Aimbot.G_Client(client) + 28u, 3);
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002244 File Offset: 0x00000444
        public static float[] vectoangles(float[] Angles)
        {
            float[] array = new float[3];
            float num;
            float num2;
            if (Angles[1] == 0f && Angles[0] == 0f)
            {
                num = 0f;
                if (Angles[2] > 0f)
                {
                    num2 = 90f;
                }
                else
                {
                    num2 = 270f;
                }
            }
            else
            {
                if (Angles[0] != -1f)
                {
                    num = (float)(Math.Atan2((double)Angles[1], (double)Angles[0]) * 180.0 / 3.1415926535897931);
                }
                else if (Angles[1] > 0f)
                {
                    num = 90f;
                }
                else
                {
                    num = 270f;
                }
                if (num < 0f)
                {
                    num += 360f;
                }
                float num3 = (float)Math.Sqrt((double)(Angles[0] * Angles[0] + Angles[1] * Angles[1]));
                num2 = (float)(Math.Atan2((double)Angles[2], (double)num3) * 180.0 / 3.1415926535897931);
                if (num2 < 0f)
                {
                    num2 += 360f;
                }
            }
            array[0] = -num2;
            array[1] = num;
            return array;
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00002388 File Offset: 0x00000588
        public static float[] getVector(int shooter, int victim)
        {
            float[] origin = Aimbot.getOrigin(shooter);
            float[] origin2 = Aimbot.getOrigin(victim);
            return new float[]
            {
                origin2[0] - origin[0],
                origin2[1] - origin[1],
                origin2[2] - origin[2]
            };
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000023D0 File Offset: 0x000005D0
        public static int nearestPlayer(int shooter)
        {
            int result = -1;
            float num = float.MaxValue;
            for (int i = 0; i < 12; i++)
            {
                float num2 = Aimbot.getOrigin(shooter)[0] - Aimbot.getOrigin(i)[0];
                float num3 = (float)Math.Sqrt((double)(num2 * num2));
                if (i != shooter)
                {
                    if (num3 < num)
                    {
                        result = i;
                        num = num3;
                    }
                }
            }
            return result;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002444 File Offset: 0x00000644
        public static void setClientViewAngles(int client)
        {
            int victim = Aimbot.nearestPlayer(client);
            float[] array = Aimbot.vectoangles(Aimbot.getVector(client, victim));
            Aimbot.WriteSingle(268451840u, array);
            RPCGhost.Call(Aimbot.Offsets.setClientViewAngles, new object[]
            {
                Aimbot.G_Entity(client),
                268451840,
                array
            });
        }
        public class Offsets
        {
            // Token: 0x0400000D RID: 13
            public static uint g_client = 16009600u;

            // Token: 0x0400000E RID: 14
            public static uint clientSize = 14080u;

            // Token: 0x0400000F RID: 15
            public static uint g_entity = 14698880u;

            // Token: 0x04000010 RID: 16
            public static uint entitySize = 640u;

            // Token: 0x04000011 RID: 17
            public static uint setClientViewAngles = 2298960u;
        }
    }
}

    
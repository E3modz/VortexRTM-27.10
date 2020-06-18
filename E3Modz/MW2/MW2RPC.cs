using E3Modz.Black_Ops_2;
using PS3Lib;
using System;
using System.Text;
using System.Threading;

namespace Furious_V2_NEW
{
    // Token: 0x0200000A RID: 10
    public class MW2RPC
    {
        public static PS3API PS3 = (MW2.PS3);
        // Token: 0x0600016D RID: 365 RVA: 0x00026FE4 File Offset: 0x000251E4
        public static int Call(uint func_address, params object[] parameters)
        {
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
                    PS3.Extension.WriteInt32(268763136u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else
                {
                    bool flag2 = parameters[i] is uint;
                    if (flag2)
                    {
                        PS3.Extension.WriteUInt32(268763136u + num2 * 4u, (uint)parameters[i]);
                        num2 += 1u;
                    }
                    else
                    {
                        bool flag3 = parameters[i] is string;
                        if (flag3)
                        {
                            uint num6 = 268771328u + num3 * 1024u;
                            PS3.Extension.WriteString(num6, Convert.ToString(parameters[i]));
                            PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
                            num2 += 1u;
                            num3 += 1u;
                        }
                        else
                        {
                            bool flag4 = parameters[i] is float;
                            if (flag4)
                            {
                                PS3.Extension.WriteFloat(268763172u + num4 * 4u, (float)parameters[i]);
                                num4 += 1u;
                            }
                            else
                            {
                                bool flag5 = parameters[i] is float[];
                                if (flag5)
                                {
                                    float[] array = (float[])parameters[i];
                                    uint num6 = 268767232u + num5 * 4u;
                                    MW2RPC.WriteSingle(num6, array);
                                    PS3.Extension.WriteUInt32(268763136u + num2 * 4u, num6);
                                    num2 += 1u;
                                    num5 += (uint)array.Length;
                                }
                            }
                        }
                    }
                }
                i++;
            }
            PS3.Extension.WriteUInt32(268763212u, func_address);
            Thread.Sleep(20);
            return PS3.Extension.ReadInt32(268763216u);
        }

        // Token: 0x0600016E RID: 366 RVA: 0x000271CC File Offset: 0x000253CC
        public static void EnableMW2RPC()
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
                64,
                0,
                114,
                48,
                66,
                76,
                56,
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
                60,
                64,
                0,
                115,
                48,
                66,
                75,
                232,
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
            PS3.SetMemory(MW2RPC.function_address, buffer);
            PS3.SetMemory(268763136u, new byte[10324]);
        }

        // Token: 0x0600016F RID: 367 RVA: 0x0002721B File Offset: 0x0002541B
        public static void ChangeFont(uint elem, uint font)
        {
            PS3.Extension.WriteUInt32(elem + MW2RPC.HudStruct.fontOffset, font);
        }

        // Token: 0x06000170 RID: 368 RVA: 0x00027238 File Offset: 0x00025438
        public static int RGB2INT(int r, int g, int b, int a)
        {
            byte[] array = new byte[]
            {
                (byte)r,
                (byte)g,
                (byte)b,
                (byte)a
            };
            Array.Reverse(array);
            return BitConverter.ToInt32(array, 0);
        }

        // Token: 0x06000171 RID: 369 RVA: 0x00027274 File Offset: 0x00025474
        private static uint HudElem_Alloc()
        {
            uint num = 120u;
            uint num2;
            for (; ; )
            {
                bool flag = num < 1024u;
                if (!flag)
                {
                    goto IL_6C;
                }
                num2 = MW2RPC.HudStructLib.G_Hudelems + num * MW2RPC.HudStructLib.IndexSize;
                bool flag2 = PS3.Extension.ReadInt32(num2 + MW2RPC.HudStructLib.type) != 0;
                if (!flag2)
                {
                    break;
                }
                num += 1u;
            }
            PS3.Extension.WriteBytes(num2, new byte[180]);
            return num2;
        IL_6C:
            return 0u;
        }

        // Token: 0x06000172 RID: 370 RVA: 0x00027300 File Offset: 0x00025500
        public static int getLevelTime()
        {
            byte[] array = new byte[4];
            PS3.GetMemory(19792644u, array);
            Array.Reverse(array, 0, 4);
            return BitConverter.ToInt32(array, 0);
        }

        // Token: 0x06000173 RID: 371 RVA: 0x0002733C File Offset: 0x0002553C
        public static void FadeOverTime(uint elem, int Time, int R, int G, int B, int A)
        {
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fadeStartTime, MW2RPC.getLevelTime());
            PS3.Extension.WriteBytes(elem + MW2RPC.HudStruct.fromColor, PS3.Extension.ReadBytes(elem + MW2RPC.HudStruct.colorOffset, 4));
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fadeTime, Time);
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.colorOffset, MW2RPC.RGB2INT(R, G, B, A));
        }

        // Token: 0x06000174 RID: 372 RVA: 0x000273D0 File Offset: 0x000255D0
        public static void FadeGlowOverTime(uint elem, int Time, int GlowR, int GlowG, int GlowB, int GlowA)
        {
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fadeStartTime, MW2RPC.getLevelTime());
            PS3.Extension.WriteBytes(elem + MW2RPC.HudStruct.fromColor, PS3.Extension.ReadBytes(elem + MW2RPC.HudStruct.colorOffset, 4));
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fadeTime, Time);
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.GlowColor, MW2RPC.RGB2INT(GlowR, GlowG, GlowB, GlowA));
        }

        // Token: 0x06000175 RID: 373 RVA: 0x00027464 File Offset: 0x00025664
        public static void MoveOverTime(uint elemIndex, short time, float X, float Y)
        {
            PS3.Extension.WriteFloat(elemIndex + MW2RPC.HudStruct.fromX, PS3.Extension.ReadFloat(elemIndex + MW2RPC.HudStruct.xOffset));
            PS3.Extension.WriteFloat(elemIndex + MW2RPC.HudStruct.fromY, PS3.Extension.ReadFloat(elemIndex + MW2RPC.HudStruct.yOffset));
            PS3.Extension.WriteInt32(elemIndex + MW2RPC.HudStruct.moveStartTime, MW2RPC.getLevelTime());
            PS3.Extension.WriteInt32(elemIndex + MW2RPC.HudStruct.moveTime, (int)time);
            PS3.Extension.WriteFloat(elemIndex + MW2RPC.HudStruct.xOffset, X);
            PS3.Extension.WriteFloat(elemIndex + MW2RPC.HudStruct.yOffset, Y);
        }

        // Token: 0x06000176 RID: 374 RVA: 0x00027530 File Offset: 0x00025730
        public static void setPulseFX(uint elem, int speed, int decayStart, int decayDuration)
        {
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fxBirthTime, MW2RPC.getLevelTime());
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fxLetterTime, speed);
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fxDecayStartTime, decayStart);
            PS3.Extension.WriteInt32(elem + MW2RPC.HudStruct.fxDecayDuration, decayDuration);
        }

        // Token: 0x06000177 RID: 375 RVA: 0x000275A2 File Offset: 0x000257A2
        public static void DestroyElem(uint elem)
        {
            PS3.SetMemory(elem, new byte[180]);
        }

        // Token: 0x06000178 RID: 376 RVA: 0x000275BB File Offset: 0x000257BB
        public static void SetElement(uint Element, uint HudTypes)
        {
            PS3.Extension.WriteUInt32(Element, HudTypes);
        }

        // Token: 0x06000179 RID: 377 RVA: 0x000275D0 File Offset: 0x000257D0
        public static uint HudElemAlloc(bool Reset = false)
        {
            if (Reset)
            {
                MW2RPC.HudAlloc.IndexSlot = 50u;
            }
            uint result = MW2RPC.HudAlloc.g_hudelem + MW2RPC.HudAlloc.IndexSlot * 180u;
            MW2RPC.HudAlloc.IndexSlot += 1u;
            return result;
        }

        // Token: 0x0600017A RID: 378 RVA: 0x00027610 File Offset: 0x00025810
        public static uint HudElemAlloc_Game(int clientNumber)
        {
            return (uint)MW2RPC.Call(1574624u, new object[]
            {
                clientNumber
            });
        }

        // Token: 0x0600017B RID: 379 RVA: 0x0002763C File Offset: 0x0002583C
        public static void WritePoweMW2RPC(bool Active)
        {
            byte[] buffer = new byte[]
            {
                248,
                33,
                byte.MaxValue,
                97,
                124,
                8,
                2,
                166,
                248,
                1,
                0,
                176,
                60,
                96,
                16,
                3,
                128,
                99,
                0,
                0,
                96,
                98,
                0,
                0,
                60,
                96,
                16,
                4,
                128,
                99,
                0,
                0,
                44,
                3,
                0,
                0,
                65,
                130,
                0,
                40,
                60,
                96,
                16,
                4,
                128,
                99,
                0,
                4,
                60,
                160,
                16,
                4,
                56,
                128,
                0,
                0,
                48,
                165,
                0,
                16,
                75,
                232,
                178,
                125,
                56,
                96,
                0,
                0,
                60,
                128,
                16,
                4,
                144,
                100,
                0,
                0,
                60,
                96,
                16,
                5,
                128,
                99,
                0,
                0,
                44,
                3,
                0,
                0,
                65,
                130,
                0,
                36,
                60,
                96,
                16,
                5,
                48,
                99,
                0,
                16,
                75,
                226,
                249,
                125,
                60,
                128,
                16,
                5,
                144,
                100,
                0,
                4,
                56,
                96,
                0,
                0,
                60,
                128,
                16,
                5,
                144,
                100,
                0,
                0,
                60,
                96,
                16,
                3,
                128,
                99,
                0,
                4,
                96,
                98,
                0,
                0,
                232,
                1,
                0,
                176,
                124,
                8,
                3,
                166,
                56,
                33,
                0,
                160,
                78,
                128,
                0,
                32
            };
            byte[] buffer2 = new byte[]
            {
                129,
                98,
                146,
                132,
                124,
                8,
                2,
                166,
                248,
                33,
                byte.MaxValue,
                1,
                251,
                225,
                0,
                184,
                219,
                1,
                0,
                192,
                124,
                127,
                27,
                120,
                219,
                33,
                0,
                200,
                219,
                65,
                0,
                208,
                219,
                97,
                0,
                216,
                219,
                129,
                0,
                224,
                219,
                161,
                0,
                232,
                219,
                193,
                0,
                240,
                219,
                225,
                0,
                248,
                251,
                97,
                0,
                152,
                251,
                129,
                0,
                160,
                251,
                161,
                0,
                168,
                251,
                193,
                0,
                176,
                248,
                1,
                1,
                16,
                129,
                43,
                0,
                0,
                136,
                9,
                0,
                12,
                47,
                128,
                0,
                0,
                64,
                158,
                0,
                100,
                124,
                105,
                27,
                120,
                192,
                2,
                146,
                148,
                193,
                162,
                146,
                136,
                212,
                9,
                2,
                64,
                208,
                9,
                0,
                12,
                209,
                169,
                0,
                4,
                208,
                9,
                0,
                8,
                232,
                1,
                1,
                16,
                235,
                97,
                0,
                152,
                235,
                129,
                0,
                160,
                124,
                8,
                3,
                166,
                235,
                161,
                0,
                168,
                235,
                193,
                0,
                176,
                235,
                225,
                0,
                184,
                203,
                1,
                0,
                192,
                203,
                33,
                0,
                200
            };
            if (Active)
            {
                PS3.SetMemory(3730920u, buffer);
            }
            else
            {
                PS3.SetMemory(3730920u, buffer2);
            }
        }

        // Token: 0x0600017C RID: 380 RVA: 0x000276A0 File Offset: 0x000258A0
        public static uint G_LocalizedString(string input)
        {
            MW2RPC.WritePoweMW2RPC(true);
            PS3.Extension.WriteString(268763152u, input);
            PS3.Extension.WriteBool(268763139u, true);
            uint num;
            do
            {
                num = PS3.Extension.ReadUInt32(268763140u);
            }
            while (num == 0u);
            PS3.Extension.WriteUInt32(268763140u, 0u);
            while (PS3.Extension.ReadBool(268763139u))
            {
            }
            MW2RPC.WritePoweMW2RPC(false);
            return num;
        }

        // Token: 0x0600017D RID: 381 RVA: 0x00027744 File Offset: 0x00025944
        public static uint G_MaterialIndex(string shader)
        {
            return (uint)MW2RPC.Call(1828696u, new object[]
            {
                shader
            });
        }

        // Token: 0x0600017E RID: 382 RVA: 0x0002776C File Offset: 0x0002596C
        private static byte[] ReverseBytes(byte[] inArray)
        {
            Array.Reverse(inArray);
            return inArray;
        }

        // Token: 0x0600017F RID: 383 RVA: 0x00027788 File Offset: 0x00025988
        public static void WriteSingle(uint address, float[] input)
        {
            int num = input.Length;
            byte[] array = new byte[num * 4];
            for (int i = 0; i < num; i++)
            {
                MW2RPC.ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, i * 4);
            }
            PS3.SetMemory(address, array);
        }

        // Token: 0x06000180 RID: 384 RVA: 0x000277DC File Offset: 0x000259DC
        public static short G_LocalizedStringIndex(string Text)
        {
            Thread.Sleep(100);
            uint func_address = 1828808u;
            object[] parameters = new object[]
            {
                Text
            };
            return (short)MW2RPC.Call(func_address, parameters);
        }

        // Token: 0x06000181 RID: 385 RVA: 0x00027810 File Offset: 0x00025A10
        public static void ChangeText(uint elemIndex, string Text)
        {
            uint hudElem_Alloc = MW2RPC.Offsets.HudElem_Alloc;
            PS3.Extension.WriteInt32(elemIndex + MW2RPC.HudStruct.textOffset, (int)MW2RPC.G_LocalizedStringIndex(Text));
        }

        // Token: 0x06000182 RID: 386 RVA: 0x00027841 File Offset: 0x00025A41
        public static void ChangeAlpha(uint elemIndex, byte Alpha)
        {
            MW2RPC.WriteByte(elemIndex + MW2RPC.HudStructLib.color + 3u, Alpha);
        }

        // Token: 0x06000183 RID: 387 RVA: 0x00027854 File Offset: 0x00025A54
        public static void WriteByte(uint address, byte input)
        {
            PS3.SetMemory(address, new byte[]
            {
                input
            });
        }

        // Token: 0x06000184 RID: 388 RVA: 0x00027870 File Offset: 0x00025A70
        public static void Huds_DestroyAll()
        {
            uint num = 120u;
            PS3.SetMemory(19830872u + num * 180u, new byte[180u * (1024u - num)]);
        }

        // Token: 0x06000185 RID: 389 RVA: 0x000278AC File Offset: 0x00025AAC
        public static uint client_s(int clientIndex)
        {
            return (uint)(880017408 + 622464 * clientIndex);
        }

        // Token: 0x06000186 RID: 390 RVA: 0x000278CC File Offset: 0x00025ACC
        public static uint G_Entity(int clientIndex)
        {
            return (uint)(20027392 + 640 * clientIndex);
        }

        // Token: 0x06000187 RID: 391 RVA: 0x000278EC File Offset: 0x00025AEC
        public static uint G_Client(int clientIndex)
        {
            return (uint)(21897728 + 14080 * clientIndex);
        }

        // Token: 0x06000188 RID: 392 RVA: 0x0002790C File Offset: 0x00025B0C
        public static uint SetText(int clientIndex, string TextString, int Font, float fontScale, float X, float Y, int align = 0, int r = 255, int g = 255, int b = 255, int a = 255, int glowr = 255, int glowg = 255, int glowb = 255, int glowa = 0)
        {
            uint num = MW2RPC.HudElem_Alloc();
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.type, 1);
            PS3.Extension.WriteFloat(num + MW2RPC.HudStructLib.fontScale, fontScale);
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.font, Font);
            bool flag = align == 0;
            if (flag)
            {
                PS3.Extension.WriteFloat(num + MW2RPC.HudStructLib.X, X);
                PS3.Extension.WriteFloat(num + MW2RPC.HudStructLib.Y, Y);
            }
            else
            {
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.alignOrg, 5);
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.alignScreen, align);
            }
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.clientIndex, clientIndex);
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.text, (int)MW2RPC.G_LocalizedStringIndex(TextString));
            uint offset = num + MW2RPC.HudStructLib.color;
            byte[] input = new byte[]
            {
                (byte)r,
                (byte)g,
                (byte)b,
                (byte)a
            };
            PS3.Extension.WriteBytes(offset, input);
            uint offset2 = num + MW2RPC.HudStructLib.glowColor;
            input = new byte[]
            {
                (byte)glowr,
                (byte)glowg,
                (byte)glowb,
                (byte)glowa
            };
            PS3.Extension.WriteBytes(offset2, input);
            return num;
        }

        // Token: 0x06000189 RID: 393 RVA: 0x00027A8C File Offset: 0x00025C8C
        public static int getMaterialIndex(string Material)
        {
            return MW2RPC.Call(MW2RPC.Offsets.G_MaterialIndex, new object[]
            {
                Material
            });
        }

        // Token: 0x0600018A RID: 394 RVA: 0x00027AB4 File Offset: 0x00025CB4
        public static int precacheShader(string Shader)
        {
            PS3.Extension.WriteInt32(MW2RPC.Offsets.AllowPrecache, 1);
            uint g_MaterialIndex = MW2RPC.Offsets.G_MaterialIndex;
            object[] parameters = new object[]
            {
                Shader
            };
            int result = MW2RPC.Call(g_MaterialIndex, parameters);
            PS3.Extension.WriteInt32(MW2RPC.Offsets.AllowPrecache, 0);
            return result;
        }

        // Token: 0x0600018B RID: 395 RVA: 0x00027B0C File Offset: 0x00025D0C
        public static uint SetShader(int clientIndex, object Material, short Width, short Height, float X, float Y, int align = 0, int r = 255, int g = 255, int b = 255, int a = 255)
        {
            uint num = MW2RPC.HudElem_Alloc();
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.type, (int)MW2RPC.HudTypes.Shader);
            bool flag = Material is string;
            if (flag)
            {
                MW2RPC.precacheShader((string)Material);
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.materialIndex, MW2RPC.getMaterialIndex((string)Material));
            }
            bool flag2 = Material is int;
            if (flag2)
            {
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.materialIndex, (int)Material);
            }
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.height, (int)Height);
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.width, (int)Width);
            bool flag3 = align == 0;
            if (flag3)
            {
                PS3.Extension.WriteFloat(num + MW2RPC.HudStructLib.X, X);
                PS3.Extension.WriteFloat(num + MW2RPC.HudStructLib.Y, Y);
            }
            else
            {
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.alignOrg, 5);
                PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.alignScreen, align);
            }
            PS3.Extension.WriteInt32(num + MW2RPC.HudStructLib.clientIndex, clientIndex);
            uint offset = num + MW2RPC.HudStructLib.color;
            byte[] input = new byte[]
            {
                (byte)r,
                (byte)g,
                (byte)b,
                (byte)a
            };
            PS3.Extension.WriteBytes(offset, input);
            return num;
        }

        // Token: 0x0600018C RID: 396 RVA: 0x00027CA4 File Offset: 0x00025EA4
        public static uint SetTypewriter(int clientIndex, string Text, int Font, float FontSize, float X, float Y, int align, ushort Lettertime = 200, ushort fxDecayStartTime = 7000, ushort fxDecayDuration = 1000, int r = 255, int g = 255, int b = 255, int a = 255, int glowr = 255, int glowg = 255, int glowb = 255, int glowa = 0)
        {
            uint num = MW2RPC.SetText(clientIndex, Text, Font, FontSize, X, Y, align, r, g, b, a, glowr, glowg, glowb, glowa);
            PS3.Extension.WriteUInt32(num + MW2RPC.HudStructLib.fxBirthTime, (uint)MW2RPC.getLevelTime());
            PS3.Extension.WriteUInt32(num + MW2RPC.HudStructLib.fxLetterTime, (uint)Lettertime);
            PS3.Extension.WriteUInt32(num + MW2RPC.HudStructLib.fxDecayStartTime, (uint)fxDecayStartTime);
            PS3.Extension.WriteUInt32(num + MW2RPC.HudStructLib.fxDecayDuration, (uint)fxDecayDuration);
            return num;
        }

        // Token: 0x0600018D RID: 397 RVA: 0x00027D40 File Offset: 0x00025F40
        public static uint G_Client(int clientIndex, uint Mod)
        {
            return MW2RPC.Offsets.G_Client + Mod + (uint)(clientIndex * (int)MW2RPC.HudStruct.clientIndex);
        }

        // Token: 0x0600018E RID: 398 RVA: 0x00027D64 File Offset: 0x00025F64
        private static uint FPS(uint Offset = 0u)
        {
            return 2439880u + Offset;
        }

        // Token: 0x0600018F RID: 399 RVA: 0x00027D7D File Offset: 0x00025F7D
        public static void ToggleON()
        {
            PS3.Extension.WriteByte(MW2RPC.FPS(0u), 64);
        }

        // Token: 0x06000190 RID: 400 RVA: 0x00027D98 File Offset: 0x00025F98
        public static void ToggleOFF()
        {
            PS3.Extension.WriteByte(MW2RPC.FPS(0u), 65);
            MW2RPC.Write(" ", (double)Convert.ToSingle(0.5f), 25f, 25f);
            byte[] buffer = new byte[]
            {
                102,
                112,
                115,
                58,
                32,
                37,
                102,
                0,
                102,
                97,
                100,
                101,
                105,
                110,
                0,
                0,
                102,
                97,
                100,
                101,
                111,
                117,
                116,
                0,
                115,
                104,
                111,
                119,
                0,
                0,
                0,
                0,
                104,
                105,
                100,
                101,
                0,
                0,
                0,
                0,
                115,
                104,
                111,
                119,
                77,
                101,
                110,
                117,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                104,
                105,
                100,
                101,
                77,
                101,
                110,
                117,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                99,
                111,
                108,
                111,
                114,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                111,
                112,
                101,
                110,
                0,
                0,
                0,
                0,
                99,
                108,
                111,
                115,
                101,
                0,
                0,
                0,
                99,
                108,
                111,
                115,
                101,
                70,
                111,
                114,
                65,
                108,
                108,
                80,
                108,
                97,
                121,
                101,
                114,
                115,
                0,
                0,
                0,
                0,
                0,
                0,
                105,
                110,
                103,
                97,
                109,
                101,
                111,
                112,
                101,
                110,
                0,
                0,
                0,
                0,
                0,
                0,
                105,
                110,
                103,
                97,
                109,
                101,
                99,
                108,
                111,
                115,
                101,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                98,
                97,
                99,
                107,
                103,
                114,
                111,
                117,
                110,
                100,
                0,
                0,
                0,
                115,
                101,
                116,
                105,
                116,
                101,
                109,
                99,
                111,
                108,
                111,
                114,
                0,
                0,
                0,
                0,
                102,
                111,
                99,
                117,
                115,
                102,
                105,
                114,
                115,
                116,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                102,
                111,
                99,
                117,
                115,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                102,
                111,
                99,
                117,
                115,
                98,
                121,
                100,
                118,
                97,
                114,
                0,
                0,
                115,
                101,
                116,
                100,
                118,
                97,
                114,
                0,
                101,
                120,
                101,
                99,
                0,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                110,
                111,
                119,
                0,
                101,
                120,
                101,
                99,
                79,
                110,
                68,
                118,
                97,
                114,
                83,
                116,
                114,
                105,
                110,
                103,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                79,
                110,
                68,
                118,
                97,
                114,
                73,
                110,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                79,
                110,
                68,
                118,
                97,
                114,
                70,
                108,
                111,
                97,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                78,
                111,
                119,
                79,
                110,
                68,
                118,
                97,
                114,
                83,
                116,
                114,
                105,
                110,
                103,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                78,
                111,
                119,
                79,
                110,
                68,
                118,
                97,
                114,
                73,
                110,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                101,
                120,
                101,
                99,
                78,
                111,
                119,
                79,
                110,
                68,
                118,
                97,
                114,
                70,
                108,
                111,
                97,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                112,
                108,
                97,
                121,
                0,
                0,
                0,
                0,
                115,
                99,
                114,
                105,
                112,
                116,
                109,
                101,
                110,
                117,
                114,
                101,
                115,
                112,
                111,
                110,
                115,
                101,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                99,
                114,
                105,
                112,
                116,
                77,
                101,
                110,
                117,
                82,
                101,
                115,
                112,
                111,
                110,
                100,
                79,
                110,
                68,
                118,
                97,
                114,
                83,
                116,
                114,
                105,
                110,
                103,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                99,
                114,
                105,
                112,
                116,
                77,
                101,
                110,
                117,
                82,
                101,
                115,
                112,
                111,
                110,
                100,
                79,
                110,
                68,
                118,
                97,
                114,
                73,
                110,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                115,
                99,
                114,
                105,
                112,
                116,
                77,
                101,
                110,
                117,
                82,
                101,
                115,
                112,
                111,
                110,
                100,
                79,
                110,
                68,
                118,
                97,
                114,
                70,
                108,
                111,
                97,
                116,
                86,
                97,
                108,
                117,
                101,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                80,
                108,
                97,
                121,
                101,
                114,
                68,
                97,
                116,
                97,
                0,
                0,
                0,
                115,
                101,
                116,
                80,
                108,
                97,
                121,
                101,
                114,
                68,
                97,
                116,
                97,
                83,
                112,
                108,
                105,
                116,
                83,
                99,
                114,
                101,
                101,
                110,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                117,
                112,
                100,
                97,
                116,
                101,
                77,
                97,
                105,
                108,
                0,
                0,
                0,
                0,
                0,
                0,
                111,
                112,
                101,
                110,
                77,
                97,
                105,
                108,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                100,
                101,
                108,
                101,
                116,
                101,
                77,
                97,
                105,
                108,
                0,
                0,
                0,
                0,
                0,
                0,
                100,
                111,
                77,
                97,
                105,
                108,
                76,
                111,
                116,
                116,
                101,
                114,
                121,
                0,
                0,
                0,
                114,
                101,
                115,
                101,
                116,
                83,
                116,
                97,
                116,
                115,
                67,
                111,
                110,
                102,
                105,
                114,
                109,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                114,
                101,
                115,
                101,
                116,
                83,
                116,
                97,
                116,
                115,
                67,
                97,
                110,
                99,
                101,
                108,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                71,
                97,
                109,
                101,
                77,
                111,
                100,
                101,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                76,
                111,
                99,
                97,
                108,
                86,
                97,
                114,
                66,
                111,
                111,
                108,
                0,
                115,
                101,
                116,
                76,
                111,
                99,
                97,
                108,
                86,
                97,
                114,
                73,
                110,
                116,
                0,
                0,
                115,
                101,
                116,
                76,
                111,
                99,
                97,
                108,
                86,
                97,
                114,
                70,
                108,
                111,
                97,
                116,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                115,
                101,
                116,
                76,
                111,
                99,
                97,
                108
            };
            PS3.SetMemory(5731696u, buffer);
            byte[] buffer2 = new byte[]
            {
                208,
                29,
                0,
                0,
                193,
                190,
                0,
                4,
                193,
                157,
                0,
                4,
                209,
                189,
                0,
                4,
                192,
                30,
                0,
                8,
                193,
                189,
                0,
                8,
                208,
                29,
                0,
                8,
                129,
                61,
                0,
                12,
                128,
                30,
                0,
                12,
                144,
                29,
                0,
                12,
                145,
                62,
                0,
                12,
                209,
                190,
                0,
                8,
                209,
                158,
                0,
                4,
                209,
                126,
                0,
                0,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                127,
                195,
                243,
                120,
                127,
                132,
                227,
                120,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                84,
                99,
                6,
                62,
                47,
                131,
                0,
                0,
                65,
                158,
                0,
                68,
                192,
                28,
                0,
                0,
                193,
                158,
                0,
                0,
                208,
                30,
                0,
                0,
                193,
                188,
                0,
                4,
                193,
                126,
                0,
                4,
                209,
                190,
                0,
                4,
                192,
                28,
                0,
                8,
                193,
                190,
                0,
                8,
                208,
                30,
                0,
                8,
                129,
                62,
                0,
                12,
                128,
                28,
                0,
                12,
                144,
                30,
                0,
                12,
                209,
                156,
                0,
                0,
                145,
                60,
                0,
                12,
                209,
                188,
                0,
                8,
                209,
                124,
                0,
                4,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                127,
                227,
                251,
                120,
                127,
                68,
                211,
                120,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                84,
                99,
                6,
                62,
                47,
                131,
                0,
                0,
                65,
                158,
                0,
                68,
                192,
                26,
                0,
                0,
                193,
                127,
                0,
                0,
                208,
                31,
                0,
                0,
                193,
                186,
                0,
                4,
                193,
                159,
                0,
                4,
                209,
                191,
                0,
                4,
                192,
                26,
                0,
                8,
                193,
                191,
                0,
                8,
                208,
                31,
                0,
                8,
                129,
                63,
                0,
                12,
                128,
                26,
                0,
                12,
                144,
                31,
                0,
                12,
                145,
                58,
                0,
                12,
                209,
                186,
                0,
                8,
                209,
                154,
                0,
                4,
                209,
                122,
                0,
                0,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                127,
                195,
                243,
                120,
                127,
                228,
                251,
                120,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                84,
                99,
                6,
                62,
                47,
                131,
                0,
                0,
                65,
                158,
                0,
                68,
                192,
                31,
                0,
                0,
                193,
                126,
                0,
                0,
                208,
                30,
                0,
                0,
                193,
                191,
                0,
                4,
                193,
                158,
                0,
                4,
                209,
                190,
                0,
                4,
                192,
                31,
                0,
                8,
                193,
                190,
                0,
                8,
                208,
                30,
                0,
                8,
                129,
                62,
                0,
                12,
                128,
                31,
                0,
                12,
                144,
                30,
                0,
                12,
                145,
                63,
                0,
                12,
                209,
                191,
                0,
                8,
                209,
                159,
                0,
                4,
                209,
                127,
                0,
                0,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                127,
                227,
                251,
                120,
                127,
                68,
                211,
                120,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                84,
                99,
                6,
                62,
                47,
                131,
                0,
                0,
                65,
                158,
                0,
                68,
                192,
                26,
                0,
                0,
                193,
                159,
                0,
                0,
                208,
                31,
                0,
                0,
                193,
                186,
                0,
                4,
                193,
                127,
                0,
                4,
                209,
                191,
                0,
                4,
                192,
                26,
                0,
                8,
                193,
                191,
                0,
                8,
                208,
                31,
                0,
                8,
                129,
                63,
                0,
                12,
                128,
                26,
                0,
                12,
                144,
                31,
                0,
                12,
                209,
                154,
                0,
                0,
                145,
                58,
                0,
                12,
                209,
                186,
                0,
                8,
                209,
                122,
                0,
                4,
                127,
                152,
                200,
                64,
                58,
                249,
                0,
                16,
                65,
                156,
                0,
                52,
                72,
                0,
                7,
                144,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                127,
                24,
                200,
                64,
                84,
                99,
                6,
                62,
                47,
                131,
                0,
                0,
                64,
                158,
                0,
                80,
                64,
                152,
                7,
                100,
                56,
                25,
                byte.MaxValue,
                240,
                248,
                65,
                0,
                40,
                120,
                29,
                0,
                32,
                129,
                59,
                0,
                0,
                127,
                228,
                251,
                120,
                128,
                91,
                0,
                4,
                125,
                41,
                3,
                166,
                127,
                163,
                235,
                120,
                127,
                58,
                203,
                120,
                124,
                25,
                3,
                120,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                127,
                164,
                235,
                120,
                84,
                96,
                6,
                62,
                127,
                227,
                251,
                120,
                47,
                128,
                0,
                0,
                127,
                191,
                235,
                120,
                65,
                158,
                byte.MaxValue,
                144,
                127,
                150,
                184,
                64,
                126,
                224,
                187,
                120,
                123,
                94,
                0,
                32,
                65,
                157,
                0,
                60,
                72,
                0,
                0,
                108,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                56,
                23,
                0,
                16,
                84,
                99,
                6,
                62,
                127,
                22,
                0,
                64,
                47,
                131,
                0,
                0,
                64,
                158,
                0,
                64,
                124,
                23,
                3,
                120,
                64,
                153,
                6,
                248,
                248,
                65,
                0,
                40,
                120,
                3,
                0,
                32,
                128,
                27,
                0,
                0,
                127,
                196,
                243,
                120,
                128,
                91,
                0,
                4,
                124,
                9,
                3,
                166,
                78,
                128,
                4,
                33,
                232,
                65,
                0,
                40,
                122,
                228,
                0,
                32,
                84,
                96,
                6,
                62,
                127,
                195,
                243,
                120,
                47,
                128,
                0,
                0,
                65,
                158,
                byte.MaxValue,
                156,
                126,
                249,
                187,
                120,
                127,
                92,
                211,
                120,
                127,
                150,
                200,
                64,
                65,
                157,
                1,
                60,
                127,
                152,
                224,
                64,
                123,
                94,
                0,
                32,
                65,
                156,
                0,
                20,
                72,
                0,
                1,
                228,
                127,
                152,
                248,
                64,
                127,
                252,
                251,
                120,
                64,
                156,
                0,
                184,
                59,
                252,
                byte.MaxValue,
                240,
                248,
                65,
                0,
                40,
                128,
                27,
                0,
                0
            };
            PS3.SetMemory(5068508u, buffer2);
        }

        // Token: 0x06000191 RID: 401 RVA: 0x00027E2C File Offset: 0x0002602C
        public static void Write(string Text, double FontSize, float X, float Y)
        {
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.Size), (float)FontSize);
            PS3.Extension.WriteString(MW2RPC.FPS(MW2RPC.Struct.Text), Text);
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.xPosition), X);
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.yPosition), Y);
        }

        // Token: 0x06000192 RID: 402 RVA: 0x00027EA7 File Offset: 0x000260A7
        public static void WriteTxt(string Text)
        {
            PS3.Extension.WriteString(MW2RPC.FPS(MW2RPC.Struct.Text), Text);
        }

        // Token: 0x06000193 RID: 403 RVA: 0x00027EC5 File Offset: 0x000260C5
        public static void WriteSize(float FontSize)
        {
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.Size), FontSize);
        }

        // Token: 0x06000194 RID: 404 RVA: 0x00027EE3 File Offset: 0x000260E3
        public static void WritePos(float X, float Y)
        {
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.xPosition), X);
            PS3.Extension.WriteFloat(MW2RPC.FPS(MW2RPC.Struct.yPosition), Y);
        }

        // Token: 0x06000195 RID: 405 RVA: 0x00027F1C File Offset: 0x0002611C
        public static int getHostNum()
        {
            bool flag = MW2RPC.inMP();
            int result;
            if (flag)
            {
                result = (int)PS3.Extension.ReadByte(10570599u);
            }
            else
            {
                result = 0;
            }
            return result;
        }

        // Token: 0x06000196 RID: 406 RVA: 0x00027F50 File Offset: 0x00026150
        public static bool onlineMatch()
        {
            return PS3.Extension.ReadInt32(913524184u) != 0;
        }

        // Token: 0x06000197 RID: 407 RVA: 0x00027F84 File Offset: 0x00026184
        public static string getName(int client)
        {
            return PS3.Extension.ReadString((uint)(21910672 + client * 14080));
        }

        // Token: 0x06000198 RID: 408 RVA: 0x00027FB4 File Offset: 0x000261B4
        public static void setName(int client, string txt)
        {
            bool flag = MW2RPC.getName(client) != "";
            if (flag)
            {
                PS3.Extension.WriteString((uint)(21910672 + client * 14080), txt + "\0");
            }
        }

        // Token: 0x06000199 RID: 409 RVA: 0x00028000 File Offset: 0x00026200
        public static bool NonHostButtonPressed(uint Button)
        {
            return PS3.Extension.ReadByte(9814154u + Button) == 1;
        }

        // Token: 0x0600019A RID: 410 RVA: 0x00028038 File Offset: 0x00026238
        public static bool L1Press(int client)
        {
            return PS3.Extension.ReadByte((uint)(21911085 + 14080 * client)) == 8;
        }

        // Token: 0x0600019B RID: 411 RVA: 0x00028074 File Offset: 0x00026274
        public static bool sqPress(int client)
        {
            return PS3.Extension.ReadByte((uint)(21911099 + 14080 * client)) == 32;
        }

        // Token: 0x0600019C RID: 412 RVA: 0x000280B0 File Offset: 0x000262B0
        public static bool L2Press(int client)
        {
            return PS3.Extension.ReadByte((uint)(21910454 + 14080 * client)) == 128;
        }

        // Token: 0x0600019D RID: 413 RVA: 0x000280F0 File Offset: 0x000262F0
        public static bool R2Press(int client)
        {
            return PS3.Extension.ReadByte((uint)(21910454 + 14080 * client)) == 64;
        }

        // Token: 0x0600019E RID: 414 RVA: 0x0002812C File Offset: 0x0002632C
        public static bool ButtonPressed(int client, string Button)
        {
            bool flag = MW2RPC.inMP();
            bool result;
            if (flag)
            {
                bool flag2 = PS3.Extension.ReadString((uint)(880086687 + client * 622464)) == Button;
                result = flag2;
            }
            else
            {
                bool flag3 = PS3.Extension.ReadString((uint)(880152223 + client * 622464)) == Button;
                result = flag3;
            }
            return result;
        }

        // Token: 0x0600019F RID: 415 RVA: 0x000281A4 File Offset: 0x000263A4
        public static bool L1_R3(int client)
        {
            return PS3.Extension.ReadByte((uint)(880086641 + client * 622464)) == 8 && PS3.Extension.ReadByte((uint)(880086643 + client * 622464)) == 4;
        }

        // Token: 0x060001A0 RID: 416 RVA: 0x00028200 File Offset: 0x00026400
        public static bool inMP()
        {
            return PS3.Extension.ReadBool(10556540u);
        }

        // Token: 0x060001A1 RID: 417 RVA: 0x00028228 File Offset: 0x00026428
        public static string KeyBoard(string Title, string PresetText = "", int MaxLength = 20)
        {
            MW2RPC.Call(2326640u, new object[]
            {
                0,
                Title,
                PresetText,
                MaxLength,
                7386328
            });
            while (PS3.Extension.ReadInt32(33797320u) != 0)
            {
            }
            return PS3.Extension.ReadString(38866466u);
        }

        // Token: 0x060001A2 RID: 418 RVA: 0x000282A8 File Offset: 0x000264A8
        public static bool IsMW2()
        {
            foreach (string a in new string[]
            {
                "BLUS30377",
                "BLKS20159",
                "BLES00683",
                "BLES00686",
                "BLES00685",
                "BLES00684",
                "BLES00687"
            })
            {
                bool flag = a == PS3.Extension.ReadString(268501585u);
                if (flag)
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x060001A3 RID: 419 RVA: 0x00028334 File Offset: 0x00026534
        public static void KFnotify(string txt)
        {
            PS3.SetMemory(831347463u, Encoding.ASCII.GetBytes("&&1\0"));
            PS3.SetMemory(33574912u, Encoding.UTF8.GetBytes("\nset CbufFIX \"set CbufFIX vstr CbufFIXoff;\\\"" + txt + "\\\".\"\0"));
            PS3.SetMemory(2439864u, new byte[]
            {
                56,
                96,
                0,
                0,
                60,
                128,
                2,
                0,
                48,
                132,
                80,
                0,
                75,
                248,
                99,
                253
            });
            Thread.Sleep(100);
            PS3.SetMemory(33574912u, Encoding.UTF8.GetBytes("\nvstr CbufFIX;\0"));
            Thread.Sleep(100);
            PS3.SetMemory(2439864u, new byte[]
            {
                129,
                34,
                69,
                16,
                129,
                105,
                0,
                0,
                136,
                11,
                0,
                12,
                47,
                128,
                0,
                0
            });
        }

        // Token: 0x060001A4 RID: 420 RVA: 0x00028400 File Offset: 0x00026600
        public static void cBuff_AddText_Fix(string dvar)
        {
            PS3.SetMemory(33574912u, Encoding.UTF8.GetBytes("\nset CbufFIX \"set CbufFIX vstr CbufFIXoff;" + dvar + "\"\0"));
            PS3.SetMemory(2439864u, new byte[]
            {
                56,
                96,
                0,
                0,
                60,
                128,
                2,
                0,
                48,
                132,
                80,
                0,
                75,
                248,
                99,
                253
            });
            Thread.Sleep(100);
            PS3.SetMemory(33574912u, Encoding.UTF8.GetBytes("\nvstr CbufFIX;\0"));
            Thread.Sleep(100);
            PS3.SetMemory(2439864u, new byte[]
            {
                129,
                34,
                69,
                16,
                129,
                105,
                0,
                0,
                136,
                11,
                0,
                12,
                47,
                128,
                0,
                0
            });
        }

        // Token: 0x060001A5 RID: 421 RVA: 0x000284AC File Offset: 0x000266AC
        public static void cBuff_AddText_Reg(string dvar)
        {
            PS3.SetMemory(33574912u, Encoding.UTF8.GetBytes(dvar + ";\0"));
            PS3.SetMemory(2439864u, new byte[]
            {
                56,
                96,
                0,
                0,
                60,
                128,
                2,
                0,
                48,
                132,
                80,
                0,
                75,
                248,
                99,
                253
            });
            Thread.Sleep(15);
            PS3.SetMemory(2439864u, new byte[]
            {
                129,
                34,
                69,
                16,
                129,
                105,
                0,
                0,
                136,
                11,
                0,
                12,
                47,
                128,
                0,
                0
            });
        }

        // Token: 0x060001A6 RID: 422 RVA: 0x0002852B File Offset: 0x0002672B
        public static void cBuff_AddText_MW2RPC(string dvar)
        {
            MW2RPC.Call(1941184u, new object[]
            {
                1,
                dvar
            });
        }

        // Token: 0x060001A7 RID: 423 RVA: 0x0002854C File Offset: 0x0002674C
        public static void SV_GameSendServerCommand(int clientIndex, string Cmd)
        {
            MW2RPC.Call(2203808u, new object[]
            {
                clientIndex,
                0,
                Cmd
            });
        }

        // Token: 0x060001A8 RID: 424 RVA: 0x00028576 File Offset: 0x00026776
        public static void setClientDvar(int clientNumber, string dvar, string Val)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, string.Concat(new string[]
            {
                "v ",
                dvar,
                " \"",
                Val,
                "\""
            }));
        }

        // Token: 0x060001A9 RID: 425 RVA: 0x000285AB File Offset: 0x000267AB
        public static void setClientJustDvar(int clientNumber, string dvar)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, "v " + dvar);
        }

        // Token: 0x060001AA RID: 426 RVA: 0x000285C0 File Offset: 0x000267C0
        public static void iPrintln(int clientNumber, string Txt)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, "f \"" + Txt + "\"");
        }

        // Token: 0x060001AB RID: 427 RVA: 0x000285DA File Offset: 0x000267DA
        public static void iPrintlnBold(int clientNumber, string Txt)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, "g \"" + Txt + "\"");
        }

        // Token: 0x060001AC RID: 428 RVA: 0x000285F4 File Offset: 0x000267F4
        public static void Notivation(int clientNumber, string Txt)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, "g \"                                                                      " + Txt + "\"");
        }

        // Token: 0x060001AD RID: 429 RVA: 0x0002860E File Offset: 0x0002680E
        public static void playSound(int clientNumber, string soundName)
        {
            MW2RPC.SV_GameSendServerCommand(clientNumber, "o \"" + soundName + "\"");
        }

        // Token: 0x060001AE RID: 430 RVA: 0x00028628 File Offset: 0x00026828
        public static void SV_SendServerCommand(int clientIndex, string Command)
        {
            MW2RPC.WritePoweMW2RPC(true);
            PS3.Extension.WriteString(268697616u, Command);
            PS3.Extension.WriteInt32(268697604u, clientIndex);
            PS3.Extension.WriteBool(268697603u, true);
            while (PS3.Extension.ReadBool(268697603u))
            {
            }
            MW2RPC.WritePoweMW2RPC(false);
        }

        // Token: 0x060001AF RID: 431 RVA: 0x000286A4 File Offset: 0x000268A4
        public static string getDetails(string type)
        {
            string text = PS3.Extension.ReadString(MW2RPC.Offsets.ServerDetails);
            string[] array = text.Split(new char[]
            {
                '\\'
            });
            int length = text.Length;
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = array[i] == type;
                if (flag)
                {
                    i++;
                    num = i;
                }
            }
            return array[num];
        }

        // Token: 0x060001B0 RID: 432 RVA: 0x00028720 File Offset: 0x00026920
        public static bool inGame()
        {
            return PS3.Extension.ReadByte(24752431u) > 0;
        }

        // Token: 0x060001B1 RID: 433 RVA: 0x00028754 File Offset: 0x00026954
        private static string ReturnInfos(int Index)
        {
            byte[] array = new byte[564];
            PS3.GetMemory(24794336u, array);
            return Encoding.ASCII.GetString(array).Replace("\\", "|").Split(new char[]
            {
                '|'
            })[Index];
        }

        // Token: 0x060001B2 RID: 434 RVA: 0x000287B0 File Offset: 0x000269B0
        private static string OnlineInfos(int Index)
        {
            byte[] array = new byte[564];
            PS3.GetMemory(10134233u, array);
            return Encoding.ASCII.GetString(array).Replace("\\", "|").Split(new char[]
            {
                '|'
            })[Index];
        }

        // Token: 0x060001B3 RID: 435 RVA: 0x0002880C File Offset: 0x00026A0C
        private static bool Online()
        {
            return MW2RPC.ReturnInfos(1) == "cg_predictItems";
        }

        // Token: 0x060001B4 RID: 436 RVA: 0x0002883C File Offset: 0x00026A3C
        public static string getHostName()
        {
            bool flag = MW2RPC.inGame();
            string result;
            if (flag)
            {
                bool flag2 = MW2RPC.Online();
                if (flag2)
                {
                    result = MW2RPC.ReturnInfos(8);
                }
                else
                {
                    result = MW2RPC.ReturnInfos(16);
                }
            }
            else
            {
                result = "Not in game";
            }
            return result;
        }

        // Token: 0x060001B5 RID: 437 RVA: 0x0002887C File Offset: 0x00026A7C
        public static string getMaxPlayers()
        {
            bool flag = MW2RPC.inGame();
            string result;
            if (flag)
            {
                bool flag2 = MW2RPC.Online();
                if (flag2)
                {
                    result = MW2RPC.OnlineInfos(18);
                }
                else
                {
                    result = MW2RPC.ReturnInfos(18);
                }
            }
            else
            {
                result = "Not in game";
            }
            return result;
        }

        // Token: 0x060001B6 RID: 438 RVA: 0x000288C0 File Offset: 0x00026AC0

        // Token: 0x060001B7 RID: 439 RVA: 0x00028C1C File Offset: 0x00026E1C
        public static string getHardcore()
        {
            bool flag = MW2RPC.inGame();
            string result;
            if (flag)
            {
                bool flag2 = MW2RPC.Online();
                if (flag2)
                {
                    string a = MW2RPC.OnlineInfos(4);
                    if (!(a == "20000"))
                    {
                        if (!(a == "0"))
                        {
                            if (!(a == "1"))
                            {
                                result = "Unknown Gametype";
                            }
                            else
                            {
                                result = "On";
                            }
                        }
                        else
                        {
                            result = "Off";
                        }
                    }
                    else
                    {
                        result = "Loading Game";
                    }
                }
                else
                {
                    string a2 = MW2RPC.ReturnInfos(4);
                    if (!(a2 == "20000"))
                    {
                        if (!(a2 == "0"))
                        {
                            if (!(a2 == "1"))
                            {
                                result = "Unknown Gametype";
                            }
                            else
                            {
                                result = "On";
                            }
                        }
                        else
                        {
                            result = "Off";
                        }
                    }
                    else
                    {
                        result = "Loading Game";
                    }
                }
            }
            else
            {
                result = "Not in game";
            }
            return result;
        }

        // Token: 0x060001B8 RID: 440 RVA: 0x00028CF0 File Offset: 0x00026EF0
        public static string get_MapName()
        {
            string text = PS3.Extension.ReadString(13932020u);
            string result = "Not in game";
            bool flag = MW2RPC.inGame();
            if (flag)
            {
                bool flag2 = text.Contains("afghan");
                if (flag2)
                {
                    result = "Afghan";
                }
                bool flag3 = text.Contains("highrise");
                if (flag3)
                {
                    result = "Highrise";
                }
                bool flag4 = text.Contains("rundown");
                if (flag4)
                {
                    result = "Rundown";
                }
                bool flag5 = text.Contains("quarry");
                if (flag5)
                {
                    result = "Quarry";
                }
                bool flag6 = text.Contains("nightshift");
                if (flag6)
                {
                    result = "Skidrow";
                }
                bool flag7 = text.Contains("terminal");
                if (flag7)
                {
                    result = "Terminal";
                }
                bool flag8 = text.Contains("brecourt");
                if (flag8)
                {
                    result = "Wasteland";
                }
                bool flag9 = text.Contains("derail");
                if (flag9)
                {
                    result = "Derail";
                }
                bool flag10 = text.Contains("estate");
                if (flag10)
                {
                    result = "Estate";
                }
                bool flag11 = text.Contains("favela");
                if (flag11)
                {
                    result = "Favela";
                }
                bool flag12 = text.Contains("invasion");
                if (flag12)
                {
                    result = "Invasion";
                }
                bool flag13 = text.Contains("rust");
                if (flag13)
                {
                    result = "Rust";
                }
                bool flag14 = text.Contains("scrapyard") || text.Contains("boneyard");
                if (flag14)
                {
                    result = "Scrapyard";
                }
                bool flag15 = text.Contains("sub");
                if (flag15)
                {
                    result = "Sub Base";
                }
                bool flag16 = text.Contains("underpass");
                if (flag16)
                {
                    result = "Underpass";
                }
                bool flag17 = text.Contains("checkpoint");
                if (flag17)
                {
                    result = "Karachi";
                }
                bool flag18 = text.Contains("bailout");
                if (flag18)
                {
                    result = "Bailout";
                }
                bool flag19 = text.Contains("compact");
                if (flag19)
                {
                    result = "Salvage";
                }
                bool flag20 = text.Contains("storm") || text.Contains("storm2");
                if (flag20)
                {
                    result = "Storm";
                }
                bool flag21 = text.Contains("crash");
                if (flag21)
                {
                    result = "Crash";
                }
                bool flag22 = text.Contains("overgrown");
                if (flag22)
                {
                    result = "Overgrown";
                }
                bool flag23 = text.Contains("strike");
                if (flag23)
                {
                    result = "Strike";
                }
                bool flag24 = text.Contains("vacant");
                if (flag24)
                {
                    result = "Vacant";
                }
                bool flag25 = text.Contains("trailerpark");
                if (flag25)
                {
                    result = "Trailer Park";
                }
                bool flag26 = text.Contains("fuel");
                if (flag26)
                {
                    result = "Fuel";
                }
                bool flag27 = text.Contains("abandon");
                if (flag27)
                {
                    result = "Carnival";
                }
                bool flag28 = text.Contains("dlc2_ui_mp");
                if (flag28)
                {
                    result = "Not in game";
                }
            }
            return result;
        }

        // Token: 0x0400026B RID: 619
        public static uint fxBirthTime = 144u;

        // Token: 0x0400026C RID: 620
        public static uint fxDecayDuration = 156u;

        // Token: 0x0400026D RID: 621
        public static uint fxDecayStartTime = 152u;

        // Token: 0x0400026E RID: 622
        public static uint fxLetterTime = 148u;

        // Token: 0x0400026F RID: 623
        private static uint function_address = 3730920u;

        // Token: 0x02000014 RID: 20
        public class HudStruct
        {
            // Token: 0x04000759 RID: 1881
            public static uint xOffset = 8u;

            // Token: 0x0400075A RID: 1882
            public static uint yOffset = 4u;

            // Token: 0x0400075B RID: 1883
            public static uint textOffset = 132u;

            // Token: 0x0400075C RID: 1884
            public static uint GlowColor = 140u;

            // Token: 0x0400075D RID: 1885
            public static uint fxBirthTime = 144u;

            // Token: 0x0400075E RID: 1886
            public static uint fadeStartTime = 60u;

            // Token: 0x0400075F RID: 1887
            public static uint fxLetterTime = 148u;

            // Token: 0x04000760 RID: 1888
            public static uint fadeTime = 64u;

            // Token: 0x04000761 RID: 1889
            public static uint fromColor = 56u;

            // Token: 0x04000762 RID: 1890
            public static uint fxDecayStartTime = 152u;

            // Token: 0x04000763 RID: 1891
            public static uint fxDecayDuration = 156u;

            // Token: 0x04000764 RID: 1892
            public static uint fontOffset = 40u;

            // Token: 0x04000765 RID: 1893
            public static uint fontSizeOffset = 20u;

            // Token: 0x04000766 RID: 1894
            public static uint colorOffset = 52u;

            // Token: 0x04000767 RID: 1895
            public static uint scaleStartTime = 88u;

            // Token: 0x04000768 RID: 1896
            public static uint fromFontScale = 24u;

            // Token: 0x04000769 RID: 1897
            public static uint fontScaleTime = 32u;

            // Token: 0x0400076A RID: 1898
            public static uint relativeOffset = 44u;

            // Token: 0x0400076B RID: 1899
            public static uint widthOffset = 72u;

            // Token: 0x0400076C RID: 1900
            public static uint heightOffset = 68u;

            // Token: 0x0400076D RID: 1901
            public static uint shaderOffset = 76u;

            // Token: 0x0400076E RID: 1902
            public static uint alignOffset = 48u;

            // Token: 0x0400076F RID: 1903
            public static uint fromAlignOrg = 104u;

            // Token: 0x04000770 RID: 1904
            public static uint fromAlignScreen = 108u;

            // Token: 0x04000771 RID: 1905
            public static uint alignOrg = 44u;

            // Token: 0x04000772 RID: 1906
            public static uint alignScreen = 48u;

            // Token: 0x04000773 RID: 1907
            public static uint fromY = 96u;

            // Token: 0x04000774 RID: 1908
            public static uint fromX = 100u;

            // Token: 0x04000775 RID: 1909
            public static uint moveStartTime = 112u;

            // Token: 0x04000776 RID: 1910
            public static uint moveTime = 116u;

            // Token: 0x04000777 RID: 1911
            public static uint flags = 164u;

            // Token: 0x04000778 RID: 1912
            public static uint soundID = 160u;

            // Token: 0x04000779 RID: 1913
            public static uint clientIndex = 168u;
        }

        // Token: 0x02000015 RID: 21
        public static class HudAlloc
        {
            // Token: 0x0400077A RID: 1914
            public static uint IndexSlot = 50u;

            // Token: 0x0400077B RID: 1915
            public static uint g_hudelem = 19830872u;

            // Token: 0x0400077C RID: 1916
            public static bool Start = true;
        }

        // Token: 0x02000016 RID: 22
        public static class HUDAlign
        {
            // Token: 0x0400077D RID: 1917
            public static uint RIGHT = 2u;

            // Token: 0x0400077E RID: 1918
            public static uint CENTER = 5u;

            // Token: 0x0400077F RID: 1919
            public static uint LEFT = 1u;
        }

        // Token: 0x02000017 RID: 23
        public class HudTypes
        {
            // Token: 0x04000780 RID: 1920
            public static uint Text = 1u;

            // Token: 0x04000781 RID: 1921
            public static uint Shader = 6u;

            // Token: 0x04000782 RID: 1922
            public static uint Null = 0u;
        }

        // Token: 0x02000018 RID: 24
        public class Material
        {
            // Token: 0x04000783 RID: 1923
            public static uint White = 1u;

            // Token: 0x04000784 RID: 1924
            public static uint Black = 2u;

            // Token: 0x04000785 RID: 1925
            public static uint Prestige0 = 26u;

            // Token: 0x04000786 RID: 1926
            public static uint Prestige1 = 27u;

            // Token: 0x04000787 RID: 1927
            public static uint Prestige2 = 28u;

            // Token: 0x04000788 RID: 1928
            public static uint Prestige3 = 29u;

            // Token: 0x04000789 RID: 1929
            public static uint Prestige4 = 30u;

            // Token: 0x0400078A RID: 1930
            public static uint Prestige5 = 31u;

            // Token: 0x0400078B RID: 1931
            public static uint Prestige6 = 32u;

            // Token: 0x0400078C RID: 1932
            public static uint Prestige7 = 33u;

            // Token: 0x0400078D RID: 1933
            public static uint Prestige8 = 34u;

            // Token: 0x0400078E RID: 1934
            public static uint Prestige9 = 35u;

            // Token: 0x0400078F RID: 1935
            public static uint Prestige10 = 36u;

            // Token: 0x04000790 RID: 1936
            public static uint WhiteRectangle = 37u;

            // Token: 0x04000791 RID: 1937
            public static uint NoMap = 41u;
        }

        // Token: 0x02000019 RID: 25
        public class Offsets
        {
            // Token: 0x04000792 RID: 1938
            public static uint G_Entity = 20027392u;

            // Token: 0x04000793 RID: 1939
            public static uint G_MaterialIndex = 1828696u;

            // Token: 0x04000794 RID: 1940
            public static uint G_LocalizedStringIndex = 1828808u;

            // Token: 0x04000795 RID: 1941
            public static uint G_HudElems = 19830872u;

            // Token: 0x04000796 RID: 1942
            public static uint HudElem_Alloc = 1574624u;

            // Token: 0x04000797 RID: 1943
            public static uint Weapon_RocketLauncher_Fire = 1838352u;

            // Token: 0x04000798 RID: 1944
            public static uint Dvar_GetString = 2584416u;

            // Token: 0x04000799 RID: 1945
            public static uint G_AddEvent = 1820168u;

            // Token: 0x0400079A RID: 1946
            public static uint cl_ingame = 30505612u;

            // Token: 0x0400079B RID: 1947
            public static uint LocalPlayerName = 33157404u;

            // Token: 0x0400079C RID: 1948
            public static uint G_FireGrenade = 1633800u;

            // Token: 0x0400079D RID: 1949
            public static uint level_locals_t = 20015232u;

            // Token: 0x0400079E RID: 1950
            public static uint levelTime = MW2RPC.Offsets.level_locals_t + 940u;

            // Token: 0x0400079F RID: 1951
            public static uint AllowPrecache = MW2RPC.Offsets.level_locals_t + 28u;

            // Token: 0x040007A0 RID: 1952
            public static uint ServerDetails = 10134233u;

            // Token: 0x040007A1 RID: 1953
            public static uint SV_GameSendServerCommand = 2203808u;

            // Token: 0x040007A2 RID: 1954
            public static uint BG_GetWeaponDef = 207000u;

            // Token: 0x040007A3 RID: 1955
            public static uint G_GetPlayerViewOrigin = 1493824u;

            // Token: 0x040007A4 RID: 1956
            public static uint ObjectiveIndex = 20015268u;

            // Token: 0x040007A5 RID: 1957
            public static uint Trace_GetEntityHitID = 1905216u;

            // Token: 0x040007A6 RID: 1958
            public static uint G_LocationalTrace = 1607008u;

            // Token: 0x040007A7 RID: 1959
            public static uint G_Client = 21897728u;

            // Token: 0x040007A8 RID: 1960
            public static uint ClientAngles = 268u;

            // Token: 0x040007A9 RID: 1961
            public static uint ClientOrigin = 28u;

            // Token: 0x040007AA RID: 1962
            public static uint ClientButtonMonitoring = 12765u;

            // Token: 0x040007AB RID: 1963
            public static uint ClientName = 12808u;

            // Token: 0x02000027 RID: 39
            public class Funcs
            {
            }
        }

        // Token: 0x0200001A RID: 26
        public class HudStructLib
        {
            // Token: 0x040007AC RID: 1964
            public static uint G_Hudelems = MW2RPC.Offsets.G_HudElems;

            // Token: 0x040007AD RID: 1965
            public static uint IndexSize = 180u;

            // Token: 0x040007AE RID: 1966
            public static uint type = 0u;

            // Token: 0x040007AF RID: 1967
            public static uint X = 8u;

            // Token: 0x040007B0 RID: 1968
            public static uint Y = 4u;

            // Token: 0x040007B1 RID: 1969
            public static uint Z = 12u;

            // Token: 0x040007B2 RID: 1970
            public static uint targetEntNum = 16u;

            // Token: 0x040007B3 RID: 1971
            public static uint fontScale = 20u;

            // Token: 0x040007B4 RID: 1972
            public static uint fromFontScale = 24u;

            // Token: 0x040007B5 RID: 1973
            public static uint fontScaleStartTime = 28u;

            // Token: 0x040007B6 RID: 1974
            public static uint fontScaleTime = 32u;

            // Token: 0x040007B7 RID: 1975
            public static uint label = 36u;

            // Token: 0x040007B8 RID: 1976
            public static uint font = 40u;

            // Token: 0x040007B9 RID: 1977
            public static uint alignOrg = 44u;

            // Token: 0x040007BA RID: 1978
            public static uint alignScreen = 48u;

            // Token: 0x040007BB RID: 1979
            public static uint color = 52u;

            // Token: 0x040007BC RID: 1980
            public static uint fromColor = 56u;

            // Token: 0x040007BD RID: 1981
            public static uint fadeStartTime = 60u;

            // Token: 0x040007BE RID: 1982
            public static uint fadeTime = 64u;

            // Token: 0x040007BF RID: 1983
            public static uint height = 68u;

            // Token: 0x040007C0 RID: 1984
            public static uint width = 72u;

            // Token: 0x040007C1 RID: 1985
            public static uint materialIndex = 76u;

            // Token: 0x040007C2 RID: 1986
            public static uint fromHeight = 80u;

            // Token: 0x040007C3 RID: 1987
            public static uint fromWidth = 84u;

            // Token: 0x040007C4 RID: 1988
            public static uint scaleStartTime = 88u;

            // Token: 0x040007C5 RID: 1989
            public static uint scaleTime = 92u;

            // Token: 0x040007C6 RID: 1990
            public static uint fromY = 96u;

            // Token: 0x040007C7 RID: 1991
            public static uint fromX = 100u;

            // Token: 0x040007C8 RID: 1992
            public static uint fromAlignOrg = 104u;

            // Token: 0x040007C9 RID: 1993
            public static uint fromAlignScreen = 108u;

            // Token: 0x040007CA RID: 1994
            public static uint moveStartTime = 112u;

            // Token: 0x040007CB RID: 1995
            public static uint moveTime = 116u;

            // Token: 0x040007CC RID: 1996
            public static uint value = 120u;

            // Token: 0x040007CD RID: 1997
            public static uint time = 124u;

            // Token: 0x040007CE RID: 1998
            public static uint duration = 128u;

            // Token: 0x040007CF RID: 1999
            public static uint text = 132u;

            // Token: 0x040007D0 RID: 2000
            public static uint sort = 136u;

            // Token: 0x040007D1 RID: 2001
            public static uint glowColor = 140u;

            // Token: 0x040007D2 RID: 2002
            public static uint fxBirthTime = 144u;

            // Token: 0x040007D3 RID: 2003
            public static uint fxLetterTime = 148u;

            // Token: 0x040007D4 RID: 2004
            public static uint fxDecayStartTime = 152u;

            // Token: 0x040007D5 RID: 2005
            public static uint fxDecayDuration = 156u;

            // Token: 0x040007D6 RID: 2006
            public static uint soundID = 160u;

            // Token: 0x040007D7 RID: 2007
            public static uint flags = 164u;

            // Token: 0x040007D8 RID: 2008
            public static uint clientIndex = 168u;
        }

        // Token: 0x0200001B RID: 27
        public class Struct
        {
            // Token: 0x040007D9 RID: 2009
            public static uint Size = 5068508u;

            // Token: 0x040007DA RID: 2010
            public static uint xPosition = 5069136u;

            // Token: 0x040007DB RID: 2011
            public static uint yPosition = 5068880u;

            // Token: 0x040007DC RID: 2012
            public static uint Text = 3291816u;
        }

        // Token: 0x0200001C RID: 28
        public static class NonHostButtons
        {
            // Token: 0x040007DD RID: 2013
            public static uint R1 = 77u;

            // Token: 0x040007DE RID: 2014
            public static uint R2 = 233u;

            // Token: 0x040007DF RID: 2015
            public static uint R3 = 209u;

            // Token: 0x040007E0 RID: 2016
            public static uint L1 = 65u;

            // Token: 0x040007E1 RID: 2017
            public static uint L2 = 221u;

            // Token: 0x040007E2 RID: 2018
            public static uint L3 = 197u;

            // Token: 0x040007E3 RID: 2019
            public static uint DpadUp = 245u;

            // Token: 0x040007E4 RID: 2020
            public static uint DpadDown = 261u;

            // Token: 0x040007E5 RID: 2021
            public static uint DpadLeft = 269u;

            // Token: 0x040007E6 RID: 2022
            public static uint DpadRight = 281u;

            // Token: 0x040007E7 RID: 2023
            public static uint Cross = 17u;

            // Token: 0x040007E8 RID: 2024
            public static uint Square = 41u;

            // Token: 0x040007E9 RID: 2025
            public static uint Circle = 29u;

            // Token: 0x040007EA RID: 2026
            public static uint Triangle = 53u;

            // Token: 0x040007EB RID: 2027
            public static uint Select = 185u;

            // Token: 0x040007EC RID: 2028
            public static uint Start = 173u;
        }

        // Token: 0x0200001D RID: 29
        public class Buttons
        {
            // Token: 0x040007ED RID: 2029
            public static string DpadUp = "+actionslot 1";

            // Token: 0x040007EE RID: 2030
            public static string DpadDown = "+actionslot 2";

            // Token: 0x040007EF RID: 2031
            public static string DpadRight = "+actionslot 4";

            // Token: 0x040007F0 RID: 2032
            public static string DpadLeft = "+actionslot 3";

            // Token: 0x040007F1 RID: 2033
            public static string Cross = "+gostand";

            // Token: 0x040007F2 RID: 2034
            public static string Circle = "+stance";

            // Token: 0x040007F3 RID: 2035
            public static string Triangle = "weapnext";

            // Token: 0x040007F4 RID: 2036
            public static string Square = "+usereload";

            // Token: 0x040007F5 RID: 2037
            public static string R3 = "+melee";

            // Token: 0x040007F6 RID: 2038
            public static string R2 = "+frag";

            // Token: 0x040007F7 RID: 2039
            public static string R1 = "+attack";

            // Token: 0x040007F8 RID: 2040
            public static string L3 = "+breath_sprint";

            // Token: 0x040007F9 RID: 2041
            public static string L2 = "+smoke";

            // Token: 0x040007FA RID: 2042
            public static string L1 = "+speed_throw";

            // Token: 0x040007FB RID: 2043
            public static string Select = "togglescores";

            // Token: 0x040007FC RID: 2044
            public static string Start = "togglemenu";
        }
    }
}

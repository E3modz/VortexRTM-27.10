using System;
using System.Threading;

namespace E3Modz.MW3
{
    internal class Funcs
    {
        public static uint NameAddress = 17880588;
        public static uint SV_GameSendServerCommand2 = 2265000;
        public static uint G_ClientOffset = 17867392;
        public static uint G_ClientSize = 14720;
        public static uint Client0 = 0;
        public static uint Client1 = 1;
        public static uint Client2 = 2;
        public static uint Client3 = 3;
        public static uint Client4 = 4;
        public static uint Client5 = 5;
        public static uint Client6 = 6;
        public static uint Client7 = 7;
        public static uint Client8 = 8;
        public static uint Client9 = 9;
        public static uint Client10 = 10;
        public static uint Client11 = 11;
        public static uint Client12 = 12;
        public static uint Client13 = 13;
        public static uint Client14 = 14;
        public static uint Client15 = 15;
        public static uint Client16 = 16;
        public static uint Client17 = 17;
        public static uint[] mods;
        public static uint xOffset = 4;
        public static uint yOffset = 8;
        public static uint zOffset = 12;
        public static uint textOffset = 132;
        public static uint fontOffset = 36;
        public static uint fontSizeOffset = 20;
        public static uint colorOffset = 48;
        public static uint relativeOffset = 44;
        public static uint widthOffset = 68;
        public static uint heightOffset = 72;
        public static uint shaderOffset = 76;
        public static uint GlowColor = 140;
        public static uint alignOffset = 44;
        public static uint clientOffset = 168;
        public static uint duration = 124;
        public static uint fadeStartTime = 56;
        public static uint fadeTime = 60;
        public static uint flags = 164;
        public static uint fromAlignOrg = 104;
        public static uint fromAlignScreen = 108;
        public static uint fromHeight = 84;
        public static uint fromWidth = 80;
        public static uint fromX = 96;
        public static uint fromY = 100;
        public static uint fxBirthTime = 144;
        public static uint fxDecayDuration = 156;
        public static uint fxDecayStartTime = 152;
        public static uint fxLetterTime = 148;
        public static uint label = 64;
        public static uint moveStartTime = 112;
        public static uint moveTime = 116;
        public static uint scaleStartTime = 88;
        public static uint scaleTime = 92;
        public static uint sort = 136;
        public static uint soundID = 160;
        public static uint time = 120;
        public static uint value = 128;
        public static uint type = 0;
        public static uint targetEntNum = 16;
        public static uint fontScale = 20;
        public static uint fromFontScale = 24;
        public static uint fontScaleStartTime = 28;
        public static uint fontScaleTime = 32;
        public static uint font = 36;
        public static uint alignOrg = 40;
        public static uint alignScreen = 44;
        public static uint color = 48;
        public static uint fromColor = 52;
        public static uint width = 68;
        public static uint height = 72;
        public static uint materialIndex = 76;
        public static uint text = 132;
        public static uint glowColor = 140;
        public static float NewsBarSpeed = 15000f;
        public static float NewsStart = 1200f;
        public static float NewsEnd = -780f;
        public static uint NewsTextIndex = 600;
        public static bool AntiStatus = false;
        public static bool TrickStatus = false;
        public static bool ResetThread = false;
        public static byte[] GmodOnline = new byte[93]
    {
      (byte) 1,
      (byte) 39,
      (byte) 0,
      (byte) 9,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 134,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 7,
      (byte) 0,
      (byte) 9,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 134,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 106,
      (byte) 0,
      (byte) 15,
      (byte) 0,
      (byte) 17,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 97,
      (byte) 0,
      (byte) 131,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 23,
      (byte) 71,
      (byte) 111,
      (byte) 100,
      (byte) 101,
      (byte) 109,
      (byte) 111,
      (byte) 100,
      (byte) 101,
      (byte) 22,
      (byte) 0,
      (byte) 115,
      (byte) 115,
      (byte) 32,
      (byte) 50,
      (byte) 0,
      (byte) 84,
      (byte) 32,
      (byte) 49,
      (byte) 0,
      (byte) 0,
      (byte) 118,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 19,
      (byte) 0,
      (byte) 20,
      (byte) 0,
      (byte) 25,
      (byte) 0,
      (byte) 45,
      (byte) 0,
      (byte) 38,
      (byte) 0,
      (byte) 39,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 6,
      (byte) 0,
      (byte) 107
    };
        public static uint BG_GetWeaponIndexForName = 250932;
        public static uint BG_TakePlayerWeapon = 1851548;
        public static uint ButtonMonitoring = 344;
        public static uint cl_ingame = 8324916;
        public static uint ClientAssists = 13092;
        public static uint ClientDeaths = 13084;
        public static uint ClientKills = 13088;
        public static uint ClientName = 13196;
        public static uint FuncAddr = 2585096;


        public static uint G_EntityOffset = 16556672;
        public static uint G_EntitySize = 640;
        public static uint G_GivePlayerWeapon = 1847348;
        public static uint G_HudElems = 15786252;
        public static uint G_InitializeAmmo = 1614492;
        public static uint G_LocalizedStringIndex = 1828556;
        public static uint G_MaterialIndex = 1828676;
        public static uint G_SetModel = 1830748;
        public static uint HudelemSize = 184;
        public static uint Lethal = 1051;
        public static uint LevelTime = 16530864;
        public static uint mFlag = 13820;
        public static uint PlayerName = 29080620;
        public static uint PrimaryWeapon = 636;
        public static uint RedBoxes = 19;
        public static uint SecondaryWeapon = 628;
        public static uint Tactial = 643;
        public static uint Team = 13268;
        public static bool AdvencedNoclipBool = false;
        public static byte[] dump = new byte[0];
        public static int SaveInt = 0;
        public static uint[] CarePackageSurferDelete = new uint[18];
        public static string TeleportString = "Real";
        public static uint[] HudAlloc = new uint[18];

        public static uint GodmodeAddress = 16557086;
        public static uint UFOAddress = 286099319;
        public static uint GodmodeOffset = 16557085;

        public static uint SV_SendServerCommand2 = 2281148;
        private static byte FreezeON = 1;
        public static uint[] DomeBowlingUint = new uint[20];
        private static bool[] PLAYER1 = new bool[10];
        private static bool[] PLAYER2 = new bool[10];
        private static bool[] STATE = new bool[10];
        private static bool GameEnd = false;
        public static uint MoveIndex = 501;
        public static uint SelectIndex = 502;
        public static uint Player2Index = 503;
        public static uint Player1Index = 504;
        public static uint TITELIndex = 505;
        public static uint AIndex = 506;
        public static uint BIndex = 507;
        public static uint CIndex = 508;
        public static uint DIndex = 509;
        public static uint EIndex = 510;
        public static uint FIndex = 511;
        public static uint GIndex = 512;
        public static uint HIndex = 513;
        public static uint IIndex = 514;
        public static uint SCROLLERIndex = 515;
        public static uint TypewriterIndex = 516;
        private static bool DPADState = false;
        public static bool EarthStatus = false;
        public static int[] InvisibleInt2 = new int[18];
        public static string[] ClientVehicle = new string[18];
        private static int Countername889 = 0;
        public static bool IPOffsetFound = false;
        public static uint IPSetOffset = 0;
        public static byte[] myhostmin = new byte[1] { (byte)1 };
        public static byte[] myhostminDefault = new byte[1]
    {
      (byte) 6
    };
        public static bool iPrintlnON = true;
        public static Thread TrickThread;
        public static Thread PDHThread;
        public static Thread LavaThread;
        public static Thread SniperThread;
        public static float[] Trickshot;
        public static uint DestroyCarousel;
        private static string pathOfEboot;
        public static Thread JumpThread;
        public static uint[] TrampolinDelete;
        public static float[] TrampolinOrigin;
        public static int WeaponNow;
        public static int SniperValue;
        public static Thread NewsThread;
        public static Thread HearthThread;
        public static Thread FXThread;
        public static string FX;
        public static Thread InvisibleThread;
        public static Thread FreezeThread;
        private static string Player1;
        private static string Player2;
        private static string Turn;
        private static string Option;
        private static bool TTTStatus;
        private static Thread TTTThread;
        private static uint DPADOFFSET;
        public static Thread EarthThread;
        private static Thread FCThread;





        public static void NonHostEndMatch()
        {
            {
                MW3.Cbuf_AddText(0, "cmd mr " + (object)PS5.Extension.ReadInt32(8594724U) + " -1 endround;");
            }
        }


        public static void G_FreeEntity(uint Entity)
        {
            RPC.Call(1837120u, new object[]
            {
                Entity
            });
        }
        public static void DestroyDomeBowling()
        {
            for (int i = 0; i < 20; i++)
            {
                Funcs.G_FreeEntity(Funcs.DomeBowlingUint[i]);
            }
        }


        public static float[] GetOrigin(uint client)
        {
            return PS5.Extension.ReadFloatArray(17867420u + 14720u * client, 3);
        }



        public static uint SolidModel(float[] Origin, float[] Angles, string Model = "com_plasticcase_friendly", int Index = 2)
        {
            uint num = (uint)RPC.Call(1836428u, new object[0]);
            PS5.Extension.WriteFloatArray(num + 312u, Origin);
            PS5.Extension.WriteFloatArray(num + 324u, Angles);
            RPC.Call(1830748u, new object[]
            {
                num,
                Model
            });
            RPC.Call(1797992u, new object[]
            {
                num
            });
            RPC.Call(2324408u, new object[]
            {
                num
            });
            PS5.Extension.WriteByte(num + 257u, 4);
            PS5.Extension.WriteInt32(num + 140u, Index);
            RPC.Call(2265692u, new object[]
            {
                num
            });
            RPC.Call(2324552u, new object[]
            {
                num
            });
            return num;
        }


        public static void G_EntEnablePhysics(uint Entity)
        {
            RPC.Call(1616724u, new object[]
            {
                Entity,
                0
            });
        }

        public static void DomeBowling()
        {
            Random random = new Random();
            float[] origin = Funcs.GetOrigin(18u);
            origin[2] += 5000f;
            for (int i = 0; i < 20; i++)
            {
                float num = (float)random.Next(-300, 300);
                float num2 = (float)random.Next(-300, 300);
                uint[] arg_93_0 = Funcs.DomeBowlingUint;
                int arg_93_1 = i;
                float[] arg_8E_0 = new float[]
                {
                    origin[0] + num,
                    origin[1] + num2,
                    origin[2]
                };
                float[] angles = new float[3];
                arg_93_0[arg_93_1] = Funcs.SolidModel(arg_8E_0, angles, "machinery_radome_cage", 0);
                Funcs.G_EntEnablePhysics(Funcs.DomeBowlingUint[i]);
                Thread.Sleep(500);
            }
        }






        public static void ChangeNameNonHost(string Text, string Color = "")
        {
            MW3.cbuf_addtext(0, string.Concat(new object[]
            {
                ";userinfo \"\\name\\",
                Text,
                "\\npid\\",
                BitConverter.ToUInt64(PS5.GetMemory(7541856u, 36), 0),
                "\\clanAbbrev\\",
                Color,
                "\\xuid\\",
                PS5.Extension.ReadString(29080664u),
                "\""
            }));
        }


        public static void GiveHost()
        {
            PS5.Extension.WriteByte(9031840u, 1);
            PS5.Extension.WriteByte(9076728u, 1);
        }


        public static void SpinMode(int client)
        {
            PS5.SetMemory((uint)(17867492 + client * 14720), new byte[1]
      {
        (byte) 68
      });
            for (byte input = 0; (int)input < 87; ++input)
            {
                PS5.Extension.WriteByte((uint)(17867493 + client * 14720), input);
                Thread.Sleep(50);
            }
        }




        public static void Invert(int client, byte input)
        {
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client0 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client0 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client0 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client0 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client1 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client1 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client1 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client1 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client2 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client2 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client2 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client2 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client3 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client3 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client3 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client3 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client4 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client4 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client4 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client4 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client5 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client5 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client5 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client5 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client6 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client6 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client6 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client6 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client7 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client7 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client7 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client7 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client8 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client8 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client8 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client8 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client9 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client9 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client9 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client9 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client10 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client10 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client10 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client10 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client11 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client11 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client11 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client11 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client12 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client12 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client12 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client12 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client13 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client13 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client13 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client13 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client14 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client14 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client14 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client14 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client15 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client15 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client15 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client15 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client16 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client16 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client16 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client16 * 14720), input);
            PS5.SetMemory((uint)(17867492 + (int)Funcs.Client17 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.SetMemory((uint)(17867496 + (int)Funcs.Client17 * 14720), new byte[1]
      {
        (byte) 68
      });
            PS5.Extension.WriteByte((uint)(17867493 + (int)Funcs.Client17 * 14720), input);
            PS5.Extension.WriteByte((uint)(17867497 + (int)Funcs.Client17 * 14720), input);
        }



        // Token: 0x0600062F RID: 1583 RVA: 0x000BC768 File Offset: 0x000BA968
        public static void ChangeMw3Background(byte[] Data)
        {
            PS5.SetMemory(3435622400u, Funcs.MakeData(Data, 460800u, true, true));
            PS5.SetMemory(3316464256u, Funcs.MakeData(Data, 460800u, true, true));
            PS5.SetMemory(3316003456u, Funcs.MakeData(Data, 460800u, true, true));
            PS5.SetMemory(3436345600u, Funcs.MakeData(Data, 460800u, true, true));
        }

        public static void AntiFreezeee()
        {
            {
                {
                    PS5.SetMemory(0xb33f0, new byte[] { 0x7c, 0x63, 0xe0, 0x2e });
                    PS5.SetMemory(0xb33fc, new byte[] { 0x48, 9, 0x2b, 0x15 });
                    PS5.SetMemory(0xb33ec, new byte[] { 0x80, 0x63, 0, 0x18 });
                    PS5.SetMemory(0xb33a0, new byte[] { 0x48, 9, 0x2b, 0x71 });
                    PS5.SetMemory(0x3dc04, new byte[] { 0x80, 0x63, 0, 0x10 });
                    PS5.SetMemory(0x3df18, new byte[] { 0x80, 0xbb, 0, 0x10 });
                    PS5.SetMemory(0xb3390, new byte[] { 0x80, 0x7d, 0, 0x18 });
                    PS5.SetMemory(0xb33a4, new byte[] { 0x83, 0xbd, 0, 0x1c });
                    PS5.SetMemory(0xb3430, new byte[] { 0x7c, 0x63, 0xe0, 0x2e });
                    PS5.SetMemory(0xb342c, new byte[] { 0x80, 0x63, 0, 0x18 });
                    PS5.SetMemory(0xb6f4c, new byte[] { 0x88, 0x84, 7 });
                    PS5.SetMemory(0x3a830, new byte[] { 0x83, 0xe4, 2 });
                    PS5.SetMemory(0x3a61c, new byte[] { 0x83, 0xe4, 2 });
                }

                {
                    byte[] buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb33f0, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb33fc, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb33ec, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb33a0, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0x3dc04, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0x3df18, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb3390, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb33a4, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb3430, buffer);
                    buffer = new byte[4];
                    buffer[0] = 0x60;
                    PS5.SetMemory(0xb342c, buffer);
                    byte[] buffer2 = new byte[3];
                    buffer2[0] = 0x38;
                    buffer2[1] = 0x80;
                    byte[] buffer3 = buffer2;
                    byte[] buffer4 = new byte[3];
                    buffer4[0] = 0x38;
                    buffer4[1] = 0x60;
                    PS5.SetMemory(0xb6f4c, buffer4);
                    PS5.SetMemory(0x3a830, buffer3);
                    PS5.SetMemory(0x3a61c, buffer3);
                }
            }
        }






        public static void AntiFreeze()
        {
            byte[] numArray1 = new byte[6]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 72,
        (byte) 0
            };
            PS5.SetMemory(3884252U, numArray1);
            byte[] numArray2 = new byte[6]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 72,
        (byte) 0
            };
            PS5.SetMemory(3673332U, numArray2);
            byte[] numArray3 = new byte[6]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 72,
        (byte) 0
            };
            {
            }
        }

        public static void AntiFrezze(bool OnOff = true)
        {
            if (OnOff)
            {
                Funcs.NOP((object)749388, (object)749512);
                byte[] Bytes = new byte[6]
       {
          (byte) 96,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 72,
          (byte) 0
       };
                PS5.SetMemory(3884252U, Bytes);
                PS5.SetMemory(3673332U, Bytes);
                PS5.SetMemory(828428U, Bytes);
            }
            else
            {
                PS5.SetMemory(3884252U, new byte[6]
       {
          (byte) 65,
          (byte) 154,
          (byte) 0,
          (byte) 8,
          (byte) 64,
          (byte) 134
       });
                PS5.SetMemory(3673332U, new byte[6]
       {
          (byte) 65,
          (byte) 130,
          (byte) 0,
          (byte) 8,
          (byte) 64,
          (byte) 134
       });
                PS5.SetMemory(828428U, new byte[6]
       {
          (byte) 65,
          (byte) 130,
          (byte) 0,
          (byte) 8,
          (byte) 64,
          (byte) 134
       });
                PS5.Extension.WriteBytes(749388U, new byte[4]
      {
          (byte) 136,
          (byte) 132,
          (byte) 7,
          (byte) 126
      });
                PS5.Extension.WriteBytes(749512U, new byte[4]
      {
          (byte) 128,
          (byte) 99,
          (byte) 0,
          (byte) 56
      });
            }
        }

        public static void NOP(params object[] parameters)
        {
            uint num = 0u;
            while ((ulong)num < (ulong)((long)parameters.Length))
            {
                uint arg_1C_0 = Convert.ToUInt32(parameters[(int)((UIntPtr)num)]);
                byte[] array = new byte[4];
                array[0] = 96;
                PS5.SetMemory(arg_1C_0, array);
                num += 1u;
            }
        }








        // Token: 0x0600065A RID: 1626 RVA: 0x000097EA File Offset: 0x000079EA
        public static void InjectImage(uint Adress, byte[] Image, uint Lenght, bool DeleteHeader = true, bool ResizeImage = true)
        {
            PS5.SetMemory(Adress, Funcs.MakeData(Image, Lenght, DeleteHeader, ResizeImage));
        }


        public static byte[] MakeData(byte[] data, uint Lenght = 460800u, bool DeleteHeader = true, bool ResizeImage = true)
        {
            byte[] result;
            try
            {
                if (ResizeImage)
                {
                    uint num;
                    if (DeleteHeader)
                    {
                        num = 128u;
                    }
                    else
                    {
                        num = 0u;
                    }
                    byte[] array = new byte[(long)data.Length - (long)((ulong)num)];
                    Buffer.BlockCopy(data, (int)num, array, 0, array.Length);
                    byte[] array2 = new byte[Lenght];
                    int num2 = 0;
                    while ((long)num2 < (long)((ulong)Lenght))
                    {
                        array2[num2] = array[num2];
                        num2++;
                    }
                    result = array2;
                }
                else
                {
                    uint num;
                    if (DeleteHeader)
                    {
                        num = 128u;
                    }
                    else
                    {
                        num = 0u;
                    }
                    byte[] array3 = new byte[(long)data.Length - (long)((ulong)num)];
                    Buffer.BlockCopy(data, (int)num, array3, 0, array3.Length);
                    result = array3;
                }
            }
            catch
            {
                result = new byte[0];
            }
            return result;
        }

        public static void MODDEDLISTS()
        {
            PS5.Extension.WriteString(25771916U, "^5TEAM-DEATHMATCH");
            PS5.Extension.WriteString(25772296U, "^^5KILL CONFIRMED");
            PS5.Extension.WriteString(25776476U, "^5MERCENARY");
            PS5.Extension.WriteString(25772676U, "^5FREE-FOR-ALL");
            PS5.Extension.WriteString(25773056U, "^5DOMINATION");
            PS5.Extension.WriteString(25773436U, "^5BITCH WAR");
            PS5.Extension.WriteString(25776096U, "^5TEAM DEFENDER");
            PS5.Extension.WriteString(25773816U, "^5DEMOLITION");
            PS5.Extension.WriteString(25774196U, "^5SABOTAGE");
            PS5.Extension.WriteString(25774576U, "^5HEADQUATERS PRO");
            PS5.Extension.WriteString(25774956U, "^5SEARCH AND DESTROY");
            PS5.Extension.WriteString(25775336U, "^5CAPTURE THE FLAG");
            PS5.Extension.WriteString(25775716U, "^5TEAM TACTICAL");
            PS5.Extension.WriteString(25779136U, "^5BAREBONES");
            PS5.Extension.WriteString(25777236U, "^5HARDCORE RICOCHET: TDM");
            PS5.Extension.WriteString(25777616U, "^5HARDCORE RICOCHET: KC");
            PS5.Extension.WriteString(25777996U, "^5HARDCORE RICOCHET: S&D");
            PS5.Extension.WriteString(25776856U, "^5HARDCORE FREE-FOR-ALL");
            PS5.Extension.WriteString(25778376U, "^5HARDCORE RICOCHET: DOM");
            PS5.Extension.WriteString(25784076U, "^5HARDCORE MOSH PIT");
            PS5.Extension.WriteString(25779516U, "^5INFECTED");
            PS5.Extension.WriteString(25779896U, "^5DROP ZONE");
            PS5.Extension.WriteString(25780276U, "^5ALL OR NOTHING");
            PS5.Extension.WriteString(25784456U, "^5MITD");
            PS5.Extension.WriteString(25778756U, "^5MW3 SOME");
            PS5.Extension.WriteString(25780656U, "^5FACE OFF: 1V1");
            PS5.Extension.WriteString(25781036U, "^5FACE OFF: 2V2");
            PS5.Extension.WriteString(25783316U, "^5FACE OFF: 3V3");
            PS5.Extension.WriteString(25784836U, "^5HARDCORE FACE OFF: 3V3");
            PS5.Extension.WriteString(25781416U, "^5COLLECTION 4 TDM, DOM, KC");
            PS5.Extension.WriteString(25781796U, "^5COLLECTION 4 OBJECTIVES");
            PS5.Extension.WriteString(25782176U, "^5COLL.4 HC RICOCHET MOSH PIT");
            PS5.Extension.WriteString(25795856U, " ^5STANDARD PLAYLISTS");
            PS5.Extension.WriteString(25796384U, "^5ADVANCED PLAYLISTS");
            PS5.Extension.WriteString(25796912U, "^5COMMUNITY PLAYLISTS");
            PS5.Extension.WriteString(25797440U, "^5FACE OFF PLAYLISTS");
            PS5.Extension.WriteString(25797968U, "^5COLLECTION 4 PLAYLISTS");
            PS5.Extension.WriteString(0x318C959C, "^2SearchGame");
            PS5.Extension.WriteString(0x318D6696, "^2Private Match");
            PS5.Extension.WriteString(0x318D6FEB, "^5CUSTOM CLASSES");
            PS5.Extension.WriteString(0x3190B3CB, "^5EDITOR");
            PS5.Extension.WriteString(0x318D7D77, "^5 STATS");
            PS5.Extension.WriteString(0x3190D0A9, "^5E3Modz");
            PS5.Extension.WriteString(0x3191511F, "^1Projekt^2Vortex");
            PS5.Extension.WriteString(0x318C7438, "^1VortexRTM^2Engine");
            PS5.Extension.WriteString(0x3190217F, "^2NAT:");
            PS5.Extension.WriteString(0x008930C4, "^1VortexRTM^2Engine");
            PS5.Extension.WriteString(0x318C7110, "^5Friends");
            PS5.Extension.WriteString(0x318CE018, "^1Back");
            PS5.Extension.WriteString(0x3190E73D, "^5E3Modz");
            PS5.Extension.WriteString(0x123E3C4, "^5E3Modz");
            PS5.Extension.WriteString(0x8A3320, "^2Thanks For Using Vortex^1RTM^2Engine");
            PS5.Extension.WriteString(0x3190B415, "^5Start");
            PS5.Extension.WriteString(0x318C9AB1, "VortexRTM");
            PS5.Extension.WriteString(0x318C838B, "^2VortexRTM");
            PS5.Extension.WriteString(0x3190B60A, "^5CLASSES");
            PS5.Extension.WriteString(0x3190B435, "^5SETUP");
            PS5.Extension.WriteString(0x318C9510, "^5Find Match using ^2ProjektVortex");
            PS5.Extension.WriteString(0x318C9660, "^5PLAY");
            PS5.Extension.WriteString(0x3190B54B, "^5SPLIT");
            PS5.Extension.WriteString(0x318C8B8D, "^5LAN PARTY");
            PS5.Extension.WriteString(0x319110AA, "^5LEADERBOARD");
            PS5.Extension.WriteString(0x3190E194, "^5EDITOR");
            PS5.Extension.WriteString(0x3190B4D5, "^5#1");
            PS5.Extension.WriteString(0x3190E345, "^5CLAN");
            PS5.Extension.WriteString(0x3190B4EB, "^5SHOW");
            PS5.Extension.WriteString(0x319162F5, "^2Vortex");
            PS5.Extension.WriteString(0x3190AFEC, "^5Online");
            PS5.Extension.WriteString(832894373U, "^5SEARCH");
            PS5.Extension.WriteString(832894472U, "^5PRIVATE");
            PS5.Extension.WriteString(832894606U, "^5CUSTOM CLASSES");
            PS5.Extension.WriteString(832894702U, "^5EDITOR");
            PS5.Extension.WriteString(832894802U, "^5STATS");
            PS5.Extension.WriteString(932594049U, "^5Start");
            PS5.Extension.WriteString(932590200U, "^5SETUP");
            PS5.Extension.WriteString(0x318D8E12, "^5Lobby");
            PS5.Extension.WriteString(0x318C9932, "^5Find Match using ^2ProjektVortex");
            PS5.Extension.WriteString(0x31907098, "^2NAT:");
            PS5.Extension.WriteString(0x318C744F, "^2VortexRTM Enigne");
            PS5.Extension.WriteString(0x39DB9880, "E3Modz");
            PS5.Extension.WriteString(0x39DB98AC, "^2E3 ^5MoDz");
            PS5.Extension.WriteString(0x318C7107, "^5Friends");
            PS5.Extension.WriteString(0x318CED44, "^5Back");
            PS5.Extension.WriteString(0x3191C8AD, "^5OFF");
            PS5.Extension.WriteString(0x3191C8AD, "^5ON");
        }

    }
}




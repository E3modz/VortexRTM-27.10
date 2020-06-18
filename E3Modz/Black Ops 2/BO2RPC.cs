﻿using E3Modz.Black_Ops_2;
using PS3Lib;

using System;

using System.Threading;

namespace E3Modz

{

    public class BO2RPC

    {
        public static PS3API PS5 = (BO2.PS3);
        private static uint function_address;



        public static int Call(uint func_address, params object[] parameters)

        {

            int length = parameters.Length;

            int index = 0;

            uint num3 = 0;

            uint num4 = 0;

            uint num5 = 0;

            uint num6 = 0;

            while (index < length)

            {

                if (parameters[index] is int)

                {

                    PS5.Extension.WriteInt32(0x10020000 + (num3 * 4), (int)parameters[index]);

                    num3++;

                }

                else if (parameters[index] is uint)

                {

                    PS5.Extension.WriteUInt32(0x10020000 + (num3 * 4), (uint)parameters[index]);

                    num3++;

                }

                else

                {

                    uint num7;

                    if (parameters[index] is string)

                    {

                        num7 = 0x10022000 + (num4 * 0x400);

                        PS5.Extension.WriteString(num7, Convert.ToString(parameters[index]));

                        PS5.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);

                        num3++;

                        num4++;

                    }

                    else if (parameters[index] is float)

                    {

                        PS5.Extension.WriteFloat(0x10020024 + (num5 * 4), (float)parameters[index]);

                        num5++;

                    }

                    else if (parameters[index] is float[])

                    {

                        float[] input = (float[])parameters[index];

                        num7 = 0x10021000 + (num6 * 4);

                        Lib.WriteSingle(num7, input);

                        PS5.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);

                        num3++;

                        num6 += (uint)input.Length;

                    }

                }

                index++;

            }

            PS5.Extension.WriteUInt32(0x1002004C, func_address);

            Thread.Sleep(20);

            return PS5.Extension.ReadInt32(0x10020050);

        }



        public static void Enable()

        {

            PS5.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });

            Thread.Sleep(20);

            byte[] memory = new byte[]

                    { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x02, 0x81, 0x83, 0x00, 0x4C,

            0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08,

            0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18,

            0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xc0, 0x43, 0x00, 0x28,

            0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xc0, 0xC3, 0x00, 0x38,

            0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00,

            0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x02, 0x38, 0xA0, 0x00, 0x00,

            0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6,

            0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };

            PS5.SetMemory(function_address + 4, memory);

            PS5.SetMemory(0x10020000, new byte[0x2854]);

            PS5.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });

        }



        public static int Init()

        {

            function_address = 0x007AA050;

            Enable();

            return 0;

        }



        public static void Cbuf_AddText(int client, string text)

        {

            BO2RPC.Call(0x313E88, client, text);

        }

        public static void iPrintln(int Client, string Text)

        {

            SV_GameSendServerCommand(Client, "O \"" + Text + "\"");

        }



        public static void iPrintlnBold(int Client, string Text)

        {

            SV_GameSendServerCommand(Client, "< \"" + Text + "\"");

        }

        public static void CBuf_Addtext(string Command)

        {

            BO2RPC.Call(00315938, 0, Command);

        }



        public static void SV_GameSendServerCommand(int Client, string Command)

        {

            BO2RPC.Call(0x34A1DC, Client, 1, Command);

        }

    }

}



//Enable with "BO2RPC.Init();
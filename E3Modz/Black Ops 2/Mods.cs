using E3Modz.Black_Ops_2;
using PS3Lib;
using System.Text;
using System.Windows.Forms;

namespace E3Modz
{
    class Mods
    {
        public static PS3API PS3 = (BO2.PS3);//public static PS3API PS3 = new PS3API(); <-- Add this to your main form to share your object.

        public static void HideIDOFF()
        {
            byte[] array = new byte[3];
            array[0] = 6;
            PS3.SetMemory(40634115u, array);
        }
        public static void HideIDON()
        {
            byte[] array = new byte[3];
            array[0] = 4;
            PS3.SetMemory(40634115u, array);
        }

        public static void AntiCloseOFF()
        {
            PS3.SetMemory(5381176U, new byte[1]
         {
          (byte) 136
         });
        }
        public static void AntiCloseON()
        {
            PS3.SetMemory(5381176U, new byte[1]
{
          (byte) 56
});
            byte[] buffer = new byte[4]
            {
          (byte) 56,
          (byte) 96,
          (byte) 0,
          (byte) 0
            };
            PS3.SetMemory(5454192U, buffer);
            PS3.SetMemory(5454204U, buffer);
            PS3.SetMemory(5454216U, buffer);
            PS3.SetMemory(5454152U, buffer);
            PS3.SetMemory(5454108U, buffer);
            PS3.SetMemory(5454156U, buffer);
            PS3.SetMemory(5454216U, buffer);
        }
        public static void AutoInviteOFF()
        {
            {
                byte[] buffer = new byte[4]
                {
          (byte) 128,
          (byte) 132,
          (byte) 0,
          (byte) 0
                };
                PS3.SetMemory(5462488U, buffer);
            }
        }
        public static void AutoInviteON()
        {
            PS3.SetMemory(5462488U, new byte[4]
               {
          (byte) 96,
          (byte) 99,
          (byte) 59,
          (byte) 15
               });
            byte[] buffer = new byte[4]
            {
          (byte) 96,
          (byte) 0,
          (byte) 0,
          (byte) 0
            };
            PS3.SetMemory(5462524U, buffer);
        }
        public static void SelfInviteOFF()
        {
            PS3.SetMemory(5463275U, new byte[1]
                 {
          (byte) 128
                 });
            PS3.SetMemory(5463399U, new byte[1]
            {
          (byte) 144
            });
        }
        public static void SelfInviteON()
        {
            PS3.SetMemory(5463275U, new byte[1]
                           {
          (byte) 144
                           });
            PS3.SetMemory(5463399U, new byte[1]
             {
          (byte) 128
             });
            PS3.Extension.WriteString(9890868U, "Vortex Invite" + "\0");
        }
        public static void HideMicON()
        {
            PS3.SetMemory(14164312u, new byte[1]);
        }
        public static void HideMicOFF()
        {
            byte[] array = new byte[]
                            {
                    1
                            };
            PS3.SetMemory(14164312u, array);
        }


        public static void NoRecoilON()
        {
            PS3.SetMemory(1023572U, new byte[4]
               {
          (byte) 44,
          (byte) 4,
          (byte) 0,
          (byte) 2f
               });
        }
        public static void NoRecoilOFF()
        {
            PS3.SetMemory(1023572U, new byte[4]
                {
          (byte) 72,
          (byte) 80,
          (byte) 109,
          (byte) 101
                });
        }
        public static void LazerON()
        {
            PS3.SetMemory(980620U, new byte[4]
                {
          (byte) 44,
          (byte) 3,
          (byte) 0,
          (byte) 1
                });
        }
        public static void LazerOFF()
        {
            byte[] buffer = new byte[4]
              {
          (byte) 44,
          (byte) 3,
          (byte) 0,
          (byte) 0
              };
            PS3.SetMemory(980620U, buffer);
            byte[] numArray = new byte[4]
            {
          (byte) 44,
          (byte) 3,
          (byte) 0,
          (byte) 0
            };
        }
        public static void AimON()
        {
            byte[] buffer = new byte[4]
               {
          (byte) 44,
          (byte) 4,
          (byte) 0,
          (byte) 0
               };
            PS3.SetMemory(6228512U, buffer);
            byte[] numArray = new byte[4]
            {
          (byte) 44,
          (byte) 4,
          (byte) 0,
          (byte) 0
            };
        }
        public static void AimOFF()
        {
            PS3.SetMemory(6228512U, new byte[4]
               {
          (byte) 44,
          (byte) 4,
          (byte) 0,
          (byte) 2
               });
        }

        public static void PoisonON()
        {
            PS3.SetMemory(24646923u, new byte[]
                {
                    1
                });
        }

        public static void ShootingON()
        {
            PS3.SetMemory(10375392u, new byte[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                28,
                29,
                30,
                31,
                0
            });
        }

        public static void ShootingOFF()
        {
            PS3.SetMemory(10375392u, new byte[]
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                28,
                29,
                30,
                31
            });
        }

        public static void PoisonOFF()
        {
            PS3.SetMemory(24646923u, new byte[1]);
        }

        public static void ModON()
        {
            byte[] array = new byte[4];
            array[0] = 66;
            array[1] = 220;
            byte[] buffer = array;
            PS3.SetMemory(30167768u, buffer);
            PS3.SetMemory(30167768u, buffer);
        }
        public static void ModOFF()
        {
            byte[] array2 = new byte[4];
            array2[0] = 65;
            array2[1] = 32;
            byte[] buffer2 = array2;
            PS3.SetMemory(30167768u, buffer2);
            PS3.SetMemory(30167768u, buffer2);
        }

        public static void GreenBoddyON()
        {
            PS3.SetMemory(30151740u, new byte[]
 {
                    63,
                    128,
                    0,
                    0,
                    63,
                    128,
                    0,
                    0
 });
        }
        public static void GreenBoddyOFF()
        {
            PS3.SetMemory(30151740u, new byte[]
                {
                    63,
                    128,
                    0,
                    0,
                    63,
                    128,
                    0,
                    0
                });
        }

        public static void PurpleBoddyON()
        {
            PS3.SetMemory(30151740u, new byte[]
                 {
                    111,
                    128,
                    0,
                    0,
                    79,
                    128,
                    0
                 });
        }
        public static void PurpleBoddyOFF()
        {
            PS3.SetMemory(30151740u, new byte[]
               {
                    63,
                    128,
                    0,
                    0,
                    63,
                    128,
                    0,
                    0
               });
        }

        public static void OrangeBoddyON()
        {
            uint offset = 30151740u;
            byte[] array2 = new byte[6];
            array2[0] = 63;
            array2[4] = 63;
            PS3.SetMemory(offset, array2);
        }
        public static void OrangeBoddyOFF()
        {
            PS3.SetMemory(30151740u, new byte[]
               {
                    63,
                    128,
                    0,
                    0,
                    63,
                    128,
                    0,
                    0
               });
        }

        public static void NamesON()
        {
            PS3.SetMemory(30174872u, new byte[]
                  {
                    63,
                    byte.MaxValue,
                    byte.MaxValue,
                    0
                  });
        }
        public static void NamesOFF()
        {
            PS3.SetMemory(30174872u, new byte[]
            {
                63,
                38,
                102,
                102
            });
        }

        public static void VSATON()
        {
            byte[] array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(212064u, array);
            array = new byte[4];
            array[0] = 96;
        }
        public static void VSATOFF()
        {
            PS3.SetMemory(212064u, new byte[]
 {
                    64,
                    129,
                    0,
                    68
 });
        }

        public static void UAVON()
        {
            PS3.SetMemory(212148U, new byte[4]
               {
          (byte) 44,
          (byte) 3,
          (byte) 0,
          (byte) 1
               });
        }
        public static void UAVOFF()
        {
            byte[] buffer = new byte[4]
               {
          (byte) 44,
          (byte) 3,
          (byte) 0,
          (byte) 0
               };
            PS3.SetMemory(212148U, buffer);
        }
        public static void ROFF()
        {
            PS3.SetMemory(1290047u, new byte[]
                     {
                228
                     });
        }
        public static void RON()
        {
            PS3.SetMemory(1290047u, new byte[]
                   {
                217
                   });
        }
        public static void StartGameON()
        {
            PS3.SetMemory(0xfa79ad, new byte[] { 0x55 });
            PS3.SetMemory(0xfa7a7c, new byte[2]);
        }
        public static void StartGameOFF()
        {
            PS3.SetMemory(0xfa79ad, new byte[] { 0x55 });
            PS3.SetMemory(0xfa7a7c, new byte[2]);
        }
        public static void FPSON()
        {
            PS3.SetMemory(30236696U, new byte[1]);
            byte[] bytes = Encoding.ASCII.GetBytes("^8%i ^5FPS\0");
            PS3.SetMemory(9319056U, bytes);
            byte[] buffer = new byte[4]
            {
          (byte) 96,
          (byte) 0,
          (byte) 0,
          (byte) 0
            };
            PS3.SetMemory(229356U, buffer);
        }
        public static void FPSOFF()
        {
            PS3.SetMemory(30236696U, new byte[1]
              {
          (byte) 1
              });
            PS3.SetMemory(9319824U, new byte[26]
            {
          (byte) 37,
          (byte) 105,
          (byte) 102,
          (byte) 112,
          (byte) 115,
          (byte) 32,
          (byte) 47,
          (byte) 32,
          (byte) 37,
          (byte) 48,
          (byte) 50,
          (byte) 105,
          (byte) 109,
          (byte) 115,
          (byte) 40,
          (byte) 115,
          (byte) 118,
          (byte) 41,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
            });
            PS3.SetMemory(229356U, new byte[4]
            {
          (byte) 65,
          (byte) 130,
          (byte) 8,
          (byte) 240
            });
        }
        public static void HOSTON()
        {
            MessageBox.Show("Force Host ON Have Funn :D", "Force Host");
            byte[] buffer = new byte[]
            {
                    1
            };
            PS3.SetMemory(30236696u, buffer);
        }
        public static void HOSTOFF()
        {
            MessageBox.Show("Force Host OFF", "Force Host");
            byte[] buffer2 = new byte[1];
            PS3.SetMemory(30236696u, buffer2);
        }

        public static void RedBoxOFF()
        {
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            byte[] array2 = array;
            PS3.SetMemory(492512u, array2);
        }

        public static void RedBoxON()
        {
            PS3.SetMemory(492512u, new byte[]
                {
                56,
                96,
                0,
                1
                });
        }
        public static void FunnyON()
        {
            PS3.SetMemory(9726532u, new byte[]
         {
                    62
         });
        }
        public static void FunnyOFF()
        {
            PS3.SetMemory(9726532u, new byte[]
                {
                    60
                });
        }
        public static void VisionON()
        {
            PS3.SetMemory(7890048u, new byte[]
                {
                    63,
                    132
                });
        }
        public static void VisionOFF()
        {
            PS3.SetMemory(7890048u, new byte[]
             {
                63,
                128
             });
        }

        public static void ScreenON()
        {
            PS3.SetMemory(9726477u, new byte[]
                 {
                    11,
                    22
                 });
        }
        public static void ScreenOFF()
        {
            PS3.SetMemory(9726476u, new byte[]
                 {
                    63,
                    128
                 });
        }
    }
}

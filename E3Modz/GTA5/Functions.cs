using PS3Lib;
using PylezZo_GTAV_Extreme_Tool.Pylo;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E3Modz.GTA5
{
    // Token: 0x02000015 RID: 21
    internal sealed class Functions
    {
        // Token: 0x0600034E RID: 846 RVA: 0x00085434 File Offset: 0x00083634
        public static void GIVE_ACHIEVEMENT_TO_PLAYER(Functions.Trophies achievement)
        {
            bool flag = !Functions.HAS_ACHIEVEMENT_BEEN_PASSED((int)achievement);
            if (flag)
            {
                ClassicRPC.Call(Natives.GIVE_ACHIEVEMENT_TO_PLAYER, new object[]
                {
                    (int)achievement
                });
            }
        }

        // Token: 0x0600034F RID: 847 RVA: 0x0008546C File Offset: 0x0008366C
        public static bool HAS_ACHIEVEMENT_BEEN_PASSED(int achievement)
        {
            return Convert.ToBoolean(ClassicRPC.Call(Natives.HAS_ACHIEVEMENT_BEEN_PASSED, new object[]
            {
                achievement
            }));
        }

        // Token: 0x04000F8D RID: 3981
        public static PS3API PS3 = new PS3API(SelectAPI.TargetManager);

        // Token: 0x04000F8E RID: 3982
        public static uint uint_1 = 0u;

        // Token: 0x04000F8F RID: 3983
        public static uint uint_2 = 0u;

        // Token: 0x04000F90 RID: 3984
        public static uint uint_3 = 0u;

        // Token: 0x04000F91 RID: 3985
        public static string UserName = "";

        // Token: 0x04000F92 RID: 3986
        public static string KeyNumber = "";

        // Token: 0x04000F93 RID: 3987
        public static byte[] byte_0 = new byte[]
        {
            65,
            78,
            78,
            73,
            72,
            76,
            0,
            0,
            0
        };

        // Token: 0x04000F94 RID: 3988
        public static byte[] byte_1 = new byte[]
        {
            179,
            155,
            10,
            230
        };

        // Token: 0x04000F95 RID: 3989
        public static byte[] byte_2 = new byte[16777216];

        // Token: 0x04000F96 RID: 3990
        private static bool ContinueWP = true;

        // Token: 0x02000046 RID: 70
        public sealed class Addresses
        {
            // Token: 0x0400266C RID: 9836
            public static int PICKUP_MONEY_PAPER_BAG = 1897726628;

            // Token: 0x0400266D RID: 9837
            public static int PICKUP_AMMO_BULLET_MP = 1426343849;

            // Token: 0x0400266E RID: 9838
            public static int PICKUP_AMMO_MISSILE_MP = -107080240;

            // Token: 0x0400266F RID: 9839
            public static int PICKUP_ARMOUR_STANDARD = 1274757841;

            // Token: 0x04002670 RID: 9840
            public static int PICKUP_HEALTH_SNACK = 483577702;

            // Token: 0x04002671 RID: 9841
            public static int PICKUP_HEALTH_STANDARD = -1888453608;

            // Token: 0x04002672 RID: 9842
            public static int PICKUP_MONEY_CASE = -831529621;

            // Token: 0x04002673 RID: 9843
            public static int PICKUP_MONEY_DEP_BAG = 545862290;

            // Token: 0x04002674 RID: 9844
            public static int PICKUP_MONEY_MED_BAG = 341217064;

            // Token: 0x04002675 RID: 9845
            public static int PICKUP_MONEY_PURSE = 513448440;

            // Token: 0x04002676 RID: 9846
            public static int PICKUP_MONEY_SECURITY_CASE = -562499202;

            // Token: 0x04002677 RID: 9847
            public static int PICKUP_MONEY_VARIABLE = -31919185;

            // Token: 0x04002678 RID: 9848
            public static int PICKUP_MONEY_WALLET = 1575005502;

            // Token: 0x04002679 RID: 9849
            public static int PICKUP_PARACHUTE = 1735599485;

            // Token: 0x0400267A RID: 9850
            public static int PICKUP_PORTABLE_PACKAGE = -2136239332;

            // Token: 0x0400267B RID: 9851
            public static int PICKUP_VEHICLE_HEALTH_STANDARD = 160266735;
        }

        // Token: 0x02000047 RID: 71
        public sealed class Weapons
        {
            // Token: 0x0400267C RID: 9852
            public static uint[] WeaponsU = new uint[]
            {
                2937143193u,
                324506233u,
                4194021054u,
                584646201u,
                3220176749u,
                3800352039u,
                4024951519u,
                600439132u,
                4192643659u,
                2294779575u,
                28811031u,
                2132975508u,
                2640438543u,
                2694266206u,
                2210333304u,
                2144741730u,
                171789620u,
                1593441988u,
                148160082u,
                2227010557u,
                2460120199u,
                4256881901u,
                101631238u,
                2138347493u,
                1233104067u,
                1198879012u,
                1141786504u,
                2481070269u,
                2726580491u,
                1305664598u,
                1627465347u,
                1317494643u,
                3523564046u,
                984333226u,
                205991906u,
                1672152130u,
                2578778090u,
                3342088282u,
                324215364u,
                1119849093u,
                615608432u,
                2828843422u,
                1737195953u,
                883325847u,
                453432689u,
                2578377531u,
                2874559379u,
                487013001u,
                2017895192u,
                4256991824u,
                100416529u,
                126349499u,
                3218215474u,
                3231910285u,
                741814745u,
                1752584910u,
                911657153u,
                2508868239u,
                2634544996u,
                2982836145u,
                736523883u,
                2725352035u,
                137902532u
            };

            // Token: 0x0400267D RID: 9853
            public static uint ADVANCEDRIFLE = 2937143193u;

            // Token: 0x0400267E RID: 9854
            public static uint AIRSTRIKE_ROCKET = 324506233u;

            // Token: 0x0400267F RID: 9855
            public static uint ANIMAL = 4194021054u;

            // Token: 0x04002680 RID: 9856
            public static uint APPISTOL = 584646201u;

            // Token: 0x04002681 RID: 9857
            public static uint ASSAULTRIFLE = 3220176749u;

            // Token: 0x04002682 RID: 9858
            public static uint ASSAULTSHOTGUN = 3800352039u;

            // Token: 0x04002683 RID: 9859
            public static uint ASSAULTSMG = 4024951519u;

            // Token: 0x04002684 RID: 9860
            public static uint BALL = 600439132u;

            // Token: 0x04002685 RID: 9861
            public static uint BOTTLE = 4192643659u;

            // Token: 0x04002686 RID: 9862
            public static uint BRIEFCASE = 2294779575u;

            // Token: 0x04002687 RID: 9863
            public static uint BRIEFCASE_02 = 28811031u;

            // Token: 0x04002688 RID: 9864
            public static uint BULLPUPRIFLE = 2132975508u;

            // Token: 0x04002689 RID: 9865
            public static uint BULLPUPSHOTGUN = 2640438543u;

            // Token: 0x0400268A RID: 9866
            public static uint BZGAS = 2694266206u;

            // Token: 0x0400268B RID: 9867
            public static uint CARBINERIFLE = 2210333304u;

            // Token: 0x0400268C RID: 9868
            public static uint COMBATMG = 2144741730u;

            // Token: 0x0400268D RID: 9869
            public static uint COMBATPDW = 171789620u;

            // Token: 0x0400268E RID: 9870
            public static uint COMBATPISTOL = 1593441988u;

            // Token: 0x0400268F RID: 9871
            public static uint COUGAR = 148160082u;

            // Token: 0x04002690 RID: 9872
            public static uint CROWBAR = 2227010557u;

            // Token: 0x04002691 RID: 9873
            public static uint DAGGER = 2460120199u;

            // Token: 0x04002692 RID: 9874
            public static uint DIGISCANNER = 4256881901u;

            // Token: 0x04002693 RID: 9875
            public static uint FIREEXTINGUISHER = 101631238u;

            // Token: 0x04002694 RID: 9876
            public static uint FIREWORK = 2138347493u;

            // Token: 0x04002695 RID: 9877
            public static uint FLARE = 1233104067u;

            // Token: 0x04002696 RID: 9878
            public static uint FLAREGUN = 1198879012u;

            // Token: 0x04002697 RID: 9879
            public static uint GOLFCLUB = 1141786504u;

            // Token: 0x04002698 RID: 9880
            public static uint GRENADE = 2481070269u;

            // Token: 0x04002699 RID: 9881
            public static uint GRENADELAUNCHER = 2726580491u;

            // Token: 0x0400269A RID: 9882
            public static uint GRENADELAUNCHER_SMOKE = 1305664598u;

            // Token: 0x0400269B RID: 9883
            public static uint GUSENBERG = 1627465347u;

            // Token: 0x0400269C RID: 9884
            public static uint HAMMER = 1317494643u;

            // Token: 0x0400269D RID: 9885
            public static uint HEAVYPISTOL = 3523564046u;

            // Token: 0x0400269E RID: 9886
            public static uint HEAVYSHOTGUN = 984333226u;

            // Token: 0x0400269F RID: 9887
            public static uint HEAVYSNIPER = 205991906u;

            // Token: 0x040026A0 RID: 9888
            public static uint HOMINGLAUNCHER = 1672152130u;

            // Token: 0x040026A1 RID: 9889
            public static uint KNIFE = 2578778090u;

            // Token: 0x040026A2 RID: 9890
            public static uint MARKSMANRIFLE = 3342088282u;

            // Token: 0x040026A3 RID: 9891
            public static uint MICROSMG = 324215364u;

            // Token: 0x040026A4 RID: 9892
            public static uint MINIGUN = 1119849093u;

            // Token: 0x040026A5 RID: 9893
            public static uint MOLOTOV = 615608432u;

            // Token: 0x040026A6 RID: 9894
            public static uint MUSKET = 2828843422u;

            // Token: 0x040026A7 RID: 9895
            public static uint NIGHTSTICK = 1737195953u;

            // Token: 0x040026A8 RID: 9896
            public static uint PETROLCAN = 883325847u;

            // Token: 0x040026A9 RID: 9897
            public static uint PISTOL = 453432689u;

            // Token: 0x040026AA RID: 9898
            public static uint PISTOL50 = 2578377531u;

            // Token: 0x040026AB RID: 9899
            public static uint PROXMINE = 2874559379u;

            // Token: 0x040026AC RID: 9900
            public static uint PUMPSHOTGUN = 487013001u;

            // Token: 0x040026AD RID: 9901
            public static uint SAWNOFFSHOTGUN = 2017895192u;

            // Token: 0x040026AE RID: 9902
            public static uint SMOKEGRENADE = 4256991824u;

            // Token: 0x040026AF RID: 9903
            public static uint SNIPERRIFLE = 100416529u;

            // Token: 0x040026B0 RID: 9904
            public static uint SNOWBALL = 126349499u;

            // Token: 0x040026B1 RID: 9905
            public static uint SNSPISTOL = 3218215474u;

            // Token: 0x040026B2 RID: 9906
            public static uint SPECIALCARBINE = 3231910285u;

            // Token: 0x040026B3 RID: 9907
            public static uint STICKYBOMB = 741814745u;

            // Token: 0x040026B4 RID: 9908
            public static uint STINGER = 1752584910u;

            // Token: 0x040026B5 RID: 9909
            public static uint STUNGUN = 911657153u;

            // Token: 0x040026B6 RID: 9910
            public static uint uint_0 = 2508868239u;

            // Token: 0x040026B7 RID: 9911
            public static uint uint_1 = 2634544996u;

            // Token: 0x040026B8 RID: 9912
            public static uint uint_2 = 2982836145u;

            // Token: 0x040026B9 RID: 9913
            public static uint uint_3 = 736523883u;

            // Token: 0x040026BA RID: 9914
            public static uint UNARMED = 2725352035u;

            // Token: 0x040026BB RID: 9915
            public static uint VINTAGEPISTOL = 137902532u;
        }

        // Token: 0x02000048 RID: 72
        public enum Trophies
        {
            // Token: 0x040026BD RID: 9917
            Welcom_To_Los_Santos = 1,
            // Token: 0x040026BE RID: 9918
            Friendship,
            // Token: 0x040026BF RID: 9919
            A_fair_days,
            // Token: 0x040026C0 RID: 9920
            The_Moment_of_Truth,
            // Token: 0x040026C1 RID: 9921
            To_live_or_die,
            // Token: 0x040026C2 RID: 9922
            Diamond_Hard,
            // Token: 0x040026C3 RID: 9923
            Subversive,
            // Token: 0x040026C4 RID: 9924
            Blitzed,
            // Token: 0x040026C5 RID: 9925
            Small_Town_Big_Job,
            // Token: 0x040026C6 RID: 9926
            The_Government_Gimps,
            // Token: 0x040026C7 RID: 9927
            The_Big_One,
            // Token: 0x040026C8 RID: 9928
            Solid_Gold,
            // Token: 0x040026C9 RID: 9929
            Career_Criminal,
            // Token: 0x040026CA RID: 9930
            Trophie_14,
            // Token: 0x040026CB RID: 9931
            Fare_in_Love_and_War,
            // Token: 0x040026CC RID: 9932
            TP_Industries_Arms_Rac,
            // Token: 0x040026CD RID: 9933
            Trophie_17,
            // Token: 0x040026CE RID: 9934
            From_Beyond_the_Stars,
            // Token: 0x040026CF RID: 9935
            A_Mystery,
            // Token: 0x040026D0 RID: 9936
            Waste_Management,
            // Token: 0x040026D1 RID: 9937
            Red_Mist,
            // Token: 0x040026D2 RID: 9938
            Trophie_22,
            // Token: 0x040026D3 RID: 9939
            Kifflom,
            // Token: 0x040026D4 RID: 9940
            Three_Man_Army,
            // Token: 0x040026D5 RID: 9941
            Out_of_your_Depth,
            // Token: 0x040026D6 RID: 9942
            Altruist_Acolyte,
            // Token: 0x040026D7 RID: 9943
            Trophie_27,
            // Token: 0x040026D8 RID: 9944
            Trading_Pure_Alpha,
            // Token: 0x040026D9 RID: 9945
            Pimp_my_Sidearm,
            // Token: 0x040026DA RID: 9946
            Wanted_Alive,
            // Token: 0x040026DB RID: 9947
            Los_Santos_Customs,
            // Token: 0x040026DC RID: 9948
            Close_Shave,
            // Token: 0x040026DD RID: 9949
            Off_the_Plane,
            // Token: 0x040026DE RID: 9950
            Trophie_34,
            // Token: 0x040026DF RID: 9951
            Trophie_35,
            // Token: 0x040026E0 RID: 9952
            Trophie_36,
            // Token: 0x040026E1 RID: 9953
            Trophie_37,
            // Token: 0x040026E2 RID: 9954
            Trophie_38,
            // Token: 0x040026E3 RID: 9955
            Trophie_39,
            // Token: 0x040026E4 RID: 9956
            Backseat_Driver,
            // Token: 0x040026E5 RID: 9957
            Trophie_41,
            // Token: 0x040026E6 RID: 9958
            Trophie_42,
            // Token: 0x040026E7 RID: 9959
            Trophie_43,
            // Token: 0x040026E8 RID: 9960
            Trophie_44,
            // Token: 0x040026E9 RID: 9961
            Trophie_45,
            // Token: 0x040026EA RID: 9962
            Trophie_46,
            // Token: 0x040026EB RID: 9963
            Trophie_47,
            // Token: 0x040026EC RID: 9964
            Trophie_48,
            // Token: 0x040026ED RID: 9965
            Trophie_49,
            // Token: 0x040026EE RID: 9966
            Trophie_50,
            // Token: 0x040026EF RID: 9967
            Trophie_51,
            // Token: 0x040026F0 RID: 9968
            Trophie_52,
            // Token: 0x040026F1 RID: 9969
            Trophie_53,
            // Token: 0x040026F2 RID: 9970
            Trophie_54,
            // Token: 0x040026F3 RID: 9971
            Trophie_55,
            // Token: 0x040026F4 RID: 9972
            Trophie_56,
            // Token: 0x040026F5 RID: 9973
            Trophie_57,
            // Token: 0x040026F6 RID: 9974
            Trophie_58
        }

        // Token: 0x02000049 RID: 73
        public static class MsgColors
        {
            // Token: 0x040026F7 RID: 9975
            public static string Red = "~r~";

            // Token: 0x040026F8 RID: 9976
            public static string Blue = "~b~";

            // Token: 0x040026F9 RID: 9977
            public static string Green = "~g~";

            // Token: 0x040026FA RID: 9978
            public static string Yellow = "~y~";

            // Token: 0x040026FB RID: 9979
            public static string Purple = "~p~";

            // Token: 0x040026FC RID: 9980
            public static string Orange = "~o~";

            // Token: 0x040026FD RID: 9981
            public static string Grey = "~c~";

            // Token: 0x040026FE RID: 9982
            public static string DarkGrey = "~m~";

            // Token: 0x040026FF RID: 9983
            public static string Black = "~u~";

            // Token: 0x04002700 RID: 9984
            public static string SkipLine = "~n~";

            // Token: 0x04002701 RID: 9985
            public static string White = "~s~";

            // Token: 0x04002702 RID: 9986
            public static string RockstarVerifiedIcon = "¦";

            // Token: 0x04002703 RID: 9987
            public static string RockstarIcon = "÷";

            // Token: 0x04002704 RID: 9988
            public static string RockstarIcon2 = "∑";
        }

        // Token: 0x0200004A RID: 74
        public sealed class RPCFunc
        {
            // Token: 0x060004B8 RID: 1208 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
            public static void TaskBossModeStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_1.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_1.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_1 = new CancellationTokenSource();
                        Functions.RPCFunc.token_1 = Functions.RPCFunc.tokenSource_1.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_1.IsCancellationRequested)
                        {
                            for (int i = 0; i < 16; i++)
                            {
                                bool flag2 = Functions.RPCFunc.IS_PLAYER_TARGETING_ENTITY(i, Functions.RPCFunc.PLAYER_PED_ID());
                                if (flag2)
                                {
                                    int num = Functions.RPCFunc.GET_PLAYER_PED(i);
                                    float[] coords = Functions.RPCFunc.GET_ENTITY_COORDS(num);
                                    int type = 5;
                                    GTA5Main.Owned_Explosion(num, coords, type);
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_1);
                }
            }

            // Token: 0x060004B9 RID: 1209 RVA: 0x000AFC24 File Offset: 0x000ADE24
            public static void TaskExplosiveBulletsStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_2.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_2.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_2 = new CancellationTokenSource();
                        Functions.RPCFunc.token_2 = Functions.RPCFunc.tokenSource_2.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_2.IsCancellationRequested)
                        {
                            int playerIndex = Functions.RPCFunc.PLAYER_PED_ID();
                            GTA5Main.ExplosiveBullets(playerIndex);
                        }
                    }, Functions.RPCFunc.token_2);
                }
            }

            // Token: 0x060004BA RID: 1210 RVA: 0x000AFCA8 File Offset: 0x000ADEA8
            public static void TaskSuperManStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_3.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_3.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_3 = new CancellationTokenSource();
                        Functions.RPCFunc.token_3 = Functions.RPCFunc.tokenSource_3.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        int num = Functions.RPCFunc.PLAYER_PED_ID();
                        while (!Functions.RPCFunc.token_3.IsCancellationRequested)
                        {
                            bool flag2 = Functions.RPCFunc.IS_ENTITY_IN_AIR(num) != 0;
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    float[] force = new float[]
                                    {
                                        100f,
                                        100f,
                                        50f
                                    };
                                    float[] pos = new float[]
                                    {
                                        140f,
                                        140f,
                                        60f
                                    };
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(num, force, pos);
                                }
                            }
                            else
                            {
                                bool flag4 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                if (flag4)
                                {
                                    float[] force2 = new float[]
                                    {
                                        0f,
                                        0f,
                                        100f
                                    };
                                    float[] pos2 = new float[3];
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(num, force2, pos2);
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_3);
                }
            }

            // Token: 0x060004BB RID: 1211 RVA: 0x000AFD2C File Offset: 0x000ADF2C
            public static void TaskDisableActionsStart(bool toggle, int clientPED)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_4.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_4.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_4 = new CancellationTokenSource();
                        Functions.RPCFunc.token_4 = Functions.RPCFunc.tokenSource_4.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_4.IsCancellationRequested)
                        {
                            GTA5Main.CLEAR_PED_TASKS_IMMEDIATLY(clientPED);
                        }
                    }, Functions.RPCFunc.token_4);
                }
            }

            // Token: 0x060004BC RID: 1212 RVA: 0x000AFDAC File Offset: 0x000ADFAC
            public static void TaskForceFieldStart(bool toggle, int clientPED)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_5.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_5.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_5 = new CancellationTokenSource();
                        Functions.RPCFunc.token_5 = Functions.RPCFunc.tokenSource_5.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_5.IsCancellationRequested)
                        {
                            bool flag2 = Functions.RPCFunc.IS_PLAYER_ALIVE(clientPED);
                            if (flag2)
                            {
                                float[] coords = Functions.RPCFunc.GET_ENTITY_COORDS(clientPED);
                                GTA5Main.Owned_Explosion(clientPED, coords, 5);
                            }
                        }
                    }, Functions.RPCFunc.token_5);
                }
            }

            // Token: 0x060004BD RID: 1213 RVA: 0x000AFE2C File Offset: 0x000AE02C
            public static void TaskInfiniteStarsStart(bool toggle, int clientPED, int stars)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_11.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_11.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_11 = new CancellationTokenSource();
                        Functions.RPCFunc.token_11 = Functions.RPCFunc.tokenSource_11.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_11.IsCancellationRequested)
                        {
                            GTA5Main.GiveStars(clientPED, stars);
                        }
                    }, Functions.RPCFunc.token_11);
                }
            }

            // Token: 0x060004BE RID: 1214 RVA: 0x000AFEB4 File Offset: 0x000AE0B4
            public static void TaskSuperManVehicleStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_14.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_14.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_14 = new CancellationTokenSource();
                        Functions.RPCFunc.token_14 = Functions.RPCFunc.tokenSource_14.Token;
                    }
                    int pedID = Functions.RPCFunc.PLAYER_PED_ID();
                    int Veh = GTA5Main.GET_VEHICLE_PED_IS_IN(pedID);
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_14.IsCancellationRequested)
                        {
                            bool flag2 = Functions.RPCFunc.IS_ENTITY_IN_AIR(Veh) != 0;
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    float[] force = new float[]
                                    {
                                        100f,
                                        100f,
                                        70f
                                    };
                                    float[] pos = new float[]
                                    {
                                        100f,
                                        100f,
                                        70f
                                    };
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, force, pos);
                                }
                            }
                            else
                            {
                                bool flag4 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                if (flag4)
                                {
                                    float[] force2 = new float[]
                                    {
                                        0f,
                                        0f,
                                        90f
                                    };
                                    float[] pos2 = new float[3];
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, force2, pos2);
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_14);
                }
            }

            public static void TaskBindFixVehicleStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_15.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_15.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_15 = new CancellationTokenSource();
                        Functions.RPCFunc.token_15 = Functions.RPCFunc.tokenSource_15.Token;
                    }
                    int pedID = Functions.RPCFunc.PLAYER_PED_ID();
                    int num = GTA5Main.GET_VEHICLE_PED_IS_IN(pedID);
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_15.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    GTA5Main.FixVehicle();
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        GTA5Main.FixVehicle();
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            GTA5Main.FixVehicle();
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                GTA5Main.FixVehicle();
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    GTA5Main.FixVehicle();
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        GTA5Main.FixVehicle();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_15);
                }
            }

            // Token: 0x060004C0 RID: 1216 RVA: 0x000AFFD0 File Offset: 0x000AE1D0
            public static void TaskLoopShootStart(bool toggle, int clientPED, string WeapStr)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_24.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_24.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_24 = new CancellationTokenSource();
                        Functions.RPCFunc.token_24 = Functions.RPCFunc.tokenSource_24.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        int getplayerped = Functions.RPCFunc.PLAYER_PED_ID();
                        uint value = Functions.RPCFunc.STRINGHASH(WeapStr);
                        while (!Functions.RPCFunc.token_24.IsCancellationRequested)
                        {
                            float[] coord = Functions.RPCFunc.GET_ENTITY_COORDS(getplayerped);
                            float[] coord2 = Functions.RPCFunc.GET_ENTITY_COORDS(clientPED);
                            Functions.RPCFunc.SHOOT_SINGLE_BULLET_BETWEEN_COORDS(coord, coord2, 0, 0, Convert.ToInt32(value), Functions.RPCFunc.PLAYER_PED_ID(), 0, 0, 700.0);
                        }
                    }, Functions.RPCFunc.token_24);
                }
            }


            // Token: 0x060004C1 RID: 1217 RVA: 0x000B0058 File Offset: 0x000AE258
            public static void TaskBindForwardBoostVehicleStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_16.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_16.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_16 = new CancellationTokenSource();
                        Functions.RPCFunc.token_16 = Functions.RPCFunc.tokenSource_16.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_16.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    GTA5Main.BoostVehicle();
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        GTA5Main.BoostVehicle();
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            GTA5Main.BoostVehicle();
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                GTA5Main.BoostVehicle();
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    GTA5Main.BoostVehicle();
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        GTA5Main.BoostVehicle();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_16);
                }
            }

            // Token: 0x060004C2 RID: 1218 RVA: 0x000B00D8 File Offset: 0x000AE2D8
            public static void TaskBindShootMissileStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_25.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_25.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_25 = new CancellationTokenSource();
                        Functions.RPCFunc.token_25 = Functions.RPCFunc.tokenSource_25.Token;
                    }
                    int PID = Functions.RPCFunc.PLAYER_PED_ID();
                    int Veh = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(PID);
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_25.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    float[] array = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[]
                                    {
                                        0.6f,
                                        0.6707f,
                                        0.3711f
                                    });
                                    float[] array2 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[]
                                    {
                                        -0.6f,
                                        0.6707f,
                                        0.3711f
                                    });
                                    float[] array3 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[]
                                    {
                                        0.6f,
                                        5.0707f,
                                        0.3711f
                                    });
                                    float[] array4 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(Veh, new float[]
                                    {
                                        -0.6f,
                                        5.0707f,
                                        0.3711f
                                    });
                                    uint num = 250u;
                                    uint num2 = Functions.RPCFunc.STRINGHASH("WEAPON_RPG");
                                    float num3 = 1500f;
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                    {
                                        array[0],
                                        array[1],
                                        array[2],
                                        array3[0],
                                        array3[1],
                                        array3[2],
                                        num,
                                        0,
                                        num2,
                                        PID,
                                        1,
                                        1,
                                        num3
                                    });
                                    RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                    {
                                        array2[0],
                                        array2[1],
                                        array2[2],
                                        array4[0],
                                        array4[1],
                                        array4[2],
                                        num,
                                        0,
                                        num2,
                                        PID,
                                        1,
                                        1,
                                        num3
                                    });
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        float[] array5 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                        {
                                            0.6f,
                                            0.6707f,
                                            0.3711f
                                        });
                                        float[] array6 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                        {
                                            -0.6f,
                                            0.6707f,
                                            0.3711f
                                        });
                                        float[] array7 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                        {
                                            0.6f,
                                            5.0707f,
                                            0.3711f
                                        });
                                        float[] array8 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                        {
                                            -0.6f,
                                            5.0707f,
                                            0.3711f
                                        });
                                        uint num4 = 250u;
                                        uint num5 = Functions.RPCFunc.STRINGHASH("WEAPON_RPG");
                                        float num6 = 1500f;
                                        RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                        {
                                            array5[0],
                                            array5[1],
                                            array5[2],
                                            array7[0],
                                            array7[1],
                                            array7[2],
                                            num4,
                                            0,
                                            num5,
                                            PID,
                                            1,
                                            1,
                                            num6
                                        });
                                        RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                        {
                                            array6[0],
                                            array6[1],
                                            array6[2],
                                            array8[0],
                                            array8[1],
                                            array8[2],
                                            num4,
                                            0,
                                            num5,
                                            PID,
                                            1,
                                            1,
                                            num6
                                        });
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            float[] array9 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                            {
                                                0.6f,
                                                0.6707f,
                                                0.3711f
                                            });
                                            float[] array10 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                            {
                                                -0.6f,
                                                0.6707f,
                                                0.3711f
                                            });
                                            float[] array11 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                            {
                                                0.6f,
                                                5.0707f,
                                                0.3711f
                                            });
                                            float[] array12 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                            {
                                                -0.6f,
                                                5.0707f,
                                                0.3711f
                                            });
                                            uint num7 = 250u;
                                            uint num8 = Functions.RPCFunc.STRINGHASH("WEAPON_RPG");
                                            float num9 = 1500f;
                                            RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                            {
                                                array9[0],
                                                array9[1],
                                                array9[2],
                                                array11[0],
                                                array11[1],
                                                array11[2],
                                                num7,
                                                0,
                                                num8,
                                                PID,
                                                1,
                                                1,
                                                num9
                                            });
                                            RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                            {
                                                array10[0],
                                                array10[1],
                                                array10[2],
                                                array12[0],
                                                array12[1],
                                                array12[2],
                                                num7,
                                                0,
                                                num8,
                                                PID,
                                                1,
                                                1,
                                                num9
                                            });
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                float[] array13 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                                {
                                                    0.6f,
                                                    0.6707f,
                                                    0.3711f
                                                });
                                                float[] array14 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                                {
                                                    -0.6f,
                                                    0.6707f,
                                                    0.3711f
                                                });
                                                float[] array15 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                                {
                                                    0.6f,
                                                    5.0707f,
                                                    0.3711f
                                                });
                                                float[] array16 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(PID, new float[]
                                                {
                                                    -0.6f,
                                                    5.0707f,
                                                    0.3711f
                                                });
                                                uint num10 = 250u;
                                                uint num11 = Functions.RPCFunc.STRINGHASH("WEAPON_RPG");
                                                float num12 = 1500f;
                                                RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                                {
                                                    array13[0],
                                                    array13[1],
                                                    array13[2],
                                                    array15[0],
                                                    array15[1],
                                                    array15[2],
                                                    num10,
                                                    0,
                                                    num11,
                                                    PID,
                                                    1,
                                                    1,
                                                    num12
                                                });
                                                RPCHook.Call(Natives.SHOOT_SINGLE_BULLET_BETWEEN_COORDS, new object[]
                                                {
                                                    array14[0],
                                                    array14[1],
                                                    array14[2],
                                                    array16[0],
                                                    array16[1],
                                                    array16[2],
                                                    num10,
                                                    0,
                                                    num11,
                                                    PID,
                                                    1,
                                                    1,
                                                    num12
                                                });
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_25);
                }
            }

            // Token: 0x060004C3 RID: 1219 RVA: 0x000B0180 File Offset: 0x000AE380
            public static void TaskBindBackwardBoostVehicleStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_17.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_17.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_17 = new CancellationTokenSource();
                        Functions.RPCFunc.token_17 = Functions.RPCFunc.tokenSource_17.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_17.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    GTA5Main.BackwardBoostVehicle();
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        GTA5Main.BackwardBoostVehicle();
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            GTA5Main.BackwardBoostVehicle();
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                GTA5Main.BackwardBoostVehicle();
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    GTA5Main.BackwardBoostVehicle();
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        GTA5Main.BackwardBoostVehicle();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_17);
                }
            }

            // Token: 0x060004C4 RID: 1220 RVA: 0x000B0200 File Offset: 0x000AE400
            public static void TaskBindApplyNosVehicleStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_18.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_18.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_18 = new CancellationTokenSource();
                        Functions.RPCFunc.token_18 = Functions.RPCFunc.tokenSource_18.Token;
                    }
                    int PID = Functions.RPCFunc.PLAYER_PED_ID();
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_18.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    int entity = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                    int num = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                    bool flag4 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                    if (flag4)
                                    {
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                        {
                                            num,
                                            1,
                                            0
                                        });
                                        float[] array = new float[3];
                                        array[1] = 10f;
                                        float[] force = array;
                                        float[] array2 = new float[3];
                                        array2[1] = 10f;
                                        float[] pos = array2;
                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity, force, pos);
                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                        {
                                            num,
                                            0,
                                            0
                                        });
                                    }
                                }
                            }
                            else
                            {
                                bool flag5 = buttP == "L2";
                                if (flag5)
                                {
                                    bool flag6 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag6)
                                    {
                                        int entity2 = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                        int num2 = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                        bool flag7 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                        if (flag7)
                                        {
                                            ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                            {
                                                num2,
                                                1,
                                                0
                                            });
                                            float[] array3 = new float[3];
                                            array3[1] = 10f;
                                            float[] force2 = array3;
                                            float[] array4 = new float[3];
                                            array4[1] = 10f;
                                            float[] pos2 = array4;
                                            Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity2, force2, pos2);
                                            ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                            {
                                                num2,
                                                0,
                                                0
                                            });
                                        }
                                    }
                                }
                                else
                                {
                                    bool flag8 = buttP == "R3";
                                    if (flag8)
                                    {
                                        bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag9)
                                        {
                                            int entity3 = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                            int num3 = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                            bool flag10 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                            if (flag10)
                                            {
                                                ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                {
                                                    num3,
                                                    1,
                                                    0
                                                });
                                                float[] array5 = new float[3];
                                                array5[1] = 10f;
                                                float[] force3 = array5;
                                                float[] array6 = new float[3];
                                                array6[1] = 10f;
                                                float[] pos3 = array6;
                                                Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity3, force3, pos3);
                                                ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                {
                                                    num3,
                                                    0,
                                                    0
                                                });
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool flag11 = buttP == "L3";
                                        if (flag11)
                                        {
                                            bool flag12 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag12)
                                            {
                                                int entity4 = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                                int num4 = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                                bool flag13 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                                if (flag13)
                                                {
                                                    ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                    {
                                                        num4,
                                                        1,
                                                        0
                                                    });
                                                    float[] array7 = new float[3];
                                                    array7[1] = 10f;
                                                    float[] force4 = array7;
                                                    float[] array8 = new float[3];
                                                    array8[1] = 10f;
                                                    float[] pos4 = array8;
                                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity4, force4, pos4);
                                                    ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                    {
                                                        num4,
                                                        0,
                                                        0
                                                    });
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bool flag14 = buttP == "L1";
                                            if (flag14)
                                            {
                                                bool flag15 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag15)
                                                {
                                                    int entity5 = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                                    int num5 = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                                    bool flag16 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                                    if (flag16)
                                                    {
                                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                        {
                                                            num5,
                                                            1,
                                                            0
                                                        });
                                                        float[] array9 = new float[3];
                                                        array9[1] = 10f;
                                                        float[] force5 = array9;
                                                        float[] array10 = new float[3];
                                                        array10[1] = 10f;
                                                        float[] pos5 = array10;
                                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity5, force5, pos5);
                                                        ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                        {
                                                            num5,
                                                            0,
                                                            0
                                                        });
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                bool flag17 = buttP == "DR";
                                                if (flag17)
                                                {
                                                    bool flag18 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag18)
                                                    {
                                                        int entity6 = GTA5Main.GET_VEHICLE_PED_IS_IN(PID);
                                                        int num6 = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(PID);
                                                        bool flag19 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                                                        if (flag19)
                                                        {
                                                            ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                            {
                                                                num6,
                                                                1,
                                                                0
                                                            });
                                                            float[] array11 = new float[3];
                                                            array11[1] = 10f;
                                                            float[] force6 = array11;
                                                            float[] array12 = new float[3];
                                                            array12[1] = 10f;
                                                            float[] pos6 = array12;
                                                            Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity6, force6, pos6);
                                                            ClassicRPC.Call(Natives.SET_VEHICLE_BOOST_ACTIVE, new object[]
                                                            {
                                                                num6,
                                                                0,
                                                                0
                                                            });
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_18);
                }
            }

            // Token: 0x060004C5 RID: 1221 RVA: 0x000B0298 File Offset: 0x000AE498
            public static void TaskBindJumpCarStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_19.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_19.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_19 = new CancellationTokenSource();
                        Functions.RPCFunc.token_19 = Functions.RPCFunc.tokenSource_19.Token;
                    }
                    int int_ = Functions.RPCFunc.PLAYER_PED_ID();
                    int Veh = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(int_);
                    float[] jump = new float[3];
                    jump[1] = 5f;
                    jump[2] = 10f;
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_19.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, jump, new float[3]);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_19);
                }
            }

            // Token: 0x060004C6 RID: 1222 RVA: 0x000B0364 File Offset: 0x000AE564
            public static void TaskBindStopVehStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_21.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_21.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_21 = new CancellationTokenSource();
                        Functions.RPCFunc.token_21 = Functions.RPCFunc.tokenSource_21.Token;
                    }
                    int int_ = Functions.RPCFunc.PLAYER_PED_ID();
                    int Veh = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(int_);
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_21.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        Functions.RPCFunc.VEHICLE_SPEED(Veh, 0f);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_21);
                }
            }

            // Token: 0x060004C7 RID: 1223 RVA: 0x000B0404 File Offset: 0x000AE604
            public static void TaskBindCatapultVehStart(bool toggle, string buttP)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_22.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_22.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_22 = new CancellationTokenSource();
                        Functions.RPCFunc.token_22 = Functions.RPCFunc.tokenSource_22.Token;
                    }
                    int int_ = Functions.RPCFunc.PLAYER_PED_ID();
                    int Veh = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(int_);
                    float[] catap = new float[3];
                    catap[1] = 30f;
                    catap[2] = 70f;
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_22.IsCancellationRequested)
                        {
                            bool flag2 = buttP == "R1";
                            if (flag2)
                            {
                                bool flag3 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R1);
                                if (flag3)
                                {
                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                }
                            }
                            else
                            {
                                bool flag4 = buttP == "L2";
                                if (flag4)
                                {
                                    bool flag5 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L2);
                                    if (flag5)
                                    {
                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                    }
                                }
                                else
                                {
                                    bool flag6 = buttP == "R3";
                                    if (flag6)
                                    {
                                        bool flag7 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.R3);
                                        if (flag7)
                                        {
                                            Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                        }
                                    }
                                    else
                                    {
                                        bool flag8 = buttP == "L3";
                                        if (flag8)
                                        {
                                            bool flag9 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L3);
                                            if (flag9)
                                            {
                                                Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                            }
                                        }
                                        else
                                        {
                                            bool flag10 = buttP == "L1";
                                            if (flag10)
                                            {
                                                bool flag11 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.L1);
                                                if (flag11)
                                                {
                                                    Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                                }
                                            }
                                            else
                                            {
                                                bool flag12 = buttP == "DR";
                                                if (flag12)
                                                {
                                                    bool flag13 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.DpadRight);
                                                    if (flag13)
                                                    {
                                                        Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(Veh, catap, new float[3]);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, Functions.RPCFunc.token_22);
                }
            }

            // Token: 0x060004C8 RID: 1224 RVA: 0x000B04D0 File Offset: 0x000AE6D0
            public static void TaskRandomResprayStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_12.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_12.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_12 = new CancellationTokenSource();
                        Functions.RPCFunc.token_12 = Functions.RPCFunc.tokenSource_12.Token;
                    }
                    int PID = Functions.RPCFunc.PLAYER_PED_ID();
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_12.IsCancellationRequested)
                        {
                            bool flag2 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                            if (flag2)
                            {
                                int int_ = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(PID);
                                Functions.RPCFunc.SET_VEHICLE_CUSTOM_PRIM_COLOR(int_, Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255), Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255), Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255));
                                Functions.RPCFunc.SET_VEHICLE_CUSTOM_SEC_COLOR(int_, Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255), Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255), Functions.RPCFunc.GET_RANDOM_INT_IN_RANGE(0, 255));
                            }
                        }
                    }, Functions.RPCFunc.token_12);
                }
            }

            // Token: 0x060004C9 RID: 1225 RVA: 0x000B0554 File Offset: 0x000AE754
            public static void TaskTireSmokeLoopStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_13.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_13.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_13 = new CancellationTokenSource();
                        Functions.RPCFunc.token_13 = Functions.RPCFunc.tokenSource_13.Token;
                    }
                    int PID = Functions.RPCFunc.PLAYER_PED_ID();
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_13.IsCancellationRequested)
                        {
                            bool flag2 = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(PID) != 0;
                            if (flag2)
                            {
                                int num = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(PID);
                                ClassicRPC.NCall(NewNatives.TOGGLE_VEHICLE_MOD, new object[]
                                {
                                    num,
                                    20,
                                    1
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    254,
                                    254,
                                    254
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    1,
                                    1,
                                    1
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    0,
                                    0,
                                    255
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    255,
                                    0,
                                    0
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    255,
                                    255,
                                    0
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    150,
                                    0,
                                    255
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    255,
                                    175,
                                    0
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    0,
                                    255,
                                    0
                                });
                                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                                {
                                    num,
                                    255,
                                    0,
                                    255
                                });
                            }
                        }
                    }, Functions.RPCFunc.token_13);
                }
            }

            // Token: 0x060004CA RID: 1226 RVA: 0x000B05D8 File Offset: 0x000AE7D8
            public static void TaskDropMoneyStart(bool toggle, int moneyhash, int clientPED)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_6.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_6.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_6 = new CancellationTokenSource();
                        Functions.RPCFunc.token_6 = Functions.RPCFunc.tokenSource_6.Token;
                    }
                    int num = Functions.RPCFunc.PLAYER_PED_ID();
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_6.IsCancellationRequested)
                        {
                            float[] coord = Functions.RPCFunc.GET_ENTITY_COORDS(clientPED);
                            Functions.RPCFunc.CREATE_AMBIENT_PICKUP3(moneyhash, coord, 2000);
                        }
                    }, Functions.RPCFunc.token_6);
                }
            }

            // Token: 0x060004CB RID: 1227 RVA: 0x000B0664 File Offset: 0x000AE864
            public static void TaskSuperRunStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_0.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_0.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_0 = new CancellationTokenSource();
                        Functions.RPCFunc.token_0 = Functions.RPCFunc.tokenSource_0.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_0.IsCancellationRequested)
                        {
                            int entity = Functions.RPCFunc.PLAYER_PED_ID();
                            bool flag2 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.X);
                            if (flag2)
                            {
                                float[] array = new float[3];
                                array[1] = 30f;
                                float[] force = array;
                                float[] array2 = new float[3];
                                array2[1] = 30f;
                                float[] pos = array2;
                                Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity, force, pos);
                            }
                        }
                    }, Functions.RPCFunc.token_0);
                }
            }

            // Token: 0x060004CC RID: 1228 RVA: 0x000B06E8 File Offset: 0x000AE8E8
            public static void TaskMultiSuperJumpStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_27.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_27.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_27 = new CancellationTokenSource();
                        Functions.RPCFunc.token_27 = Functions.RPCFunc.tokenSource_27.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_27.IsCancellationRequested)
                        {
                            int entity = Functions.RPCFunc.PLAYER_PED_ID();
                            bool flag2 = Functions.ButtonMonitoring.IS_CONTROL_PRESSED(0, Functions.ButtonMonitoring.Buttons.Square);
                            if (flag2)
                            {
                                float[] force = new float[]
                                {
                                    0f,
                                    15f,
                                    15f
                                };
                                float[] pos = new float[]
                                {
                                    0f,
                                    15f,
                                    15f
                                };
                                Functions.RPCFunc.APPLY_FORCE_TO_ENTITY(entity, force, pos);
                            }
                        }
                    }, Functions.RPCFunc.token_27);
                }
            }

            // Token: 0x060004CD RID: 1229 RVA: 0x000B076C File Offset: 0x000AE96C
            public static void TaskNetworkControlStart(bool toggle)
            {
                bool flag = !toggle;
                if (flag)
                {
                    Functions.RPCFunc.tokenSource_26.Cancel();
                }
                if (toggle)
                {
                    bool isCancellationRequested = Functions.RPCFunc.tokenSource_26.IsCancellationRequested;
                    if (isCancellationRequested)
                    {
                        Functions.RPCFunc.tokenSource_26 = new CancellationTokenSource();
                        Functions.RPCFunc.token_26 = Functions.RPCFunc.tokenSource_26.Token;
                    }
                    Task task = Task.Factory.StartNew(delegate ()
                    {
                        while (!Functions.RPCFunc.token_26.IsCancellationRequested)
                        {
                            int id = Functions.RPCFunc.PLAYER_PED_ID();
                            GTA5Main.NewRequestNetworkControl(id);
                        }
                    }, Functions.RPCFunc.token_26);
                }
            }

            // Token: 0x060004CE RID: 1230 RVA: 0x000B07F0 File Offset: 0x000AE9F0
            public static uint STRINGHASH(string string_0)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(string_0.ToLower());
                uint num = 0u;
                for (int i = 0; i < bytes.Length; i++)
                {
                    uint num2 = num + (uint)bytes[i];
                    uint num3 = num2 + (num2 << 10);
                    num = (num3 ^ num3 >> 6);
                }
                uint num4 = num + (num << 3);
                uint num5 = num4 ^ num4 >> 11;
                return num5 + (num5 << 15);
            }

            // Token: 0x060004CF RID: 1231 RVA: 0x000B0860 File Offset: 0x000AEA60
            public static int GET_CURRENT_PED_WEAPON(int ped)
            {
                ClassicRPC.Call(Natives.GET_CURRENT_PED_WEAPON, new object[]
                {
                    ped,
                    268632896,
                    1
                });
                return Functions.PS3.Extension.ReadInt32(268632896u);
            }

            // Token: 0x060004D0 RID: 1232 RVA: 0x000B08B6 File Offset: 0x000AEAB6
            public static void SET_PED_WEAPON_TINT_INDEX(int ped, uint hashw, int color)
            {
                ClassicRPC.CallwHash<string>("0xEB2A7B23", new object[]
                {
                    ped,
                    hashw,
                    color
                });
            }

            // Token: 0x060004D1 RID: 1233 RVA: 0x000B08E8 File Offset: 0x000AEAE8
            public static void TASK_PLAY_ANIMATION(int Entity, string AnimDict, string Anim)
            {
                RPCHook.CompleteReq();
                RPCHook.Call(Natives.REQUEST_ANIM_DICT, new object[]
                {
                    AnimDict
                });
                RPCHook.CompleteReq();
                while (RPCHook.Call(Natives.HAS_ANIM_DICT_LOADED, new object[]
                {
                    AnimDict
                }) == 0)
                {
                }
                bool flag = RPCHook.Call(Natives.HAS_ANIM_DICT_LOADED, new object[]
                {
                    AnimDict
                }) == 1;
                if (flag)
                {
                    RPCHook.Call(Natives.TASK_PLAY_ANIM, new object[]
                    {
                        Entity,
                        AnimDict,
                        Anim,
                        8f,
                        0,
                        -1,
                        9,
                        0,
                        0,
                        0,
                        0
                    });
                }
            }

            // Token: 0x060004D2 RID: 1234 RVA: 0x000B09C4 File Offset: 0x000AEBC4
            public static void CREATE_AMBIENT_PICKUP(uint Offset, float[] Coord, int in1, int value, uint oft, int in2, int in3)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[]
                {
                    Offset,
                    Coord,
                    in1,
                    value,
                    oft,
                    in2,
                    in3
                });
            }

            // Token: 0x060004D3 RID: 1235 RVA: 0x000B0A20 File Offset: 0x000AEC20
            public static void CREATE_AMBIENT_PICKUP_ST(uint Offset, float[] Coord, int val)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[]
                {
                    Offset,
                    Coord,
                    0,
                    val,
                    1,
                    0,
                    1
                });
            }

            // Token: 0x060004D4 RID: 1236 RVA: 0x000B0A7C File Offset: 0x000AEC7C
            public static void SET_ENTITY_PROOFS(int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool p6, bool p7, bool drownProof)
            {
                RPC3.Call(Natives.SET_ENTITY_PROOFS, new object[]
                {
                    entity,
                    bulletProof,
                    fireProof,
                    explosionProof,
                    collisionProof,
                    meleeProof,
                    p6,
                    p7,
                    drownProof
                });
            }

            // Token: 0x060004D5 RID: 1237 RVA: 0x000B0AF2 File Offset: 0x000AECF2
            public static void SET_VEHICLE_STRONG(int vehicle, bool toggle)
            {
                RPC3.Call(Natives.SET_VEHICLE_STRONG, new object[]
                {
                    vehicle,
                    toggle
                });
            }

            // Token: 0x060004D6 RID: 1238 RVA: 0x000B0B18 File Offset: 0x000AED18
            public static void SET_VEHICLE_CAN_BREAK(int vehicle, bool toggle)
            {
                RPC3.Call(Natives.SET_VEHICLE_CAN_BREAK, new object[]
                {
                    vehicle,
                    toggle
                });
            }

            // Token: 0x060004D7 RID: 1239 RVA: 0x000B0B40 File Offset: 0x000AED40
            public static void CREATE_AMBIENT_PICKUP2(int Offset, float[] Coord, int in1, int value, int oft, int in2, int in3)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[]
                {
                    Offset,
                    Coord,
                    in1,
                    value,
                    oft,
                    in2,
                    in3
                });
            }

            // Token: 0x060004D8 RID: 1240 RVA: 0x000B0B9C File Offset: 0x000AED9C
            public static void CREATE_AMBIENT_PICKUP3(int Model, float[] Coord, int in1)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[]
                {
                    Model,
                    Coord,
                    0,
                    in1,
                    1,
                    0,
                    1
                });
            }

            // Token: 0x060004D9 RID: 1241 RVA: 0x000B0BF5 File Offset: 0x000AEDF5
            public static void DELETE_ENTITY(int Entity)
            {
                ClassicRPC.NCall(NewNatives.DELETE_ENTITY, new object[]
                {
                    Entity
                });
            }

            // Token: 0x060004DA RID: 1242 RVA: 0x000B0C14 File Offset: 0x000AEE14
            public static int GET_PED_MONEY(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_MONEY, new object[]
                {
                    Player,
                    1
                });
            }

            // Token: 0x060004DB RID: 1243 RVA: 0x000B0C48 File Offset: 0x000AEE48
            public static int GET_PED_NEARBY_PEDS(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_NEARBY_PEDS, new object[]
                {
                    Player
                });
            }

            // Token: 0x060004DC RID: 1244 RVA: 0x000B0C74 File Offset: 0x000AEE74
            public static int GET_PED_NEARBY_VEHICLES(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_NEARBY_VEHICLES, new object[]
                {
                    Player
                });
            }

            // Token: 0x060004DD RID: 1245 RVA: 0x000B0C9F File Offset: 0x000AEE9F
            public static void DELETE_VEHICLE(int Vehicle)
            {
                ClassicRPC.HookCall(Natives.DELETE_VEHICLE, new object[]
                {
                    Vehicle
                });
            }

            // Token: 0x060004DE RID: 1246 RVA: 0x000B0CBC File Offset: 0x000AEEBC
            public static int GET_PLAYERS_LAST_VEHICLE(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYERS_LAST_VEHICLE, new object[]
                {
                    Player
                });
            }

            // Token: 0x060004DF RID: 1247 RVA: 0x000B0CE8 File Offset: 0x000AEEE8
            public static int NETWORK_GET_HOST_OF_SCRIPT(string Mod, int unk1, int unk2)
            {
                return ClassicRPC.NCall(NewNatives.NETWORK_GET_HOST_OF_SCRIPT, new object[]
                {
                    Mod,
                    unk1,
                    unk2
                });
            }

            // Token: 0x060004E0 RID: 1248 RVA: 0x000B0D20 File Offset: 0x000AEF20
            public static void CLEAR_AREA(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA, new object[]
                {
                    Pos,
                    Dis,
                    0,
                    0,
                    0,
                    0
                });
            }

            // Token: 0x060004E1 RID: 1249 RVA: 0x000B0D70 File Offset: 0x000AEF70
            public static void CLEAR_AREA_OF_COPS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_COPS, new object[]
                {
                    Pos,
                    Dis,
                    0
                });
            }

            // Token: 0x060004E2 RID: 1250 RVA: 0x000B0D9A File Offset: 0x000AEF9A
            public static void CLEAR_AREA_OF_OBJECTS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_OBJECTS, new object[]
                {
                    Pos,
                    Dis,
                    0
                });
            }

            // Token: 0x060004E3 RID: 1251 RVA: 0x000B0DC4 File Offset: 0x000AEFC4
            public static void CLEAR_AREA_OF_VEHICLES(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_VEHICLES, new object[]
                {
                    Pos,
                    Dis,
                    0,
                    0,
                    0,
                    0,
                    0
                });
            }

            // Token: 0x060004E4 RID: 1252 RVA: 0x000B0E1D File Offset: 0x000AF01D
            public static void CLEAR_AREA_OF_PEDS(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_PEDS, new object[]
                {
                    Pos,
                    Dis,
                    0
                });
            }

            // Token: 0x060004E5 RID: 1253 RVA: 0x000B0E47 File Offset: 0x000AF047
            public static void CLEAR_AREA_OF_PROJECTILES(float[] Pos, int Dis)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_AREA_OF_PROJECTILES, new object[]
                {
                    Pos,
                    Dis,
                    0
                });
            }

            // Token: 0x060004E6 RID: 1254 RVA: 0x000B0E74 File Offset: 0x000AF074
            public static int CREATE_OBJECT(uint uint_0, float[] float_0)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, new object[]
                {
                    uint_0,
                    float_0,
                    1,
                    1,
                    0
                });
            }

            // Token: 0x060004E7 RID: 1255 RVA: 0x000B0EC0 File Offset: 0x000AF0C0
            public static int GET_ENTITY_HEADING(int ind)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_HEADING, new object[]
                {
                    ind
                });
            }

            // Token: 0x060004E8 RID: 1256 RVA: 0x000B0EEC File Offset: 0x000AF0EC
            public static int CREATE_VEHICLE(int ind, float[] Pos, int Head, int int_0, int int_1)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_HEADING, new object[]
                {
                    ind,
                    Pos,
                    Head,
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004E9 RID: 1257 RVA: 0x000B0F37 File Offset: 0x000AF137
            public static void VEHICLE_SPEED(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_FORWARD_SPEED, new object[]
                {
                    int_0,
                    float_0
                });
            }

            // Token: 0x060004EA RID: 1258 RVA: 0x000B0F5D File Offset: 0x000AF15D
            public static void SET_VEHICLE_ENGINE_ON(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_ON, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x060004EB RID: 1259 RVA: 0x000B0F8C File Offset: 0x000AF18C
            public static void VEHICLE_GRAVITY(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_GRAVITY, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004EC RID: 1260 RVA: 0x000B0FB2 File Offset: 0x000AF1B2
            public static void VEHICLE_ENGINE_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_HEALTH, new object[]
                {
                    int_0,
                    float_0
                });
            }

            // Token: 0x060004ED RID: 1261 RVA: 0x000B0FD8 File Offset: 0x000AF1D8
            public static void VEHICLE_PETROL_TANK_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_PETROL_TANK_HEALTH, new object[]
                {
                    int_0,
                    float_0
                });
            }

            // Token: 0x060004EE RID: 1262 RVA: 0x000B0FFE File Offset: 0x000AF1FE
            public static void SET_ENTITY_HEALTH(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_HEALTH, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004EF RID: 1263 RVA: 0x000B1024 File Offset: 0x000AF224
            public static void REQUEST_IPL(string string_0)
            {
                ClassicRPC.NCall(NewNatives.REQUEST_IPL, new object[]
                {
                    string_0
                });
            }

            // Token: 0x060004F0 RID: 1264 RVA: 0x000B103C File Offset: 0x000AF23C
            public static void REMOVE_IPL(string string_0)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_IPL, new object[]
                {
                    string_0
                });
            }

            // Token: 0x060004F1 RID: 1265 RVA: 0x000B1054 File Offset: 0x000AF254
            public static void START_ENTITY_FIRE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.START_ENTITY_FIRE, new object[]
                {
                    int_0
                });
            }

            // Token: 0x060004F2 RID: 1266 RVA: 0x000B1071 File Offset: 0x000AF271
            public static void REDUCE_GRIP(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_REDUCE_GRIP, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004F3 RID: 1267 RVA: 0x000B1097 File Offset: 0x000AF297
            public static void ENTITY_CAN_BE_DAMAGED(int int_0, int int_1)
            {
                RPC3.Call(Natives.SET_ENTITY_CAN_BE_DAMAGED, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004F4 RID: 1268 RVA: 0x000B10BD File Offset: 0x000AF2BD
            public static void RESET_PED_VISIBLE_DAMAGE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.RESET_PED_VISIBLE_DAMAGE, new object[]
                {
                    int_0
                });
            }

            // Token: 0x060004F5 RID: 1269 RVA: 0x000B10DA File Offset: 0x000AF2DA
            public static void VEHICLE_CAN_VISIBLY_DAMAGED(int int_0, int int_1)
            {
                RPC3.Call(Natives.SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004F6 RID: 1270 RVA: 0x000B1100 File Offset: 0x000AF300
            public static void REQUEST_COLLISION_AT_COORD(float[] Coord)
            {
                ClassicRPC.NCall(NewNatives.REQUEST_COLLISION_AT_COORD, new object[]
                {
                    Coord
                });
            }

            // Token: 0x060004F7 RID: 1271 RVA: 0x000B1118 File Offset: 0x000AF318
            public static void SET_VEHICLE_DOOR_OPEN(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOOR_OPEN, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x060004F8 RID: 1272 RVA: 0x000B1147 File Offset: 0x000AF347
            public static void SET_VEHICLE_DOOR_SHUT(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOOR_SHUT, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x060004F9 RID: 1273 RVA: 0x000B1176 File Offset: 0x000AF376
            public static void SET_VEHICLE_TYRE_SMOKE_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRE_SMOKE_COLOR, new object[]
                {
                    int_0,
                    int_1,
                    int_2,
                    int_3
                });
            }

            // Token: 0x060004FA RID: 1274 RVA: 0x000B11B0 File Offset: 0x000AF3B0
            public static int GET_RANDOM_INT_IN_RANGE(int int_0, int int_1)
            {
                return ClassicRPC.NCall(NewNatives.GET_RANDOM_INT_IN_RANGE, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004FB RID: 1275 RVA: 0x000B11E4 File Offset: 0x000AF3E4
            public static void SET_VEHICLE_CAN_BREAK(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_BRAKE, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004FC RID: 1276 RVA: 0x000B120A File Offset: 0x000AF40A
            public static void VEHICLE_UNDRIVEABLE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_UNDRIVEABLE, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x060004FD RID: 1277 RVA: 0x000B1230 File Offset: 0x000AF430
            public static int IS_PED_IN_ANY_VEHICLE(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.IS_PED_IN_ANY_VEHICLE, new object[]
                {
                    int_0,
                    0
                });
            }

            // Token: 0x060004FE RID: 1278 RVA: 0x000B1264 File Offset: 0x000AF464
            public static void FIX_VEHICLE(int int_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_FIXED, new object[]
                {
                    int_0
                });
            }

            // Token: 0x060004FF RID: 1279 RVA: 0x000B1284 File Offset: 0x000AF484
            public static int GET_PED_VEHICLE_IS_IN(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_PED_IS_IN, new object[]
                {
                    int_0,
                    new object[0]
                });
            }

            // Token: 0x06000500 RID: 1280 RVA: 0x000B12B8 File Offset: 0x000AF4B8
            public static int GET_PED_VEHICLE_IS_USING(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_PED_IS_USING, new object[]
                {
                    int_0,
                    new object[0]
                });
            }

            // Token: 0x06000501 RID: 1281 RVA: 0x000B12EC File Offset: 0x000AF4EC
            public static int PLAYER_PED_ID()
            {
                return ClassicRPC.NCall(NewNatives.PLAYER_PED_ID, new object[0]);
            }

            // Token: 0x06000502 RID: 1282 RVA: 0x000B130E File Offset: 0x000AF50E
            public static void OHK(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_WEAPON_DAMAGE_MODIFIER, new object[]
                {
                    int_0,
                    float_0
                });
            }

            // Token: 0x06000503 RID: 1283 RVA: 0x000B1334 File Offset: 0x000AF534
            public static void SET_TIMECYCLE_MODIFIER(string wh)
            {
                ClassicRPC.NCall(NewNatives.SET_TIMECYCLE_MODIFIER, new object[]
                {
                    wh
                });
            }

            // Token: 0x06000504 RID: 1284 RVA: 0x000B134C File Offset: 0x000AF54C
            public static void FTPCo(string IP)
            {

            }

            // Token: 0x06000505 RID: 1285 RVA: 0x000B1368 File Offset: 0x000AF568
            public static void FTPCoEB(string IP)
            {

            }

            // Token: 0x06000506 RID: 1286 RVA: 0x000B1384 File Offset: 0x000AF584
            public static void ENTITY_VISIBLE(int int_0, bool bool_0)
            {
                if (bool_0)
                {
                    ClassicRPC.NCall(NewNatives.SET_ENTITY_VISIBLE, new object[]
                    {
                        int_0,
                        1
                    });
                }
                else
                {
                    ClassicRPC.NCall(NewNatives.SET_ENTITY_VISIBLE, new object[]
                    {
                        int_0,
                        0
                    });
                }
            }

            // Token: 0x06000507 RID: 1287 RVA: 0x000B13E4 File Offset: 0x000AF5E4
            public static void SET_MOVEMENTS(int PID, string Movement)
            {
                RPCHook.Call2<int>(OLDNatives.REQUEST_ANIM_DICT, new object[]
                {
                    Movement
                });
                Thread.Sleep(500);
                RPCHook.CompleteReq();
                bool flag = RPCHook.Call2<int>(OLDNatives.HAS_ANIM_DICT_LOADED, new object[]
                {
                    Movement
                }) != 0;
                if (flag)
                {
                    RPCHook.Call2<int>(OLDNatives.SET_PED_MOVEMENT_CLIPSET, new object[]
                    {
                        PID,
                        Movement,
                        1048576000
                    });
                }
            }

            // Token: 0x06000508 RID: 1288 RVA: 0x000B1460 File Offset: 0x000AF660
            public static float[] GET_COORDS(int int_0)
            {
                float[] array = new float[3];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[]
                {
                    Functions.RPCFunc.entityXCoord,
                    int_0
                });
                array[0] = Functions.PS3.Extension.ReadFloat(Functions.RPCFunc.entityXCoord);
                array[1] = Functions.PS3.Extension.ReadFloat(Functions.RPCFunc.entityYCoord);
                array[2] = Functions.PS3.Extension.ReadFloat(Functions.RPCFunc.entityZCoord);
                return array;
            }

            // Token: 0x06000509 RID: 1289 RVA: 0x000B14E8 File Offset: 0x000AF6E8
            public static float[] GET_ENTITY_COORDS_2(int PedID)
            {
                float[] array = new float[3];
                ClassicRPC.CompleteReq();
                ClassicRPC.Call(Natives.GET_ENTITY_COORDS, new object[]
                {
                    268636160,
                    PedID
                });
                Thread.Sleep(20);
                return PS5.Extension.ReadFloatArray(268636160u, 3);
            }

            // Token: 0x0600050A RID: 1290 RVA: 0x000B154C File Offset: 0x000AF74C
            public static float GET_ENTITY_FORWARD_VECTOR(int Player)
            {
                return (float)ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_VECTOR, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600050B RID: 1291 RVA: 0x000B1578 File Offset: 0x000AF778
            public static float GET_ENTITY_FORWARD_X(int Player)
            {
                return (float)ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_X, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600050C RID: 1292 RVA: 0x000B15A4 File Offset: 0x000AF7A4
            public static float GET_ENTITY_FORWARD_Y(int Player)
            {
                return (float)ClassicRPC.NCall(NewNatives.GET_ENTITY_FORWARD_Y, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600050D RID: 1293 RVA: 0x000B15D0 File Offset: 0x000AF7D0
            public static float GET_ENTITY_SPEED(int Player)
            {
                return (float)ClassicRPC.NCall(NewNatives.GET_ENTITY_SPEED, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600050E RID: 1294 RVA: 0x000B15FC File Offset: 0x000AF7FC
            public static float[] GET_MY_X_COORDS(int int_0)
            {
                float[] array = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[]
                {
                    268636160,
                    int_0
                });
                array[0] = Functions.PS3.Extension.ReadFloat(268636160u);
                return array;
            }

            // Token: 0x0600050F RID: 1295 RVA: 0x000B1654 File Offset: 0x000AF854
            public static float[] GET_MY_Y_COORDS(int int_0)
            {
                float[] array = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[]
                {
                    268636164,
                    int_0
                });
                array[0] = Functions.PS3.Extension.ReadFloat(268636164u);
                return array;
            }

            // Token: 0x06000510 RID: 1296 RVA: 0x000B16AC File Offset: 0x000AF8AC
            public static float[] GET_MY_Z_COORDS(int int_0)
            {
                float[] array = new float[0];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[]
                {
                    268636168,
                    int_0
                });
                array[0] = Functions.PS3.Extension.ReadFloat(268636168u);
                return array;
            }

            // Token: 0x06000511 RID: 1297 RVA: 0x000B1704 File Offset: 0x000AF904
            public static void AMBIENT_PICKUP(int int_0, float[] float_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.CREATE_AMBIENT_PICKUP, new object[]
                {
                    int_0,
                    float_0,
                    0,
                    int_1,
                    1,
                    0,
                    1
                });
            }

            // Token: 0x06000512 RID: 1298 RVA: 0x000B1760 File Offset: 0x000AF960
            public static void GiveWeapons(int int_0)
            {
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.KNIFE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.NIGHTSTICK,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.HAMMER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.uint_0,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.GOLFCLUB,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.CROWBAR,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.PISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.COMBATPISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.APPISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.PISTOL50,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.MICROSMG,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.uint_3,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.ASSAULTSMG,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.ASSAULTRIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.CARBINERIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.ADVANCEDRIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.uint_1,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.COMBATMG,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.PUMPSHOTGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SAWNOFFSHOTGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.ASSAULTSHOTGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.BULLPUPSHOTGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.STUNGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SNIPERRIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.HEAVYSNIPER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.GRENADELAUNCHER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.uint_2,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.MINIGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.GRENADE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.STICKYBOMB,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SMOKEGRENADE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.BZGAS,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.MOLOTOV,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.FIREEXTINGUISHER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.PETROLCAN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.BALL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.FLARE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.BOTTLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.GUSENBERG,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SPECIALCARBINE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.HEAVYPISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SNSPISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.BULLPUPRIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.DAGGER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.VINTAGEPISTOL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.FIREWORK,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.MUSKET,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.HEAVYSHOTGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.MARKSMANRIFLE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.HOMINGLAUNCHER,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.PROXMINE,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.SNOWBALL,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.FLAREGUN,
                    9999,
                    0,
                    1
                });
                ClassicRPC.NCall(NewNatives.GIVE_WEAPON_TO_PED, new object[]
                {
                    int_0,
                    Functions.Weapons.COMBATPDW,
                    9999,
                    0,
                    1
                });
            }

            // Token: 0x06000513 RID: 1299 RVA: 0x000B2634 File Offset: 0x000B0834
            public static int GET_PLAYER_PED(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_PED, new object[]
                {
                    int_0
                });
            }

            // Token: 0x06000514 RID: 1300 RVA: 0x000B265F File Offset: 0x000B085F
            public static void SET_NIGHT_V(int int_0)
            {
                ClassicRPC.Call(3929412u, new object[]
                {
                    int_0
                });
            }

            // Token: 0x06000515 RID: 1301 RVA: 0x000B267C File Offset: 0x000B087C
            public static void GOD_MODE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_INVINCIBLE, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000516 RID: 1302 RVA: 0x000B26A2 File Offset: 0x000B08A2
            public static void PED_RAGDOLL(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_CAN_RAGDOLL, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000517 RID: 1303 RVA: 0x000B26C8 File Offset: 0x000B08C8
            public static void INVITE_GAMER(string name)
            {
                byte[] array = new byte[8];
                array[3] = 2;
                Functions.PS3.Extension.WriteBytes(268567040u, array);
                Functions.PS3.Extension.WriteString(268567048u, name);
                ClassicRPC.Call(20128236u, new object[]
                {
                    1074089184,
                    268567040,
                    1,
                    0,
                    0,
                    0,
                    1344,
                    1260,
                    89
                });
            }

            // Token: 0x06000518 RID: 1304 RVA: 0x000B2781 File Offset: 0x000B0981
            public static void PED_RAGDOLL_IMPACT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000519 RID: 1305 RVA: 0x000B27A7 File Offset: 0x000B09A7
            public static void CLEAR_PED_TASKS_IMMEDIATLY(int int_0)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PED_TASKS_IMMEDIATELY, new object[]
                {
                    int_0
                });
            }

            // Token: 0x0600051A RID: 1306 RVA: 0x000B27C4 File Offset: 0x000B09C4
            public static void SCREEN_FADE_OUT(int ms)
            {
                ClassicRPC.NCall(NewNatives.DO_SCREEN_FADE_OUT, new object[]
                {
                    ms
                });
            }

            // Token: 0x0600051B RID: 1307 RVA: 0x000B27E4 File Offset: 0x000B09E4
            public static int IS_PED_IN_VEHICLE(int ped)
            {
                return ClassicRPC.NCall(NewNatives.IS_PED_IN_ANY_VEHICLE, new object[]
                {
                    ped,
                    0
                });
            }

            // Token: 0x0600051C RID: 1308 RVA: 0x000B2818 File Offset: 0x000B0A18
            public static void SET_ENTITY_COORDS(int entity, float[] coords)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[]
                {
                    entity,
                    coords,
                    1,
                    0,
                    0,
                    1
                });
            }

            // Token: 0x0600051D RID: 1309 RVA: 0x000B2868 File Offset: 0x000B0A68
            public static void SET_ENTITY_COORDS2(int entity, float coords1, float coords2, float coords3)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[]
                {
                    entity,
                    coords1,
                    coords2,
                    coords3,
                    1,
                    0,
                    0,
                    1
                });
            }

            // Token: 0x0600051E RID: 1310 RVA: 0x000B28CF File Offset: 0x000B0ACF
            public static void CHANGE_PLAYER_PED(int ped)
            {
                ClassicRPC.Call(Natives.CHANGE_PLAYER_PED, new object[]
                {
                    Functions.RPCFunc.PLAYER_ID(),
                    ped,
                    0,
                    0
                });
            }

            // Token: 0x0600051F RID: 1311 RVA: 0x000B290C File Offset: 0x000B0B0C
            public static uint GET_ENTITY_MODEL(int entity)
            {
                return (uint)ClassicRPC.Call(Natives.GET_ENTITY_MODEL, new object[]
                {
                    entity
                });
            }

            // Token: 0x06000520 RID: 1312 RVA: 0x000B2938 File Offset: 0x000B0B38
            public static string GET_VEH_NAME(int veh)
            {
                return Functions.PS3.Extension.ReadString((uint)ClassicRPC.Call(Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL, new object[]
                {
                    Functions.RPCFunc.GET_ENTITY_MODEL(veh)
                }));
            }

            // Token: 0x06000521 RID: 1313 RVA: 0x000B2978 File Offset: 0x000B0B78
            public static uint FindOffset(uint StartOffset, int length, byte[] toFind, int add)
            {
                byte[] array = new byte[length];
                Functions.PS3.GetMemory(StartOffset, array);
                int num = 0;
                while (num + toFind.Length < array.Length)
                {
                    bool flag = true;
                    for (int i = 0; i <= toFind.Length - 1; i++)
                    {
                        bool flag2 = Convert.ToInt32(array[num + i]) != Convert.ToInt32(toFind[i]);
                        if (flag2)
                        {
                            flag = false;
                            break;
                        }
                    }
                    bool flag3 = flag;
                    if (flag3)
                    {
                        return StartOffset + Convert.ToUInt32(num + add);
                    }
                    num += 4;
                }
                return 0u;
            }

            // Token: 0x06000522 RID: 1314 RVA: 0x000B2A10 File Offset: 0x000B0C10
            public static int GET_PLAYER_NAME_INT(int int_0)
            {
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_NAME, new object[]
                {
                    int_0
                });
            }

            // Token: 0x06000523 RID: 1315 RVA: 0x000B2A3B File Offset: 0x000B0C3B
            public static void SCREEN_FADE_IN(int int_0)
            {
                ClassicRPC.NCall(NewNatives.DO_SCREEN_FADE_IN, new object[]
                {
                    int_0
                });
            }

            // Token: 0x06000524 RID: 1316 RVA: 0x000B2A58 File Offset: 0x000B0C58
            public static int PLAYER_ID()
            {
                return ClassicRPC.NCall(NewNatives.PLAYER_ID, new object[0]);
            }

            // Token: 0x06000525 RID: 1317 RVA: 0x000B2A7A File Offset: 0x000B0C7A
            public static void FREEZE_ENTITY_POSITION(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.FREEZE_ENTITY_POSITION, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000526 RID: 1318 RVA: 0x000B2AA0 File Offset: 0x000B0CA0
            public static void NETWORK_REQUEST_CONTROL_ENTITY(int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_REQUEST_CONTROL_OF_ENTITY, new object[]
                {
                    int_0
                });
            }

            // Token: 0x06000527 RID: 1319 RVA: 0x000B0FB2 File Offset: 0x000AF1B2
            public static void SET_VEHICLE_ENGINE_HEALTH(int int_0, float float_0)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_ENGINE_HEALTH, new object[]
                {
                    int_0,
                    float_0
                });
            }

            // Token: 0x06000528 RID: 1320 RVA: 0x000B2ABD File Offset: 0x000B0CBD
            public static void SET_VEHICLE_MOD_KIT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD_KIT, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000529 RID: 1321 RVA: 0x000B2AE3 File Offset: 0x000B0CE3
            public static void REMOVE_VEHICLE_MOD_KIT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_VEHICLE_MOD_KIT, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x0600052A RID: 1322 RVA: 0x000B2B09 File Offset: 0x000B0D09
            public static void REMOVE_VEHICLE_MOD(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.REMOVE_VEHICLE_MOD, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x0600052B RID: 1323 RVA: 0x000B2B2F File Offset: 0x000B0D2F
            public static void SET_VEHICLE_WINDOW_TINT(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_WINDOW_TINT, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x0600052C RID: 1324 RVA: 0x000B2B55 File Offset: 0x000B0D55
            public static void SET_VEHICLE_WHEEL_TYPE(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_WHEEL_TYPE, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x0600052D RID: 1325 RVA: 0x000B2B7B File Offset: 0x000B0D7B
            public static void NETWORK_SPENT_CASH_DROP(int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SPENT_CASH_DROP, new object[]
                {
                    int_0
                });
            }

            // Token: 0x0600052E RID: 1326 RVA: 0x000B2B98 File Offset: 0x000B0D98
            public static void SET_MAX_WANTED_LEVEL(int Level)
            {
                ClassicRPC.NCall(NewNatives.SET_MAX_WANTED_LEVEL, new object[]
                {
                    Level
                });
            }

            // Token: 0x0600052F RID: 1327 RVA: 0x000B2BB5 File Offset: 0x000B0DB5
            public static void PLAYERPED_NETWORK_SPENT_CASH_DROP(int player, int int_0)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SPENT_CASH_DROP, new object[]
                {
                    player,
                    int_0
                });
            }

            // Token: 0x06000530 RID: 1328 RVA: 0x000B2BDC File Offset: 0x000B0DDC
            public static float[] GET_ENTITY_COORDS(int getplayerped)
            {
                float[] array = new float[3];
                ClassicRPC.NCall(NewNatives.GET_ENTITY_COORDS, new object[]
                {
                    268636160,
                    getplayerped
                });
                array[0] = Functions.PS3.Extension.ReadFloat(268636160u);
                array[1] = Functions.PS3.Extension.ReadFloat(268636164u);
                array[2] = Functions.PS3.Extension.ReadFloat(268636168u);
                return array;
            }

            // Token: 0x06000531 RID: 1329 RVA: 0x000B2C62 File Offset: 0x000B0E62
            public static void SET_VEHICLE_COLOURS(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_COLOURS, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x06000532 RID: 1330 RVA: 0x000B2C91 File Offset: 0x000B0E91
            public static void TOGGLE_VEHICLE_MOD(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.TOGGLE_VEHICLE_MOD, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x06000533 RID: 1331 RVA: 0x000B2CC0 File Offset: 0x000B0EC0
            public static void SET_VEHICLE_NUMBER_PLATE_TEXT(int int_0, string txt)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_NUMBER_PLATE_TEXT, new object[]
                {
                    int_0,
                    txt
                });
            }

            // Token: 0x06000534 RID: 1332 RVA: 0x000B2CE1 File Offset: 0x000B0EE1
            public static void SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX(int int_0, int int_1)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_NUMBER_PLATE_TEXT_INDEX, new object[]
                {
                    int_0,
                    int_1
                });
            }

            // Token: 0x06000535 RID: 1333 RVA: 0x000B2D07 File Offset: 0x000B0F07
            public static void SET_VEHICLE_MOD(int int_0, int int_1, int int_2)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD, new object[]
                {
                    int_0,
                    int_1,
                    int_2
                });
            }

            // Token: 0x06000536 RID: 1334 RVA: 0x000B2D36 File Offset: 0x000B0F36
            public static void SET_VEHICLE_MOD2(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_MOD, new object[]
                {
                    int_0,
                    int_1,
                    int_2,
                    int_3
                });
            }

            // Token: 0x06000537 RID: 1335 RVA: 0x000B2D6E File Offset: 0x000B0F6E
            public static void SET_VEHICLE_CUSTOM_PRIM_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_CUSTOM_PRIMARY_COLOUR, new object[]
                {
                    int_0,
                    int_1,
                    int_2,
                    int_3
                });
            }

            // Token: 0x06000538 RID: 1336 RVA: 0x000B2DA6 File Offset: 0x000B0FA6
            public static void SET_VEHICLE_CUSTOM_SEC_COLOR(int int_0, int int_1, int int_2, int int_3)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_CUSTOM_SECONDARY_COLOUR, new object[]
                {
                    int_0,
                    int_1,
                    int_2,
                    int_3
                });
            }

            // Token: 0x06000539 RID: 1337 RVA: 0x000B2DDE File Offset: 0x000B0FDE
            public static void ATTACH_ENTITY_TO_ENTITY(int Player1, int Player2, float[] Coord)
            {
                ClassicRPC.Call(Natives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    Player1,
                    Player2,
                    Coord
                });
            }

            // Token: 0x0600053A RID: 1338 RVA: 0x000B2E08 File Offset: 0x000B1008
            public static int NEW_ATTACH_ENTITY_TO_ENTITY(int ent1, int ent2)
            {
                return ClassicRPC.Call(Natives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    ent1,
                    ent2,
                    0,
                    268632080,
                    268632080,
                    0,
                    0,
                    0,
                    0,
                    2,
                    0
                });
            }

            // Token: 0x0600053B RID: 1339 RVA: 0x000B2E98 File Offset: 0x000B1098
            public static int NEW_DETACH_ENTITY(int entity)
            {
                return ClassicRPC.Call(Natives.DETACH_ENTITY, new object[]
                {
                    entity,
                    1,
                    1
                });
            }

            // Token: 0x0600053C RID: 1340 RVA: 0x000B2ED5 File Offset: 0x000B10D5
            public static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int Player1, int Player2, float[] Coord)
            {
                ClassicRPC.NCall(NewNatives.ATTACH_ENTITY_TO_ENTITY_PHYSICALLY, new object[]
                {
                    Player1,
                    Player2,
                    Coord
                });
            }

            // Token: 0x0600053D RID: 1341 RVA: 0x000B2EFF File Offset: 0x000B10FF
            public static void DISABLE_PLAYER_FIRING(int Player, bool Value)
            {
                ClassicRPC.NCall(NewNatives.DISABLE_PLAYER_FIRING, new object[]
                {
                    Player,
                    Value
                });
            }

            // Token: 0x0600053E RID: 1342 RVA: 0x000B2F25 File Offset: 0x000B1125
            public static void EXPLODE_VEHICLE(int Vehicle, int t, int r)
            {
                ClassicRPC.NCall(NewNatives.EXPLODE_VEHICLE, new object[]
                {
                    Vehicle,
                    t,
                    r
                });
            }

            // Token: 0x0600053F RID: 1343 RVA: 0x000B2F54 File Offset: 0x000B1154
            public static void NETWORK_EXPLODE_VEHICLE(int Vehicle)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_EXPLODE_VEHICLE, new object[]
                {
                    Vehicle
                });
            }

            // Token: 0x06000540 RID: 1344 RVA: 0x000B2F74 File Offset: 0x000B1174
            public static int TELEPORT_TO_CLOSEST_VEHICLE()
            {
                int num = Functions.RPCFunc.GET_CLOSEST_VEHICLE(Functions.RPCFunc.GET_BLIP_ID());
                int player = Functions.RPCFunc.PLAYER_PED_ID();
                Functions.RPCFunc.SET_PED_INTO_VEHICLE(player, num);
                return num;
            }

            // Token: 0x06000541 RID: 1345 RVA: 0x000B2FA0 File Offset: 0x000B11A0
            public static float[] GET_BLIP_ID()
            {
                ClassicRPC.Call(Natives.GET_BLIP_COORDS, new object[]
                {
                    268502272,
                    Functions.RPCFunc.GET_GTA5Main_PLAYER_BLIP_ID()
                });
                return PS5.Extension.ReadFloatArray(268502272u, 3);
            }

            // Token: 0x06000542 RID: 1346 RVA: 0x000B2FF4 File Offset: 0x000B11F4
            public static int GET_GTA5Main_PLAYER_BLIP_ID()
            {
                return ClassicRPC.CallwHash<string>("get_GTA5Main_player_blip_id", Array.Empty<object>());
            }

            // Token: 0x06000543 RID: 1347 RVA: 0x000B3018 File Offset: 0x000B1218
            public static int GET_CLOSEST_VEHICLE(float[] blipc)
            {
                return ClassicRPC.Call(Natives.GET_CLOSEST_VEHICLE, new object[]
                {
                    blipc,
                    5000f,
                    0,
                    0
                });
            }

            // Token: 0x06000544 RID: 1348 RVA: 0x000B3060 File Offset: 0x000B1260
            public static int GET_STREET_NAME_AT_COORD(float Coord)
            {
                return ClassicRPC.NCall(NewNatives.GET_STREET_NAME_AT_COORD, new object[]
                {
                    Coord
                });
            }

            // Token: 0x06000545 RID: 1349 RVA: 0x000B308C File Offset: 0x000B128C
            public static int GET_DISPLAY_NAME_FROM_VEHICLE_MODEL(int Entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL, new object[]
                {
                    Entity
                });
            }

            // Token: 0x06000546 RID: 1350 RVA: 0x000B30B7 File Offset: 0x000B12B7
            public static void SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY(int toggle)
            {
                ClassicRPC.HookCall(Natives.SET_MOBILE_RADIO_ENABLED_DURING_GAMEPLAY, new object[]
                {
                    toggle
                });
            }

            // Token: 0x06000547 RID: 1351 RVA: 0x000B30D4 File Offset: 0x000B12D4
            public static void SET_PED_INTO_VEHICLE(int Player, int Vehicle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_INTO_VEHICLE, new object[]
                {
                    Player,
                    Vehicle
                });
            }

            // Token: 0x06000548 RID: 1352 RVA: 0x000B30FA File Offset: 0x000B12FA
            public static void SET_PED_INTO_VEHICLE2(int Player, int Vehicle, int Seat)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_INTO_VEHICLE, new object[]
                {
                    Player,
                    Vehicle,
                    Seat
                });
            }

            // Token: 0x06000549 RID: 1353 RVA: 0x000B3129 File Offset: 0x000B1329
            public static void SET_PED_IS_DRUNK(int Player, bool Value)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_IS_DRUNK, new object[]
                {
                    Player,
                    Value
                });
            }

            // Token: 0x0600054A RID: 1354 RVA: 0x000B314F File Offset: 0x000B134F
            public static void REMOVE_PARTICLE_FX_FROM_ENTITY(int Player)
            {
                ClassicRPC.HookCall(Natives.REMOVE_PARTICLE_FX_FROM_ENTITY, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600054B RID: 1355 RVA: 0x000B316C File Offset: 0x000B136C
            public static bool HAS_PTFX_ASSET_LOADED(string FX)
            {
                return RPCHook.Call(Natives.HAS_PTFX_ASSET_LOADED, new object[]
                {
                    FX
                }) != 0;
            }

            // Token: 0x0600054C RID: 1356 RVA: 0x000B31A0 File Offset: 0x000B13A0
            public static void START_PARTICLE_FX_LOOPED_ON_ENTITY(string FX, int Entity)
            {
                RPCHook.Call(Natives.START_PARTICLE_FX_LOOPED_ON_ENTITY, new object[]
                {
                    FX,
                    Entity,
                    0.0,
                    0.0,
                    -0.5,
                    0.0,
                    0.0,
                    0.0,
                    1.0,
                    0,
                    0,
                    0
                });
            }

            // Token: 0x0600054D RID: 1357 RVA: 0x000B3262 File Offset: 0x000B1462
            public static void SET_PARTICLE_FX_LOOPED_COLOUR(int r, int g, int b)
            {
                RPCHook.Call(Natives.SET_PARTICLE_FX_LOOPED_COLOUR, new object[]
                {
                    r,
                    g,
                    b
                });
            }

            // Token: 0x0600054E RID: 1358 RVA: 0x000B3291 File Offset: 0x000B1491
            public static void REQUEST_PTFX_ASSET(string FX)
            {
                RPCHook.Call(Natives.REQUEST_PTFX_ASSET, new object[]
                {
                    FX
                });
            }

            // Token: 0x0600054F RID: 1359 RVA: 0x000B32A9 File Offset: 0x000B14A9
            public static void SET_PTFX_ASSET_NEXT_CALL(string FX)
            {
                ClassicRPC.Call(Natives.SET_PTFX_ASSET_NEXT_CALL, new object[]
                {
                    FX
                });
            }

            // Token: 0x06000550 RID: 1360 RVA: 0x000B32C4 File Offset: 0x000B14C4
            public static void START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string FX, int Entity, uint bone)
            {
                ClassicRPC.NCall(NewNatives.START_PARTICLE_FX_LOOPED_ON_PED_BONE, new object[]
                {
                    FX,
                    Entity,
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    bone,
                    0.1f,
                    0,
                    0,
                    0
                });
            }

            // Token: 0x06000551 RID: 1361 RVA: 0x000B335C File Offset: 0x000B155C
            public static void STOP_ENTITY_FIRE(int Entity)
            {
                ClassicRPC.NCall(NewNatives.STOP_ENTITY_FIRE, new object[]
                {
                    Entity
                });
            }

            // Token: 0x06000552 RID: 1362 RVA: 0x000B3379 File Offset: 0x000B1579
            public static void CLEAR_PED_BLOOD_DAMAGE(int Player)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PED_BLOOD_DAMAGE, new object[]
                {
                    Player
                });
            }

            // Token: 0x06000553 RID: 1363 RVA: 0x000B3396 File Offset: 0x000B1596
            public static void OVERRIDE_WEATHER(string Weather)
            {
                ClassicRPC.NCall(NewNatives.SET_OVERRIDE_WEATHER, new object[]
                {
                    Weather
                });
            }

            // Token: 0x06000554 RID: 1364 RVA: 0x000B33AE File Offset: 0x000B15AE
            public static void SET_PED_INFINITE_AMMO_CLIP(int Player, int state)
            {
                ClassicRPC.HookCall(Natives.SET_PED_INFINITE_AMMO_CLIP, new object[]
                {
                    Player,
                    state
                });
            }

            // Token: 0x06000555 RID: 1365 RVA: 0x000B33D4 File Offset: 0x000B15D4
            public static void TASK_START_SCENARIO_AT_POSITION(int Ped, string Scenario, float x, float y, float z, float Heading, int p6, bool p7, bool p8)
            {
                ClassicRPC.HookCall(Natives.SET_PED_INFINITE_AMMO_CLIP, new object[]
                {
                    Ped,
                    Scenario,
                    x,
                    y,
                    z,
                    Heading,
                    p6,
                    p7,
                    p8
                });
            }

            // Token: 0x06000556 RID: 1366 RVA: 0x000B3448 File Offset: 0x000B1648
            public static bool IS_PLAYER_TARGETING_ENTITY(int PlayerIndex, int Me)
            {
                return ClassicRPC.NCall(NewNatives.IS_PLAYER_TARGETTING_ENTITY, new object[]
                {
                    PlayerIndex,
                    Me
                }) != 0;
            }

            // Token: 0x06000557 RID: 1367 RVA: 0x000B3488 File Offset: 0x000B1688
            public static void SET_ENTITY_AS_MISSION_ENTITY(int Ped, int y, int z)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_AS_MISSION_ENTITY, new object[]
                {
                    Ped,
                    y,
                    z
                });
            }

            // Token: 0x06000558 RID: 1368 RVA: 0x000B34B8 File Offset: 0x000B16B8
            public static void SET_ENTITY_COORDS_FOR_FORCE(int Ped, float x, float y, float z)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COORDS, new object[]
                {
                    Ped,
                    x,
                    y,
                    z,
                    0,
                    0,
                    0,
                    1
                });
            }

            // Token: 0x06000559 RID: 1369 RVA: 0x000B3520 File Offset: 0x000B1720
            public static int IS_PED_SHOOTING(int PlayerIndex)
            {
                return ClassicRPC.NCall(NewNatives.IS_PLAYER_TARGETTING_ENTITY, new object[]
                {
                    PlayerIndex
                });
            }

            // Token: 0x0600055A RID: 1370 RVA: 0x000B354C File Offset: 0x000B174C
            public static int IS_ENTITY_IN_AIR(int PlayerIndex)
            {
                return ClassicRPC.NCall(NewNatives.IS_ENTITY_IN_AIR, new object[]
                {
                    PlayerIndex
                });
            }

            // Token: 0x0600055B RID: 1371 RVA: 0x000B3578 File Offset: 0x000B1778
            public static float[] GET_CORDS_INFRONT(int Entity, float Dis)
            {
                float[] array = new float[3];
                array = Functions.RPCFunc.GET_ENTITY_COORDS(Entity);
                array[0] = Dis;
                return array;
            }

            // Token: 0x0600055C RID: 1372 RVA: 0x000B35A0 File Offset: 0x000B17A0
            public static int GET_CONTROL_VALUE(int st, int en)
            {
                return ClassicRPC.NCall(NewNatives.GET_CONTROL_VALUE, new object[]
                {
                    st,
                    en
                });
            }

            // Token: 0x0600055D RID: 1373 RVA: 0x000B35D4 File Offset: 0x000B17D4
            public static float[] GET_PED_LAST_WEAPON_IMPACT_COORD(int Ped)
            {
                float[] array = new float[3];
                ClassicRPC.NCall(NewNatives.GET_PED_LAST_WEAPON_IMPACT_COORD, new object[]
                {
                    Ped,
                    array
                });
                return array;
            }

            // Token: 0x0600055E RID: 1374 RVA: 0x000B360C File Offset: 0x000B180C
            public static int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int num)
            {
                return ClassicRPC.NCall(NewNatives.GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS, new object[]
                {
                    num
                });
            }

            // Token: 0x0600055F RID: 1375 RVA: 0x000B3638 File Offset: 0x000B1838
            public static bool IS_VEHICLE_SEAT_FREE(int Veh, int Seat)
            {
                bool result = false;
                bool flag = ClassicRPC.NCall(NewNatives.IS_VEHICLE_SEAT_FREE, new object[]
                {
                    Veh,
                    Seat
                }) == 1;
                if (flag)
                {
                    result = true;
                }
                return result;
            }

            // Token: 0x06000560 RID: 1376 RVA: 0x000B367C File Offset: 0x000B187C
            public static int CREATE_OBJECT2(int hash, float[] Coord, int in1, int in2, int in3, int in4, int in5)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, new object[]
                {
                    hash,
                    Coord,
                    in1,
                    in2,
                    in3,
                    in4,
                    in5
                });
            }

            // Token: 0x06000561 RID: 1377 RVA: 0x000B36DC File Offset: 0x000B18DC
            public static int GET_PED_BONE_INDEX(int st, int en)
            {
                return ClassicRPC.NCall(NewNatives.GET_PED_BONE_INDEX, new object[]
                {
                    st,
                    en
                });
            }

            // Token: 0x06000562 RID: 1378 RVA: 0x000B3710 File Offset: 0x000B1910
            public static void SET_ENTITY_COLLISION(int Ped, int y)
            {
                ClassicRPC.NCall(NewNatives.SET_ENTITY_COLLISION, new object[]
                {
                    Ped,
                    y
                });
            }

            // Token: 0x06000563 RID: 1379 RVA: 0x000B3736 File Offset: 0x000B1936
            public static void TASK_START_SCENARIO_IN_PLACE(int Ped, string Scenario)
            {
                ClassicRPC.HookCall(Natives.TASK_START_SCENARIO_IN_PLACE, new object[]
                {
                    Ped,
                    Scenario,
                    0,
                    1
                });
            }

            // Token: 0x06000564 RID: 1380 RVA: 0x000B3769 File Offset: 0x000B1969
            public static void REQUEST_CUTSCENE(string Cutscene)
            {
                ClassicRPC.HookCall(Natives.REQUEST_CUTSCENE, new object[]
                {
                    Cutscene,
                    8
                });
            }

            // Token: 0x06000565 RID: 1381 RVA: 0x000B378C File Offset: 0x000B198C
            public static int HAS_CUTSCENE_LOADED()
            {
                return ClassicRPC.HookCall(Natives.REQUEST_CUTSCENE, new object[0]);
            }

            // Token: 0x06000566 RID: 1382 RVA: 0x000B37AE File Offset: 0x000B19AE
            public static void START_CUTSCENE(string Cutscene)
            {
                ClassicRPC.HookCall(Natives.START_CUTSCENE, new object[]
                {
                    Cutscene
                });
            }

            // Token: 0x06000567 RID: 1383 RVA: 0x000B37C6 File Offset: 0x000B19C6
            public static void STOP_CUTSCENE_IMMEDIATELY()
            {
                ClassicRPC.HookCall(Natives.STOP_CUTSCENE_IMMEDIATELY, new object[0]);
            }

            // Token: 0x06000568 RID: 1384 RVA: 0x000B37DC File Offset: 0x000B19DC
            public static void AttachObject(string obj, int list)
            {
                int num = Functions.RPCFunc.GET_PLAYER_PED(list);
                float[] coord = Functions.RPCFunc.GET_ENTITY_COORDS(num);
                int hash = GTA5Main.GET_HASH_KEY(obj);
                GTA5Main.REQUEST_MODEL(hash);
                int num2 = Functions.RPCFunc.GET_PED_BONE_INDEX(num, 31086);
                bool flag = GTA5Main.HAS_MODEL_LOADED(hash) != 0;
                if (flag)
                {
                    int objToNet = Functions.RPCFunc.CREATE_OBJECT2(hash, coord, 1, 1, 0, 0, 1);
                    GTA5Main.ATTACH_ENTITY_TO_ENTITY(objToNet, num, Convert.ToInt32(Boneindices.SKEL_Head), 0.3f, 0f, 0f, 0f, 90f, 0f);
                }
            }

            public static void ATTACH_ENTITY_TO_ENTITY1(int ObjToNet, int ToAttachID, int bone, float X, float Y, float Z, float RX, float RY, float RZ)
            {
                float[] array = new float[3];
                float[] array2 = new float[3];
                array[0] += X;
                array[1] += Y;
                array[2] += Z;
                array2[0] += RX;
                array2[1] += RY;
                array2[2] += RZ;
                RPCHook.Call2<int>(OLDNatives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                ObjToNet,
                ToAttachID,
                bone,
                array,
                array2,
                1,
                1,
                1,
                1,
                2,
                1
                });
                RPCHook.Call(OLDNatives.SET_ENTITY_VISIBLE, new object[]
                {
                GTA5Main.zzz[GTA5Main.sss],
                0
                });
                RPCHook.Call(OLDNatives.SET_ENTITY_LOCALLY_INVISIBLE, new object[]
                {
                GTA5Main.zzz[GTA5Main.sss],
                1
                });
            }
            // Token: 0x06000569 RID: 1385 RVA: 0x000B3868 File Offset: 0x000B1A68
            public static void ATTACH_ENTITY_TO_ENTITY3(int obj, int y)
            {
                ClassicRPC.HookCall(Natives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    obj,
                    y,
                    BoneIndices.SKEL_Head,
                    0.0,
                    0.0,
                    0.0,
                    0f,
                    90f,
                    0.5f,
                    0,
                    0,
                    0
                });
            }

            // Token: 0x0600056A RID: 1386 RVA: 0x000B3920 File Offset: 0x000B1B20
            public static int GET_PLAYER_GROUP(int Ped)
            {
                return ClassicRPC.HookCall(Natives.GET_PLAYER_GROUP, new object[]
                {
                    Ped
                });
            }

            // Token: 0x0600056B RID: 1387 RVA: 0x000B394B File Offset: 0x000B1B4B
            public static void SET_PED_AS_GROUP_LEADER(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_AS_GROUP_LEADER, new object[]
                {
                    Ped,
                    grouphandle
                });
            }

            // Token: 0x0600056C RID: 1388 RVA: 0x000B3974 File Offset: 0x000B1B74
            public static float[] GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int Ped, float[] unk)
            {
                return RPCHook.Call2<float[]>(Natives.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS, new object[]
                {
                    Ped,
                    unk
                });
            }

            // Token: 0x0600056D RID: 1389 RVA: 0x000B39A4 File Offset: 0x000B1BA4
            public static float[] GET_GAMEPLAY_CAM_ROT(int Dis)
            {
                return RPCHook.Call2<float[]>(Natives.GET_GAMEPLAY_CAM_ROT, new object[]
                {
                    Dis
                });
            }

            // Token: 0x0600056E RID: 1390 RVA: 0x000B39D0 File Offset: 0x000B1BD0
            public static void DRAW_LINE(float[] coord1, float[] coord2, int a, int r, int g, int b)
            {
                ClassicRPC.NCall(NewNatives.DRAW_LINE, new object[]
                {
                    coord1,
                    coord2,
                    a,
                    r,
                    g,
                    b
                });
            }

            // Token: 0x0600056F RID: 1391 RVA: 0x000B3A1D File Offset: 0x000B1C1D
            public static void REQUEST_WEAPON_ASSET(int weapon, int unk, int unk2)
            {
                ClassicRPC.HookCall(Natives.REQUEST_WEAPON_ASSET, new object[]
                {
                    weapon,
                    unk,
                    unk2
                });
            }

            // Token: 0x06000570 RID: 1392 RVA: 0x000B3A4C File Offset: 0x000B1C4C
            public static void SET_ENTITY_ROTATION(int entity, float[] val, int unk, int unk2)
            {
                ClassicRPC.HookCall(Natives.SET_ENTITY_ROTATION, new object[]
                {
                    entity,
                    val,
                    unk,
                    unk2
                });
            }

            // Token: 0x06000571 RID: 1393 RVA: 0x000B3A80 File Offset: 0x000B1C80
            public static int GET_ENTITY_PITCH(int entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_PITCH, new object[]
                {
                    entity
                });
            }

            // Token: 0x06000572 RID: 1394 RVA: 0x000B3AAC File Offset: 0x000B1CAC
            public static bool DOES_ENTITY_EXIST(int entity)
            {
                return RPC3.Call(Natives.DOES_ENTITY_EXIST, new object[]
                {
                    entity
                }) != 0;
            }

            // Token: 0x06000573 RID: 1395 RVA: 0x000B3AE4 File Offset: 0x000B1CE4
            public static int GET_ENTITY_ROLL(int entity)
            {
                return ClassicRPC.NCall(NewNatives.GET_ENTITY_ROLL, new object[]
                {
                    entity
                });
            }

            // Token: 0x06000574 RID: 1396 RVA: 0x000B3B10 File Offset: 0x000B1D10
            public static void LocoMode()
            {
                int int_ = Functions.RPCFunc.PLAYER_PED_ID();
                bool flag = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(int_) != 0;
                if (flag)
                {
                    int num = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(int_);
                    float num2 = (float)Functions.RPCFunc.GET_ENTITY_HEADING(num);
                    float num3 = (float)Functions.RPCFunc.GET_ENTITY_PITCH(num);
                    float num4 = (float)Functions.RPCFunc.GET_ENTITY_ROLL(num);
                    num2 += 2f;
                    Functions.RPCFunc.SET_ENTITY_ROTATION(num, new float[]
                    {
                        num3,
                        num4,
                        num2
                    }, 2, 1);
                }
            }

            // Token: 0x06000575 RID: 1397 RVA: 0x000B3B80 File Offset: 0x000B1D80
            public static void DropPickup(float[] Location, string PickupModel, string PickupBehavior, int PickupAmount, string DisplayName, int Client)
            {
                int num = GTA5Main.GET_HASH_KEY(PickupModel);
                int offset = GTA5Main.GET_HASH_KEY(PickupBehavior);
                GTA5Main.REQUEST_MODEL(num);
                bool flag = GTA5Main.HAS_MODEL_LOADED(num) != 0;
                if (flag)
                {
                    Functions.RPCFunc.CREATE_AMBIENT_PICKUP2(offset, Location, 0, PickupAmount, num, 0, 2);
                    GTA5Main.SET_MODEL_AS_NO_LONGER_NEEDED(num);
                }
            }

            // Token: 0x06000576 RID: 1398 RVA: 0x000B3BC8 File Offset: 0x000B1DC8
            public static void AimingLaser()
            {
                int int_ = Functions.RPCFunc.PLAYER_PED_ID();
                int ped = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(int_);
                float[] unk = new float[]
                {
                    0.6f,
                    0.6707f,
                    0.3711f
                };
                float[] unk2 = new float[]
                {
                    -0.6f,
                    0.6707f,
                    0.3711f
                };
                float[] unk3 = new float[]
                {
                    0.6f,
                    25.0707f,
                    0.3711f
                };
                float[] unk4 = new float[]
                {
                    -0.6f,
                    25.0707f,
                    0.3711f
                };
                float[] coord = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk);
                float[] coord2 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk2);
                float[] coord3 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk3);
                float[] coord4 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk4);
                Functions.RPCFunc.DRAW_LINE(coord, coord3, 255, 0, 0, 255);
                Functions.RPCFunc.DRAW_LINE(coord2, coord4, 255, 0, 0, 255);
            }

            // Token: 0x06000577 RID: 1399 RVA: 0x000B3C80 File Offset: 0x000B1E80
            public static void VehicleWeapon(string Bullet)
            {
                int ped = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(Functions.RPCFunc.PLAYER_PED_ID());
                int num = GTA5Main.GET_HASH_KEY(Bullet);
                Functions.RPCFunc.REQUEST_WEAPON_ASSET(num, 31, 0);
                float num2 = 800f;
                float[] unk = new float[]
                {
                    0.6f,
                    0.6707f,
                    0.3711f
                };
                float[] coord = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk);
                float[] unk2 = new float[]
                {
                    -0.6f,
                    0.6707f,
                    0.3711f
                };
                float[] coord2 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk2);
                float[] unk3 = new float[]
                {
                    0.6f,
                    5.0707f,
                    0.3711f
                };
                float[] coord3 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk3);
                float[] unk4 = new float[]
                {
                    -0.6f,
                    5.0707f,
                    0.3711f
                };
                float[] coord4 = Functions.RPCFunc.GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(ped, unk4);
                Functions.RPCFunc.SHOOT_SINGLE_BULLET_BETWEEN_COORDS(coord, coord3, 0, 0, num, Functions.RPCFunc.PLAYER_PED_ID(), 1, 1, (double)num2);
                Functions.RPCFunc.SHOOT_SINGLE_BULLET_BETWEEN_COORDS(coord2, coord4, 0, 0, num, Functions.RPCFunc.PLAYER_PED_ID(), 1, 1, (double)num2);
            }

            // Token: 0x06000578 RID: 1400 RVA: 0x000B3D56 File Offset: 0x000B1F56
            public static void SET_PED_AS_GROUP_MEMBER(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_AS_GROUP_MEMBER, new object[]
                {
                    Ped,
                    grouphandle
                });
            }

            // Token: 0x06000579 RID: 1401 RVA: 0x000B3D7C File Offset: 0x000B1F7C
            public static void SHOOT_SINGLE_BULLET_BETWEEN_COORDS(float[] coord1, float[] coord2, int distance, int unk3, int whash, int me, int unk1, int unk2, double lspeed)
            {
                RPCHook.Call2<int>("SHOOT_SINGLE_BULLET_BETWEEN_COORDS", new object[]
                {
                    coord1,
                    coord2,
                    distance,
                    unk3,
                    whash,
                    me,
                    unk1,
                    unk2,
                    lspeed
                });
            }

            // Token: 0x0600057A RID: 1402 RVA: 0x000B3DE8 File Offset: 0x000B1FE8
            public static void SET_PED_NEVER_LEAVES_GROUP(int Ped, int grouphandle)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_NEVER_LEAVES_GROUP, new object[]
                {
                    Ped,
                    grouphandle
                });
            }

            // Token: 0x0600057B RID: 1403 RVA: 0x000B3E0E File Offset: 0x000B200E
            public static void SET_GROUP_FORMATION(int Ped, int formation)
            {
                ClassicRPC.NCall(NewNatives.SET_GROUP_FORMATION, new object[]
                {
                    Ped,
                    formation
                });
            }

            // Token: 0x0600057C RID: 1404 RVA: 0x000B3E34 File Offset: 0x000B2034
            public static void SET_PED_ARMOUR(int Ped, int value)
            {
                ClassicRPC.NCall(NewNatives.SET_PED_ARMOUR, new object[]
                {
                    Ped,
                    value
                });
            }

            // Token: 0x0600057D RID: 1405 RVA: 0x000B3E5C File Offset: 0x000B205C
            public static int CLONE_PED(int Ped)
            {
                return RPCHook.Call(Natives.CLONE_PED, new object[]
                {
                    Ped
                });
            }

            // Token: 0x0600057E RID: 1406 RVA: 0x000B3E87 File Offset: 0x000B2087
            public static void SET_RADIO_TO_STATION_INDEX(int station)
            {
                ClassicRPC.HookCall(Natives.SET_RADIO_TO_STATION_INDEX, new object[]
                {
                    station
                });
            }

            // Token: 0x0600057F RID: 1407 RVA: 0x000B3EA4 File Offset: 0x000B20A4
            public static void SET_VEHICLE_UNDRIVEABLE(int Veh, bool toggle)
            {
                ClassicRPC.Call(Natives.SET_VEHICLE_UNDRIVEABLE, new object[]
                {
                    Veh,
                    toggle
                });
            }

            // Token: 0x06000580 RID: 1408 RVA: 0x000B3ECA File Offset: 0x000B20CA
            public static void SET_VEHICLE_TYRES_CAN_BURST(int Veh, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_TYRES_CAN_BURST, new object[]
                {
                    Veh,
                    toggle
                });
            }

            // Token: 0x06000581 RID: 1409 RVA: 0x000B3EF0 File Offset: 0x000B20F0
            public static void EXPLODE_PED_HEAD(int Ped, string WeapHash)
            {
                ClassicRPC.NCall(NewNatives.EXPLODE_PED_HEAD, new object[]
                {
                    Ped,
                    WeapHash
                });
            }

            // Token: 0x06000582 RID: 1410 RVA: 0x000B3F11 File Offset: 0x000B2111
            public static void START_VEHICLE_ALARM(int Veh)
            {
                ClassicRPC.NCall(NewNatives.START_VEHICLE_ALARM, new object[]
                {
                    Veh
                });
            }

            // Token: 0x06000583 RID: 1411 RVA: 0x000B3F2E File Offset: 0x000B212E
            public static void ROLL_DOWN_WINDOWS(int Veh)
            {
                ClassicRPC.NCall(NewNatives.ROLL_DOWN_WINDOWS, new object[]
                {
                    Veh
                });
            }

            // Token: 0x06000584 RID: 1412 RVA: 0x000B3F4B File Offset: 0x000B214B
            public static void ROLL_DOWN_WINDOW(int Veh, int windowindex)
            {
                ClassicRPC.NCall(NewNatives.ROLL_DOWN_WINDOW, new object[]
                {
                    Veh,
                    windowindex
                });
            }

            // Token: 0x06000585 RID: 1413 RVA: 0x000B3F71 File Offset: 0x000B2171
            public static void ROLL_UP_WINDOW(int Veh, int windowindex)
            {
                ClassicRPC.NCall(NewNatives.ROLL_UP_WINDOW, new object[]
                {
                    Veh,
                    windowindex
                });
            }

            // Token: 0x06000586 RID: 1414 RVA: 0x000B3F97 File Offset: 0x000B2197
            public static void SET_VEHICLE_INDICATOR_LIGHTS(int Veh, int signal, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_INDICATOR_LIGHTS, new object[]
                {
                    Veh,
                    signal,
                    toggle
                });
            }

            // Token: 0x06000587 RID: 1415 RVA: 0x000B3FC8 File Offset: 0x000B21C8
            public static void DRAW_LIGHT_WITH_RANGE(float[] Coords, int r, int g, int b, float fl1, float fl2)
            {
                ClassicRPC.NCall(NewNatives.DRAW_LIGHT_WITH_RANGE, new object[]
                {
                    Coords,
                    r,
                    g,
                    b,
                    fl1,
                    fl2
                });
            }

            // Token: 0x06000588 RID: 1416 RVA: 0x000B401A File Offset: 0x000B221A
            public static void SET_VEHICLE_ON_GROUND_PROPERLY(int Veh)
            {
                RPC3.Call(Natives.SET_VEHICLE_ON_GROUND_PROPERLY, new object[]
                {
                    Veh
                });
            }

            // Token: 0x06000589 RID: 1417 RVA: 0x000B4037 File Offset: 0x000B2237
            public static void TASK_PARACHUTE(int in1, int in2)
            {
                ClassicRPC.NCall(NewNatives.TASK_PARACHUTE, new object[]
                {
                    in1,
                    in2
                });
            }

            // Token: 0x0600058A RID: 1418 RVA: 0x000B4060 File Offset: 0x000B2260
            public static void DRAW_LINE(float[] TargetPED)
            {
                float[] array = Functions.RPCFunc.GET_ENTITY_COORDS(Functions.RPCFunc.PLAYER_PED_ID());
                ClassicRPC.NCall(NewNatives.DRAW_LINE, new object[]
                {
                    array,
                    TargetPED,
                    255,
                    0,
                    0,
                    255
                });
            }

            // Token: 0x0600058B RID: 1419 RVA: 0x000B40BE File Offset: 0x000B22BE
            public static void SHAKE_GAMEPLAY_CAM(string in1, float in2)
            {
                ClassicRPC.Call(Natives.SHAKE_GAMEPLAY_CAM, new object[]
                {
                    in1,
                    in2
                });
            }

            // Token: 0x0600058C RID: 1420 RVA: 0x000B40E0 File Offset: 0x000B22E0
            public static void APPLY_FORCE_TO_ENTITY(int Entity, float[] force, float[] pos)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[]
                {
                    Entity,
                    1,
                    force,
                    pos,
                    0,
                    1,
                    1,
                    1,
                    0,
                    1
                });
            }

            // Token: 0x0600058D RID: 1421 RVA: 0x000B4154 File Offset: 0x000B2354
            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP(int Entity, int in1, int in2, int in3, int in4, int in5, int in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[]
                {
                    Entity,
                    in1,
                    in2,
                    in3,
                    in4,
                    in5,
                    in6,
                    in7,
                    in8,
                    in9,
                    in10,
                    in11,
                    in12,
                    in13
                });
            }

            // Token: 0x0600058E RID: 1422 RVA: 0x000B4204 File Offset: 0x000B2404
            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP2(int Entity, int in1, double in2, int in3, int in4, int in5, double in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[]
                {
                    Entity,
                    in1,
                    in2,
                    in3,
                    in4,
                    in5,
                    in6,
                    in7,
                    in8,
                    in9,
                    in10,
                    in11,
                    in12,
                    in13
                });
            }

            // Token: 0x0600058F RID: 1423 RVA: 0x000B42B4 File Offset: 0x000B24B4
            public static void APPLY_FORCE_TO_ENTITY_FOR_SUP3(int Entity, int in1, int in2, int in3, double in4, int in5, int in6, int in7, int in8, int in9, int in10, int in11, int in12, int in13)
            {
                ClassicRPC.NCall(NewNatives.APPLY_FORCE_TO_ENTITY, new object[]
                {
                    Entity,
                    in1,
                    in2,
                    in3,
                    in4,
                    in5,
                    in6,
                    in7,
                    in8,
                    in9,
                    in10,
                    in11,
                    in12,
                    in13
                });
            }

            // Token: 0x06000590 RID: 1424 RVA: 0x000B4364 File Offset: 0x000B2564
            public static int GET_FIRST_BLIP_INFO_ID(int wp)
            {
                return ClassicRPC.NCall(NewNatives.GET_FIRST_BLIP_INFO_ID, new object[]
                {
                    wp
                });
            }

            // Token: 0x06000591 RID: 1425 RVA: 0x000B4390 File Offset: 0x000B2590
            public static int DOES_BLIP_EXIST(int wp)
            {
                return ClassicRPC.NCall(NewNatives.GET_FIRST_BLIP_INFO_ID, new object[]
                {
                    wp
                });
            }

            // Token: 0x06000592 RID: 1426 RVA: 0x000B43BC File Offset: 0x000B25BC
            public static float[] GET_BLIP_COORDS(int wp)
            {
                return RPCHook.Call2<float[]>(Natives.GET_BLIP_COORDS, new object[]
                {
                    wp
                });
            }

            // Token: 0x06000593 RID: 1427 RVA: 0x000B43E8 File Offset: 0x000B25E8
            public static void TeleToWayp()
            {
                while (Functions.ContinueWP)
                {
                    int wp = Functions.RPCFunc.GET_FIRST_BLIP_INFO_ID(8);
                    float[] array = Functions.RPCFunc.GET_BLIP_COORDS(wp);
                    float[] array2 = new float[3];
                    bool flag = Functions.RPCFunc.IS_PED_IN_ANY_VEHICLE(Functions.RPCFunc.PLAYER_PED_ID()) == 1;
                    int num;
                    if (flag)
                    {
                        num = Functions.RPCFunc.GET_PED_VEHICLE_IS_USING(Functions.RPCFunc.PLAYER_PED_ID());
                    }
                    else
                    {
                        num = Functions.RPCFunc.PLAYER_PED_ID();
                    }
                    float num2 = 0f;
                    bool flag2 = array[0] != 0f && array[1] != 0f;
                    if (flag2)
                    {
                        Functions.RPCFunc.SET_ENTITY_COORDS(num, array);
                        Functions.ContinueWP = true;
                    }
                    bool continueWP = Functions.ContinueWP;
                    if (continueWP)
                    {
                        array2 = Functions.RPCFunc.GET_ENTITY_COORDS(num);
                        array2[2] += 10f;
                        Functions.RPCFunc.SET_ENTITY_COORDS(num, array2);
                    }
                    bool flag3 = RPC3.Call2<int>(Natives.GET_GROUND_Z_FOR_3D_COORD, new object[]
                    {
                        array2,
                        num2
                    }) != 0;
                    if (flag3)
                    {
                        Functions.RPCFunc.SET_ENTITY_COORDS2(num, array2[0], array2[1], num2 + 1f);
                        Functions.ContinueWP = false;
                    }
                }
            }

            // Token: 0x06000594 RID: 1428 RVA: 0x000B44F8 File Offset: 0x000B26F8
            public static bool IS_PLAYER_ALIVE(int PED)
            {
                return ClassicRPC.NCall(NewNatives.IS_PLAYER_DEAD, new object[]
                {
                    PED
                }) == 0;
            }

            // Token: 0x06000595 RID: 1429 RVA: 0x000B4530 File Offset: 0x000B2730
            public static int GET_PLAYER_RADIO_STATION_INDEX()
            {
                object obj = 0;
                return ClassicRPC.NCall(NewNatives.GET_PLAYER_RADIO_STATION_INDEX, new object[]
                {
                    obj
                });
            }

            // Token: 0x06000596 RID: 1430 RVA: 0x000B455D File Offset: 0x000B275D
            public static void SET_POLICE_IGNORE_PLAYER(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_POLICE_IGNORE_PLAYER, new object[]
                {
                    Player,
                    Toggle
                });
            }

            // Token: 0x06000597 RID: 1431 RVA: 0x000B4583 File Offset: 0x000B2783
            public static void SET_EVERYONE_IGNORE_PLAYER(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_EVERYONE_IGNORE_PLAYER, new object[]
                {
                    Player,
                    Toggle
                });
            }

            // Token: 0x06000598 RID: 1432 RVA: 0x000B45A9 File Offset: 0x000B27A9
            public static void SET_PLAYER_FORCED_AIM(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_FORCED_AIM, new object[]
                {
                    Player,
                    Toggle
                });
            }

            // Token: 0x06000599 RID: 1433 RVA: 0x000B45CF File Offset: 0x000B27CF
            public static void SET_PLAYER_FORCED_ZOOM(int Player, bool Toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_FORCED_ZOOM, new object[]
                {
                    Player,
                    Toggle
                });
            }

            // Token: 0x0600059A RID: 1434 RVA: 0x000B45F5 File Offset: 0x000B27F5
            public static void CLEAR_WANTED_LEVEL(int Player)
            {
                ClassicRPC.NCall(NewNatives.CLEAR_PLAYER_WANTED_LEVEL, new object[]
                {
                    Player
                });
            }

            // Token: 0x0600059B RID: 1435 RVA: 0x000B4612 File Offset: 0x000B2812
            public static void SET_WANTED_LEVEL(int Player, int Level)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_WANTED_LEVEL, new object[]
                {
                    Player,
                    Level
                });
            }

            // Token: 0x0600059C RID: 1436 RVA: 0x000B267C File Offset: 0x000B087C
            public static void SET_PLAYER_INVINCIBLE(int Player, int toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_PLAYER_INVINCIBLE, new object[]
                {
                    Player,
                    toggle
                });
            }

            // Token: 0x0600059D RID: 1437 RVA: 0x000B4638 File Offset: 0x000B2838
            public static void NETWORK_EARN_FROM_ROCKSTAR(int Player, int value)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_EARN_FROM_ROCKSTAR, new object[]
                {
                    Player,
                    value
                });
            }

            // Token: 0x0600059E RID: 1438 RVA: 0x000B465E File Offset: 0x000B285E
            public static void SET_VEHICLE_GRAVITY(int state, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_GRAVITY, new object[]
                {
                    state,
                    toggle
                });
            }

            // Token: 0x0600059F RID: 1439 RVA: 0x000B4684 File Offset: 0x000B2884
            public static void SET_VEHICLE_DOORS_LOCKED(int Veh, int toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED, new object[]
                {
                    Veh,
                    toggle
                });
            }

            // Token: 0x060005A0 RID: 1440 RVA: 0x000B46AC File Offset: 0x000B28AC
            public static void ADD_EXPLOSION(float[] coord, int ExType)
            {
                ClassicRPC.NCall(NewNatives.ADD_EXPLOSION, new object[]
                {
                    coord,
                    ExType,
                    5f,
                    0,
                    1,
                    5f
                });
            }

            // Token: 0x060005A1 RID: 1441 RVA: 0x000B4704 File Offset: 0x000B2904
            public static int GET_FREE_SEAT(int Vehicle)
            {
                int num = Functions.RPCFunc.GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(Vehicle);
                for (int i = -1; i < num; i++)
                {
                    bool flag = Functions.RPCFunc.IS_VEHICLE_SEAT_FREE(Vehicle, i);
                    if (flag)
                    {
                        return i;
                    }
                }
                return -2;
            }

            // Token: 0x060005A2 RID: 1442 RVA: 0x000B4744 File Offset: 0x000B2944
            public static void TELEPORT_ME_TO_PLAYER_CAR(int Player)
            {
                int num = Functions.RPCFunc.GET_PLAYER_PED(Player);
                bool flag = Functions.RPCFunc.IS_PED_IN_VEHICLE(num) != 0;
                if (flag)
                {
                    int vehicle = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(num);
                    Functions.RPCFunc.SET_PED_INTO_VEHICLE2(Functions.RPCFunc.PLAYER_PED_ID(), vehicle, Functions.RPCFunc.GET_FREE_SEAT(vehicle));
                }
            }

            // Token: 0x060005A3 RID: 1443 RVA: 0x000B4784 File Offset: 0x000B2984
            public static void TELEPORT_PLAYER_TO_MY_CAR(int PlayerToTeleport)
            {
                int num = Functions.RPCFunc.PLAYER_PED_ID();
                bool flag = Functions.RPCFunc.IS_PED_IN_VEHICLE(num) != 0;
                if (flag)
                {
                    int vehicle = Functions.RPCFunc.GET_PED_VEHICLE_IS_IN(num);
                    Functions.RPCFunc.SET_PED_INTO_VEHICLE2(Functions.RPCFunc.GET_PLAYER_PED(PlayerToTeleport), vehicle, Functions.RPCFunc.GET_FREE_SEAT(vehicle));
                }
            }

            // Token: 0x060005A4 RID: 1444 RVA: 0x000B47C4 File Offset: 0x000B29C4
            public static int ATTACH_OBJECT_TO_PLAYER(int Hash, float[] coord, int ped)
            {
                int num = Functions.RPCFunc.CREATE_OBJECT_INT(Hash, coord);
                RPCHook.CompleteReq();
                Functions.RPCFunc.ATTACH_PED_TO_PED(num, ped);
                return num;
            }

            // Token: 0x060005A5 RID: 1445 RVA: 0x000B47F0 File Offset: 0x000B29F0
            public static int CREATE_OBJECT_INT(int hash, float[] coords)
            {
                return RPCHook.Call2<int>(Natives.CREATE_OBJECT, new object[]
                {
                    hash,
                    coords,
                    1,
                    1,
                    0
                });
            }

            // Token: 0x060005A6 RID: 1446 RVA: 0x000B483C File Offset: 0x000B2A3C
            public static void ATTACH_OB_TO_ENTITY(int ObjToNet, int ToAttachID, int bone, float X, float Y, float Z, float RX, float RY, float RZ)
            {
                float[] array = new float[3];
                float[] array2 = new float[3];
                array[0] += X;
                array[1] += Y;
                array[2] += Z;
                array2[0] += RX;
                array2[1] += RY;
                array2[2] += RZ;
                RPCHook.Call2<int>(Natives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    ObjToNet,
                    ToAttachID,
                    bone,
                    array,
                    array2,
                    1,
                    1,
                    1,
                    1,
                    2,
                    1
                });
            }

            // Token: 0x060005A7 RID: 1447 RVA: 0x000B4914 File Offset: 0x000B2B14
            public static void ATTACH_ENTITY_TO_ENTITY_2(int Ent, int Ent2, int Bone = 0, float f1 = 0f, float f2 = 0f, float f3 = 0f, float f4 = 0f, float f5 = 2f, float f6 = 0f, int i1 = 1, int i2 = 0)
            {
                RPCHook.Call2<int>(OLDNatives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    Ent,
                    Ent2,
                    Bone,
                    f1,
                    f2,
                    f3,
                    f4,
                    f5,
                    f6,
                    0,
                    i1,
                    i2,
                    0,
                    2,
                    1
                });
            }

            // Token: 0x060005A8 RID: 1448 RVA: 0x000B49C8 File Offset: 0x000B2BC8
            public static void ATTACH_PED_TO_PED(int toatt, int Ped)
            {
                RPCHook.Call2<int>(OLDNatives.ATTACH_ENTITY_TO_ENTITY, new object[]
                {
                    toatt,
                    Ped,
                    0,
                    268632080,
                    268632080,
                    0,
                    0,
                    0,
                    0,
                    2,
                    0
                });
            }

            // Token: 0x060005A9 RID: 1449 RVA: 0x000B4A55 File Offset: 0x000B2C55
            public static void DETACH_ENTITY_FROM_ENTITY(int todet, int ent)
            {
                RPCHook.Call2<int>(OLDNatives.DETACH_ENTITY, new object[]
                {
                    todet,
                    ent,
                    1
                });
            }

            // Token: 0x060005AA RID: 1450 RVA: 0x000B4A84 File Offset: 0x000B2C84
            public static void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS, new object[]
                {
                    vehicle,
                    toggle
                });
            }

            // Token: 0x060005AB RID: 1451 RVA: 0x000B4AAA File Offset: 0x000B2CAA
            public static void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int Player, bool toggle)
            {
                ClassicRPC.NCall(NewNatives.SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER, new object[]
                {
                    vehicle,
                    Player,
                    toggle
                });
            }

            // Token: 0x060005AC RID: 1452 RVA: 0x000B4ADC File Offset: 0x000B2CDC
            public static int CREATE_OBJECT_NEW(uint Hash, float[] Coords)
            {
                return ClassicRPC.NCall(NewNatives.CREATE_OBJECT, new object[]
                {
                    Hash,
                    Coords,
                    true,
                    true,
                    false
                });
            }

            // Token: 0x060005AD RID: 1453 RVA: 0x000B4B26 File Offset: 0x000B2D26
            public static void SHOW_NOTIFY(string txt)
            {
                Functions.RPCFunc.NOTIFICATION_TYPE("STRING");
                Functions.RPCFunc.NOTIFICATION_TEXT(txt);
                Functions.RPCFunc.NOTIFICATION_SHOW(2000, 1);
            }

            // Token: 0x060005AE RID: 1454 RVA: 0x000B4B47 File Offset: 0x000B2D47
            public static void NOTIFICATION_TYPE(string type)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_TYPE, new object[]
                {
                    type
                });
            }

            // Token: 0x060005AF RID: 1455 RVA: 0x000B4B5F File Offset: 0x000B2D5F
            public static void NOTIFICATION_TEXT(string type)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_TEXT, new object[]
                {
                    type
                });
            }

            // Token: 0x060005B0 RID: 1456 RVA: 0x000B4B77 File Offset: 0x000B2D77
            public static void NOTIFICATION_SHOW(int MilliSec, int Enable)
            {
                ClassicRPC.Call(Natives.NOTIFICATION_SHOW, new object[]
                {
                    MilliSec,
                    Enable
                });
            }

            // Token: 0x060005B1 RID: 1457 RVA: 0x000B4B9D File Offset: 0x000B2D9D
            public static void PRINT(string txt, int MilliSec)
            {
                Functions.RPCFunc.PRINT_TEXT_TYPE("STRING");
                Functions.RPCFunc.PRINT_TEXT_TEXT(txt);
                Functions.RPCFunc.PRINT_TEXT_TIME(MilliSec);
            }

            // Token: 0x060005B2 RID: 1458 RVA: 0x000B4BB9 File Offset: 0x000B2DB9
            public static void PRINT_TEXT_TYPE(string type)
            {
                ClassicRPC.Call(Natives.PRINT_TEXT_TYPE, new object[]
                {
                    type
                });
            }

            // Token: 0x060005B3 RID: 1459 RVA: 0x000B4BD1 File Offset: 0x000B2DD1
            public static void PRINT_TEXT_TEXT(string txt)
            {
                ClassicRPC.Call(Natives.ADD_TEXT_COMPONENT_STRING, new object[]
                {
                    txt
                });
            }

            // Token: 0x060005B4 RID: 1460 RVA: 0x000B4BE9 File Offset: 0x000B2DE9
            public static void PRINT_TEXT_TIME(int sec)
            {
                ClassicRPC.Call(Natives.PRINT_TEXT_TIME, new object[]
                {
                    sec
                });
            }

            // Token: 0x060005B5 RID: 1461 RVA: 0x000B4C08 File Offset: 0x000B2E08
            public static void TASK_FOLLOW_NAV_MESH_TO_COORD(int Player, float[] Coords, int a, int b, int c, int d, int e)
            {
                ClassicRPC.NCall(NewNatives.TASK_FOLLOW_NAV_MESH_TO_COORD, new object[]
                {
                    Player,
                    Coords,
                    a,
                    b,
                    c,
                    d,
                    e
                });
            }

            // Token: 0x060005B6 RID: 1462 RVA: 0x000B4C64 File Offset: 0x000B2E64
            public static void NETWORK_SET_FRIENDLY_FIRE_OPTION(int am)
            {
                ClassicRPC.NCall(NewNatives.NETWORK_SET_FRIENDLY_FIRE_OPTION, new object[]
                {
                    am
                });
            }

            // Token: 0x060005B7 RID: 1463 RVA: 0x000B4C84 File Offset: 0x000B2E84
            public static int GET_NEAREST_PLAYER_TO_ENTITY(int Player)
            {
                return ClassicRPC.NCall(NewNatives.GET_NEAREST_PLAYER_TO_ENTITY, new object[]
                {
                    Player
                });
            }

            // Token: 0x060005B8 RID: 1464 RVA: 0x000B4CAF File Offset: 0x000B2EAF
            public static void TASK_JUMP(int Player)
            {
                ClassicRPC.Call(Natives.TASK_JUMP, new object[]
                {
                    Player
                });
            }

            // Token: 0x04002705 RID: 9989
            public static string WeapStr = "";

            // Token: 0x04002706 RID: 9990
            public static CancellationTokenSource tokenSource_0 = new CancellationTokenSource();

            // Token: 0x04002707 RID: 9991
            public static CancellationTokenSource tokenSource_1 = new CancellationTokenSource();

            // Token: 0x04002708 RID: 9992
            public static CancellationTokenSource tokenSource_2 = new CancellationTokenSource();

            // Token: 0x04002709 RID: 9993
            public static CancellationTokenSource tokenSource_3 = new CancellationTokenSource();

            // Token: 0x0400270A RID: 9994
            public static CancellationTokenSource tokenSource_4 = new CancellationTokenSource();

            // Token: 0x0400270B RID: 9995
            public static CancellationTokenSource tokenSource_5 = new CancellationTokenSource();

            // Token: 0x0400270C RID: 9996
            public static CancellationTokenSource tokenSource_6 = new CancellationTokenSource();

            // Token: 0x0400270D RID: 9997
            public static CancellationTokenSource tokenSource_11 = new CancellationTokenSource();

            // Token: 0x0400270E RID: 9998
            public static CancellationTokenSource tokenSource_12 = new CancellationTokenSource();

            // Token: 0x0400270F RID: 9999
            public static CancellationTokenSource tokenSource_13 = new CancellationTokenSource();

            // Token: 0x04002710 RID: 10000
            public static CancellationTokenSource tokenSource_14 = new CancellationTokenSource();

            // Token: 0x04002711 RID: 10001
            public static CancellationTokenSource tokenSource_15 = new CancellationTokenSource();

            // Token: 0x04002712 RID: 10002
            public static CancellationTokenSource tokenSource_16 = new CancellationTokenSource();

            // Token: 0x04002713 RID: 10003
            public static CancellationTokenSource tokenSource_17 = new CancellationTokenSource();

            // Token: 0x04002714 RID: 10004
            public static CancellationTokenSource tokenSource_18 = new CancellationTokenSource();

            // Token: 0x04002715 RID: 10005
            public static CancellationTokenSource tokenSource_19 = new CancellationTokenSource();

            // Token: 0x04002716 RID: 10006
            public static CancellationTokenSource tokenSource_20 = new CancellationTokenSource();

            // Token: 0x04002717 RID: 10007
            public static CancellationTokenSource tokenSource_21 = new CancellationTokenSource();

            // Token: 0x04002718 RID: 10008
            public static CancellationTokenSource tokenSource_22 = new CancellationTokenSource();

            // Token: 0x04002719 RID: 10009
            public static CancellationTokenSource tokenSource_23 = new CancellationTokenSource();

            // Token: 0x0400271A RID: 10010
            public static CancellationTokenSource tokenSource_24 = new CancellationTokenSource();

            // Token: 0x0400271B RID: 10011
            public static CancellationTokenSource tokenSource_25 = new CancellationTokenSource();

            // Token: 0x0400271C RID: 10012
            public static CancellationTokenSource tokenSource_26 = new CancellationTokenSource();

            // Token: 0x0400271D RID: 10013
            public static CancellationTokenSource tokenSource_27 = new CancellationTokenSource();

            // Token: 0x0400271E RID: 10014
            public static CancellationToken token_0 = Functions.RPCFunc.tokenSource_0.Token;

            // Token: 0x0400271F RID: 10015
            public static CancellationToken token_1 = Functions.RPCFunc.tokenSource_1.Token;

            // Token: 0x04002720 RID: 10016
            public static CancellationToken token_2 = Functions.RPCFunc.tokenSource_2.Token;

            // Token: 0x04002721 RID: 10017
            public static CancellationToken token_3 = Functions.RPCFunc.tokenSource_3.Token;

            // Token: 0x04002722 RID: 10018
            public static CancellationToken token_4 = Functions.RPCFunc.tokenSource_4.Token;

            // Token: 0x04002723 RID: 10019
            public static CancellationToken token_5 = Functions.RPCFunc.tokenSource_5.Token;

            // Token: 0x04002724 RID: 10020
            public static CancellationToken token_6 = Functions.RPCFunc.tokenSource_6.Token;

            // Token: 0x04002725 RID: 10021
            public static CancellationToken token_11 = Functions.RPCFunc.tokenSource_11.Token;

            // Token: 0x04002726 RID: 10022
            public static CancellationToken token_12 = Functions.RPCFunc.tokenSource_12.Token;

            // Token: 0x04002727 RID: 10023
            public static CancellationToken token_13 = Functions.RPCFunc.tokenSource_13.Token;

            // Token: 0x04002728 RID: 10024
            public static CancellationToken token_14 = Functions.RPCFunc.tokenSource_14.Token;

            // Token: 0x04002729 RID: 10025
            public static CancellationToken token_15 = Functions.RPCFunc.tokenSource_15.Token;

            // Token: 0x0400272A RID: 10026
            public static CancellationToken token_16 = Functions.RPCFunc.tokenSource_16.Token;

            // Token: 0x0400272B RID: 10027
            public static CancellationToken token_17 = Functions.RPCFunc.tokenSource_17.Token;

            // Token: 0x0400272C RID: 10028
            public static CancellationToken token_18 = Functions.RPCFunc.tokenSource_18.Token;

            // Token: 0x0400272D RID: 10029
            public static CancellationToken token_19 = Functions.RPCFunc.tokenSource_19.Token;

            // Token: 0x0400272E RID: 10030
            public static CancellationToken token_20 = Functions.RPCFunc.tokenSource_20.Token;

            // Token: 0x0400272F RID: 10031
            public static CancellationToken token_21 = Functions.RPCFunc.tokenSource_21.Token;

            // Token: 0x04002730 RID: 10032
            public static CancellationToken token_22 = Functions.RPCFunc.tokenSource_22.Token;

            // Token: 0x04002731 RID: 10033
            public static CancellationToken token_23 = Functions.RPCFunc.tokenSource_23.Token;

            // Token: 0x04002732 RID: 10034
            public static CancellationToken token_24 = Functions.RPCFunc.tokenSource_24.Token;

            // Token: 0x04002733 RID: 10035
            public static CancellationToken token_25 = Functions.RPCFunc.tokenSource_25.Token;

            // Token: 0x04002734 RID: 10036
            public static CancellationToken token_26 = Functions.RPCFunc.tokenSource_26.Token;

            // Token: 0x04002735 RID: 10037
            public static CancellationToken token_27 = Functions.RPCFunc.tokenSource_27.Token;

            // Token: 0x04002736 RID: 10038
            public static uint entityXCoord = 268632064u;

            // Token: 0x04002737 RID: 10039
            public static uint entityYCoord = 268632068u;

            // Token: 0x04002738 RID: 10040
            public static uint entityZCoord = 268632072u;

            // Token: 0x04002739 RID: 10041
            public static string[] Walk = new string[]
            {
                "move_m@casual@b",
                "move_m@drunk@verydrunk",
                "move_m@fat@a",
                "move_f@film_reel",
                "move_m@hiking",
                "move_m@business@a"
            };

            // Token: 0x0400273A RID: 10042
            public static string[] Visions = new string[]
            {
                "DEFAULT",
                "stoned",
                "REDMIST",
                "DEATH",
                "stoned_aliens",
                "MichaelColorCode",
                "NeutralColorCode",
                "player_transition",
                "Bloom",
                "CHOP",
                "hud_def_blur",
                "PlayerSwitchPulse",
                "michealspliff",
                "BarryFadeOut",
                "Drunk",
                "drug_flying_base",
                "DRUG_gas_huffin",
                "drug_wobbly",
                "MP_heli_cam",
                "BlackOut",
                "phone_cam1",
                "phone_cam2",
                "phone_cam3",
                "phone_cam4",
                "phone_cam5",
                "phone_cam6",
                "phone_cam7",
                "phone_cam8",
                "phone_cam9",
                "phone_cam10",
                "phone_cam11",
                "phone_cam12",
                "phone_cam13"
            };

            // Token: 0x0400273B RID: 10043
            public static byte[] AllHUDBlue = new byte[]
            {
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue,
                15,
                157,
                232,
                byte.MaxValue
            };

            // Token: 0x0400273C RID: 10044
            public static byte[] AllHUDGreen = new byte[]
            {
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue,
                58,
                137,
                35,
                byte.MaxValue
            };

            // Token: 0x0400273D RID: 10045
            public static byte[] AllHUDRed = new byte[]
            {
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue,
                238,
                16,
                16,
                byte.MaxValue
            };

            // Token: 0x0400273E RID: 10046
            public static byte[] AllHUDOrange = new byte[]
            {
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue,
                223,
                109,
                20,
                byte.MaxValue
            };

            // Token: 0x0400273F RID: 10047
            public static byte[] AllHUDPurple = new byte[]
            {
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue,
                121,
                28,
                248,
                byte.MaxValue
            };

            // Token: 0x04002740 RID: 10048
            public static byte[] AllHUDPink = new byte[]
            {
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue,
                253,
                63,
                146,
                byte.MaxValue
            };

            // Token: 0x04002741 RID: 10049
            public static byte[] AllHUDYellow = new byte[]
            {
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue,
                231,
                240,
                13,
                byte.MaxValue
            };

            // Token: 0x04002742 RID: 10050
            public static byte[] AllHUDBrown = new byte[]
            {
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue,
                173,
                79,
                9,
                byte.MaxValue
            };

            // Token: 0x04002743 RID: 10051
            public static byte[] AllHUDNormal = new byte[]
            {
                155,
                155,
                155,
                byte.MaxValue,
                205,
                205,
                205,
                byte.MaxValue,
                77,
                77,
                77,
                byte.MaxValue,
                194,
                80,
                80,
                byte.MaxValue,
                225,
                168,
                168,
                byte.MaxValue,
                97,
                40,
                40,
                byte.MaxValue,
                93,
                182,
                229,
                byte.MaxValue,
                174,
                219,
                242,
                byte.MaxValue,
                47,
                92,
                115,
                byte.MaxValue,
                240,
                200,
                80,
                byte.MaxValue,
                254,
                235,
                169,
                byte.MaxValue,
                126,
                107,
                41,
                byte.MaxValue,
                byte.MaxValue,
                133,
                85,
                byte.MaxValue,
                byte.MaxValue,
                194,
                170,
                byte.MaxValue,
                127,
                66,
                42,
                byte.MaxValue,
                102,
                152,
                104,
                byte.MaxValue,
                179,
                204,
                180,
                byte.MaxValue,
                52,
                77,
                53,
                byte.MaxValue,
                100,
                79,
                142,
                byte.MaxValue,
                78,
                167,
                199,
                byte.MaxValue,
                50,
                39,
                71,
                byte.MaxValue,
                203,
                54,
                148,
                byte.MaxValue,
                53,
                154,
                71,
                byte.MaxValue,
                93,
                182,
                229,
                byte.MaxValue,
                235,
                36,
                39,
                byte.MaxValue,
                194,
                80,
                80,
                byte.MaxValue,
                156,
                110,
                175,
                byte.MaxValue,
                byte.MaxValue,
                123,
                196,
                byte.MaxValue,
                229,
                176,
                147,
                byte.MaxValue,
                199,
                131,
                209,
                byte.MaxValue,
                215,
                189,
                121,
                byte.MaxValue,
                139,
                179,
                167,
                byte.MaxValue,
                123,
                156,
                84,
                byte.MaxValue,
                144,
                127,
                153,
                byte.MaxValue,
                106,
                196,
                191,
                byte.MaxValue,
                214,
                196,
                153,
                byte.MaxValue,
                234,
                142,
                80,
                byte.MaxValue,
                152,
                203,
                234,
                byte.MaxValue,
                178,
                98,
                135,
                byte.MaxValue,
                144,
                142,
                122,
                byte.MaxValue,
                166,
                117,
                94,
                byte.MaxValue,
                175,
                168,
                168,
                byte.MaxValue,
                232,
                142,
                155,
                byte.MaxValue,
                187,
                214,
                91,
                byte.MaxValue,
                12,
                123,
                86,
                byte.MaxValue,
                123,
                196,
                byte.MaxValue,
                byte.MaxValue,
                171,
                60,
                230,
                byte.MaxValue,
                206,
                169,
                13,
                byte.MaxValue,
                71,
                99,
                173,
                byte.MaxValue,
                42,
                166,
                185,
                byte.MaxValue,
                186,
                157,
                125,
                byte.MaxValue,
                201,
                225,
                byte.MaxValue,
                byte.MaxValue,
                240,
                240,
                150,
                byte.MaxValue,
                237,
                140,
                161,
                byte.MaxValue,
                249,
                138,
                138,
                byte.MaxValue,
                252,
                239,
                166,
                byte.MaxValue,
                240,
                240,
                240,
                byte.MaxValue,
                159,
                201,
                166,
                byte.MaxValue,
                140,
                140,
                140,
                byte.MaxValue,
                140,
                140,
                140,
                byte.MaxValue,
                40,
                40,
                40,
                byte.MaxValue,
                240,
                160,
                0,
                byte.MaxValue,
                240,
                160,
                0,
                byte.MaxValue,
                240,
                160,
                0,
                byte.MaxValue,
                140,
                140,
                140,
                byte.MaxValue,
                60,
                60,
                60,
                byte.MaxValue,
                30,
                30,
                30,
                byte.MaxValue,
                140,
                140,
                140,
                byte.MaxValue,
                75,
                75,
                75,
                byte.MaxValue,
                50,
                50,
                50,
                byte.MaxValue,
                95,
                95,
                95,
                byte.MaxValue,
                100,
                100,
                100,
                byte.MaxValue,
                97,
                40,
                40,
                byte.MaxValue,
                78,
                55,
                87,
                byte.MaxValue,
                121,
                40,
                85,
                byte.MaxValue,
                114,
                88,
                73,
                byte.MaxValue,
                99,
                65,
                104,
                byte.MaxValue,
                107,
                94,
                60,
                byte.MaxValue,
                69,
                89,
                83,
                byte.MaxValue,
                61,
                78,
                42,
                byte.MaxValue,
                72,
                63,
                76,
                byte.MaxValue,
                53,
                98,
                95,
                byte.MaxValue,
                107,
                98,
                76,
                byte.MaxValue,
                117,
                71,
                40,
                byte.MaxValue,
                76,
                101,
                117,
                byte.MaxValue,
                65,
                35,
                47,
                byte.MaxValue,
                72,
                71,
                61,
                byte.MaxValue,
                85,
                58,
                47,
                byte.MaxValue,
                87,
                84,
                84,
                byte.MaxValue,
                116,
                71,
                77,
                byte.MaxValue,
                93,
                107,
                45,
                byte.MaxValue,
                6,
                61,
                43,
                byte.MaxValue,
                61,
                98,
                127,
                byte.MaxValue,
                85,
                30,
                115,
                byte.MaxValue,
                103,
                84,
                6,
                byte.MaxValue,
                35,
                49,
                86,
                byte.MaxValue,
                21,
                83,
                92,
                byte.MaxValue,
                93,
                98,
                62,
                byte.MaxValue,
                100,
                112,
                127,
                byte.MaxValue,
                120,
                120,
                75,
                byte.MaxValue,
                152,
                76,
                93,
                byte.MaxValue,
                124,
                69,
                69,
                byte.MaxValue,
                10,
                43,
                50,
                byte.MaxValue,
                95,
                95,
                10,
                byte.MaxValue,
                180,
                130,
                97,
                byte.MaxValue,
                150,
                153,
                161,
                byte.MaxValue,
                214,
                181,
                99,
                byte.MaxValue,
                166,
                221,
                190,
                byte.MaxValue,
                29,
                100,
                153,
                byte.MaxValue,
                214,
                116,
                15,
                byte.MaxValue,
                135,
                125,
                142,
                byte.MaxValue,
                229,
                119,
                185,
                byte.MaxValue,
                252,
                239,
                166,
                byte.MaxValue,
                45,
                110,
                185,
                186,
                0,
                0,
                0,
                byte.MaxValue,
                93,
                182,
                229,
                byte.MaxValue,
                194,
                80,
                80,
                byte.MaxValue,
                240,
                200,
                80,
                byte.MaxValue,
                102,
                152,
                104,
                byte.MaxValue,
                102,
                152,
                104,
                byte.MaxValue,
                22,
                55,
                92,
                byte.MaxValue,
                154,
                154,
                154,
                byte.MaxValue,
                194,
                80,
                80,
                byte.MaxValue,
                252,
                115,
                201,
                byte.MaxValue,
                252,
                177,
                49,
                byte.MaxValue,
                0,
                0,
                0,
                byte.MaxValue,
                109,
                247,
                204,
                byte.MaxValue,
                241,
                101,
                34,
                byte.MaxValue,
                214,
                189,
                97,
                byte.MaxValue,
                97,
                40,
                40,
                byte.MaxValue,
                47,
                92,
                115,
                byte.MaxValue,
                93,
                182,
                229,
                byte.MaxValue,
                234,
                153,
                28,
                byte.MaxValue,
                11,
                55,
                123,
                byte.MaxValue,
                146,
                200,
                62,
                byte.MaxValue,
                234,
                153,
                28,
                byte.MaxValue,
                66,
                89,
                148,
                186,
                0,
                0,
                0,
                byte.MaxValue,
                102,
                152,
                104,
                byte.MaxValue,
                164,
                76,
                242,
                byte.MaxValue,
                101,
                180,
                212,
                byte.MaxValue,
                171,
                237,
                171,
                byte.MaxValue,
                byte.MaxValue,
                163,
                87,
                byte.MaxValue,
                240,
                240,
                240,
                byte.MaxValue,
                235,
                239,
                30,
                byte.MaxValue,
                byte.MaxValue,
                149,
                14,
                byte.MaxValue,
                246,
                60,
                161,
                byte.MaxValue,
                210,
                166,
                249,
                byte.MaxValue,
                82,
                38,
                121,
                77,
                0,
                0,
                0,
                byte.MaxValue,
                72,
                103,
                116,
                byte.MaxValue,
                85,
                118,
                85,
                byte.MaxValue,
                127,
                81,
                43,
                byte.MaxValue,
                240,
                200,
                80,
                215,
                0,
                0,
                0,
                127,
                100,
                100,
                100,
                byte.MaxValue,
                45,
                110,
                185,
                191,
                240,
                240,
                240,
                186,
                0,
                0,
                0,
                byte.MaxValue,
                171,
                237,
                171,
                215,
                0,
                0,
                0,
                byte.MaxValue,
                0,
                71,
                133,
                byte.MaxValue,
                0,
                0,
                0,
                byte.MaxValue,
                33,
                118,
                37,
                byte.MaxValue,
                37,
                102,
                40,
                byte.MaxValue,
                234,
                153,
                28,
                byte.MaxValue,
                225,
                140,
                8,
                byte.MaxValue,
                38,
                46,
                51,
                byte.MaxValue,
                48,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                48,
                byte.MaxValue,
                0,
                byte.MaxValue,
                176,
                80,
                0,
                byte.MaxValue,
                194,
                80,
                80,
                byte.MaxValue
            };
        }

        // Token: 0x0200004B RID: 75
        public static class ButtonMonitoring
        {
            // Token: 0x060005BB RID: 1467 RVA: 0x000B51AC File Offset: 0x000B33AC
            public static bool IS_CONTROL_PRESSED(int Client, int Button)
            {
                bool result = false;
                bool flag = ClassicRPC.NCall(NewNatives.IS_CONTROL_PRESSED, new object[]
                {
                    Client,
                    Button
                }) == 1;
                if (flag)
                {
                    result = true;
                }
                return result;
            }

            // Token: 0x060005BC RID: 1468 RVA: 0x000B51F0 File Offset: 0x000B33F0
            public static int isButtonBeingPressed(int ButtonID)
            {
                return ClassicRPC.NCall(NewNatives.IS_DISABLED_CONTROL_PRESSED, new object[]
                {
                    0,
                    ButtonID
                });
            }

            // Token: 0x0200007F RID: 127
            public class Buttons
            {
                // Token: 0x040027AA RID: 10154
                public static int X = 193;

                // Token: 0x040027AB RID: 10155
                public static int O = 195;

                // Token: 0x040027AC RID: 10156
                public static int Square = 194;

                // Token: 0x040027AD RID: 10157
                public static int Triangle = 192;

                // Token: 0x040027AE RID: 10158
                public static int L3 = 200;

                // Token: 0x040027AF RID: 10159
                public static int R3 = 201;

                // Token: 0x040027B0 RID: 10160
                public static int L2 = 198;

                // Token: 0x040027B1 RID: 10161
                public static int R2 = 199;

                // Token: 0x040027B2 RID: 10162
                public static int L1 = 196;

                // Token: 0x040027B3 RID: 10163
                public static int R1 = 197;

                // Token: 0x040027B4 RID: 10164
                public static int DpadDown = 203;

                // Token: 0x040027B5 RID: 10165
                public static int DPadUp = 202;

                // Token: 0x040027B6 RID: 10166
                public static int DpadRight = 205;

                // Token: 0x040027B7 RID: 10167
                public static int DpadLeft = 204;
            }
        }
    }
}

using E3Modz.Black_Ops_2;
using PS3Lib;

namespace E3Modz
{
    class Antifreeze
    {

        public static PS3API PS32 = (BO2.PS3);
        /**********************************************
         *                                            *
         *                                            *
         *              100% AntiFreeze               *
         *                by E3MoDz                   *
         *                                            *                                            
         *///******************************************
        public static PS3API PS3 = (BO2.PS3);

        public static void crisis()
        {
            PS3.Extension.WriteString(0x1c30ab4, "mp_crisis");
        }

        public static void RUS()
        {
            PS3.Extension.WriteString(0x1c30ab4, "mp_russianbase");
        }

        public static void frz1()
        {
            byte[] array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            byte[] array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            byte[] array3 = new byte[2];
            array3[0] = 72;
            PS3.SetMemory(5284768u, array3);
            byte[] array4 = new byte[2];
            array4[0] = 72;
            PS3.SetMemory(5289500u, array4);
            byte[] array5 = new byte[2];
            array5[0] = 72;
            PS3.SetMemory(5292000u, array5);
            byte[] array6 = new byte[2];
            array6[0] = 72;
            PS3.SetMemory(5295240u, array6);
            byte[] array7 = new byte[2];
            array7[0] = 72;
            PS3.SetMemory(5504108u, array7);
            byte[] array8 = new byte[4];
            array8[0] = 96;
            PS3.SetMemory(5290612u, array8);
            byte[] array9 = new byte[4];
            array9[0] = 96;
            PS3.SetMemory(5537236u, array9);
            byte[] array10 = new byte[4];
            array10[0] = 96;
            PS3.SetMemory(5538120u, array10);
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            PS3.SetMemory(2948476u, array11);
            PS3.SetMemory(6797352u, new byte[]
            {
        72
            });
            PS3.SetMemory(6797355u, new byte[]
            {
        72
            });
            PS3.SetMemory(6797362u, new byte[1]);
            PS3.SetMemory(810557548u, new byte[]
            {
        101,
        110,
        100,
        114,
        111,
        117,
        110,
        100,
        0
            });
            PS3.SetMemory(111388u, new byte[]
            {
        127,
        byte.MaxValue,
        24,
        46
            });
            array2[0] = 115;
            array2[1] = 108;
            PS3.SetMemory(9482500u, array2);
            PS3.SetMemory(6797352u, new byte[]
            {
        96
            });
            PS3.SetMemory(6797355u, new byte[1]);
            PS3.SetMemory(6797362u, new byte[]
            {
        127
            });
            PS3.SetMemory(810557548u, new byte[8]);
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(9482500u, new byte[3]);
            PS3.SetMemory(9347824u, new byte[]
            {
        114
            });
            PS3.SetMemory(9347824u, new byte[]
            {
        82
            });
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
        }


        public static void AntiFreeze100()
        {
            PS3API ps = PS3;
            uint offset = 106354214u;
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            ps.SetMemory(offset, array);
            PS3API ps2 = PS3;
            uint offset2 = 4307152u;
            byte[] array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            ps2.SetMemory(offset2, array2);
            PS3API ps3 = PS3;
            uint offset3 = 111388u;
            byte[] array3 = new byte[4];
            array3[0] = 56;
            array3[1] = 96;
            ps3.SetMemory(offset3, array3);
            PS3API ps4 = PS3;
            uint offset4 = 7746652u;
            byte[] array4 = new byte[4];
            array4[0] = 56;
            array4[1] = 96;
            ps4.SetMemory(offset4, array4);
            PS3API ps5 = PS3;
            uint offset5 = 7894432u;
            byte[] array5 = new byte[4];
            array5[0] = 56;
            array5[1] = 96;
            ps5.SetMemory(offset5, array5);
            PS3API ps6 = PS3;
            uint offset6 = 4307128u;
            byte[] array6 = new byte[4];
            array6[0] = 56;
            array6[1] = 96;
            ps6.SetMemory(offset6, array6);
            PS3API ps7 = PS3;
            uint offset7 = 4307164u;
            byte[] array7 = new byte[4];
            array7[0] = 56;
            array7[1] = 96;
            ps7.SetMemory(offset7, array7);
            PS3API ps8 = PS3;
            uint offset8 = 7894432u;
            byte[] array8 = new byte[4];
            array8[0] = 56;
            array8[1] = 96;
            ps8.SetMemory(offset8, array8);
            PS3API ps9 = PS3;
            uint offset9 = 4307152u;
            byte[] array9 = new byte[4];
            array9[0] = 56;
            array9[1] = 96;
            ps9.SetMemory(offset9, array9);
            PS3API ps10 = PS3;
            uint offset10 = 7740788u;
            byte[] array10 = new byte[4];
            array10[0] = 56;
            array10[1] = 96;
            ps10.SetMemory(offset10, array10);
            PS3API ps11 = PS3;
            uint offset11 = 7740768u;
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            ps11.SetMemory(offset11, array11);
            PS3API ps12 = PS3;
            uint offset12 = 7740756u;
            byte[] array12 = new byte[4];
            array12[0] = 56;
            array12[1] = 96;
            ps12.SetMemory(offset12, array12);
            PS3API ps13 = PS3;
            uint offset13 = 7607508u;
            byte[] array13 = new byte[4];
            array13[0] = 56;
            array13[1] = 96;
            ps13.SetMemory(offset13, array13);
            PS3API ps14 = PS3;
            uint offset14 = 7743252u;
            byte[] array14 = new byte[4];
            array14[0] = 56;
            array14[1] = 96;
            ps14.SetMemory(offset14, array14);
            PS3API ps15 = PS3;
            uint offset15 = 7743220u;
            byte[] array15 = new byte[4];
            array15[0] = 56;
            array15[1] = 96;
            ps15.SetMemory(offset15, array15);
            PS3API ps16 = PS3;
            uint offset16 = 762714u;
            byte[] array16 = new byte[4];
            array16[0] = 56;
            array16[1] = 96;
            ps16.SetMemory(offset16, array16);
            PS3API ps17 = PS3;
            uint offset17 = 7743232u;
            byte[] array17 = new byte[4];
            array17[0] = 56;
            array17[1] = 96;
            ps17.SetMemory(offset17, array17);
            PS3API ps18 = PS3;
            uint offset18 = 7743176u;
            byte[] array18 = new byte[4];
            array18[0] = 56;
            array18[1] = 96;
            ps18.SetMemory(offset18, array18);
            PS3API ps19 = PS3;
            uint offset19 = 3397704u;
            byte[] array19 = new byte[4];
            array19[0] = 56;
            array19[1] = 96;
            ps19.SetMemory(offset19, array19);
            PS3API ps20 = PS3;
            uint offset20 = 4301148u;
            byte[] array20 = new byte[4];
            array20[0] = 56;
            array20[1] = 96;
            ps20.SetMemory(offset20, array20);
            PS3API ps21 = PS3;
            uint offset21 = 4301156u;
            byte[] array21 = new byte[4];
            array21[0] = 56;
            array21[1] = 96;
            ps21.SetMemory(offset21, array21);
            PS3API ps22 = PS3;
            uint offset22 = 4301252u;
            byte[] array22 = new byte[4];
            array22[0] = 56;
            array22[1] = 96;
            ps22.SetMemory(offset22, array22);
            PS3API ps23 = PS3;
            uint offset23 = 4301272u;
            byte[] array23 = new byte[4];
            array23[0] = 56;
            array23[1] = 96;
            ps23.SetMemory(offset23, array23);
            PS3API ps24 = PS3;
            uint offset24 = 4301288u;
            byte[] array24 = new byte[4];
            array24[0] = 56;
            array24[1] = 96;
            ps24.SetMemory(offset24, array24);
            PS3API ps25 = PS3;
            uint offset25 = 4301312u;
            byte[] array25 = new byte[4];
            array25[0] = 56;
            array25[1] = 96;
            ps25.SetMemory(offset25, array25);
            PS3API ps26 = PS3;
            uint offset26 = 4301332u;
            byte[] array26 = new byte[4];
            array26[0] = 56;
            array26[1] = 96;
            ps26.SetMemory(offset26, array26);
            PS3API ps27 = PS3;
            uint offset27 = 4301356u;
            byte[] array27 = new byte[4];
            array27[0] = 56;
            array27[1] = 96;
            ps27.SetMemory(offset27, array27);
            PS3API ps28 = PS3;
            uint offset28 = 4301380u;
            byte[] array28 = new byte[4];
            array28[0] = 56;
            array28[1] = 96;
            ps28.SetMemory(offset28, array28);
            PS3API ps29 = PS3;
            uint offset29 = 4301432u;
            byte[] array29 = new byte[4];
            array29[0] = 56;
            array29[1] = 96;
            ps29.SetMemory(offset29, array29);
            PS3API ps30 = PS3;
            uint offset30 = 4301436u;
            byte[] array30 = new byte[4];
            array30[0] = 56;
            array30[1] = 96;
            ps30.SetMemory(offset30, array30);
            PS3API ps31 = PS3;
            uint offset31 = 4301828u;
            byte[] array31 = new byte[4];
            array31[0] = 56;
            array31[1] = 96;
            ps31.SetMemory(offset31, array31);
            PS3API ps32 = PS3;
            uint offset32 = 4301960u;
            byte[] array32 = new byte[4];
            array32[0] = 56;
            array32[1] = 96;
            ps32.SetMemory(offset32, array32);
            PS3.SetMemory(7740752u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3.SetMemory(3341524u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3.SetMemory(7743212u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3API ps33 = PS3;
            uint offset33 = 4599916u;
            byte[] array33 = new byte[4];
            array33[0] = 96;
            ps33.SetMemory(offset33, array33);
            PS3API ps34 = PS3;
            uint offset34 = 762700u;
            byte[] array34 = new byte[4];
            array34[0] = 96;
            ps34.SetMemory(offset34, array34);
            PS3.SetMemory(2948476u, new byte[]
            {
        96
            });
            PS3API ps35 = PS3;
            uint offset35 = 6797208u;
            byte[] array35 = new byte[3];
            array35[0] = 96;
            ps35.SetMemory(offset35, array35);
            PS3.SetMemory(6797232u, new byte[]
            {
        60,
        96,
        81,
        0
            });
            PS3API ps36 = PS3;
            uint offset36 = 6976232u;
            byte[] array36 = new byte[4];
            array36[0] = 56;
            array36[1] = 96;
            ps36.SetMemory(offset36, array36);
            PS3API ps37 = PS3;
            uint offset37 = 6976224u;
            byte[] array37 = new byte[4];
            array37[0] = 56;
            array37[1] = 96;
            ps37.SetMemory(offset37, array37);
            PS3API ps38 = PS3;
            uint offset38 = 111388u;
            byte[] array38 = new byte[4];
            array38[0] = 56;
            array38[1] = 96;
            ps38.SetMemory(offset38, array38);
            PS3.SetMemory(24666981u, new byte[]
            {
        3,
        69,
        152
            });
            PS3.SetMemory(24667041u, new byte[]
            {
        3,
        69,
        122
            });
            PS3.SetMemory(24667585u, new byte[]
            {
        3,
        81,
        206
            });
            PS3API ps39 = PS3;
            uint offset39 = 779924u;
            byte[] array39 = new byte[4];
            array39[0] = 60;
            array39[1] = 96;
            ps39.SetMemory(offset39, array39);
            PS3API ps40 = PS3;
            uint offset40 = 779932u;
            byte[] array40 = new byte[4];
            array40[0] = 60;
            array40[1] = 96;
            ps40.SetMemory(offset40, array40);
            PS3API ps41 = PS3;
            uint offset41 = 779908u;
            byte[] array41 = new byte[4];
            array41[0] = 60;
            array41[1] = 128;
            ps41.SetMemory(offset41, array41);
            PS3API ps42 = PS3;
            uint offset42 = 779936u;
            byte[] array42 = new byte[4];
            array42[0] = 60;
            array42[1] = 128;
            ps42.SetMemory(offset42, array42);
            PS3API ps43 = PS3;
            uint offset43 = 779944u;
            byte[] array43 = new byte[4];
            array43[0] = 60;
            array43[1] = 128;
            ps43.SetMemory(offset43, array43);
            PS3API ps44 = PS3;
            uint offset44 = 8682960u;
            byte[] array44 = new byte[4];
            array44[0] = 60;
            array44[1] = 128;
            ps44.SetMemory(offset44, array44);
            PS3API ps45 = PS3;
            uint offset45 = 779896u;
            byte[] array45 = new byte[4];
            array45[0] = 60;
            array45[1] = 128;
            ps45.SetMemory(offset45, array45);
            PS3API ps46 = PS3;
            uint offset46 = 779860u;
            byte[] array46 = new byte[4];
            array46[0] = 60;
            array46[1] = 128;
            ps46.SetMemory(offset46, array46);
            PS3API ps47 = PS3;
            uint offset47 = 7710772u;
            byte[] array47 = new byte[4];
            array47[0] = 96;
            ps47.SetMemory(offset47, array47);
            PS3API ps48 = PS3;
            uint offset48 = 7710800u;
            byte[] array48 = new byte[4];
            array48[0] = 96;
            ps48.SetMemory(offset48, array48);
            PS3API ps49 = PS3;
            uint offset49 = 6320096u;
            byte[] array49 = new byte[4];
            array49[0] = 60;
            array49[1] = 96;
            ps49.SetMemory(offset49, array49);
            PS3API ps50 = PS3;
            uint offset50 = 1115872u;
            byte[] array50 = new byte[4];
            array50[0] = 56;
            array50[1] = 96;
            ps50.SetMemory(offset50, array50);
            PS3API ps51 = PS3;
            uint offset51 = 1116644u;
            byte[] array51 = new byte[4];
            array51[0] = 56;
            array51[1] = 96;
            ps51.SetMemory(offset51, array51);
            PS3API ps52 = PS3;
            uint offset52 = 1116592u;
            byte[] array52 = new byte[4];
            array52[0] = 56;
            array52[1] = 96;
            ps52.SetMemory(offset52, array52);
            PS3API ps53 = PS3;
            uint offset53 = 1115804u;
            byte[] array53 = new byte[4];
            array53[0] = 56;
            array53[1] = 96;
            ps53.SetMemory(offset53, array53);
            PS3API ps54 = PS3;
            uint offset54 = 1115908u;
            byte[] array54 = new byte[4];
            array54[0] = 56;
            array54[1] = 96;
            ps54.SetMemory(offset54, array54);
            PS3API ps55 = PS3;
            uint offset55 = 1115728u;
            byte[] array55 = new byte[4];
            array55[0] = 56;
            array55[1] = 96;
            ps55.SetMemory(offset55, array55);
            PS3API ps56 = PS3;
            uint offset56 = 1115728u;
            byte[] array56 = new byte[4];
            array56[0] = 56;
            array56[1] = 96;
            ps56.SetMemory(offset56, array56);
            PS3.SetMemory(6976224u, new byte[]
            {
        61,
        96,
        2,
        16
            });
            PS3API ps57 = PS3;
            uint offset57 = 6982636u;
            byte[] array57 = new byte[4];
            array57[0] = 56;
            array57[1] = 96;
            ps57.SetMemory(offset57, array57);
            PS3API ps58 = PS3;
            uint offset58 = 6975448u;
            byte[] array58 = new byte[4];
            array58[0] = 56;
            array58[1] = 96;
            ps58.SetMemory(offset58, array58);
            PS3API ps59 = PS3;
            uint offset59 = 6975392u;
            byte[] array59 = new byte[4];
            array59[0] = 56;
            array59[1] = 96;
            ps59.SetMemory(offset59, array59);
            PS3API ps60 = PS3;
            uint offset60 = 6974288u;
            byte[] array60 = new byte[4];
            array60[0] = 56;
            array60[1] = 96;
            ps60.SetMemory(offset60, array60);
            PS3API ps61 = PS3;
            uint offset61 = 6336020u;
            byte[] array61 = new byte[4];
            array61[0] = 56;
            array61[1] = 96;
            ps61.SetMemory(offset61, array61);
            PS3API ps62 = PS3;
            uint offset62 = 6308824u;
            byte[] array62 = new byte[4];
            array62[0] = 56;
            array62[1] = 96;
            ps62.SetMemory(offset62, array62);
            PS3API ps63 = PS3;
            uint offset63 = 6308792u;
            byte[] array63 = new byte[4];
            array63[0] = 56;
            array63[1] = 96;
            ps63.SetMemory(offset63, array63);
            PS3API ps64 = PS3;
            uint offset64 = 6335796u;
            byte[] array64 = new byte[4];
            array64[0] = 56;
            array64[1] = 96;
            ps64.SetMemory(offset64, array64);
            PS3API ps65 = PS3;
            uint offset65 = 6335660u;
            byte[] array65 = new byte[4];
            array65[0] = 56;
            array65[1] = 96;
            ps65.SetMemory(offset65, array65);
            PS3API ps66 = PS3;
            uint offset66 = 6335432u;
            byte[] array66 = new byte[4];
            array66[0] = 56;
            array66[1] = 96;
            ps66.SetMemory(offset66, array66);
            PS3API ps67 = PS3;
            uint offset67 = 6334896u;
            byte[] array67 = new byte[4];
            array67[0] = 56;
            array67[1] = 96;
            ps67.SetMemory(offset67, array67);
            PS3API ps68 = PS3;
            uint offset68 = 6308720u;
            byte[] array68 = new byte[4];
            array68[0] = 56;
            array68[1] = 96;
            ps68.SetMemory(offset68, array68);
            PS3API ps69 = PS3;
            uint offset69 = 6339284u;
            byte[] array69 = new byte[4];
            array69[0] = 56;
            array69[1] = 96;
            ps69.SetMemory(offset69, array69);
            PS3API ps70 = PS3;
            uint offset70 = 6339448u;
            byte[] array70 = new byte[4];
            array70[0] = 56;
            array70[1] = 96;
            ps70.SetMemory(offset70, array70);
            PS3API ps71 = PS3;
            uint offset71 = 6339508u;
            byte[] array71 = new byte[4];
            array71[0] = 56;
            array71[1] = 96;
            ps71.SetMemory(offset71, array71);
            PS3API ps72 = PS3;
            uint offset72 = 1056332u;
            byte[] array72 = new byte[4];
            array72[0] = 56;
            array72[1] = 96;
            ps72.SetMemory(offset72, array72);
            PS3API ps73 = PS3;
            uint offset73 = 6304604u;
            byte[] array73 = new byte[4];
            array73[0] = 56;
            array73[1] = 96;
            ps73.SetMemory(offset73, array73);
            PS3API ps74 = PS3;
            uint offset74 = 6304540u;
            byte[] array74 = new byte[4];
            array74[0] = 56;
            array74[1] = 96;
            ps74.SetMemory(offset74, array74);
            PS3API ps75 = PS3;
            uint offset75 = 6304288u;
            byte[] array75 = new byte[4];
            array75[0] = 56;
            array75[1] = 96;
            ps75.SetMemory(offset75, array75);
            PS3API ps76 = PS3;
            uint offset76 = 6304304u;
            byte[] array76 = new byte[4];
            array76[0] = 56;
            array76[1] = 96;
            ps76.SetMemory(offset76, array76);
            PS3API ps77 = PS3;
            uint offset77 = 6304280u;
            byte[] array77 = new byte[4];
            array77[0] = 56;
            array77[1] = 96;
            ps77.SetMemory(offset77, array77);
            PS3API ps78 = PS3;
            uint offset78 = 6304296u;
            byte[] array78 = new byte[4];
            array78[0] = 56;
            array78[1] = 96;
            ps78.SetMemory(offset78, array78);
            PS3API ps79 = PS3;
            uint offset79 = 466636u;
            byte[] array79 = new byte[4];
            array79[0] = 56;
            array79[1] = 96;
            ps79.SetMemory(offset79, array79);
            PS3API ps80 = PS3;
            uint offset80 = 466672u;
            byte[] array80 = new byte[4];
            array80[0] = 56;
            array80[1] = 96;
            ps80.SetMemory(offset80, array80);
            PS3API ps81 = PS3;
            uint offset81 = 466680u;
            byte[] array81 = new byte[4];
            array81[0] = 56;
            array81[1] = 96;
            ps81.SetMemory(offset81, array81);
            PS3API ps82 = PS3;
            uint offset82 = 6304252u;
            byte[] array82 = new byte[4];
            array82[0] = 56;
            array82[1] = 96;
            ps82.SetMemory(offset82, array82);
            PS3API ps83 = PS3;
            uint offset83 = 6304244u;
            byte[] array83 = new byte[4];
            array83[0] = 56;
            array83[1] = 96;
            ps83.SetMemory(offset83, array83);
            PS3API ps84 = PS3;
            uint offset84 = 980540u;
            byte[] array84 = new byte[4];
            array84[0] = 56;
            array84[1] = 96;
            ps84.SetMemory(offset84, array84);
            PS3API ps85 = PS3;
            uint offset85 = 980532u;
            byte[] array85 = new byte[4];
            array85[0] = 56;
            array85[1] = 96;
            ps85.SetMemory(offset85, array85);
            PS3API ps86 = PS3;
            uint offset86 = 6226228u;
            byte[] array86 = new byte[4];
            array86[0] = 56;
            array86[1] = 96;
            ps86.SetMemory(offset86, array86);
            PS3API ps87 = PS3;
            uint offset87 = 6226208u;
            byte[] array87 = new byte[4];
            array87[0] = 56;
            array87[1] = 96;
            ps87.SetMemory(offset87, array87);
            PS3API ps88 = PS3;
            uint offset88 = 6226200u;
            byte[] array88 = new byte[4];
            array88[0] = 56;
            array88[1] = 96;
            ps88.SetMemory(offset88, array88);
            PS3API ps89 = PS3;
            uint offset89 = 6226192u;
            byte[] array89 = new byte[4];
            array89[0] = 56;
            array89[1] = 96;
            ps89.SetMemory(offset89, array89);
            PS3API ps90 = PS3;
            uint offset90 = 6309488u;
            byte[] array90 = new byte[4];
            array90[0] = 56;
            array90[1] = 96;
            ps90.SetMemory(offset90, array90);
            PS3API ps91 = PS3;
            uint offset91 = 6309512u;
            byte[] array91 = new byte[4];
            array91[0] = 56;
            array91[1] = 96;
            ps91.SetMemory(offset91, array91);
            PS3API ps92 = PS3;
            uint offset92 = 6309504u;
            byte[] array92 = new byte[4];
            array92[0] = 56;
            array92[1] = 96;
            ps92.SetMemory(offset92, array92);
            PS3API ps93 = PS3;
            uint offset93 = 942296u;
            byte[] array93 = new byte[4];
            array93[0] = 56;
            array93[1] = 96;
            ps93.SetMemory(offset93, array93);
            PS3API ps94 = PS3;
            uint offset94 = 942304u;
            byte[] array94 = new byte[4];
            array94[0] = 56;
            array94[1] = 96;
            ps94.SetMemory(offset94, array94);
            PS3API ps95 = PS3;
            uint offset95 = 2777828u;
            byte[] array95 = new byte[4];
            array95[0] = 56;
            array95[1] = 96;
            ps95.SetMemory(offset95, array95);
            PS3API ps96 = PS3;
            uint offset96 = 6236596u;
            byte[] array96 = new byte[4];
            array96[0] = 56;
            array96[1] = 96;
            ps96.SetMemory(offset96, array96);
            PS3API ps97 = PS3;
            uint offset97 = 6236612u;
            byte[] array97 = new byte[4];
            array97[0] = 56;
            array97[1] = 96;
            ps97.SetMemory(offset97, array97);
            PS3API ps98 = PS3;
            uint offset98 = 6236616u;
            byte[] array98 = new byte[4];
            array98[0] = 56;
            array98[1] = 96;
            ps98.SetMemory(offset98, array98);
            PS3API ps99 = PS3;
            uint offset99 = 6236696u;
            byte[] array99 = new byte[4];
            array99[0] = 56;
            array99[1] = 96;
            ps99.SetMemory(offset99, array99);
            PS3API ps100 = PS3;
            uint offset100 = 6236748u;
            byte[] array100 = new byte[4];
            array100[0] = 56;
            array100[1] = 96;
            ps100.SetMemory(offset100, array100);
            PS3API ps101 = PS3;
            uint offset101 = 6974728u;
            byte[] array101 = new byte[4];
            array101[0] = 56;
            array101[1] = 96;
            ps101.SetMemory(offset101, array101);
            PS3API ps102 = PS3;
            uint offset102 = 6973988u;
            byte[] array102 = new byte[4];
            array102[0] = 56;
            array102[1] = 96;
            ps102.SetMemory(offset102, array102);
            PS3API ps103 = PS3;
            uint offset103 = 6304656u;
            byte[] array103 = new byte[4];
            array103[0] = 56;
            array103[1] = 96;
            ps103.SetMemory(offset103, array103);
            PS3API ps104 = PS3;
            uint offset104 = 6304244u;
            byte[] array104 = new byte[4];
            array104[0] = 56;
            array104[1] = 96;
            ps104.SetMemory(offset104, array104);
            PS3API ps105 = PS3;
            uint offset105 = 6303944u;
            byte[] array105 = new byte[4];
            array105[0] = 56;
            array105[1] = 96;
            ps105.SetMemory(offset105, array105);
            PS3API ps106 = PS3;
            uint offset106 = 6303612u;
            byte[] array106 = new byte[4];
            array106[0] = 56;
            array106[1] = 96;
            ps106.SetMemory(offset106, array106);
            PS3API ps107 = PS3;
            uint offset107 = 6303468u;
            byte[] array107 = new byte[4];
            array107[0] = 56;
            array107[1] = 96;
            ps107.SetMemory(offset107, array107);
            PS3API ps108 = PS3;
            uint offset108 = 6300128u;
            byte[] array108 = new byte[4];
            array108[0] = 56;
            array108[1] = 96;
            ps108.SetMemory(offset108, array108);
            PS3API ps109 = PS3;
            uint offset109 = 6308852u;
            byte[] array109 = new byte[4];
            array109[0] = 56;
            array109[1] = 96;
            ps109.SetMemory(offset109, array109);
            PS3API ps110 = PS3;
            uint offset110 = 6334556u;
            byte[] array110 = new byte[4];
            array110[0] = 56;
            array110[1] = 96;
            ps110.SetMemory(offset110, array110);
            PS3API ps111 = PS3;
            uint offset111 = 6334316u;
            byte[] array111 = new byte[4];
            array111[0] = 56;
            array111[1] = 96;
            ps111.SetMemory(offset111, array111);
            PS3API ps112 = PS3;
            uint offset112 = 6334136u;
            byte[] array112 = new byte[4];
            array112[0] = 56;
            array112[1] = 96;
            ps112.SetMemory(offset112, array112);
            PS3API ps113 = PS3;
            uint offset113 = 6333892u;
            byte[] array113 = new byte[4];
            array113[0] = 56;
            array113[1] = 96;
            ps113.SetMemory(offset113, array113);
            PS3API ps114 = PS3;
            uint offset114 = 6311380u;
            byte[] array114 = new byte[4];
            array114[0] = 56;
            array114[1] = 96;
            ps114.SetMemory(offset114, array114);
            PS3.SetMemory(6311372u, new byte[]
            {
        72,
        0,
        0,
        8
            });
            PS3API ps115 = PS3;
            uint offset115 = 6311040u;
            byte[] array115 = new byte[4];
            array115[0] = 56;
            array115[1] = 96;
            ps115.SetMemory(offset115, array115);
            PS3.SetMemory(6311032u, new byte[]
            {
        61,
        96,
        2,
        16
            });
            PS3.SetMemory(6305488u, new byte[]
            {
        61,
        96,
        0,
        8
            });
            PS3.SetMemory(6305496u, new byte[]
            {
        61,
        96,
        0,
        44
            });
            byte[] array116 = new byte[4];
            array116[0] = 96;
            PS3.SetMemory(4173260u, array116);
            array116 = new byte[4];
            array116[0] = 96;
            PS3.SetMemory(4173260u, array116);
            array116 = new byte[4];
            array116[0] = 96;
            PS3.SetMemory(4173260u, array116);
            array116 = new byte[4];
            array116[0] = 96;
            PS3.SetMemory(4173260u, array116);
            array116 = new byte[4];
            array116[0] = 96;
            PS3.SetMemory(4173260u, array116);
        }


        public static void AntiFreezeIngame()
        {
            byte[] array = new byte[4];
            byte[] array2 = new byte[]
            {
        96,
        0,
        0,
        249
            };
            PS3.SetMemory(111388u, array2);
            PS3.SetMemory(6797348u, array2);
            PS3.SetMemory(6797348u, array2);
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(6976224u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(6258260u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5273536u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5284768u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5289500u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5292000u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5295240u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5504108u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5290612u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5537236u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5538120u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(2948476u, array);
            array2[0] = 96;
            PS3.SetMemory(6797348u, array2);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array[0] = 96;
            PS3.SetMemory(2948476u, array);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
            PS3.SetMemory(111388u, array2);
            PS3.SetMemory(6797348u, array2);
            PS3.SetMemory(6797348u, array2);
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(6976224u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(6258260u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5273536u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5284768u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5289500u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5292000u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5295240u, array);
            array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(5504108u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5290612u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5537236u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(5538120u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(2948476u, array);
            array2[0] = 96;
            PS3.SetMemory(6797348u, array2);
            PS3.SetMemory(111388u, new byte[]
            {
        53,
        23,
        53,
        30
            });
            array[0] = 96;
            PS3.SetMemory(2948476u, array);
            PS3.SetMemory(6797348u, new byte[]
            {
        144,
        154,
        0,
        0,
        94,
        94,
        94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
        94,
        94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
        65,
        130,
        8,
        240
            });
        }


        public static void AntiFeezeButton()
        {
            byte[] array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            byte[] array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            byte[] array3 = new byte[2];
            array3[0] = 72;
            PS3.SetMemory(5284768u, array3);
            byte[] array4 = new byte[2];
            array4[0] = 72;
            PS3.SetMemory(5289500u, array4);
            byte[] array5 = new byte[2];
            array5[0] = 72;
            PS3.SetMemory(5292000u, array5);
            byte[] array6 = new byte[2];
            array6[0] = 72;
            PS3.SetMemory(5295240u, array6);
            byte[] array7 = new byte[2];
            array7[0] = 72;
            PS3.SetMemory(5504108u, array7);
            byte[] array8 = new byte[4];
            array8[0] = 96;
            PS3.SetMemory(5290612u, array8);
            byte[] array9 = new byte[4];
            array9[0] = 96;
            PS3.SetMemory(5537236u, array9);
            byte[] array10 = new byte[4];
            array10[0] = 96;
            PS3.SetMemory(5538120u, array10);
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            PS3.SetMemory(2948476u, array11);
        }


        public static void deluxeanti()
        {
            PS3API ps = PS3;
            uint offset = 106354214u;
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            ps.SetMemory(offset, array);
            PS3API ps2 = PS3;
            uint offset2 = 4307152u;
            byte[] array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            ps2.SetMemory(offset2, array2);
            PS3API ps3 = PS3;
            uint offset3 = 111388u;
            byte[] array3 = new byte[4];
            array3[0] = 56;
            array3[1] = 96;
            ps3.SetMemory(offset3, array3);
            PS3API ps4 = PS3;
            uint offset4 = 7746652u;
            byte[] array4 = new byte[4];
            array4[0] = 56;
            array4[1] = 96;
            ps4.SetMemory(offset4, array4);
            PS3API ps5 = PS3;
            uint offset5 = 7894432u;
            byte[] array5 = new byte[4];
            array5[0] = 56;
            array5[1] = 96;
            ps5.SetMemory(offset5, array5);
            PS3API ps6 = PS3;
            uint offset6 = 4307128u;
            byte[] array6 = new byte[4];
            array6[0] = 56;
            array6[1] = 96;
            ps6.SetMemory(offset6, array6);
            PS3API ps7 = PS3;
            uint offset7 = 4307164u;
            byte[] array7 = new byte[4];
            array7[0] = 56;
            array7[1] = 96;
            ps7.SetMemory(offset7, array7);
            PS3API ps8 = PS3;
            uint offset8 = 7894432u;
            byte[] array8 = new byte[4];
            array8[0] = 56;
            array8[1] = 96;
            ps8.SetMemory(offset8, array8);
            PS3API ps9 = PS3;
            uint offset9 = 4307152u;
            byte[] array9 = new byte[4];
            array9[0] = 56;
            array9[1] = 96;
            ps9.SetMemory(offset9, array9);
            PS3API ps10 = PS3;
            uint offset10 = 7740788u;
            byte[] array10 = new byte[4];
            array10[0] = 56;
            array10[1] = 96;
            ps10.SetMemory(offset10, array10);
            PS3API ps11 = PS3;
            uint offset11 = 7740768u;
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            ps11.SetMemory(offset11, array11);
            PS3API ps12 = PS3;
            uint offset12 = 7740756u;
            byte[] array12 = new byte[4];
            array12[0] = 56;
            array12[1] = 96;
            ps12.SetMemory(offset12, array12);
            PS3API ps13 = PS3;
            uint offset13 = 7607508u;
            byte[] array13 = new byte[4];
            array13[0] = 56;
            array13[1] = 96;
            ps13.SetMemory(offset13, array13);
            PS3API ps14 = PS3;
            uint offset14 = 7743252u;
            byte[] array14 = new byte[4];
            array14[0] = 56;
            array14[1] = 96;
            ps14.SetMemory(offset14, array14);
            PS3API ps15 = PS3;
            uint offset15 = 7743220u;
            byte[] array15 = new byte[4];
            array15[0] = 56;
            array15[1] = 96;
            ps15.SetMemory(offset15, array15);
            PS3API ps16 = PS3;
            uint offset16 = 762714u;
            byte[] array16 = new byte[4];
            array16[0] = 56;
            array16[1] = 96;
            ps16.SetMemory(offset16, array16);
            PS3API ps17 = PS3;
            uint offset17 = 7743232u;
            byte[] array17 = new byte[4];
            array17[0] = 56;
            array17[1] = 96;
            ps17.SetMemory(offset17, array17);
            PS3API ps18 = PS3;
            uint offset18 = 7743176u;
            byte[] array18 = new byte[4];
            array18[0] = 56;
            array18[1] = 96;
            ps18.SetMemory(offset18, array18);
            PS3API ps19 = PS3;
            uint offset19 = 3397704u;
            byte[] array19 = new byte[4];
            array19[0] = 56;
            array19[1] = 96;
            ps19.SetMemory(offset19, array19);
            PS3API ps20 = PS3;
            uint offset20 = 4301148u;
            byte[] array20 = new byte[4];
            array20[0] = 56;
            array20[1] = 96;
            ps20.SetMemory(offset20, array20);
            PS3API ps21 = PS3;
            uint offset21 = 4301156u;
            byte[] array21 = new byte[4];
            array21[0] = 56;
            array21[1] = 96;
            ps21.SetMemory(offset21, array21);
            PS3API ps22 = PS3;
            uint offset22 = 4301252u;
            byte[] array22 = new byte[4];
            array22[0] = 56;
            array22[1] = 96;
            ps22.SetMemory(offset22, array22);
            PS3API ps23 = PS3;
            uint offset23 = 4301272u;
            byte[] array23 = new byte[4];
            array23[0] = 56;
            array23[1] = 96;
            ps23.SetMemory(offset23, array23);
            PS3API ps24 = PS3;
            uint offset24 = 4301288u;
            byte[] array24 = new byte[4];
            array24[0] = 56;
            array24[1] = 96;
            ps24.SetMemory(offset24, array24);
            PS3API ps25 = PS3;
            uint offset25 = 4301312u;
            byte[] array25 = new byte[4];
            array25[0] = 56;
            array25[1] = 96;
            ps25.SetMemory(offset25, array25);
            PS3API ps26 = PS3;
            uint offset26 = 4301332u;
            byte[] array26 = new byte[4];
            array26[0] = 56;
            array26[1] = 96;
            ps26.SetMemory(offset26, array26);
            PS3API ps27 = PS3;
            uint offset27 = 4301356u;
            byte[] array27 = new byte[4];
            array27[0] = 56;
            array27[1] = 96;
            ps27.SetMemory(offset27, array27);
            PS3API ps28 = PS3;
            uint offset28 = 4301380u;
            byte[] array28 = new byte[4];
            array28[0] = 56;
            array28[1] = 96;
            ps28.SetMemory(offset28, array28);
            PS3API ps29 = PS3;
            uint offset29 = 4301432u;
            byte[] array29 = new byte[4];
            array29[0] = 56;
            array29[1] = 96;
            ps29.SetMemory(offset29, array29);
            PS3API ps30 = PS3;
            uint offset30 = 4301436u;
            byte[] array30 = new byte[4];
            array30[0] = 56;
            array30[1] = 96;
            ps30.SetMemory(offset30, array30);
            PS3API ps31 = PS3;
            uint offset31 = 4301828u;
            byte[] array31 = new byte[4];
            array31[0] = 56;
            array31[1] = 96;
            ps31.SetMemory(offset31, array31);
            PS3API ps32 = PS3;
            uint offset32 = 4301960u;
            byte[] array32 = new byte[4];
            array32[0] = 56;
            array32[1] = 96;
            ps32.SetMemory(offset32, array32);
            PS3.SetMemory(7740752u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3.SetMemory(3341524u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3.SetMemory(7743212u, new byte[]
            {
        47,
        131,
        72,
        0
            });
            PS3API ps33 = PS3;
            uint offset33 = 4599916u;
            byte[] array33 = new byte[4];
            array33[0] = 96;
            ps33.SetMemory(offset33, array33);
            PS3API ps34 = PS3;
            uint offset34 = 762700u;
            byte[] array34 = new byte[4];
            array34[0] = 96;
            ps34.SetMemory(offset34, array34);
            PS3.SetMemory(2948476u, new byte[]
            {
        96
            });
            PS3API ps35 = PS3;
            uint offset35 = 6797208u;
            byte[] array35 = new byte[3];
            array35[0] = 96;
            ps35.SetMemory(offset35, array35);
            PS3.SetMemory(6797232u, new byte[]
            {
        60,
        96,
        81,
        0
            });
            PS3API ps36 = PS3;
            uint offset36 = 6976232u;
            byte[] array36 = new byte[4];
            array36[0] = 56;
            array36[1] = 96;
            ps36.SetMemory(offset36, array36);
            PS3API ps37 = PS3;
            uint offset37 = 6976224u;
            byte[] array37 = new byte[4];
            array37[0] = 56;
            array37[1] = 96;
            ps37.SetMemory(offset37, array37);
            PS3API ps38 = PS3;
            uint offset38 = 111388u;
            byte[] array38 = new byte[4];
            array38[0] = 56;
            array38[1] = 96;
            ps38.SetMemory(offset38, array38);
            PS3.SetMemory(24666981u, new byte[]
            {
        3,
        69,
        152
            });
            PS3.SetMemory(24667041u, new byte[]
            {
        3,
        69,
        122
            });
            PS3.SetMemory(24667585u, new byte[]
            {
        3,
        81,
        206
            });
            PS3API ps39 = PS3;
            uint offset39 = 779924u;
            byte[] array39 = new byte[4];
            array39[0] = 60;
            array39[1] = 96;
            ps39.SetMemory(offset39, array39);
            PS3API ps40 = PS3;
            uint offset40 = 779932u;
            byte[] array40 = new byte[4];
            array40[0] = 60;
            array40[1] = 96;
            ps40.SetMemory(offset40, array40);
            PS3API ps41 = PS3;
            uint offset41 = 779908u;
            byte[] array41 = new byte[4];
            array41[0] = 60;
            array41[1] = 128;
            ps41.SetMemory(offset41, array41);
            PS3API ps42 = PS3;
            uint offset42 = 779936u;
            byte[] array42 = new byte[4];
            array42[0] = 60;
            array42[1] = 128;
            ps42.SetMemory(offset42, array42);
            PS3API ps43 = PS3;
            uint offset43 = 779944u;
            byte[] array43 = new byte[4];
            array43[0] = 60;
            array43[1] = 128;
            ps43.SetMemory(offset43, array43);
            PS3API ps44 = PS3;
            uint offset44 = 8682960u;
            byte[] array44 = new byte[4];
            array44[0] = 60;
            array44[1] = 128;
            ps44.SetMemory(offset44, array44);
            PS3API ps45 = PS3;
            uint offset45 = 779896u;
            byte[] array45 = new byte[4];
            array45[0] = 60;
            array45[1] = 128;
            ps45.SetMemory(offset45, array45);
            PS3API ps46 = PS3;
            uint offset46 = 779860u;
            byte[] array46 = new byte[4];
            array46[0] = 60;
            array46[1] = 128;
            ps46.SetMemory(offset46, array46);
            PS3API ps47 = PS3;
            uint offset47 = 7710772u;
            byte[] array47 = new byte[4];
            array47[0] = 96;
            ps47.SetMemory(offset47, array47);
            PS3API ps48 = PS3;
            uint offset48 = 7710800u;
            byte[] array48 = new byte[4];
            array48[0] = 96;
            ps48.SetMemory(offset48, array48);
            PS3API ps49 = PS3;
            uint offset49 = 6320096u;
            byte[] array49 = new byte[4];
            array49[0] = 60;
            array49[1] = 96;
            ps49.SetMemory(offset49, array49);
            PS3API ps50 = PS3;
            uint offset50 = 1115872u;
            byte[] array50 = new byte[4];
            array50[0] = 56;
            array50[1] = 96;
            ps50.SetMemory(offset50, array50);
            PS3API ps51 = PS3;
            uint offset51 = 1116644u;
            byte[] array51 = new byte[4];
            array51[0] = 56;
            array51[1] = 96;
            ps51.SetMemory(offset51, array51);
            PS3API ps52 = PS3;
            uint offset52 = 1116592u;
            byte[] array52 = new byte[4];
            array52[0] = 56;
            array52[1] = 96;
            ps52.SetMemory(offset52, array52);
            PS3API ps53 = PS3;
            uint offset53 = 1115804u;
            byte[] array53 = new byte[4];
            array53[0] = 56;
            array53[1] = 96;
            ps53.SetMemory(offset53, array53);
            PS3API ps54 = PS3;
            uint offset54 = 1115908u;
            byte[] array54 = new byte[4];
            array54[0] = 56;
            array54[1] = 96;
            ps54.SetMemory(offset54, array54);
            PS3API ps55 = PS3;
            uint offset55 = 1115728u;
            byte[] array55 = new byte[4];
            array55[0] = 56;
            array55[1] = 96;
            ps55.SetMemory(offset55, array55);
            PS3API ps56 = PS3;
            uint offset56 = 1115728u;
            byte[] array56 = new byte[4];
            array56[0] = 56;
            array56[1] = 96;
            ps56.SetMemory(offset56, array56);
            PS3.SetMemory(6976224u, new byte[]
            {
        61,
        96,
        2,
        16
            });
            PS3API ps57 = PS3;
            uint offset57 = 6982636u;
            byte[] array57 = new byte[4];
            array57[0] = 56;
            array57[1] = 96;
            ps57.SetMemory(offset57, array57);
            PS3API ps58 = PS3;
            uint offset58 = 6975448u;
            byte[] array58 = new byte[4];
            array58[0] = 56;
            array58[1] = 96;
            ps58.SetMemory(offset58, array58);
            PS3API ps59 = PS3;
            uint offset59 = 6975392u;
            byte[] array59 = new byte[4];
            array59[0] = 56;
            array59[1] = 96;
            ps59.SetMemory(offset59, array59);
            PS3API ps60 = PS3;
            uint offset60 = 6974288u;
            byte[] array60 = new byte[4];
            array60[0] = 56;
            array60[1] = 96;
            ps60.SetMemory(offset60, array60);
            PS3API ps61 = PS3;
            uint offset61 = 6336020u;
            byte[] array61 = new byte[4];
            array61[0] = 56;
            array61[1] = 96;
            ps61.SetMemory(offset61, array61);
            PS3API ps62 = PS3;
            uint offset62 = 6308824u;
            byte[] array62 = new byte[4];
            array62[0] = 56;
            array62[1] = 96;
            ps62.SetMemory(offset62, array62);
            PS3API ps63 = PS3;
            uint offset63 = 6308792u;
            byte[] array63 = new byte[4];
            array63[0] = 56;
            array63[1] = 96;
            ps63.SetMemory(offset63, array63);
            PS3API ps64 = PS3;
            uint offset64 = 6335796u;
            byte[] array64 = new byte[4];
            array64[0] = 56;
            array64[1] = 96;
            ps64.SetMemory(offset64, array64);
            PS3API ps65 = PS3;
            uint offset65 = 6335660u;
            byte[] array65 = new byte[4];
            array65[0] = 56;
            array65[1] = 96;
            ps65.SetMemory(offset65, array65);
            PS3API ps66 = PS3;
            uint offset66 = 6335432u;
            byte[] array66 = new byte[4];
            array66[0] = 56;
            array66[1] = 96;
            ps66.SetMemory(offset66, array66);
            PS3API ps67 = PS3;
            uint offset67 = 6334896u;
            byte[] array67 = new byte[4];
            array67[0] = 56;
            array67[1] = 96;
            ps67.SetMemory(offset67, array67);
            PS3API ps68 = PS3;
            uint offset68 = 6308720u;
            byte[] array68 = new byte[4];
            array68[0] = 56;
            array68[1] = 96;
            ps68.SetMemory(offset68, array68);
            PS3API ps69 = PS3;
            uint offset69 = 6339284u;
            byte[] array69 = new byte[4];
            array69[0] = 56;
            array69[1] = 96;
            ps69.SetMemory(offset69, array69);
            PS3API ps70 = PS3;
            uint offset70 = 6339448u;
            byte[] array70 = new byte[4];
            array70[0] = 56;
            array70[1] = 96;
            ps70.SetMemory(offset70, array70);
            PS3API ps71 = PS3;
            uint offset71 = 6339508u;
            byte[] array71 = new byte[4];
            array71[0] = 56;
            array71[1] = 96;
            ps71.SetMemory(offset71, array71);
            PS3API ps72 = PS3;
            uint offset72 = 1056332u;
            byte[] array72 = new byte[4];
            array72[0] = 56;
            array72[1] = 96;
            ps72.SetMemory(offset72, array72);
            PS3API ps73 = PS3;
            uint offset73 = 6304604u;
            byte[] array73 = new byte[4];
            array73[0] = 56;
            array73[1] = 96;
            ps73.SetMemory(offset73, array73);
            PS3API ps74 = PS3;
            uint offset74 = 6304540u;
            byte[] array74 = new byte[4];
            array74[0] = 56;
            array74[1] = 96;
            ps74.SetMemory(offset74, array74);
            PS3API ps75 = PS3;
            uint offset75 = 6304288u;
            byte[] array75 = new byte[4];
            array75[0] = 56;
            array75[1] = 96;
            ps75.SetMemory(offset75, array75);
            PS3API ps76 = PS3;
            uint offset76 = 6304304u;
            byte[] array76 = new byte[4];
            array76[0] = 56;
            array76[1] = 96;
            ps76.SetMemory(offset76, array76);
            PS3API ps77 = PS3;
            uint offset77 = 6304280u;
            byte[] array77 = new byte[4];
            array77[0] = 56;
            array77[1] = 96;
            ps77.SetMemory(offset77, array77);
            PS3API ps78 = PS3;
            uint offset78 = 6304296u;
            byte[] array78 = new byte[4];
            array78[0] = 56;
            array78[1] = 96;
            ps78.SetMemory(offset78, array78);
            PS3API ps79 = PS3;
            uint offset79 = 466636u;
            byte[] array79 = new byte[4];
            array79[0] = 56;
            array79[1] = 96;
            ps79.SetMemory(offset79, array79);
            PS3API ps80 = PS3;
            uint offset80 = 466672u;
            byte[] array80 = new byte[4];
            array80[0] = 56;
            array80[1] = 96;
            ps80.SetMemory(offset80, array80);
            PS3API ps81 = PS3;
            uint offset81 = 466680u;
            byte[] array81 = new byte[4];
            array81[0] = 56;
            array81[1] = 96;
            ps81.SetMemory(offset81, array81);
            PS3API ps82 = PS3;
            uint offset82 = 6304252u;
            byte[] array82 = new byte[4];
            array82[0] = 56;
            array82[1] = 96;
            ps82.SetMemory(offset82, array82);
            PS3API ps83 = PS3;
            uint offset83 = 6304244u;
            byte[] array83 = new byte[4];
            array83[0] = 56;
            array83[1] = 96;
            ps83.SetMemory(offset83, array83);
            PS3API ps84 = PS3;
            uint offset84 = 980540u;
            byte[] array84 = new byte[4];
            array84[0] = 56;
            array84[1] = 96;
            ps84.SetMemory(offset84, array84);
            PS3API ps85 = PS3;
            uint offset85 = 980532u;
            byte[] array85 = new byte[4];
            array85[0] = 56;
            array85[1] = 96;
            ps85.SetMemory(offset85, array85);
            PS3API ps86 = PS3;
            uint offset86 = 6226228u;
            byte[] array86 = new byte[4];
            array86[0] = 56;
            array86[1] = 96;
            ps86.SetMemory(offset86, array86);
            PS3API ps87 = PS3;
            uint offset87 = 6226208u;
            byte[] array87 = new byte[4];
            array87[0] = 56;
            array87[1] = 96;
            ps87.SetMemory(offset87, array87);
            PS3API ps88 = PS3;
            uint offset88 = 6226200u;
            byte[] array88 = new byte[4];
            array88[0] = 56;
            array88[1] = 96;
            ps88.SetMemory(offset88, array88);
            PS3API ps89 = PS3;
            uint offset89 = 6226192u;
            byte[] array89 = new byte[4];
            array89[0] = 56;
            array89[1] = 96;
            ps89.SetMemory(offset89, array89);
            PS3API ps90 = PS3;
            uint offset90 = 6309488u;
            byte[] array90 = new byte[4];
            array90[0] = 56;
            array90[1] = 96;
            ps90.SetMemory(offset90, array90);
            PS3API ps91 = PS3;
            uint offset91 = 6309512u;
            byte[] array91 = new byte[4];
            array91[0] = 56;
            array91[1] = 96;
            ps91.SetMemory(offset91, array91);
            PS3API ps92 = PS3;
            uint offset92 = 6309504u;
            byte[] array92 = new byte[4];
            array92[0] = 56;
            array92[1] = 96;
            ps92.SetMemory(offset92, array92);
            PS3API ps93 = PS3;
            uint offset93 = 942296u;
            byte[] array93 = new byte[4];
            array93[0] = 56;
            array93[1] = 96;
            ps93.SetMemory(offset93, array93);
            PS3API ps94 = PS3;
            uint offset94 = 942304u;
            byte[] array94 = new byte[4];
            array94[0] = 56;
            array94[1] = 96;
            ps94.SetMemory(offset94, array94);
            PS3API ps95 = PS3;
            uint offset95 = 2777828u;
            byte[] array95 = new byte[4];
            array95[0] = 56;
            array95[1] = 96;
            ps95.SetMemory(offset95, array95);
            PS3API ps96 = PS3;
            uint offset96 = 6236596u;
            byte[] array96 = new byte[4];
            array96[0] = 56;
            array96[1] = 96;
            ps96.SetMemory(offset96, array96);
            PS3API ps97 = PS3;
            uint offset97 = 6236612u;
            byte[] array97 = new byte[4];
            array97[0] = 56;
            array97[1] = 96;
            ps97.SetMemory(offset97, array97);
            PS3API ps98 = PS3;
            uint offset98 = 6236616u;
            byte[] array98 = new byte[4];
            array98[0] = 56;
            array98[1] = 96;
            ps98.SetMemory(offset98, array98);
            PS3API ps99 = PS3;
            uint offset99 = 6236696u;
            byte[] array99 = new byte[4];
            array99[0] = 56;
            array99[1] = 96;
            ps99.SetMemory(offset99, array99);
            PS3API ps100 = PS3;
            uint offset100 = 6236748u;
            byte[] array100 = new byte[4];
            array100[0] = 56;
            array100[1] = 96;
            ps100.SetMemory(offset100, array100);
            PS3API ps101 = PS3;
            uint offset101 = 6974728u;
            byte[] array101 = new byte[4];
            array101[0] = 56;
            array101[1] = 96;
            ps101.SetMemory(offset101, array101);
            PS3API ps102 = PS3;
            uint offset102 = 6973988u;
            byte[] array102 = new byte[4];
            array102[0] = 56;
            array102[1] = 96;
            ps102.SetMemory(offset102, array102);
            PS3API ps103 = PS3;
            uint offset103 = 6304656u;
            byte[] array103 = new byte[4];
            array103[0] = 56;
            array103[1] = 96;
            ps103.SetMemory(offset103, array103);
            PS3API ps104 = PS3;
            uint offset104 = 6304244u;
            byte[] array104 = new byte[4];
            array104[0] = 56;
            array104[1] = 96;
            ps104.SetMemory(offset104, array104);
            PS3API ps105 = PS3;
            uint offset105 = 6303944u;
            byte[] array105 = new byte[4];
            array105[0] = 56;
            array105[1] = 96;
            ps105.SetMemory(offset105, array105);
            PS3API ps106 = PS3;
            uint offset106 = 6303612u;
            byte[] array106 = new byte[4];
            array106[0] = 56;
            array106[1] = 96;
            ps106.SetMemory(offset106, array106);
            PS3API ps107 = PS3;
            uint offset107 = 6303468u;
            byte[] array107 = new byte[4];
            array107[0] = 56;
            array107[1] = 96;
            ps107.SetMemory(offset107, array107);
            PS3API ps108 = PS3;
            uint offset108 = 6300128u;
            byte[] array108 = new byte[4];
            array108[0] = 56;
            array108[1] = 96;
            ps108.SetMemory(offset108, array108);
            PS3API ps109 = PS3;
            uint offset109 = 6308852u;
            byte[] array109 = new byte[4];
            array109[0] = 56;
            array109[1] = 96;
            ps109.SetMemory(offset109, array109);
            PS3API ps110 = PS3;
            uint offset110 = 6334556u;
            byte[] array110 = new byte[4];
            array110[0] = 56;
            array110[1] = 96;
            ps110.SetMemory(offset110, array110);
            PS3API ps111 = PS3;
            uint offset111 = 6334316u;
            byte[] array111 = new byte[4];
            array111[0] = 56;
            array111[1] = 96;
            ps111.SetMemory(offset111, array111);
            PS3API ps112 = PS3;
            uint offset112 = 6334136u;
            byte[] array112 = new byte[4];
            array112[0] = 56;
            array112[1] = 96;
            ps112.SetMemory(offset112, array112);
            PS3API ps113 = PS3;
            uint offset113 = 6333892u;
            byte[] array113 = new byte[4];
            array113[0] = 56;
            array113[1] = 96;
            ps113.SetMemory(offset113, array113);
            PS3API ps114 = PS3;
            uint offset114 = 6311380u;
            byte[] array114 = new byte[4];
            array114[0] = 56;
            array114[1] = 96;
            ps114.SetMemory(offset114, array114);
            PS3.SetMemory(6311372u, new byte[]
            {
        72,
        0,
        0,
        8
            });
            PS3API ps115 = PS3;
            uint offset115 = 6311040u;
            byte[] array115 = new byte[4];
            array115[0] = 56;
            array115[1] = 96;
            ps115.SetMemory(offset115, array115);
            PS3.SetMemory(6311032u, new byte[]
            {
        61,
        96,
        2,
        16
            });
            PS3.SetMemory(6305488u, new byte[]
            {
        61,
        96,
        0,
        8
            });
            PS3.SetMemory(6305496u, new byte[]
            {
        61,
        96,
        0,
        44
            });
            uint[] array116 = new uint[]
            {
        4162977585u,
        2080899750u,
        4160815328u,
        1012946176u,
        2153971712u,
        4225827016u,
        4223729856u,
        4221632696u,
        738394113u,
        1082261860u,
        1012946176u,
        815857832u,
        962593569u,
        1004601343u,
        947913282u,
        2153971716u,
        952107008u,
        2024079392u,
        2019754016u,
        954204160u,
        956301312u,
        1140850690u,
        738394112u,
        1082261796u,
        1012946176u,
        1015043328u,
        2158035112u,
        817954936u,
        1620967436u,
        962593571u,
        2156068872u,
        2091059124u,
        2078146592u,
        2089093044u,
        1004601342u,
        2026242080u,
        1673789440u,
        1140850690u,
        738394112u,
        1082261732u,
        1012946176u,
        962593248u,
        947912704u,
        1675427840u,
        1004601341u,
        2153971716u,
        950009856u,
        2019754016u,
        1140850690u,
        2155937960u,
        2088634292u,
        817954928u,
        962593571u,
        2088961972u,
        950009856u,
        2026242080u,
        1671692288u,
        1140850690u,
        2153840808u,
        962593572u,
        2086864820u,
        1140850690u,
        740163584u,
        1098907780u,
        945815592u,
        947912705u,
        952107008u,
        954204160u,
        4167106688u,
        4169203848u,
        815857792u,
        2428567696u,
        962593249u,
        2428567700u,
        1673723904u,
        4175495320u,
        1004601340u,
        2024079392u,
        4175495328u,
        947912704u,
        1140850690u,
        738394112u,
        1082261560u,
        2153840788u,
        1004601339u,
        738394112u,
        1099038760u,
        2156068864u,
        4165009448u,
        2089354150u,
        2151874564u,
        1318978593u,
        3896573992u,
        738394112u,
        1082261512u,
        1004535808u,
        1012946176u,
        2481127424u,
        3892379872u,
        2080900006u,
        3953197240u,
        3955294400u,
        3957391560u,
        941686992u,
        1317011488u
            };
            uint[] array117 = new uint[]
            {
        4162977617u,
        2080899750u,
        4160815296u,
        4221632624u,
        4223729784u,
        4225826944u,
        1071644847u,
        1677665632u,
        1069569280u,
        2149449728u,
        738197504u,
        1099038864u,
        2145647480u,
        2143613816u,
        1207959713u,
        2145647480u,
        947912704u,
        950009856u,
        962593248u,
        1140850690u,
        2088568756u,
        939524096u,
        2417885184u,
        2145647480u,
        2143613816u,
        1207959669u,
        2141449080u,
        815857800u,
        939524136u,
        4161077248u,
        939524097u,
        4161077256u,
        939589631u,
        4161077264u,
        947912704u,
        962593249u,
        1140850690u,
        3915448472u,
        741081087u,
        1099038752u,
        4165009448u,
        2152398852u,
        2171273216u,
        2104034214u,
        2141449080u,
        1317012513u,
        3896573992u,
        3953197168u,
        3955294328u,
        3957391488u,
        3892379840u,
        2080900006u,
        941686960u,
        1317011488u,
        4162977661u,
        2080899750u,
        4160815252u,
        4225826928u,
        2090804088u,
        947913282u,
        815857784u,
        952107008u,
        954204160u,
        1029701773u,
        1634458228u,
        2104034214u,
        1317012513u,
        2153840760u,
        815726596u,
        2160001024u,
        817954940u,
        962593571u,
        1140850690u,
        2153840760u,
        962593572u,
        1140850690u,
        3957391472u,
        3892379796u,
        2080900006u,
        941686916u,
        1317011488u
            };
            uint[] array118 = new uint[]
            {
        4162977617u,
        2080899750u,
        4160815296u,
        4221632624u,
        4223729784u,
        4225826944u,
        1071644847u,
        1677665632u,
        1069569280u,
        2149449728u,
        738197504u,
        1099038864u,
        2145647480u,
        2143613816u,
        1207959713u,
        2145647480u,
        947912704u,
        950009856u,
        962593248u,
        1140850690u,
        2088568756u,
        939524096u,
        2417885184u,
        2145647480u,
        2143613816u,
        1207959669u,
        2141449080u,
        815857800u,
        939524136u,
        4161077248u,
        939524097u,
        4161077256u,
        939589631u,
        4161077264u,
        947912704u,
        962593249u,
        1140850690u,
        3915448472u,
        741081087u,
        1099038752u,
        4165009448u,
        2152398852u,
        2171273216u,
        2104034214u,
        2141449080u,
        1317012513u,
        3896573992u,
        3953197168u,
        3955294328u,
        3957391488u,
        3892379840u,
        2080900006u,
        941686960u,
        1317011488u,
        4162977661u,
        2080899750u,
        4160815252u,
        4225826928u,
        2090804088u,
        947913282u,
        815857784u,
        952107008u,
        954204160u,
        1029701773u,
        1634458228u,
        2104034214u,
        1317012513u,
        2153840760u,
        815726596u,
        2160001024u,
        817954940u,
        962593571u,
        1140850690u,
        2153840760u,
        962593572u,
        1140850690u,
        3957391472u,
        3892379796u,
        2080900006u,
        941686916u,
        1317011488u
            };
            uint offset116 = 780200u;
            byte[] array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset116, array119);
            uint offset117 = 4307164u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset117, array119);
            uint offset118 = 4307128u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset118, array119);
            uint offset119 = 7894432u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset119, array119);
            uint offset120 = 4307152u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset120, array119);
            uint offset121 = 7740788u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset121, array119);
            uint offset122 = 7607508u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset122, array119);
            uint offset123 = 7740752u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset123, array119);
            uint offset124 = 7746652u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset124, array119);
            uint offset125 = 7743252u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset125, array119);
            uint offset126 = 7743232u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset126, array119);
            uint offset127 = 7743220u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset127, array119);
            uint offset128 = 7743212u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset128, array119);
            uint offset129 = 7740768u;
            array119 = new byte[4];
            array119[0] = 60;
            array119[1] = 96;
            PS3.SetMemory(offset129, array119);
            uint offset130 = 7740756u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset130, array119);
            uint offset131 = 7745684u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset131, array119);
            uint offset132 = 7745656u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset132, array119);
            uint offset133 = 7745700u;
            array119 = new byte[4];
            array119[0] = 96;
            PS3.SetMemory(offset133, array119);
            uint offset134 = 7745632u;
            array119 = new byte[4];
            array119[0] = 56;
            array119[1] = 96;
            PS3.SetMemory(offset134, array119);
            uint offset135 = 4046164u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset135, array119);
            uint offset136 = 5273536u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset136, array119);
            uint offset137 = 5284768u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset137, array119);
            uint offset138 = 5289500u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset138, array119);
            uint offset139 = 5292000u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset139, array119);
            uint offset140 = 5295240u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset140, array119);
            uint offset141 = 5504108u;
            array119 = new byte[2];
            array119[0] = 72;
            PS3.SetMemory(offset141, array119);
            uint offset142 = 5290612u;
            array119 = new byte[4];
            array119[0] = 96;
            PS3.SetMemory(offset142, array119);
            uint offset143 = 5537236u;
            array119 = new byte[4];
            array119[0] = 96;
            PS3.SetMemory(offset143, array119);
            uint offset144 = 5538120u;
            array119 = new byte[4];
            array119[0] = 96;
            PS3.SetMemory(offset144, array119);
            byte[] array120 = new byte[4];
            array120[0] = 56;
            array120[1] = 96;
            byte[] buffer = array120;
            PS3.SetMemory(4307152u, buffer);
            PS3.SetMemory(111388u, buffer);
            PS3.SetMemory(7746652u, buffer);
            PS3.SetMemory(7894432u, buffer);
            PS3.SetMemory(4307128u, buffer);
            PS3.SetMemory(4307164u, buffer);
            PS3.SetMemory(7894432u, buffer);
            PS3.SetMemory(4307152u, buffer);
            PS3.SetMemory(7740788u, buffer);
            PS3.SetMemory(7740768u, buffer);
            PS3.SetMemory(7740756u, buffer);
            PS3.SetMemory(7607508u, buffer);
            PS3.SetMemory(7743252u, buffer);
            PS3.SetMemory(7743220u, buffer);
            PS3.SetMemory(762714u, buffer);
            PS3.SetMemory(7743232u, buffer);
            PS3.SetMemory(7743176u, buffer);
            PS3.SetMemory(3397704u, buffer);
            PS3.SetMemory(4301148u, buffer);
            PS3.SetMemory(4301156u, buffer);
            PS3.SetMemory(4301252u, buffer);
            PS3.SetMemory(4301272u, buffer);
            PS3.SetMemory(4301288u, buffer);
            PS3.SetMemory(4301312u, buffer);
            PS3.SetMemory(4301332u, buffer);
            PS3.SetMemory(4301356u, buffer);
            PS3.SetMemory(4301380u, buffer);
            PS3.SetMemory(4301432u, buffer);
            PS3.SetMemory(4301436u, buffer);
            PS3.SetMemory(4301828u, buffer);
            PS3.SetMemory(4301960u, buffer);
            byte[] buffer2 = new byte[]
            {
        47,
        131,
        72,
        0
            };
            PS3.SetMemory(7740752u, buffer2);
            PS3.SetMemory(3341524u, buffer2);
            PS3.SetMemory(7743212u, buffer2);
            byte[] array121 = new byte[4];
            array121[0] = 96;
            PS3.SetMemory(4599916u, array121);
            PS3.SetMemory(762700u, array121);
            PS3.SetMemory(2948476u, new byte[]
            {
        96
            });
            array120 = new byte[2];
            array120[0] = 96;
            PS3.SetMemory(6797348u, array120);
            array120 = new byte[3];
            array120[0] = 96;
            PS3.SetMemory(6797208u, array120);
            PS3.SetMemory(6797232u, new byte[]
            {
        60,
        96,
        81
            });
            array120 = new byte[4];
            array120[0] = 56;
            array120[1] = 96;
            array120 = new byte[4];
            array120[0] = 56;
            array120[1] = 96;
            array120 = new byte[4];
            array120[0] = 56;
            array120[1] = 96;
            PS3.SetMemory(111388u, array120);
            PS3.SetMemory(24666981u, new byte[]
            {
        3,
        69,
        152
            });
            PS3.SetMemory(24667041u, new byte[]
            {
        3,
        69,
        122
            });
            PS3.SetMemory(24667585u, new byte[]
            {
        3,
        81,
        206
            });
            byte[] buffer3 = new byte[]
            {
        96
            };
            PS3.SetMemory(6797352u, buffer3);
            PS3.SetMemory(6797355u, new byte[1]);
            byte[] buffer4 = new byte[]
            {
        127
            };
            PS3.SetMemory(6797362u, buffer4);
            PS3.SetMemory(9347820u, new byte[]
            {
        55,
        105,
        0,
        0,
        146
            });
            byte[] array122 = new byte[4];
            array122[0] = 96;
            PS3.SetMemory(1327440u, array122);
            array122 = new byte[4];
            array122[0] = 60;
            array122[1] = 96;
            PS3.SetMemory(1115588u, array122);
            array122 = new byte[4];
            array122[0] = 60;
            array122[1] = 96;
            PS3.SetMemory(780200u, array122);
            array122 = new byte[4];
            array122[0] = 60;
            array122[1] = 96;
            PS3.SetMemory(779932u, array122);
            array122 = new byte[4];
            array122[0] = 60;
            array122[1] = 96;
            PS3.SetMemory(6976232u, array122);
            array122 = new byte[4];
            array122[0] = 56;
            array122[1] = 96;
            PS3.SetMemory(6976224u, array122);

        }

        public static void Ingame()
        {
            byte[] array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(4173260u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(4173260u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(4173260u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(4173260u, array);
            array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(4173260u, array);
        }



        public static void AntifreezeAllinOn()
        {
            byte[] array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            byte[] array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            byte[] array3 = new byte[2];
            array3[0] = 72;
            PS3.SetMemory(5284768u, array3);
            byte[] array4 = new byte[2];
            array4[0] = 72;
            PS3.SetMemory(5289500u, array4);
            byte[] array5 = new byte[2];
            array5[0] = 72;
            PS3.SetMemory(5292000u, array5);
            byte[] array6 = new byte[2];
            array6[0] = 72;
            PS3.SetMemory(5295240u, array6);
            byte[] array7 = new byte[2];
            array7[0] = 72;
            PS3.SetMemory(5504108u, array7);
            byte[] array8 = new byte[4];
            array8[0] = 96;
            PS3.SetMemory(5290612u, array8);
            byte[] array9 = new byte[4];
            array9[0] = 96;
            PS3.SetMemory(5537236u, array9);
            byte[] array10 = new byte[4];
            array10[0] = 96;
            PS3.SetMemory(5538120u, array10);
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            PS3.SetMemory(2948476u, array11);
            PS3.SetMemory(6797352u, new byte[]
            {72});
            PS3.SetMemory(6797355u, new byte[]
            {72});
            PS3.SetMemory(6797362u, new byte[1]);
            PS3.SetMemory(810557548u, new byte[]
            {101,110,100,114,111,117,110,100,0});
            PS3.SetMemory(111388u, new byte[]
            {127,255,24,46});
            array2[0] = 115;
            array2[1] = 108;
            PS3.SetMemory(9482500u, array2);
            PS3.SetMemory(6797352u, new byte[]
                {
                    96
                });
            PS3.SetMemory(6797355u, new byte[1]);
            PS3.SetMemory(6797362u, new byte[]
            {
                    127
            });
            PS3.SetMemory(810557548u, new byte[8]);
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(9482500u, new byte[3]);
            PS3.SetMemory(9347824u, new byte[] { 114 });
            PS3.SetMemory(9347824u, new byte[]
            {82});
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {53,23,53,30});
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {144, 154, 0, 0,94, 94, 94});
            PS3.SetMemory(6797362u, new byte[]
            {94,94});
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {65,130,8,240});
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
                53,
                23,
                53,
                30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });

            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
                53,
                23,
                53,
                30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(6797348u, array);
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6976224u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(6258260u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(4046164u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5284768u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5289500u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5292000u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5295240u, array2);
            array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5504108u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5290612u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5537236u, array2);
            array2 = new byte[4];
            array2[0] = 96;
            PS3.SetMemory(5538120u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            PS3.SetMemory(2948476u, array2);
            array[0] = 96;
            PS3.SetMemory(6797348u, array);
            PS3.SetMemory(111388u, new byte[]
            {
                53,
                23,
                53,
                30
            });
            array2[0] = 96;
            PS3.SetMemory(2948476u, array2);
            PS3.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            PS3.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            PS3.SetMemory(9319824u, new byte[13]);
            PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
        }

        public static void AntiLevelFreeze()
        {
            PS3.SetMemory(9347824u, new byte[] { 114 });
            PS3.SetMemory(9347824u, new byte[] { 82 });
            return;
        }
        public static void AntiPartyAndKickHostFreeze()
        {
            PS3.SetMemory(6797352u, new byte[]
            {72});
            PS3.SetMemory(6797355u, new byte[]
            {72});
            PS3.SetMemory(6797362u, new byte[1]);
            PS3.SetMemory(810557548u, new byte[]
            {101,110,100,114,111,117,110,100,0});
            PS3.SetMemory(111388u, new byte[]
            {127,255,24,46});
            byte[] array2 = new byte[3];
            array2[0] = 115;
            array2[1] = 108;
            PS3.SetMemory(9482500u, array2);
            PS3.SetMemory(6797352u, new byte[]
                {
                    96
                });
            PS3.SetMemory(6797355u, new byte[1]);
            PS3.SetMemory(6797362u, new byte[]
            {
                    127
            });
            PS3.SetMemory(810557548u, new byte[8]);
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(111388u, array);
            PS3.SetMemory(9482500u, new byte[3]);
            return;
        }
        public static void AntiShit()
        {
            byte[] array = new byte[2];
            array[0] = 72;
            PS3.SetMemory(4046164u, array);
            byte[] array2 = new byte[2];
            array2[0] = 72;
            PS3.SetMemory(5273536u, array2);
            byte[] array3 = new byte[2];
            array3[0] = 72;
            PS3.SetMemory(5284768u, array3);
            byte[] array4 = new byte[2];
            array4[0] = 72;
            PS3.SetMemory(5289500u, array4);
            byte[] array5 = new byte[2];
            array5[0] = 72;
            PS3.SetMemory(5292000u, array5);
            byte[] array6 = new byte[2];
            array6[0] = 72;
            PS3.SetMemory(5295240u, array6);
            byte[] array7 = new byte[2];
            array7[0] = 72;
            PS3.SetMemory(5504108u, array7);
            byte[] array8 = new byte[4];
            array8[0] = 96;
            PS3.SetMemory(5290612u, array8);
            byte[] array9 = new byte[4];
            array9[0] = 96;
            PS3.SetMemory(5537236u, array9);
            byte[] array10 = new byte[4];
            array10[0] = 96;
            PS3.SetMemory(5538120u, array10);
            byte[] array11 = new byte[4];
            array11[0] = 56;
            array11[1] = 96;
            PS3.SetMemory(2948476u, array11);
        }
    }
}

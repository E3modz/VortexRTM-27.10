using E3Modz.Black_Ops_2;

// Token: 0x02000036 RID: 54
internal class Stats
{
    // Token: 0x0400057C RID: 1404
    public static uint MedalsSt = BO2.Offsets.Prestige;

    // Token: 0x0400057D RID: 1405
    public static uint[] Rank = new uint[]
    {
        0u,
        800u,
        1900u,
        3300u,
        5300u,
        7900u,
        11100u,
        14900u,
        19300u,
        24300u,
        30100u,
        36700u,
        44100u,
        52300u,
        61300u,
        71100u,
        81700u,
        93100u,
        105300u,
        118300u,
        132100u,
        146700u,
        162100u,
        178300u,
        195300u,
        213100u,
        231700u,
        251100u,
        271300u,
        292300u,
        314100u,
        337100u,
        361300u,
        386700u,
        413300u,
        441100u,
        470100u,
        500300u,
        531700u,
        564300u,
        598100u,
        633100u,
        669300u,
        706700u,
        745300u,
        785100u,
        826100u,
        868300u,
        911700u,
        958300u,
        1002100u,
        1049100u,
        1097300u,
        1146700u,
        1197300u,
        1249100u
    };

    // Token: 0x0400057E RID: 1406
    public static uint StatsCombat = BO2.Offsets.UnlockWeapTit;

    // Token: 0x02000037 RID: 55
    public static class Classes
    {
        // Token: 0x0400057F RID: 1407
        public static uint Class1NaOffset = BO2.Offsets.UnlockWeapTit + 36284u;

        // Token: 0x04000580 RID: 1408
        public static uint Class1Weap = BO2.Offsets.UnlockWeapTit + 35756u;

        // Token: 0x02000038 RID: 56
        public static class Typex34
        {
            // Token: 0x04000581 RID: 1409
            public static byte[] WeapBytes = new byte[]
            {
                0,
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
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                24,
                25,
                26,
                27,
                28,
                29,
                30,
                31,
                32,
                36,
                37,
                38,
                39,
                42,
                43,
                44,
                45,
                47,
                48,
                49,
                50,
                53,
                54,
                55,
                57,
                58,
                59
            };

            // Token: 0x04000582 RID: 1410
            public static string[] WeapNames = new string[]
            {
                "None",
                "KAP-40",
                "Tac-45",
                "B23R",
                "Executioner",
                "Five-seven",
                "KAP-40 Dual Wield",
                "Tac-45 Dual Wield",
                "Five-seven Dual Wield",
                "Executioner Dual Wield",
                "B23R Dual Wield",
                "MP7",
                "Skorpion EVO",
                "PDW-57",
                "Chicom CQB",
                "MSMC",
                "Vector K10",
                "Peacekeeper",
                "M8A1",
                "SCAR-H",
                "AN-94",
                "SWAT-556",
                "Type 25",
                "FAL OSW",
                "SMR",
                "M27",
                "MTAR",
                "Mk 48",
                "QBB LSW",
                "LSAT",
                "HAMR",
                "Ballista",
                "SVU-AS",
                "DSR 50",
                "XPR-50",
                "R870 MCS",
                "M1216",
                "S12",
                "KSG",
                "SMAW",
                "FHJ-18 AA",
                "RPG",
                "Assault Shield",
                "Crossbow",
                "Ballistic Knife"
            };
        }

        // Token: 0x02000039 RID: 57
        public static class Typex35
        {
        }
    }

    // Token: 0x0200003A RID: 58
    public static class Equipment
    {
        // Token: 0x04000583 RID: 1411
        public static uint[] Multi = new uint[]
        {
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            128u,
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            2u,
            128u
        };

        // Token: 0x04000584 RID: 1412
        public static uint[] Oth = new uint[]
        {
            7287u,
            7403u,
            7519u,
            7634u,
            7750u,
            7866u,
            8139u,
            8267u,
            8383u,
            8499u,
            8614u,
            8730u,
            8846u,
            8962u,
            9077u
        };

        // Token: 0x04000585 RID: 1413
        public static uint[] Use = new uint[]
        {
            7329u,
            7445u,
            7561u,
            7676u,
            7792u,
            7908u,
            8151u,
            8255u,
            8371u,
            8487u,
            8602u,
            8718u,
            8834u,
            8950u,
            9065u
        };
    }

    // Token: 0x0200003B RID: 59
    public static class Gamemodes
    {
        // Token: 0x04000586 RID: 1414
        public static uint[] Multi = new uint[]
        {
            64u,
            1u,
            4u,
            16u,
            64u,
            1u,
            4u,
            16u,
            64u,
            1u,
            4u,
            16u,
            64u,
            1u,
            16u,
            64u,
            1u
        };

        // Token: 0x04000587 RID: 1415
        public static uint[] Offsets = new uint[]
        {
            4956u,
            4750u,
            4545u,
            4340u,
            4135u,
            3929u,
            3724u,
            3519u,
            3314u,
            3108u,
            2903u,
            2698u,
            2493u,
            2287u,
            1877u,
            1672u,
            645u
        };
    }

    // Token: 0x0200003C RID: 60
    public static class Medals
    {
        // Token: 0x04000588 RID: 1416
        public static uint[] Offsets = new uint[]
        {
            1032u,
            1026u,
            1020u,
            1014u,
            1008u,
            1002u,
            996u,
            990u,
            984u,
            978u,
            972u,
            966u,
            960u,
            954u,
            948u,
            942u,
            936u,
            930u,
            924u,
            918u,
            912u,
            906u,
            900u,
            894u,
            888u,
            882u,
            876u,
            870u,
            864u,
            858u,
            852u,
            846u,
            840u,
            834u,
            828u,
            822u,
            810u,
            804u,
            798u,
            786u,
            780u,
            774u,
            768u,
            762u,
            756u,
            744u,
            732u,
            726u,
            720u,
            714u,
            708u,
            702u,
            696u,
            690u,
            684u,
            678u,
            672u,
            666u,
            660u,
            654u,
            648u,
            630u,
            624u,
            618u,
            612u,
            606u,
            600u,
            594u,
            588u,
            582u,
            576u,
            570u,
            564u,
            558u,
            552u,
            546u,
            540u,
            534u,
            528u,
            522u,
            516u,
            510u,
            504u,
            498u,
            492u,
            486u,
            480u,
            474u,
            468u,
            462u,
            456u,
            450u,
            444u,
            438u,
            432u,
            426u,
            420u,
            414u,
            408u,
            402u,
            396u,
            390u,
            384u,
            378u,
            372u,
            366u,
            354u,
            348u,
            342u,
            336u,
            330u,
            324u,
            318u,
            312u,
            306u,
            300u,
            294u,
            288u,
            282u,
            276u,
            270u,
            264u,
            258u,
            252u,
            246u,
            240u,
            234u,
            228u,
            222u,
            210u,
            204u,
            198u
        };
    }

    // Token: 0x0200003D RID: 61
    public static class Offsets
    {
        // Token: 0x04000589 RID: 1417
        public static uint ClanOffset = BO2.Offsets.UnlockWeapTit + 38186u;

        // Token: 0x0400058A RID: 1418
        public static uint Deaths = BO2.Offsets.Prestige - 1746u;

        // Token: 0x0400058B RID: 1419
        public static uint Kills = BO2.Offsets.Prestige - 1188u;

        // Token: 0x0400058C RID: 1420
        public static uint Losses = BO2.Offsets.Prestige - 1074u;

        // Token: 0x0400058D RID: 1421
        public static uint NaOffset1 = 40633944u;

        // Token: 0x0400058E RID: 1422
        public static uint NaOffset2 = BO2.Offsets.NaOffset1 + 39u;

        // Token: 0x0400058F RID: 1423
        public static uint Prestige = 40882196u;

        // Token: 0x04000590 RID: 1424
        public static uint Rank = BO2.Offsets.Prestige + 18u;

        // Token: 0x04000591 RID: 1425
        public static uint Score = BO2.Offsets.Prestige + 60u;

        // Token: 0x04000592 RID: 1426
        public static uint TimeSec = BO2.Offsets.Prestige + 246u;

        // Token: 0x04000593 RID: 1427
        public static uint Tokens = BO2.Offsets.UnlockWeapTit + 31786u;

        // Token: 0x04000594 RID: 1428
        public static uint UnlockAll = BO2.Offsets.Prestige + 2446u;

        // Token: 0x04000595 RID: 1429
        public static uint UnlockWeapTit = BO2.Offsets.Prestige + 7418u;

        // Token: 0x04000596 RID: 1430
        public static uint Wins = BO2.Offsets.Prestige + 318u;
    }

    // Token: 0x0200003E RID: 62
    public static class Streaks
    {
        // Token: 0x04000597 RID: 1431
        public static uint[] Multi = new uint[]
        {
            32u,
            128u,
            8u,
            128u,
            2u,
            32u,
            8u,
            2u,
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            2u,
            128u,
            8u,
            32u,
            2u,
            128u,
            32u,
            8u
        };

        // Token: 0x04000598 RID: 1432
        public static uint[] OffsetsOther = new uint[]
        {
            23077u,
            22913u,
            23145u,
            23376u,
            23309u,
            23492u,
            23608u,
            23724u,
            23955u,
            24071u,
            24187u,
            24302u,
            24418u,
            24534u,
            24698u,
            24765u,
            25045u,
            24881u,
            25113u,
            25228u,
            25344u,
            25460u
        };

        // Token: 0x04000599 RID: 1433
        public static uint[] OffsetsUse = new uint[]
        {
            23071u,
            22955u,
            23187u,
            23418u,
            23303u,
            23534u,
            23650u,
            23766u,
            23997u,
            24113u,
            24229u,
            24344u,
            24460u,
            24576u,
            24692u,
            24807u,
            25039u,
            24923u,
            25155u,
            25270u,
            25386u,
            25502u
        };
    }

    // Token: 0x0200003F RID: 63
    public static class Weapons
    {
        // Token: 0x0400059A RID: 1434
        public static uint[] Multi = new uint[]
        {
            128u,
            32u,
            8u,
            2u,
            128u,
            2u,
            128u,
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            2u,
            128u,
            32u,
            8u,
            8u,
            2u,
            128u,
            32u,
            128u,
            32u,
            8u,
            2u,
            32u,
            8u,
            2u,
            128u,
            2u,
            128u,
            32u,
            2u,
            128u,
            32u
        };

        // Token: 0x0400059B RID: 1435
        public static uint[] Offsets = new uint[]
        {
            226u,
            342u,
            458u,
            574u,
            689u,
            1500u,
            1615u,
            1731u,
            1847u,
            1963u,
            2078u,
            2194u,
            2773u,
            2889u,
            3004u,
            3120u,
            3236u,
            3352u,
            3467u,
            3583u,
            3699u,
            4162u,
            4278u,
            4393u,
            4509u,
            4856u,
            4972u,
            5088u,
            5204u,
            5435u,
            5551u,
            5667u,
            5782u,
            6130u,
            6245u,
            6361u,
            6593u,
            6708u,
            6824u
        };
    }
}

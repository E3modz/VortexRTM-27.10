using E3Modz.Login___Home;

namespace E3Modz.Klassen
{
    // Token: 0x0200015E RID: 350
    internal class bo1server
    {
        // Token: 0x06000F8F RID: 3983 RVA: 0x005B4D0C File Offset: 0x005B2F0C
        internal static void GiveRank(string prestige, string rank, string xp, string kills, string deaths, string wins, string losses, string score)
        {
            string text = string.Format("callvote map \"mp_nuked;statsetbyname PLEVEL {0};updategamerprofile;uploadstats;statsetbyname RANK {1};statsetbyname RANKXP {2};statsetbyname kills {3};statsetbyname deaths {4};statsetbyname wins {5};statsetbyname losses {6};statsetbyname score {7}", new object[]
            {
                prestige,
                rank,
                xp,
                kills,
                deaths,
                wins,
                losses,
                score
            });
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F90 RID: 3984 RVA: 0x005B4D78 File Offset: 0x005B2F78
        internal static void Derank(string prestige, string rank, string xp)
        {
            string text = string.Format("callvote map \"mp_nuked;resetStats;statsetbyname PLEVEL {0};statsetbyname RANK {1};statsetbyname RANKXP {2};", prestige, rank, xp);
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F91 RID: 3985 RVA: 0x005B4DBC File Offset: 0x005B2FBC
        internal static void XMB(string cmd)
        {
            string text = string.Format("callvote map \"mp_nuked; {0}", cmd);
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F92 RID: 3986 RVA: 0x005B4DFC File Offset: 0x005B2FFC
        internal static void mp_nuked()
        {
            string text = string.Format("callvote map \"mp_nuketown_2020;\"");
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F93 RID: 3987 RVA: 0x005B4E40 File Offset: 0x005B3040
        internal static void mp_array()
        {
            string text = string.Format("callvote map \"mp_array;\"");
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F94 RID: 3988 RVA: 0x005B4E84 File Offset: 0x005B3084
        internal static void mp_cracked()
        {
            string text = string.Format("callvote map \"mp_cracked;\"");
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }

        // Token: 0x06000F95 RID: 3989 RVA: 0x005B4EC8 File Offset: 0x005B30C8
        internal static void mp_mountain()
        {
            string text = string.Format("callvote map \"mp_mountain;\"");
            BO1RPC.Call(3775688u, new object[]
            {
                0,
                text.Replace(';', '\r')
            });
        }
    }
}

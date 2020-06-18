using E3Modz;

internal class Server
{
    internal static void GiveRank(string prestige, string rank, string xp, string kills, string deaths, string wins, string losses, string score)
    {
        string text = string.Format("callvote map \"mp_carrier;statsetbyname PLEVEL {0};updategamerprofile;uploadstats;statsetbyname RANK {1};statsetbyname RANKXP {2};statsetbyname kills {3};statsetbyname deaths {4};statsetbyname wins {5};statsetbyname losses {6};statsetbyname score {7}", prestige, rank, xp, kills, deaths, wins, losses, score);
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void Derank(string prestige, string rank, string xp)
    {
        string text = string.Format("callvote map \"mp_carrier;resetStats;statsetbyname PLEVEL {0};statsetbyname RANK {1};statsetbyname RANKXP {2};", prestige, rank, xp);
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void XMB(string cmd)
    {
        string text = string.Format("callvote map \"mp_carrier; {0}", cmd);
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_carrier()
    {
        string text = string.Format("callvote map \"mp_carrier;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_raid()
    {
        string text = string.Format("callvote map \"mp_raid;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_standoff()
    {
        string text = string.Format("callvote map \"mp_village;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_express()
    {
        string text = string.Format("callvote map \"mp_express;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_turbine()
    {
        string text = string.Format("callvote map \"mp_turbine;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_aftermath()
    {
        string text = string.Format("callvote map \"mp_la;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_cargo()
    {
        string text = string.Format("callvote map \"mp_dockside;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_drone()
    {
        string text = string.Format("callvote map \"mp_drone;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void mp_nuketown()
    {
        string text = string.Format("callvote map \"mp_nuketown_2020;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void gametype()
    {
        string text = string.Format("callvote map \"mp_nuketown_2020;ui_gametype dom;party_gametype dom;g_gametype dom;ls_gametype dom;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }

    internal static void prob()
    {
        string text = string.Format("callvote map \"mp_nuketown_2020;probation_public_quitScalar 1; probation_public_enabled 1; probation_public_forgiveCount 1; probation_public_probationTime 999999;");
        BO2RPC.Call(1199232u, 0, text.Replace(';', '\r'));
    }
}

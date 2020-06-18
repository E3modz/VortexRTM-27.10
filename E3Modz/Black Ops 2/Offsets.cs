namespace E3Modz
{
    internal class Offsets
    {

        public class Funcs
        {
            public static uint G_Client(int clientIndex, uint Mod = 0u)
            {
                return Offsets.G_Client + Mod + (uint)(clientIndex * 22536);
            }
            public static uint G_Entity(int entityIndex, uint Mod = 0u)
            {
                return Offsets.G_Entity + Mod + (uint)(entityIndex * 796);
            }
        }
        public class Index
        {
            public class Vision
            {
                public static string concussion_grenade = "concussion_grenade";
                public static string death = "death";
                public static string normal = "default";
                public static string default_night = "default_night";
                public static string drown = "drown";
                public static string flare = "flare";
                public static string flash_grenade = "flash_grenade";
                public static string infrared = "infrared";
                public static string infrared_snow = "infrared_snow";
                public static string int_frontend_char_trans = "int_frontend_char_trans";
                public static string low_health = "low_health";
                public static string mp_array = "mp_array";
                public static string mp_cracked = "mp_cracked";
                public static string mp_havoc = "mp_havoc";
                public static string mp_mountain = "mp_mountain";
                public static string mp_nuked = "mp_nuked";
                public static string mp_nuked2 = "mp_nuked2";
                public static string mpintro = "mpintro";
                public static string mpoutro = "mpoutro";
                public static string neutral = "neutral";
                public static string remote_mortar_enhanced = "remote_mortar_enhanced";
                public static string remote_mortar_infrared = "remote_mortar_infrared";
                public static string taser_mine_shock = "taser_mine_shock";
                public static string tvguided_mp = "tvguided_mp";
                public static string tvguided_sp = "tvguided_sp";
            }
            public class Rumble
            {
                public static int Open = 5;
                public static int Close = 5;
                public static int Click = 1;
                public static int Scroll = 19;
            }
            public class Freeze
            {
                public static int FullFreeze = 4;
                public static int AllowLook = 240;
                public static int Disable = 0;
            }
            public class Keyboard
            {
                public static int Numpad = 1;
                public static int Normal = 2;
            }
            public class Turret
            {
                public static string auto_gun_turret_mp = "auto_gun_turret_mp";
                public static string heli_gunner_rockets_mp = "heli_gunner_rockets_mp";
                public static string straferun_rockets_mp = "straferun_rockets_mp";
                public static string chopper_minigun_mp = "chopper_minigun_mp";
                public static string mounted_turret_stand = "mounted_turret_stand";
            }
        }
        public static uint InGame = 30107880u;
        public static uint RPC = 8036832u;
        public static uint RPCCustom = 3766764u;
        public static uint CheatProtection = 4046704u;
        public static uint ServerDetails = 16089029u;
        public static uint ServerCache = 16089060u;
        public static uint FPS = 3766764u;
        public static uint G_LocalizedStringIndex = 2579748u;
        public static uint G_SoundAliasIndex = 5196108u;
        public static uint SV_GameSendServerCommand = 3449308u;
        public static uint Cbuf_AddText = 3227272u;
        public static uint G_GetWeaponIndexForName = 2780136u;
        public static uint cl_ingame = 30107880u;
        public static uint LocalPlayerName = 40633983u;
        public static uint level_locals_t = 23101696u;
        public static uint AllowPrecache = Offsets.level_locals_t + 64u;
        public static uint LevelTime = Offsets.level_locals_t + 1944u;
        public static uint G_HudElems = 22928128u;
        public static uint G_MaterialIndex = 2580512u;
        public static uint HudelemSize = 136u;
        public static uint G_Client = 24645416u;
        public static uint ClientVelocity = 52u;
        public static uint ClientFriction = 12u;
        public static uint ClientCurrentWeapon = 440u;
        public static uint ClientFreeze = 22164u;
        public static uint ClientViewModel = 21748u;
        public static uint ClientButtonMonitoring = 22172u;
        public static uint ClientPlayerName = 21828u;
        public static uint ClientOrigin = 40u;
        public static uint ClientAngles = 22204u;
        public static uint ClientTeam = 21764u;
        public static uint ClientIsAlive = 21968u;
        public static uint ClientStance = 252u;
        public static uint ClientGodMode = 24u;
        public static uint ClientPerks = 1352u;
        public static uint ClientPrimaryCamo = 728u;
        public static uint ClientSecondaryCamo = 700u;
        public static uint ClientTactical = 780u;
        public static uint ClientLethal = 752u;
        public static uint ClientKS1 = 1067u;
        public static uint ClientKS2 = 1072u;
        public static uint ClientKS3 = 1076u;
        public static uint PrimaryAmmo = 1084u;
        public static uint SecondaryAmmo = 1080u;
        public static uint LethalAmmo = 1088u;
        public static uint TacticalAmmo = 1092u;
        public static uint G_Entity = 23830304u;
        public static uint G_EntitySize = 796u;
        public static uint EntModelIndex = 364u;
        public static uint EntOrigin = 308u;
        public static uint EntAngles = 320u;
        public static uint G_ModelIndex = 2580864u;
        public static uint G_EntLink = 2806848u;
        public static uint G_EntUnlink = 2807232u;
        public static uint G_SetOrigin = 2594456u;
        public static uint G_AddEvent = 2595152u;
        public static uint G_GivePlayerWeapon = 2786148u;
        public static uint G_InitializeAmmo = 1992760u;
        public static uint SetClientViewAngles = 1973648u;
        public static uint Player_Die = 2086160u;
        public static uint Scr_PlayerKilled = 2395936u;
        public static uint ScriptEntCmdGetCommandTimes = 2519560u;
        public static uint ScriptMover_SetupMove = 2525752u;
        public static uint Trace_GetEntityHitID = 3174192u;
        public static uint G_GetPlayerViewOrigin = 1990864u;
        public static uint G_LocationalTrace = 3524008u;
        public static uint SV_LinkEntity = 3513344u;
        public static uint G_TempEntity = 2594624u;
        public static uint G_SetModel = 2586180u;
        public static uint G_Spawn = 2591840u;
        public static uint G_SpawnTurret = 2860488u;
        public static uint G_SpawnHelicopter = 2278744u;
        public static uint SP_Turret = 2862680u;
        public static uint SP_Script_Model = 2519272u;
    }
}

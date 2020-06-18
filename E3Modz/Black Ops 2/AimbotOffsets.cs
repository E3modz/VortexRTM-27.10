using System;

namespace E3Modz.Black_Ops_2
{
    class AimbotOffsets
    {
        public static uint

        //G_Client
        G_Client = 0x1780F28,
        G_ClientSize = 0x5808,
        ClientOrigin = 0x28,
        ClientAngles = 0x56BC,
        ClientTeam = 0x5504,
        ClientIsAlive = 0x55D0,
        ClientStance = 0xFC,

        //Entity
        G_Entity = 0x16B9F20,
        G_EntitySize = 0x31C,
        SetClientViewAngles = 0x1E1D90;
    }
    public class FuncsAim
    {
        public static float[] getPlayerPosition(int clientIndex)
        {
            float[] Position = Lib.ReadSingle(Offsets.Funcs.G_Client(clientIndex, Offsets.ClientOrigin), 3);
            return Position;
        }
        public static uint G_Client(int clientIndex, uint Mod = 0x00)
        {
            return (Offsets.G_Client + (UInt32)Mod) + ((uint)clientIndex * 0x5808);
        }
        public static uint G_Entity(int entityIndex, uint Mod = 0x00)
        {
            return (Offsets.G_Entity + (UInt32)Mod) + ((uint)entityIndex * 0x31C);
        }
    }
}


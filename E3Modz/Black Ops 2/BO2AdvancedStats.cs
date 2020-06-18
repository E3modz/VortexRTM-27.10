using PS3Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_2
{
    public partial class BO2AdvancedStats : Form
    {
        public static PS3API PS3 = (BO2.PS3);
        public BO2AdvancedStats()
        {
            InitializeComponent();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            BO2 bo = new BO2();
            bo.Show();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CoreCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CoreCheckAll.Checked)
            {
                this.TDMCheck.Checked = true;
                this.FreeForAllCheck.Checked = true;
                this.DominationCheck.Checked = true;
                this.DemolitionCheck.Checked = true;
                this.KillConfirmedCheck.Checked = true;
                this.HardpointCheck.Checked = true;
                this.HeadquartersCheck.Checked = true;
                this.CTFCheck.Checked = true;
                this.SDCheck.Checked = true;
            }
            else
            {
                this.TDMCheck.Checked = false;
                this.FreeForAllCheck.Checked = false;
                this.DominationCheck.Checked = false;
                this.DemolitionCheck.Checked = false;
                this.KillConfirmedCheck.Checked = false;
                this.HardpointCheck.Checked = false;
                this.HeadquartersCheck.Checked = false;
                this.CTFCheck.Checked = false;
                this.SDCheck.Checked = false;
            }
        }
        private string GetRatio(decimal Kill, decimal Death)
        {
            string result;
            if (Kill != 0m && Death != 0m)
            {
                result = (Kill / Death).ToString("0.00").Replace(".00", string.Empty);
            }
            else
            {
                result = "0.00";
            }
            return result;
        }
        private void TDMWin_ValueChanged(object sender, EventArgs e)
        {
            this.TDMWL.Text = this.GetRatio(this.TDMWin.Value, this.TDMLos.Value);
        }

        private void TDMLos_ValueChanged(object sender, EventArgs e)
        {
            this.TDMWL.Text = this.GetRatio(this.TDMWin.Value, this.TDMLos.Value);
        }

        private void TDMCur_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FreeForAllWin_ValueChanged(object sender, EventArgs e)
        {
            this.FreeForAllWL.Text = this.GetRatio(this.FreeForAllWin.Value, this.FreeForAllLos.Value);
        }

        private void FreeForAllLos_ValueChanged(object sender, EventArgs e)
        {
            this.FreeForAllWL.Text = this.GetRatio(this.FreeForAllWin.Value, this.FreeForAllLos.Value);
        }

        private void DominationWin_ValueChanged(object sender, EventArgs e)
        {
            this.DominationWL.Text = this.GetRatio(this.DominationWin.Value, this.DominationLos.Value);
        }

        private void DominationLos_ValueChanged(object sender, EventArgs e)
        {
            this.DominationWL.Text = this.GetRatio(this.DominationWin.Value, this.DominationLos.Value);
        }

        private void DemolitionWin_ValueChanged(object sender, EventArgs e)
        {
            this.DemolitionWL.Text = this.GetRatio(this.DemolitionWin.Value, this.DemolitionLos.Value);
        }

        private void DemolitionLos_ValueChanged(object sender, EventArgs e)
        {
            this.DemolitionWL.Text = this.GetRatio(this.DemolitionWin.Value, this.DemolitionLos.Value);
        }

        private void KillConfirmedWin_ValueChanged(object sender, EventArgs e)
        {
            this.KillConfirmedWL.Text = this.GetRatio(this.KillConfirmedWin.Value, this.KillConfirmedLos.Value);
        }

        private void KillConfirmedLos_ValueChanged(object sender, EventArgs e)
        {
            this.KillConfirmedWL.Text = this.GetRatio(this.KillConfirmedWin.Value, this.KillConfirmedLos.Value);
        }

        private void HardpointWin_ValueChanged(object sender, EventArgs e)
        {
            this.HardpointWL.Text = this.GetRatio(this.HardpointWin.Value, this.HardpointLos.Value);
        }

        private void HardpointLos_ValueChanged(object sender, EventArgs e)
        {
            this.HardpointWL.Text = this.GetRatio(this.HardpointWin.Value, this.HardpointLos.Value);
        }

        private void HeadquartersWin_ValueChanged(object sender, EventArgs e)
        {
            this.HeadquartersWL.Text = this.GetRatio(this.HeadquartersWin.Value, this.HeadquartersLos.Value);
        }

        private void HeadquartersLos_ValueChanged(object sender, EventArgs e)
        {
            this.HeadquartersWL.Text = this.GetRatio(this.HeadquartersWin.Value, this.HeadquartersLos.Value);
        }

        private void CTFWin_ValueChanged(object sender, EventArgs e)
        {
            this.CTFWL.Text = this.GetRatio(this.CTFWin.Value, this.CTFLos.Value);
        }

        private void CTFLos_ValueChanged(object sender, EventArgs e)
        {
            this.CTFWL.Text = this.GetRatio(this.CTFWin.Value, this.CTFLos.Value);
        }

        private void SDWin_ValueChanged(object sender, EventArgs e)
        {
            this.SDWL.Text = this.GetRatio(this.SDWin.Value, this.SDLos.Value);
        }

        private void SDLos_ValueChanged(object sender, EventArgs e)
        {
            this.SDWL.Text = this.GetRatio(this.SDWin.Value, this.SDLos.Value);
        }

        private void BO2AdvancedStats_Load(object sender, EventArgs e)
        {
            this.StreaksUse = new NumericUpDown[]
            {
                this.UAVUse,
                this.RXUse,
                this.HtUse,
                this.CPacUse,
                this.CoutUse,
                this.GdiUse,
                this.MisUse,
                this.StikUse,
                this.SenyUse,
                this.DetUse,
                this.WarUse,
                this.DrgUse,
                this.AGRUse,
                this.ChopUse,
                this.VSATUse,
                this.DrnUse,
                this.EMPUse,
                this.WathUse,
                this.LodsUse,
                this.VTOLUse,
                this.K9Use,
                this.SwrUse
            };
            this.StreaksOth = new NumericUpDown[]
            {
                this.UAVOth,
                this.RXOth,
                this.HtOth,
                this.CPacOth,
                this.CoutOth,
                this.GdiOth,
                this.MisOth,
                this.StikOth,
                this.SenyOth,
                this.DetOth,
                this.WarOth,
                this.DrgOth,
                this.AGROth,
                this.ChopOth,
                this.VSATOth,
                this.DrnOth,
                this.EMPOth,
                this.WathOth,
                this.LodsOth,
                this.VTOLOth,
                this.K9Oth,
                this.SwrOth
            };
            this.StreaksCheck = new CheckBox[]
            {
                this.UAVCheck,
                this.RXCheck,
                this.HtCheck,
                this.CPacCheck,
                this.CoutCheck,
                this.GdiCheck,
                this.MisCheck,
                this.StikCheck,
                this.SenyCheck,
                this.DetCheck,
                this.WarCheck,
                this.DrgCheck,
                this.AGRCheck,
                this.ChopCheck,
                this.VSATCheck,
                this.DrnCheck,
                this.EMPCheck,
                this.WathCheck,
                this.LodsCheck,
                this.VTOLCheck,
                this.K9Check,
                this.SwrCheck
            };
            this.WeapKill = new NumericUpDown[]
            {
                this.KAPKs,
                this.TacKs,
                this.B23RKs,
                this.ExeKs,
                this.FivesKs,
                this.MP7Ks,
                this.EVOKs,
                this.PDWKs,
                this.CQBKs,
                this.MSMCKs,
                this.K10Ks,
                this.PeaceKs,
                this.M8A1Ks,
                this.SCARKs,
                this.ANKs,
                this.SWATKs,
                this.TypeKs,
                this.FALKs,
                this.SMRKs,
                this.M27Ks,
                this.MTARKs,
                this.MK48Ks,
                this.QBBKs,
                this.LSATKs,
                this.HAMRKs,
                this.BallistaKs,
                this.SVUKs,
                this.DSRKs,
                this.XPRKs,
                this.R870Ks,
                this.M1216Ks,
                this.S12Ks,
                this.KSGKs,
                this.SMAWKs,
                this.FHJKs,
                this.RPGKs,
                this.ShieldKs,
                this.BowKs,
                this.BallKnifeKs
            };
            this.WeapDeath = new NumericUpDown[]
            {
                this.KAPDe,
                this.TacDe,
                this.B23RDe,
                this.ExeDe,
                this.FivesDe,
                this.MP7De,
                this.EVODe,
                this.PDWDe,
                this.CQBDe,
                this.MSMCDe,
                this.K10De,
                this.PeaceDe,
                this.M8A1De,
                this.SCARDe,
                this.ANDe,
                this.SWATDe,
                this.TypeDe,
                this.FALDe,
                this.SMRDe,
                this.M27De,
                this.MTARDe,
                this.MK48De,
                this.QBBDe,
                this.LSATDe,
                this.HAMRDe,
                this.BallistaDe,
                this.SVUDe,
                this.DSRDe,
                this.XPRDe,
                this.R870De,
                this.M1216De,
                this.S12De,
                this.KSGDe,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.ShieldDe,
                this.BowDe,
                this.BallKnifeDe
            };
            this.WeapHead = new NumericUpDown[]
            {
                this.KAPHd,
                this.TacHd,
                this.B23RHd,
                this.ExeHd,
                this.FivesHd,
                this.MP7Hd,
                this.EVOHd,
                this.PDWHd,
                this.CQBHd,
                this.MSMCHd,
                this.K10Hd,
                this.PeaceHd,
                this.M8A1Hd,
                this.SCARHd,
                this.ANHd,
                this.SWATHd,
                this.TypeHd,
                this.FALHd,
                this.SMRHd,
                this.M27Hd,
                this.MTARHd,
                this.MK48Hd,
                this.QBBHd,
                this.LSATHd,
                this.HAMRHd,
                this.BallistaHd,
                this.SVUHd,
                this.DSRHd,
                this.XPRHd,
                this.R870Hd,
                this.M1216Hd,
                this.S12Hd,
                this.KSGHd,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.BallKnifeHd
            };
            this.WeapAccy = new NumericUpDown[]
            {
                this.KAPAc,
                this.TacAc,
                this.B23RAc,
                this.ExeAc,
                this.FivesAc,
                this.MP7Ac,
                this.EVOAc,
                this.PDWAc,
                this.CQBAc,
                this.MSMCAc,
                this.K10Ac,
                this.PeaceAc,
                this.M8A1Ac,
                this.SCARAc,
                this.ANAc,
                this.SWATAc,
                this.TypeAc,
                this.FALAc,
                this.SMRAc,
                this.M27Ac,
                this.MTARAc,
                this.MK48Ac,
                this.QBBAc,
                this.LSATAc,
                this.HAMRAc,
                this.BallistaAc,
                this.SVUAc,
                this.DSRAc,
                this.XPRAc,
                this.R870Ac,
                this.M1216Ac,
                this.S12Ac,
                this.KSGAc,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.EmptyNum,
                this.BowAc,
                this.BallKnifeAc
            };
            this.WeapCheck = new CheckBox[]
            {
                this.KAPCheck,
                this.TacCheck,
                this.B23RCheck,
                this.ExeCheck,
                this.FivesCheck,
                this.MP7Check,
                this.EVOCheck,
                this.PDWCheck,
                this.CQBCheck,
                this.MSMCCheck,
                this.K10Check,
                this.PeaceCheck,
                this.M8A1Check,
                this.SCARCheck,
                this.ANCheck,
                this.SWATCheck,
                this.TypeCheck,
                this.FALCheck,
                this.SMRCheck,
                this.M27Check,
                this.MTARCheck,
                this.MK48Check,
                this.QBBCheck,
                this.LSATCheck,
                this.HAMRCheck,
                this.BallistaCheck,
                this.SVUCheck,
                this.DSRCheck,
                this.XPRCheck,
                this.R870Check,
                this.M1216Check,
                this.S12Check,
                this.KSGCheck,
                this.SMAWCheck,
                this.FHJCheck,
                this.RPGCheck,
                this.ShieldCheck,
                this.BowCheck,
                this.BallKnifeCheck
            };
            this.GamesWin = new NumericUpDown[]
            {
                this.TDMWin,
                this.FreeForAllWin,
                this.SDWin,
                this.DominationWin,
                this.HardpointWin,
                this.HeadquartersWin,
                this.DemolitionWin,
                this.CTFWin,
                this.KillConfirmedWin,
                this.GunGameWin,
                this.OneintheChamberWin,
                this.SharpshooterWin,
                this.SticksandStonesWin,
                this.HCTDMWin,
                this.HCSDWin,
                this.HCDominationWin,
                this.HCKillConfirmedWin
            };
            this.GamesLos = new NumericUpDown[]
            {
                this.TDMLos,
                this.FreeForAllLos,
                this.SDLos,
                this.DominationLos,
                this.HardpointLos,
                this.HeadquartersLos,
                this.DemolitionLos,
                this.CTFLos,
                this.KillConfirmedLos,
                this.GunGameLos,
                this.OneintheChamberLos,
                this.SharpshooterLos,
                this.SticksandStonesLos,
                this.HCTDMLos,
                this.HCSDLos,
                this.HCDominationLos,
                this.HCKillConfirmedLos
            };
            this.GamesCur = new NumericUpDown[]
            {
                this.TDMCur,
                this.FreeForAllCur,
                this.SDCur,
                this.DominationCur,
                this.HardpointCur,
                this.HeadquartersCur,
                this.DemolitionCur,
                this.CTFCur,
                this.KillConfirmedCur,
                this.GunGameCur,
                this.OneintheChamberCur,
                this.SharpshooterCur,
                this.SticksandStonesCur,
                this.HCTDMCur,
                this.HCSDCur,
                this.HCDominationCur,
                this.HCKillConfirmedCur
            };
            this.GamesBes = new NumericUpDown[]
            {
                this.TDMBes,
                this.FreeForAllBes,
                this.SDBes,
                this.DominationBes,
                this.HardpointBes,
                this.HeadquartersBes,
                this.DemolitionBes,
                this.CTFBes,
                this.KillConfirmedBes,
                this.GunGameBes,
                this.OneintheChamberBes,
                this.SharpshooterBes,
                this.SticksandStonesBes,
                this.HCTDMBes,
                this.HCSDBes,
                this.HCDominationBes,
                this.HCKillConfirmedBes
            };
            this.GamesCheck = new CheckBox[]
            {
                this.TDMCheck,
                this.FreeForAllCheck,
                this.SDCheck,
                this.DominationCheck,
                this.HardpointCheck,
                this.HeadquartersCheck,
                this.DemolitionCheck,
                this.CTFCheck,
                this.KillConfirmedCheck,
                this.GunGameCheck,
                this.OneintheChamberCheck,
                this.SharpshooterCheck,
                this.SticksandStonesCheck,
                this.HCTDMCheck,
                this.HCSDCheck,
                this.HCDominationCheck,
                this.HCKillConfirmedCheck
            };
            this.EqutUse = new NumericUpDown[]
            {
                this.GrenadeUse,
                this.CombatAxeUse,
                this.SemtexUse,
                this.C4Use,
                this.BouncingBettyUse,
                this.ClaymoreUse,
                this.SmokeGrenadeUse,
                this.ConcussionUse,
                this.EMPGrenadeUse,
                this.SensorGrenadeUse,
                this.FlashbangUse,
                this.ShockChargeUse,
                this.BlackHatUse,
                this.TacticalInsertionUse,
                this.TrophySystemUse
            };
            this.EqutOth = new NumericUpDown[]
            {
                this.GrenadeOth,
                this.CombatAxeOth,
                this.SemtexOth,
                this.C4Oth,
                this.BouncingBettyOth,
                this.ClaymoreOth,
                this.SmokeGrenadeOth,
                this.ConcussionOth,
                this.EMPGrenadeOth,
                this.SensorGrenadeOth,
                this.FlashbangOth,
                this.ShockChargeOth,
                this.BlackHatOth,
                this.TacticalInsertionOth,
                this.TrophySystemOth
            };
            this.EqutCheck = new CheckBox[]
            {
                this.GrenadeCheck,
                this.CombatAxeCheck,
                this.SemtexCheck,
                this.C4Check,
                this.BouncingBettyCheck,
                this.ClaymoreCheck,
                this.SmokeGrenadeCheck,
                this.ConcussionCheck,
                this.EMPGrenadeCheck,
                this.SensorGrenadeCheck,
                this.FlashbangCheck,
                this.ShockChargeCheck,
                this.BlackHatCheck,
                this.TacticalInsertionCheck,
                this.TrophySystemCheck
            };
            this.MedalsNum = new NumericUpDown[]
            {
                this.Bouncer,
                this.AssistedSuicide,
                this.BackStabber,
                this.Skewered,
                this.Bomber,
                this.Bankshot,
                this.Hijacker,
                this.Wipeout,
                this.Comeback,
                this.StrengthandHonor,
                this.Deadeye,
                this.Decimated,
                this.Clutch1,
                this.Hero,
                this.Clutch2,
                this.DroneHunter,
                this.Fuzzbuster,
                this.ShadowCatcher,
                this.Demolished,
                this.BigGameHunter,
                this.BurnOut,
                this.Rejected,
                this.Exterminator,
                this.TKO,
                this.Flyswatter,
                this.RoadRage,
                this.Intercepted,
                this.Uppercut,
                this.Scrapped,
                this.Hogtied,
                this.NoTip,
                this.Blackout,
                this.Warbeast,
                this.Elimination1,
                this.Elimination2,
                this.LastManStanding,
                this.FirstBlood,
                this.Playmaker,
                this.CloseCall,
                this.Hacked,
                this.ChoppedUp,
                this.Headshot,
                this.SilentKiller,
                this.Wingman,
                this.DeathFromAbove,
                this.Secure1,
                this.Humiliation,
                this.CleanUp,
                this.Efficiency,
                this.Afterlife,
                this.Savior,
                this.OneShotOneKill,
                this.Dropshot,
                this.Survivor,
                this.Aggression,
                this.Avenger,
                this.Pancake,
                this.BaitTaken,
                this.Underdog,
                this.Backfire,
                this.Takedown1,
                this.Gunslinger,
                this.Regicide1,
                this.Bankrupted,
                this.SwitchHitter,
                this.ComboBreaker,
                this.Denied1,
                this.Takedown2,
                this.Denied2,
                this.Merciless,
                this.Ruthless,
                this.Relentless,
                this.Brutal,
                this.Nuclear,
                this.Bloodthirsty,
                this.Unstoppable,
                this.Regicide2,
                this.Frugal,
                this.HardpointSecure,
                this.LongShot,
                this.ShieldBash,
                this.Cooked,
                this.Bullseye,
                this.FallingSkies,
                this.GunExpert,
                this.DoubleKill,
                this.TripleKill,
                this.FuryKill,
                this.FrenzyKill,
                this.SuperKill,
                this.MegaKill,
                this.UltraKill,
                this.KillChain,
                this.Boomstick,
                this.OpeningMove,
                this.StrikeDelivered,
                this.Secure2,
                this.RedBaron,
                this.ForwardPosition,
                this.Kaboom,
                this.RainingDeath,
                this.DistantThunder,
                this.Retrieved,
                this.Revenge,
                this.Crackdown,
                this.SharedAGR,
                this.SharedCounterUAV,
                this.SharedDeathMachine,
                this.SharedK9Unit,
                this.SharedEMPSystems,
                this.SharedStealthChopper,
                this.SharedEscortDrone,
                this.SharedVTOLWarship,
                this.SharedGuardian,
                this.SharedHunterKiller,
                this.SharedSwarm,
                this.SharedWarMachine,
                this.SharedLightningStrike,
                this.SharedDragonfire,
                this.SharedRCXD,
                this.SharedHellstormMissile,
                this.SharedLodestar,
                this.SharedOrbitalVSAT,
                this.SharedSentryGun,
                this.SharedWarthog,
                this.SharedUAV,
                this.Stick,
                this.BuzzKill,
                this.Cropduster,
                this.QuadFeed,
                this.Victor,
                this.DoubleDown
            };
            this.MedalsCheck = new CheckBox[]
            {
                this.BouncerCheck,
                this.AssistedSuicideCheck,
                this.BackStabberCheck,
                this.SkeweredCheck,
                this.BomberCheck,
                this.BankshotCheck,
                this.HijackerCheck,
                this.WipeoutCheck,
                this.ComebackCheck,
                this.StrengthandHonorCheck,
                this.DeadeyeCheck,
                this.DecimatedCheck,
                this.Clutch1Check,
                this.HeroCheck,
                this.Clutch2Check,
                this.DroneHunterCheck,
                this.FuzzbusterCheck,
                this.ShadowCatcherCheck,
                this.DemolishedCheck,
                this.BigGameHunterCheck,
                this.BurnOutCheck,
                this.RejectedCheck,
                this.ExterminatorCheck,
                this.TKOCheck,
                this.FlyswatterCheck,
                this.RoadRageCheck,
                this.InterceptedCheck,
                this.UppercutCheck,
                this.ScrappedCheck,
                this.HogtiedCheck,
                this.NoTipCheck,
                this.BlackoutCheck,
                this.WarbeastCheck,
                this.Elimination1Check,
                this.Elimination2Check,
                this.LastManStandingCheck,
                this.FirstBloodCheck,
                this.PlaymakerCheck,
                this.CloseCallCheck,
                this.HackedCheck,
                this.ChoppedUpCheck,
                this.HeadshotCheck,
                this.SilentKillerCheck,
                this.WingmanCheck,
                this.DeathFromAboveCheck,
                this.Secure1Check,
                this.HumiliationCheck,
                this.CleanUpCheck,
                this.EfficiencyCheck,
                this.AfterlifeCheck,
                this.SaviorCheck,
                this.OneShotOneKillCheck,
                this.DropshotCheck,
                this.SurvivorCheck,
                this.AggressionCheck,
                this.AvengerCheck,
                this.PancakeCheck,
                this.BaitTakenCheck,
                this.UnderdogCheck,
                this.BackfireCheck,
                this.Takedown1Check,
                this.GunslingerCheck,
                this.Regicide1Check,
                this.BankruptedCheck,
                this.SwitchHitterCheck,
                this.ComboBreakerCheck,
                this.Denied1Check,
                this.Takedown2Check,
                this.Denied2Check,
                this.MercilessCheck,
                this.RuthlessCheck,
                this.RelentlessCheck,
                this.BrutalCheck,
                this.NuclearCheck,
                this.BloodthirstyCheck,
                this.UnstoppableCheck,
                this.Regicide2Check,
                this.FrugalCheck,
                this.HardpointSecureCheck,
                this.LongShotCheck,
                this.ShieldBashCheck,
                this.CookedCheck,
                this.BullseyeCheck,
                this.FallingSkiesCheck,
                this.GunExpertCheck,
                this.DoubleKillCheck,
                this.TripleKillCheck,
                this.FuryKillCheck,
                this.FrenzyKillCheck,
                this.SuperKillCheck,
                this.MegaKillCheck,
                this.UltraKillCheck,
                this.KillChainCheck,
                this.BoomstickCheck,
                this.OpeningMoveCheck,
                this.StrikeDeliveredCheck,
                this.Secure2Check,
                this.RedBaronCheck,
                this.ForwardPositionCheck,
                this.KaboomCheck,
                this.RainingDeathCheck,
                this.DistantThunderCheck,
                this.RetrievedCheck,
                this.RevengeCheck,
                this.CrackdownCheck,
                this.SharedAGRCheck,
                this.SharedCounterUAVCheck,
                this.SharedDeathMachineCheck,
                this.SharedK9UnitCheck,
                this.SharedEMPSystemsCheck,
                this.SharedStealthChopperCheck,
                this.SharedEscortDroneCheck,
                this.SharedVTOLWarshipCheck,
                this.SharedGuardianCheck,
                this.SharedHunterKillerCheck,
                this.SharedSwarmCheck,
                this.SharedWarMachineCheck,
                this.SharedLightningStrikeCheck,
                this.SharedDragonfireCheck,
                this.SharedRCXDCheck,
                this.SharedHellstormMissileCheck,
                this.SharedLodestarCheck,
                this.SharedOrbitalVSATCheck,
                this.SharedSentryGunCheck,
                this.SharedWarthogCheck,
                this.SharedUAVCheck,
                this.StickCheck,
                this.BuzzKillCheck,
                this.CropdusterCheck,
                this.QuadFeedCheck,
                this.VictorCheck,
                this.DoubleDownCheck
            };
            label113.Visible = false;
            PS3.ConnectTarget();
            PS3.AttachProcess();
            this.LoadStreaks();
            this.LoadWeapons();
            this.LoadGames();
            this.LoadMedals();
            this.LoadEuit();
        }


        private void HCTDMWin_ValueChanged(object sender, EventArgs e)
        {
            this.HCTDMWL.Text = this.GetRatio(this.HCTDMWin.Value, this.HCTDMLos.Value);
        }

        private void HCTDMLos_ValueChanged(object sender, EventArgs e)
        {
            this.HCTDMWL.Text = this.GetRatio(this.HCTDMWin.Value, this.HCTDMLos.Value);
        }

        private void HCSDWin_ValueChanged(object sender, EventArgs e)
        {
            this.HCSDWL.Text = this.GetRatio(this.HCSDWin.Value, this.HCSDLos.Value);
        }

        private void HCSDLos_ValueChanged(object sender, EventArgs e)
        {
            this.HCSDWL.Text = this.GetRatio(this.HCSDWin.Value, this.HCSDLos.Value);
        }

        private void HCKillConfirmedWin_ValueChanged(object sender, EventArgs e)
        {
            this.HCKillConfirmedWL.Text = this.GetRatio(this.HCKillConfirmedWin.Value, this.HCKillConfirmedLos.Value);
        }

        private void HCKillConfirmedLos_ValueChanged(object sender, EventArgs e)
        {
            this.HCKillConfirmedWL.Text = this.GetRatio(this.HCKillConfirmedWin.Value, this.HCKillConfirmedLos.Value);
        }

        private void HCDominationWin_ValueChanged(object sender, EventArgs e)
        {
            this.HCDominationWL.Text = this.GetRatio(this.HCDominationWin.Value, this.HCDominationLos.Value);
        }

        private void HCDominationLos_ValueChanged(object sender, EventArgs e)
        {
            this.HCDominationWL.Text = this.GetRatio(this.HCDominationWin.Value, this.HCDominationLos.Value);
        }

        private void GunGameWin_ValueChanged(object sender, EventArgs e)
        {
            this.GunGameWL.Text = this.GetRatio(this.GunGameWin.Value, this.GunGameLos.Value);
        }

        private void GunGameLos_ValueChanged(object sender, EventArgs e)
        {
            this.GunGameWL.Text = this.GetRatio(this.GunGameWin.Value, this.GunGameLos.Value);
        }

        private void OneintheChamberWin_ValueChanged(object sender, EventArgs e)
        {
            this.OneintheChamberWL.Text = this.GetRatio(this.OneintheChamberWin.Value, this.OneintheChamberLos.Value);
        }

        private void OneintheChamberLos_ValueChanged(object sender, EventArgs e)
        {
            this.OneintheChamberWL.Text = this.GetRatio(this.OneintheChamberWin.Value, this.OneintheChamberLos.Value);
        }

        private void SharpshooterWin_ValueChanged(object sender, EventArgs e)
        {
            this.SharpshooterWL.Text = this.GetRatio(this.SharpshooterWin.Value, this.SharpshooterLos.Value);
        }

        private void SharpshooterLos_ValueChanged(object sender, EventArgs e)
        {
            this.SharpshooterWL.Text = this.GetRatio(this.SharpshooterWin.Value, this.SharpshooterLos.Value);
        }

        private void SticksandStonesWin_ValueChanged(object sender, EventArgs e)
        {
            this.SticksandStonesWL.Text = this.GetRatio(this.SticksandStonesWin.Value, this.SticksandStonesLos.Value);
        }

        private void SticksandStonesLos_ValueChanged(object sender, EventArgs e)
        {
            this.SticksandStonesWL.Text = this.GetRatio(this.SticksandStonesWin.Value, this.SticksandStonesLos.Value);
        }

        private void MTARKs_ValueChanged(object sender, EventArgs e)
        {
            this.MTARKD.Text = this.GetRatio(this.MTARKs.Value, this.MTARDe.Value);
        }

        private void MTARDe_ValueChanged(object sender, EventArgs e)
        {
            this.MTARKD.Text = this.GetRatio(this.MTARKs.Value, this.MTARDe.Value);
        }

        private void TypeKs_ValueChanged(object sender, EventArgs e)
        {
            this.TypeKD.Text = this.GetRatio(this.TypeKs.Value, this.TypeDe.Value);
        }

        private void TypeDe_ValueChanged(object sender, EventArgs e)
        {
            this.TypeKD.Text = this.GetRatio(this.TypeKs.Value, this.TypeDe.Value);
        }

        private void SWATKs_ValueChanged(object sender, EventArgs e)
        {
            this.SWATKD.Text = this.GetRatio(this.SWATKs.Value, this.SWATDe.Value);
        }

        private void SWATDe_ValueChanged(object sender, EventArgs e)
        {
            this.SWATKD.Text = this.GetRatio(this.SWATKs.Value, this.SWATDe.Value);
        }

        private void FALKs_ValueChanged(object sender, EventArgs e)
        {
            this.FALKD.Text = this.GetRatio(this.FALKs.Value, this.FALDe.Value);
        }

        private void FALDe_ValueChanged(object sender, EventArgs e)
        {
            this.FALKD.Text = this.GetRatio(this.FALKs.Value, this.FALDe.Value);
        }

        private void M27Ks_ValueChanged(object sender, EventArgs e)
        {
            this.M27KD.Text = this.GetRatio(this.M27Ks.Value, this.M27De.Value);
        }

        private void M27De_ValueChanged(object sender, EventArgs e)
        {
            this.M27KD.Text = this.GetRatio(this.M27Ks.Value, this.M27De.Value);
        }

        private void SCARKs_ValueChanged(object sender, EventArgs e)
        {
            this.SCARKD.Text = this.GetRatio(this.SCARKs.Value, this.SCARDe.Value);
        }

        private void SCARDe_ValueChanged(object sender, EventArgs e)
        {
            this.SCARKD.Text = this.GetRatio(this.SCARKs.Value, this.SCARDe.Value);
        }

        private void SMRKs_ValueChanged(object sender, EventArgs e)
        {
            this.SMRKD.Text = this.GetRatio(this.SMRKs.Value, this.SMRDe.Value);
        }

        private void SMRDe_ValueChanged(object sender, EventArgs e)
        {
            this.SMRKD.Text = this.GetRatio(this.SMRKs.Value, this.SMRDe.Value);
        }

        private void M8A1Ks_ValueChanged(object sender, EventArgs e)
        {
            this.M8A1KD.Text = this.GetRatio(this.M8A1Ks.Value, this.M8A1De.Value);
        }

        private void M8A1De_ValueChanged(object sender, EventArgs e)
        {
            this.M8A1KD.Text = this.GetRatio(this.M8A1Ks.Value, this.M8A1De.Value);
        }

        private void ANKs_ValueChanged(object sender, EventArgs e)
        {
            this.ANKD.Text = this.GetRatio(this.ANKs.Value, this.ANDe.Value);
        }

        private void ANDe_ValueChanged(object sender, EventArgs e)
        {
            this.ANKD.Text = this.GetRatio(this.ANKs.Value, this.ANDe.Value);
        }

        private void AssaultAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AssaultAll.Checked)
            {
                this.MTARCheck.Checked = true;
                this.TypeCheck.Checked = true;
                this.SWATCheck.Checked = true;
                this.FALCheck.Checked = true;
                this.M27Check.Checked = true;
                this.SCARCheck.Checked = true;
                this.SMRCheck.Checked = true;
                this.M8A1Check.Checked = true;
                this.ANCheck.Checked = true;
            }
            else
            {
                this.MTARCheck.Checked = false;
                this.TypeCheck.Checked = false;
                this.SWATCheck.Checked = false;
                this.FALCheck.Checked = false;
                this.M27Check.Checked = false;
                this.SCARCheck.Checked = false;
                this.SMRCheck.Checked = false;
                this.M8A1Check.Checked = false;
                this.ANCheck.Checked = false;
            }
        }

        private void MP7Ks_ValueChanged(object sender, EventArgs e)
        {
            this.MP7KD.Text = this.GetRatio(this.MP7Ks.Value, this.MP7De.Value);
        }

        private void MP7De_ValueChanged(object sender, EventArgs e)
        {
            this.MP7KD.Text = this.GetRatio(this.MP7Ks.Value, this.MP7De.Value);
        }

        private void PDWKs_ValueChanged(object sender, EventArgs e)
        {
            this.PDWKD.Text = this.GetRatio(this.PDWKs.Value, this.PDWDe.Value);
        }

        private void PDWDe_ValueChanged(object sender, EventArgs e)
        {
            this.PDWKD.Text = this.GetRatio(this.PDWKs.Value, this.PDWDe.Value);
        }

        private void K10Ks_ValueChanged(object sender, EventArgs e)
        {
            this.K10KD.Text = this.GetRatio(this.K10Ks.Value, this.K10De.Value);
        }

        private void K10De_ValueChanged(object sender, EventArgs e)
        {
            this.K10KD.Text = this.GetRatio(this.K10Ks.Value, this.K10De.Value);
        }

        private void MSMCKs_ValueChanged(object sender, EventArgs e)
        {
            this.MSMCKD.Text = this.GetRatio(this.MSMCKs.Value, this.MSMCDe.Value);
        }

        private void MSMCDe_ValueChanged(object sender, EventArgs e)
        {
            this.MSMCKD.Text = this.GetRatio(this.MSMCKs.Value, this.MSMCDe.Value);
        }

        private void CQBKs_ValueChanged(object sender, EventArgs e)
        {
            this.CQBKD.Text = this.GetRatio(this.CQBKs.Value, this.CQBDe.Value);
        }

        private void CQBDe_ValueChanged(object sender, EventArgs e)
        {
            this.CQBKD.Text = this.GetRatio(this.CQBKs.Value, this.CQBDe.Value);
        }

        private void EVOKs_ValueChanged(object sender, EventArgs e)
        {
            this.EVOKD.Text = this.GetRatio(this.EVOKs.Value, this.EVODe.Value);
        }

        private void EVODe_ValueChanged(object sender, EventArgs e)
        {
            this.EVOKD.Text = this.GetRatio(this.EVOKs.Value, this.EVODe.Value);
        }

        private void PeaceKs_ValueChanged(object sender, EventArgs e)
        {
            this.PeaceKD.Text = this.GetRatio(this.PeaceKs.Value, this.PeaceDe.Value);
        }

        private void PeaceDe_ValueChanged(object sender, EventArgs e)
        {
            this.PeaceKD.Text = this.GetRatio(this.PeaceKs.Value, this.PeaceDe.Value);
        }

        private void SMGAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SMGAll.Checked)
            {
                this.MP7Check.Checked = true;
                this.PDWCheck.Checked = true;
                this.K10Check.Checked = true;
                this.MSMCCheck.Checked = true;
                this.CQBCheck.Checked = true;
                this.EVOCheck.Checked = true;
                this.PeaceCheck.Checked = true;
            }
            else
            {
                this.MP7Check.Checked = false;
                this.PDWCheck.Checked = false;
                this.K10Check.Checked = false;
                this.MSMCCheck.Checked = false;
                this.CQBCheck.Checked = false;
                this.EVOCheck.Checked = false;
                this.PeaceCheck.Checked = false;
            }
        }

        private void MK48Ks_ValueChanged(object sender, EventArgs e)
        {
            this.MK48KD.Text = this.GetRatio(this.MK48Ks.Value, this.MK48De.Value);
        }

        private void MK48De_ValueChanged(object sender, EventArgs e)
        {
            this.MK48KD.Text = this.GetRatio(this.MK48Ks.Value, this.MK48De.Value);
        }

        private void QBBKs_ValueChanged(object sender, EventArgs e)
        {
            this.QBBKD.Text = this.GetRatio(this.QBBKs.Value, this.QBBDe.Value);
        }

        private void QBBDe_ValueChanged(object sender, EventArgs e)
        {
            this.QBBKD.Text = this.GetRatio(this.QBBKs.Value, this.QBBDe.Value);
        }

        private void LSATKs_ValueChanged(object sender, EventArgs e)
        {
            this.LSATKD.Text = this.GetRatio(this.LSATKs.Value, this.LSATDe.Value);
        }

        private void LSATDe_ValueChanged(object sender, EventArgs e)
        {
            this.LSATKD.Text = this.GetRatio(this.LSATKs.Value, this.LSATDe.Value);
        }

        private void HAMRKs_ValueChanged(object sender, EventArgs e)
        {
            this.HAMRKD.Text = this.GetRatio(this.HAMRKs.Value, this.HAMRDe.Value);
        }

        private void HAMRDe_ValueChanged(object sender, EventArgs e)
        {
            this.HAMRKD.Text = this.GetRatio(this.HAMRKs.Value, this.HAMRDe.Value);
        }

        private void R870Ks_ValueChanged(object sender, EventArgs e)
        {
            this.R870KD.Text = this.GetRatio(this.R870Ks.Value, this.R870De.Value);
        }

        private void R870De_ValueChanged(object sender, EventArgs e)
        {
            this.R870KD.Text = this.GetRatio(this.R870Ks.Value, this.R870De.Value);
        }

        private void S12Ks_ValueChanged(object sender, EventArgs e)
        {
            this.S12KD.Text = this.GetRatio(this.S12Ks.Value, this.S12De.Value);
        }

        private void S12De_ValueChanged(object sender, EventArgs e)
        {
            this.S12KD.Text = this.GetRatio(this.S12Ks.Value, this.S12De.Value);
        }

        private void KSGKs_ValueChanged(object sender, EventArgs e)
        {
            this.KSGKD.Text = this.GetRatio(this.KSGKs.Value, this.KSGDe.Value);
        }

        private void KSGDe_ValueChanged(object sender, EventArgs e)
        {
            this.KSGKD.Text = this.GetRatio(this.KSGKs.Value, this.KSGDe.Value);
        }

        private void M1216Ks_ValueChanged(object sender, EventArgs e)
        {
            this.M1216KD.Text = this.GetRatio(this.M1216Ks.Value, this.M1216De.Value);
        }

        private void M1216De_ValueChanged(object sender, EventArgs e)
        {
            this.M1216KD.Text = this.GetRatio(this.M1216Ks.Value, this.M1216De.Value);
        }

        private void SVUKs_ValueChanged(object sender, EventArgs e)
        {
            this.SVUKD.Text = this.GetRatio(this.SVUKs.Value, this.SVUDe.Value);
        }

        private void SVUDe_ValueChanged(object sender, EventArgs e)
        {
            this.SVUKD.Text = this.GetRatio(this.SVUKs.Value, this.SVUDe.Value);
        }

        private void DSRKs_ValueChanged(object sender, EventArgs e)
        {
            this.DSRKD.Text = this.GetRatio(this.DSRKs.Value, this.DSRDe.Value);
        }

        private void DSRDe_ValueChanged(object sender, EventArgs e)
        {
            this.DSRKD.Text = this.GetRatio(this.DSRKs.Value, this.DSRDe.Value);
        }

        private void BallistaKs_ValueChanged(object sender, EventArgs e)
        {
            this.BallistaKD.Text = this.GetRatio(this.BallistaKs.Value, this.BallistaDe.Value);
        }

        private void BallistaDe_ValueChanged(object sender, EventArgs e)
        {
            this.BallistaKD.Text = this.GetRatio(this.BallistaKs.Value, this.BallistaDe.Value);
        }

        private void XPRKs_ValueChanged(object sender, EventArgs e)
        {
            this.XPRKD.Text = this.GetRatio(this.XPRKs.Value, this.XPRDe.Value);
        }

        private void XPRDe_ValueChanged(object sender, EventArgs e)
        {
            this.XPRKD.Text = this.GetRatio(this.XPRKs.Value, this.XPRDe.Value);
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void SniperAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SniperAll.Checked)
            {
                this.SVUCheck.Checked = true;
                this.DSRCheck.Checked = true;
                this.BallistaCheck.Checked = true;
                this.XPRCheck.Checked = true;
            }
            else
            {
                this.SVUCheck.Checked = false;
                this.DSRCheck.Checked = false;
                this.BallistaCheck.Checked = false;
                this.XPRCheck.Checked = false;
            }
        }

        private void FivesKs_ValueChanged(object sender, EventArgs e)
        {
            this.FivesKD.Text = this.GetRatio(this.FivesKs.Value, this.FivesDe.Value);
        }

        private void FivesDe_ValueChanged(object sender, EventArgs e)
        {
            this.FivesKD.Text = this.GetRatio(this.FivesKs.Value, this.FivesDe.Value);
        }

        private void TacKs_ValueChanged(object sender, EventArgs e)
        {
            this.TacKD.Text = this.GetRatio(this.TacKs.Value, this.TacDe.Value);
        }

        private void TacDe_ValueChanged(object sender, EventArgs e)
        {
            this.TacKD.Text = this.GetRatio(this.TacKs.Value, this.TacDe.Value);
        }

        private void B23RKs_ValueChanged(object sender, EventArgs e)
        {
            this.B23RKD.Text = this.GetRatio(this.B23RKs.Value, this.B23RDe.Value);
        }

        private void B23RDe_ValueChanged(object sender, EventArgs e)
        {
            this.B23RKD.Text = this.GetRatio(this.B23RKs.Value, this.B23RDe.Value);
        }

        private void ExeKs_ValueChanged(object sender, EventArgs e)
        {
            this.ExeKD.Text = this.GetRatio(this.ExeKs.Value, this.ExeDe.Value);
        }

        private void ExeDe_ValueChanged(object sender, EventArgs e)
        {
            this.ExeKD.Text = this.GetRatio(this.ExeKs.Value, this.ExeDe.Value);
        }

        private void KAPKs_ValueChanged(object sender, EventArgs e)
        {
            this.KAPKD.Text = this.GetRatio(this.KAPKs.Value, this.KAPDe.Value);
        }

        private void KAPDe_ValueChanged(object sender, EventArgs e)
        {
            this.KAPKD.Text = this.GetRatio(this.KAPKs.Value, this.KAPDe.Value);
        }

        private void PistolsAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.PistolsAll.Checked)
            {
                this.FivesCheck.Checked = true;
                this.TacCheck.Checked = true;
                this.B23RCheck.Checked = true;
                this.ExeCheck.Checked = true;
                this.KAPCheck.Checked = true;
            }
            else
            {
                this.FivesCheck.Checked = false;
                this.TacCheck.Checked = false;
                this.B23RCheck.Checked = false;
                this.ExeCheck.Checked = false;
                this.KAPCheck.Checked = false;
            }
        }

        private void LaunchersAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LaunchersAll.Checked)
            {
                this.SMAWCheck.Checked = true;
                this.FHJCheck.Checked = true;
                this.RPGCheck.Checked = true;
            }
            else
            {
                this.SMAWCheck.Checked = false;
                this.FHJCheck.Checked = false;
                this.RPGCheck.Checked = false;
            }
        }

        private void ShieldKs_ValueChanged(object sender, EventArgs e)
        {
            this.ShieldKD.Text = this.GetRatio(this.ShieldKs.Value, this.ShieldDe.Value);
        }

        private void ShieldDe_ValueChanged(object sender, EventArgs e)
        {
            this.ShieldKD.Text = this.GetRatio(this.ShieldKs.Value, this.ShieldDe.Value);
        }

        private void BowKs_ValueChanged(object sender, EventArgs e)
        {
            this.BowKD.Text = this.GetRatio(this.BowKs.Value, this.BowDe.Value);
        }

        private void BowDe_ValueChanged(object sender, EventArgs e)
        {
            this.BowKD.Text = this.GetRatio(this.BowKs.Value, this.BowDe.Value);
        }

        private void BallKnifeKs_ValueChanged(object sender, EventArgs e)
        {
            this.BallKnifeKD.Text = this.GetRatio(this.BallKnifeKs.Value, this.BallKnifeDe.Value);
        }

        private void BallKnifeDe_ValueChanged(object sender, EventArgs e)
        {
            this.BallKnifeKD.Text = this.GetRatio(this.BallKnifeKs.Value, this.BallKnifeDe.Value);
        }

        private void SpecialsAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SpecialsAll.Checked)
            {
                this.ShieldCheck.Checked = true;
                this.BowCheck.Checked = true;
                this.BallKnifeCheck.Checked = true;
            }
            else
            {
                this.ShieldCheck.Checked = false;
                this.BowCheck.Checked = false;
                this.BallKnifeCheck.Checked = false;
            }
        }

        private void HCCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.HCCheckAll.Checked)
            {
                this.HCTDMCheck.Checked = true;
                this.HCSDCheck.Checked = true;
                this.HCKillConfirmedCheck.Checked = true;
                this.HCDominationCheck.Checked = true;
                this.GunGameCheck.Checked = true;
                this.OneintheChamberCheck.Checked = true;
                this.SharpshooterCheck.Checked = true;
                this.SticksandStonesCheck.Checked = true;
            }
            else
            {
                this.HCTDMCheck.Checked = false;
                this.HCSDCheck.Checked = false;
                this.HCKillConfirmedCheck.Checked = false;
                this.HCDominationCheck.Checked = false;
                this.GunGameCheck.Checked = false;
                this.OneintheChamberCheck.Checked = false;
                this.SharpshooterCheck.Checked = false;
                this.SticksandStonesCheck.Checked = false;
            }
        }

        private void Cob0L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cob0L.Checked)
            {
                this.UnstoppableCheck.Checked = true;
                this.NuclearCheck.Checked = true;
                this.BrutalCheck.Checked = true;
                this.RelentlessCheck.Checked = true;
                this.RuthlessCheck.Checked = true;
                this.MercilessCheck.Checked = true;
                this.BloodthirstyCheck.Checked = true;
                this.KillChainCheck.Checked = true;
                this.UltraKillCheck.Checked = true;
                this.MegaKillCheck.Checked = true;
            }
            else
            {
                this.UnstoppableCheck.Checked = false;
                this.NuclearCheck.Checked = false;
                this.BrutalCheck.Checked = false;
                this.RelentlessCheck.Checked = false;
                this.RuthlessCheck.Checked = false;
                this.MercilessCheck.Checked = false;
                this.BloodthirstyCheck.Checked = false;
                this.KillChainCheck.Checked = false;
                this.UltraKillCheck.Checked = false;
                this.MegaKillCheck.Checked = false;
            }
        }

        private void Cob0R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cob0R.Checked)
            {
                this.SuperKillCheck.Checked = true;
                this.FrenzyKillCheck.Checked = true;
                this.FuryKillCheck.Checked = true;
                this.TripleKillCheck.Checked = true;
                this.DoubleKillCheck.Checked = true;
                this.BuzzKillCheck.Checked = true;
                this.BaitTakenCheck.Checked = true;
                this.PancakeCheck.Checked = true;
                this.DropshotCheck.Checked = true;
                this.OneShotOneKillCheck.Checked = true;
            }
            else
            {
                this.SuperKillCheck.Checked = false;
                this.FrenzyKillCheck.Checked = false;
                this.FuryKillCheck.Checked = false;
                this.TripleKillCheck.Checked = false;
                this.DoubleKillCheck.Checked = false;
                this.BuzzKillCheck.Checked = false;
                this.BaitTakenCheck.Checked = false;
                this.PancakeCheck.Checked = false;
                this.DropshotCheck.Checked = false;
                this.OneShotOneKillCheck.Checked = false;
            }
        }

        private void Cob1L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cob1L.Checked)
            {
                this.EfficiencyCheck.Checked = true;
                this.ComebackCheck.Checked = true;
                this.ShieldBashCheck.Checked = true;
                this.SkeweredCheck.Checked = true;
                this.HackedCheck.Checked = true;
                this.FirstBloodCheck.Checked = true;
                this.AssistedSuicideCheck.Checked = true;
                this.QuadFeedCheck.Checked = true;
                this.HeadshotCheck.Checked = true;
                this.AfterlifeCheck.Checked = true;
            }
            else
            {
                this.EfficiencyCheck.Checked = false;
                this.ComebackCheck.Checked = false;
                this.ShieldBashCheck.Checked = false;
                this.SkeweredCheck.Checked = false;
                this.HackedCheck.Checked = false;
                this.FirstBloodCheck.Checked = false;
                this.AssistedSuicideCheck.Checked = false;
                this.QuadFeedCheck.Checked = false;
                this.HeadshotCheck.Checked = false;
                this.AfterlifeCheck.Checked = false;
            }
        }

        private void Cob1R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cob1R.Checked)
            {
                this.BankshotCheck.Checked = true;
                this.LongShotCheck.Checked = true;
                this.BackStabberCheck.Checked = true;
                this.RevengeCheck.Checked = true;
                this.HijackerCheck.Checked = true;
                this.SurvivorCheck.Checked = true;
                this.BackfireCheck.Checked = true;
                this.AvengerCheck.Checked = true;
                this.SaviorCheck.Checked = true;
                this.StickCheck.Checked = true;
            }
            else
            {
                this.BankshotCheck.Checked = false;
                this.LongShotCheck.Checked = false;
                this.BackStabberCheck.Checked = false;
                this.RevengeCheck.Checked = false;
                this.HijackerCheck.Checked = false;
                this.SurvivorCheck.Checked = false;
                this.BackfireCheck.Checked = false;
                this.AvengerCheck.Checked = false;
                this.SaviorCheck.Checked = false;
                this.StickCheck.Checked = false;
            }
        }

        private void Cob2L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Cob2L.Checked)
            {
                this.ChoppedUpCheck.Checked = true;
                this.DeadeyeCheck.Checked = true;
            }
            else
            {
                this.ChoppedUpCheck.Checked = false;
                this.DeadeyeCheck.Checked = false;
            }
        }

        private void Stks0L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Stks0L.Checked)
            {
                this.FallingSkiesCheck.Checked = true;
                this.KaboomCheck.Checked = true;
                this.RainingDeathCheck.Checked = true;
                this.BullseyeCheck.Checked = true;
                this.CrackdownCheck.Checked = true;
                this.CookedCheck.Checked = true;
                this.StrikeDeliveredCheck.Checked = true;
                this.DecimatedCheck.Checked = true;
                this.BoomstickCheck.Checked = true;
                this.RedBaronCheck.Checked = true;
            }
            else
            {
                this.FallingSkiesCheck.Checked = false;
                this.KaboomCheck.Checked = false;
                this.RainingDeathCheck.Checked = false;
                this.BullseyeCheck.Checked = false;
                this.CrackdownCheck.Checked = false;
                this.CookedCheck.Checked = false;
                this.StrikeDeliveredCheck.Checked = false;
                this.DecimatedCheck.Checked = false;
                this.BoomstickCheck.Checked = false;
                this.RedBaronCheck.Checked = false;
            }
        }

        private void Stks0R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Stks0R.Checked)
            {
                this.BouncerCheck.Checked = true;
                this.WingmanCheck.Checked = true;
                this.CropdusterCheck.Checked = true;
                this.SilentKillerCheck.Checked = true;
                this.DistantThunderCheck.Checked = true;
                this.DeathFromAboveCheck.Checked = true;
                this.WarbeastCheck.Checked = true;
                this.SharedSwarmCheck.Checked = true;
                this.SharedDeathMachineCheck.Checked = true;
                this.SharedUAVCheck.Checked = true;
            }
            else
            {
                this.BouncerCheck.Checked = false;
                this.WingmanCheck.Checked = false;
                this.CropdusterCheck.Checked = false;
                this.SilentKillerCheck.Checked = false;
                this.DistantThunderCheck.Checked = false;
                this.DeathFromAboveCheck.Checked = false;
                this.WarbeastCheck.Checked = false;
                this.SharedSwarmCheck.Checked = false;
                this.SharedDeathMachineCheck.Checked = false;
                this.SharedUAVCheck.Checked = false;
            }
        }

        private void Stks1L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Stks1L.Checked)
            {
                this.SharedHunterKillerCheck.Checked = true;
                this.SharedRCXDCheck.Checked = true;
                this.SharedCounterUAVCheck.Checked = true;
                this.SharedDragonfireCheck.Checked = true;
                this.SharedGuardianCheck.Checked = true;
                this.SharedHellstormMissileCheck.Checked = true;
                this.SharedLightningStrikeCheck.Checked = true;
                this.SharedSentryGunCheck.Checked = true;
                this.SharedStealthChopperCheck.Checked = true;
                this.SharedEscortDroneCheck.Checked = true;
            }
            else
            {
                this.SharedHunterKillerCheck.Checked = false;
                this.SharedRCXDCheck.Checked = false;
                this.SharedCounterUAVCheck.Checked = false;
                this.SharedDragonfireCheck.Checked = false;
                this.SharedGuardianCheck.Checked = false;
                this.SharedHellstormMissileCheck.Checked = false;
                this.SharedLightningStrikeCheck.Checked = false;
                this.SharedSentryGunCheck.Checked = false;
                this.SharedStealthChopperCheck.Checked = false;
                this.SharedEscortDroneCheck.Checked = false;
            }
        }

        private void Stks1R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Stks1R.Checked)
            {
                this.SharedOrbitalVSATCheck.Checked = true;
                this.SharedAGRCheck.Checked = true;
                this.SharedEMPSystemsCheck.Checked = true;
                this.SharedWarthogCheck.Checked = true;
                this.SharedLodestarCheck.Checked = true;
                this.SharedVTOLWarshipCheck.Checked = true;
                this.SharedK9UnitCheck.Checked = true;
                this.SharedWarMachineCheck.Checked = true;
            }
            else
            {
                this.SharedOrbitalVSATCheck.Checked = false;
                this.SharedAGRCheck.Checked = false;
                this.SharedEMPSystemsCheck.Checked = false;
                this.SharedWarthogCheck.Checked = false;
                this.SharedLodestarCheck.Checked = false;
                this.SharedVTOLWarshipCheck.Checked = false;
                this.SharedK9UnitCheck.Checked = false;
                this.SharedWarMachineCheck.Checked = false;
            }
        }

        private void AStks0L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AStks0L.Checked)
            {
                this.BlackoutCheck.Checked = true;
                this.FuzzbusterCheck.Checked = true;
                this.NoTipCheck.Checked = true;
                this.RejectedCheck.Checked = true;
                this.RoadRageCheck.Checked = true;
                this.BurnOutCheck.Checked = true;
                this.InterceptedCheck.Checked = true;
                this.TKOCheck.Checked = true;
                this.ScrappedCheck.Checked = true;
                this.FlyswatterCheck.Checked = true;
            }
            else
            {
                this.BlackoutCheck.Checked = false;
                this.FuzzbusterCheck.Checked = false;
                this.NoTipCheck.Checked = false;
                this.RejectedCheck.Checked = false;
                this.RoadRageCheck.Checked = false;
                this.BurnOutCheck.Checked = false;
                this.InterceptedCheck.Checked = false;
                this.TKOCheck.Checked = false;
                this.ScrappedCheck.Checked = false;
                this.FlyswatterCheck.Checked = false;
            }
        }

        private void AStks0R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AStks0R.Checked)
            {
                this.DroneHunterCheck.Checked = true;
                this.ShadowCatcherCheck.Checked = true;
                this.DemolishedCheck.Checked = true;
                this.UppercutCheck.Checked = true;
                this.BigGameHunterCheck.Checked = true;
                this.ExterminatorCheck.Checked = true;
                this.HogtiedCheck.Checked = true;
            }
            else
            {
                this.DroneHunterCheck.Checked = false;
                this.ShadowCatcherCheck.Checked = false;
                this.DemolishedCheck.Checked = false;
                this.UppercutCheck.Checked = false;
                this.BigGameHunterCheck.Checked = false;
                this.ExterminatorCheck.Checked = false;
                this.HogtiedCheck.Checked = false;
            }
        }

        private void Gms0L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Gms0L.Checked)
            {
                this.OpeningMoveCheck.Checked = true;
                this.Secure2Check.Checked = true;
                this.CleanUpCheck.Checked = true;
                this.RetrievedCheck.Checked = true;
                this.HeroCheck.Checked = true;
                this.Clutch2Check.Checked = true;
                this.Takedown2Check.Checked = true;
                this.Denied1Check.Checked = true;
                this.BomberCheck.Checked = true;
                this.LastManStandingCheck.Checked = true;
            }
            else
            {
                this.OpeningMoveCheck.Checked = false;
                this.Secure2Check.Checked = false;
                this.CleanUpCheck.Checked = false;
                this.RetrievedCheck.Checked = false;
                this.HeroCheck.Checked = false;
                this.Clutch2Check.Checked = false;
                this.Takedown2Check.Checked = false;
                this.Denied1Check.Checked = false;
                this.BomberCheck.Checked = false;
                this.LastManStandingCheck.Checked = false;
            }
        }

        private void ModesTab_Click(object sender, EventArgs e)
        {

        }

        private void Gms0R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Gms0R.Checked)
            {
                this.Clutch1Check.Checked = true;
                this.PlaymakerCheck.Checked = true;
                this.CloseCallCheck.Checked = true;
                this.Denied2Check.Checked = true;
                this.Takedown1Check.Checked = true;
                this.Secure1Check.Checked = true;
                this.HardpointSecureCheck.Checked = true;
                this.UnderdogCheck.Checked = true;
                this.Elimination2Check.Checked = true;
                this.WipeoutCheck.Checked = true;
            }
            else
            {
                this.Clutch1Check.Checked = false;
                this.PlaymakerCheck.Checked = false;
                this.CloseCallCheck.Checked = false;
                this.Denied2Check.Checked = false;
                this.Takedown1Check.Checked = false;
                this.Secure1Check.Checked = false;
                this.HardpointSecureCheck.Checked = false;
                this.UnderdogCheck.Checked = false;
                this.Elimination2Check.Checked = false;
                this.WipeoutCheck.Checked = false;
            }
        }

        private void Gms1L_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Gms1L.Checked)
            {
                this.ForwardPositionCheck.Checked = true;
                this.AggressionCheck.Checked = true;
                this.HumiliationCheck.Checked = true;
                this.GunslingerCheck.Checked = true;
                this.Regicide2Check.Checked = true;
                this.DoubleDownCheck.Checked = true;
                this.GunExpertCheck.Checked = true;
                this.ComboBreakerCheck.Checked = true;
                this.BankruptedCheck.Checked = true;
                this.Regicide1Check.Checked = true;
            }
            else
            {
                this.ForwardPositionCheck.Checked = false;
                this.AggressionCheck.Checked = false;
                this.HumiliationCheck.Checked = false;
                this.GunslingerCheck.Checked = false;
                this.Regicide2Check.Checked = false;
                this.DoubleDownCheck.Checked = false;
                this.GunExpertCheck.Checked = false;
                this.ComboBreakerCheck.Checked = false;
                this.BankruptedCheck.Checked = false;
                this.Regicide1Check.Checked = false;
            }
        }

        private void Gms1R_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Gms1R.Checked)
            {
                this.SwitchHitterCheck.Checked = true;
                this.FrugalCheck.Checked = true;
                this.Elimination1Check.Checked = true;
                this.StrengthandHonorCheck.Checked = true;
                this.VictorCheck.Checked = true;
            }
            else
            {
                this.SwitchHitterCheck.Checked = false;
                this.FrugalCheck.Checked = false;
                this.Elimination1Check.Checked = false;
                this.StrengthandHonorCheck.Checked = false;
                this.VictorCheck.Checked = false;
            }
        }

        private void Eq0All_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Eq0All.Checked)
            {
                this.GrenadeCheck.Checked = true;
                this.SemtexCheck.Checked = true;
                this.CombatAxeCheck.Checked = true;
                this.BouncingBettyCheck.Checked = true;
                this.C4Check.Checked = true;
                this.ClaymoreCheck.Checked = true;
            }
            else
            {
                this.GrenadeCheck.Checked = false;
                this.SemtexCheck.Checked = false;
                this.CombatAxeCheck.Checked = false;
                this.BouncingBettyCheck.Checked = false;
                this.C4Check.Checked = false;
                this.ClaymoreCheck.Checked = false;
            }
        }

        private void Eq1All_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Eq1All.Checked)
            {
                this.ConcussionCheck.Checked = true;
                this.SmokeGrenadeCheck.Checked = true;
                this.SensorGrenadeCheck.Checked = true;
                this.EMPGrenadeCheck.Checked = true;
                this.ShockChargeCheck.Checked = true;
                this.BlackHatCheck.Checked = true;
                this.FlashbangCheck.Checked = true;
                this.TrophySystemCheck.Checked = true;
                this.TacticalInsertionCheck.Checked = true;
            }
            else
            {
                this.ConcussionCheck.Checked = false;
                this.SmokeGrenadeCheck.Checked = false;
                this.SensorGrenadeCheck.Checked = false;
                this.EMPGrenadeCheck.Checked = false;
                this.ShockChargeCheck.Checked = false;
                this.BlackHatCheck.Checked = false;
                this.FlashbangCheck.Checked = false;
                this.TrophySystemCheck.Checked = false;
                this.TacticalInsertionCheck.Checked = false;
            }
        }

        private void Tier1AllStk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Tier1AllStk.Checked)
            {
                this.UAVCheck.Checked = true;
                this.RXCheck.Checked = true;
                this.HtCheck.Checked = true;
                this.CPacCheck.Checked = true;
                this.CoutCheck.Checked = true;
                this.GdiCheck.Checked = true;
                this.MisCheck.Checked = true;
                this.StikCheck.Checked = true;
                this.SenyCheck.Checked = true;
                this.DetCheck.Checked = true;
                this.WarCheck.Checked = true;
            }
            else
            {
                this.UAVCheck.Checked = false;
                this.RXCheck.Checked = false;
                this.HtCheck.Checked = false;
                this.CPacCheck.Checked = false;
                this.CoutCheck.Checked = false;
                this.GdiCheck.Checked = false;
                this.MisCheck.Checked = false;
                this.StikCheck.Checked = false;
                this.SenyCheck.Checked = false;
                this.DetCheck.Checked = false;
                this.WarCheck.Checked = false;
            }
        }

        private void Tier2AllStk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Tier2AllStk.Checked)
            {
                this.DrgCheck.Checked = true;
                this.AGRCheck.Checked = true;
                this.ChopCheck.Checked = true;
                this.VSATCheck.Checked = true;
                this.DrnCheck.Checked = true;
                this.EMPCheck.Checked = true;
                this.WathCheck.Checked = true;
                this.LodsCheck.Checked = true;
                this.VTOLCheck.Checked = true;
                this.K9Check.Checked = true;
                this.SwrCheck.Checked = true;
            }
            else
            {
                this.DrgCheck.Checked = false;
                this.AGRCheck.Checked = false;
                this.ChopCheck.Checked = false;
                this.VSATCheck.Checked = false;
                this.DrnCheck.Checked = false;
                this.EMPCheck.Checked = false;
                this.WathCheck.Checked = false;
                this.LodsCheck.Checked = false;
                this.VTOLCheck.Checked = false;
                this.K9Check.Checked = false;
                this.SwrCheck.Checked = false;
            }
        }

        private void LoadSF_Click(object sender, EventArgs e)
        {
            NumericUpDown[] array = new NumericUpDown[]
        {
                this.KAPKs,
                this.KAPKs,
                this.TacKs,
                this.B23RKs,
                this.ExeKs,
                this.FivesKs,
                this.MP7Ks,
                this.EVOKs,
                this.PDWKs,
                this.CQBKs,
                this.MSMCKs,
                this.K10Ks,
                this.PeaceKs,
                this.M8A1Ks,
                this.SCARKs,
                this.ANKs,
                this.SWATKs,
                this.TypeKs,
                this.FALKs,
                this.SMRKs,
                this.M27Ks,
                this.MTARKs,
                this.MK48Ks,
                this.QBBKs,
                this.LSATKs,
                this.HAMRKs,
                this.BallistaKs,
                this.SVUKs,
                this.DSRKs,
                this.XPRKs,
                this.R870Ks,
                this.M1216Ks,
                this.S12Ks,
                this.KSGKs,
                this.SMAWKs,
                this.FHJKs,
                this.RPGKs,
                this.ShieldKs,
                this.BowKs,
                this.BallKnifeKs,
                this.KAPDe,
                this.TacDe,
                this.B23RDe,
                this.ExeDe,
                this.FivesDe,
                this.MP7De,
                this.EVODe,
                this.PDWDe,
                this.CQBDe,
                this.MSMCDe,
                this.K10De,
                this.PeaceDe,
                this.M8A1De,
                this.SCARDe,
                this.ANDe,
                this.SWATDe,
                this.TypeDe,
                this.FALDe,
                this.SMRDe,
                this.M27De,
                this.MTARDe,
                this.MK48De,
                this.QBBDe,
                this.LSATDe,
                this.HAMRDe,
                this.BallistaDe,
                this.SVUDe,
                this.DSRDe,
                this.XPRDe,
                this.R870De,
                this.M1216De,
                this.S12De,
                this.KSGDe,
                this.ShieldDe,
                this.BowDe,
                this.BallKnifeDe,
                this.KAPHd,
                this.TacHd,
                this.B23RHd,
                this.ExeHd,
                this.FivesHd,
                this.MP7Hd,
                this.EVOHd,
                this.PDWHd,
                this.CQBHd,
                this.MSMCHd,
                this.K10Hd,
                this.PeaceHd,
                this.M8A1Hd,
                this.SCARHd,
                this.ANHd,
                this.SWATHd,
                this.TypeHd,
                this.FALHd,
                this.SMRHd,
                this.M27Hd,
                this.MTARHd,
                this.MK48Hd,
                this.QBBHd,
                this.LSATHd,
                this.HAMRHd,
                this.BallistaHd,
                this.SVUHd,
                this.DSRHd,
                this.XPRHd,
                this.R870Hd,
                this.M1216Hd,
                this.S12Hd,
                this.KSGHd,
                this.BallKnifeHd,
                this.KAPAc,
                this.TacAc,
                this.B23RAc,
                this.ExeAc,
                this.FivesAc,
                this.MP7Ac,
                this.EVOAc,
                this.PDWAc,
                this.CQBAc,
                this.MSMCAc,
                this.K10Ac,
                this.PeaceAc,
                this.M8A1Ac,
                this.SCARAc,
                this.ANAc,
                this.SWATAc,
                this.TypeAc,
                this.FALAc,
                this.SMRAc,
                this.M27Ac,
                this.MTARAc,
                this.MK48Ac,
                this.QBBAc,
                this.LSATAc,
                this.HAMRAc,
                this.BallistaAc,
                this.SVUAc,
                this.DSRAc,
                this.XPRAc,
                this.R870Ac,
                this.M27Ac,
                this.S12Ac,
                this.KSGAc,
                this.BowAc,
                this.BallKnifeAc,
                this.UAVUse,
                this.RXUse,
                this.HtUse,
                this.CPacUse,
                this.CoutUse,
                this.GdiUse,
                this.MisUse,
                this.StikUse,
                this.SenyUse,
                this.DetUse,
                this.WarUse,
                this.DrgUse,
                this.AGRUse,
                this.ChopUse,
                this.VSATUse,
                this.DrnUse,
                this.EMPUse,
                this.WathUse,
                this.LodsUse,
                this.VTOLUse,
                this.K9Use,
                this.SwrUse,
                this.UAVOth,
                this.RXOth,
                this.HtOth,
                this.CPacOth,
                this.CoutOth,
                this.GdiOth,
                this.MisOth,
                this.StikOth,
                this.SenyOth,
                this.DetOth,
                this.WarOth,
                this.DrgOth,
                this.AGROth,
                this.ChopOth,
                this.VSATOth,
                this.DrnOth,
                this.EMPOth,
                this.WathOth,
                this.LodsOth,
                this.VTOLOth,
                this.K9Oth,
                this.SwrOth,
                this.Bouncer,
                this.AssistedSuicide,
                this.BackStabber,
                this.Skewered,
                this.Bomber,
                this.Bankshot,
                this.Hijacker,
                this.Wipeout,
                this.Comeback,
                this.StrengthandHonor,
                this.Deadeye,
                this.Decimated,
                this.Clutch1,
                this.Hero,
                this.Clutch2,
                this.DroneHunter,
                this.Fuzzbuster,
                this.ShadowCatcher,
                this.Demolished,
                this.BigGameHunter,
                this.BurnOut,
                this.Rejected,
                this.Exterminator,
                this.TKO,
                this.Flyswatter,
                this.RoadRage,
                this.Intercepted,
                this.Uppercut,
                this.Scrapped,
                this.Hogtied,
                this.NoTip,
                this.Blackout,
                this.Warbeast,
                this.Elimination1,
                this.Elimination2,
                this.LastManStanding,
                this.FirstBlood,
                this.Playmaker,
                this.CloseCall,
                this.Hacked,
                this.ChoppedUp,
                this.Headshot,
                this.SilentKiller,
                this.Wingman,
                this.DeathFromAbove,
                this.Secure1,
                this.Humiliation,
                this.CleanUp,
                this.Efficiency,
                this.Afterlife,
                this.Savior,
                this.OneShotOneKill,
                this.Dropshot,
                this.Survivor,
                this.Aggression,
                this.Avenger,
                this.Pancake,
                this.BaitTaken,
                this.Underdog,
                this.Backfire,
                this.Takedown1,
                this.Gunslinger,
                this.Regicide1,
                this.Bankrupted,
                this.SwitchHitter,
                this.ComboBreaker,
                this.Denied1,
                this.Takedown2,
                this.Denied2,
                this.Merciless,
                this.Ruthless,
                this.Relentless,
                this.Brutal,
                this.Nuclear,
                this.Bloodthirsty,
                this.Unstoppable,
                this.Regicide2,
                this.Frugal,
                this.HardpointSecure,
                this.LongShot,
                this.ShieldBash,
                this.Cooked,
                this.Bullseye,
                this.FallingSkies,
                this.GunExpert,
                this.DoubleKill,
                this.TripleKill,
                this.FuryKill,
                this.FrenzyKill,
                this.SuperKill,
                this.MegaKill,
                this.UltraKill,
                this.KillChain,
                this.Boomstick,
                this.OpeningMove,
                this.StrikeDelivered,
                this.Secure2,
                this.RedBaron,
                this.ForwardPosition,
                this.Kaboom,
                this.RainingDeath,
                this.DistantThunder,
                this.Retrieved,
                this.Revenge,
                this.Crackdown,
                this.SharedAGR,
                this.SharedCounterUAV,
                this.SharedDeathMachine,
                this.SharedK9Unit,
                this.SharedEMPSystems,
                this.SharedStealthChopper,
                this.SharedEscortDrone,
                this.SharedVTOLWarship,
                this.SharedGuardian,
                this.SharedHunterKiller,
                this.SharedSwarm,
                this.SharedWarMachine,
                this.SharedLightningStrike,
                this.SharedDragonfire,
                this.SharedRCXD,
                this.SharedHellstormMissile,
                this.SharedLodestar,
                this.SharedOrbitalVSAT,
                this.SharedSentryGun,
                this.SharedWarthog,
                this.SharedUAV,
                this.Stick,
                this.BuzzKill,
                this.Cropduster,
                this.QuadFeed,
                this.Victor,
                this.DoubleDown,
                this.GrenadeUse,
                this.CombatAxeUse,
                this.SemtexUse,
                this.C4Use,
                this.BouncingBettyUse,
                this.ClaymoreUse,
                this.SmokeGrenadeUse,
                this.ConcussionUse,
                this.EMPGrenadeUse,
                this.SensorGrenadeUse,
                this.FlashbangUse,
                this.ShockChargeUse,
                this.BlackHatUse,
                this.TacticalInsertionUse,
                this.TrophySystemUse,
                this.GrenadeOth,
                this.CombatAxeOth,
                this.SemtexOth,
                this.C4Oth,
                this.BouncingBettyOth,
                this.ClaymoreOth,
                this.SmokeGrenadeOth,
                this.ConcussionOth,
                this.EMPGrenadeOth,
                this.SensorGrenadeOth,
                this.FlashbangOth,
                this.ShockChargeOth,
                this.BlackHatOth,
                this.TacticalInsertionOth,
                this.TrophySystemOth,
                this.TDMWin,
                this.FreeForAllWin,
                this.SDWin,
                this.DominationWin,
                this.HardpointWin,
                this.HeadquartersWin,
                this.DemolitionWin,
                this.CTFWin,
                this.KillConfirmedWin,
                this.GunGameWin,
                this.OneintheChamberWin,
                this.SharpshooterWin,
                this.SticksandStonesWin,
                this.HCTDMWin,
                this.HCSDWin,
                this.HCDominationWin,
                this.HCKillConfirmedWin,
                this.TDMLos,
                this.FreeForAllLos,
                this.SDLos,
                this.DominationLos,
                this.HardpointLos,
                this.HeadquartersLos,
                this.DemolitionLos,
                this.CTFLos,
                this.KillConfirmedLos,
                this.GunGameLos,
                this.OneintheChamberLos,
                this.SharpshooterLos,
                this.SticksandStonesLos,
                this.HCTDMLos,
                this.HCSDLos,
                this.HCDominationLos,
                this.HCKillConfirmedLos,
                this.TDMCur,
                this.FreeForAllCur,
                this.SDCur,
                this.DominationCur,
                this.HardpointCur,
                this.HeadquartersCur,
                this.DemolitionCur,
                this.CTFCur,
                this.KillConfirmedCur,
                this.GunGameCur,
                this.OneintheChamberCur,
                this.SharpshooterCur,
                this.SticksandStonesCur,
                this.HCTDMCur,
                this.HCSDCur,
                this.HCDominationCur,
                this.HCKillConfirmedCur,
                this.TDMBes,
                this.FreeForAllBes,
                this.SDBes,
                this.DominationBes,
                this.HardpointBes,
                this.HeadquartersBes,
                this.DemolitionBes,
                this.CTFBes,
                this.KillConfirmedBes,
                this.GunGameBes,
                this.OneintheChamberBes,
                this.SharpshooterBes,
                this.SticksandStonesBes,
                this.HCTDMBes,
                this.HCSDBes,
                this.HCDominationBes,
                this.HCKillConfirmedBes
        };
            try
            {
                string text = FileLS.ReadText(this.LSBox.Text);
                if (text.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0] == "Adv")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i != 0)
                        {
                            array[i].Value = FileLS.LoadNum(text, i);
                        }
                    }
                    this.SLStatus.ForeColor = Color.Green;
                    this.SLStatus.Text = "Loaded";
                }
                else
                {
                    this.SLStatus.ForeColor = Color.Red;
                    this.SLStatus.Text = "Failed To Load";
                }
            }
            catch
            {
                this.SLStatus.ForeColor = Color.Red;
                this.SLStatus.Text = "Failed To Load";
            }
        }
        private decimal GetAcValue(uint offset)
        {
            decimal d = PS6.Func.GetUInt32(offset, true);
            decimal num = PS6.Func.GetUInt32(offset - 6u, true);
            decimal result;
            if (num != 0m)
            {
                result = d / num * 100m;
            }
            else
            {
                result = 0.00m;
            }
            return result;
        }
        private uint GetValue(uint Offset, uint Multi)
        {
            return PS6.Func.GetUInt32(Offset, true) / Multi;
        }
        private void LoadStreaks()
        {
            try
            {
                for (int i = 0; i < this.StreaksUse.Length; i++)
                {
                    this.StreaksUse[i].Value = this.GetValue(Stats.Streaks.OffsetsUse[i] + Stats.StatsCombat, Stats.Streaks.Multi[i]);
                    this.StreaksOth[i].Value = this.GetValue(Stats.Streaks.OffsetsOther[i] + Stats.StatsCombat, Stats.Streaks.Multi[i]);
                }
            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nReset Stats(Streaks)??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int j = 0; j < this.StreaksUse.Length; j++)
                    {
                        PS3.SetMemory(Stats.Streaks.OffsetsUse[j] + Stats.StatsCombat, new byte[4]);
                    }
                    for (int k = 0; k < this.StreaksOth.Length; k++)
                    {
                        PS3.SetMemory(Stats.Streaks.OffsetsOther[k] + Stats.StatsCombat, new byte[4]);
                    }
                }
            }
        }
        private void LoadWeapons()
        {
            try
            {
                for (int i = 0; i < 39; i++)
                {
                    this.WeapKill[i].Value = this.GetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i], Stats.Weapons.Multi[i]);
                    if (i != 34 || i != 35 || i != 36)
                    {
                        this.WeapDeath[i].Value = this.GetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 12u, Stats.Weapons.Multi[i]);
                    }
                    if (i != 34 || i != 35 || i != 36 || i != 37)
                    {
                        this.WeapAccy[i].Value = this.GetAcValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 24u);
                    }
                    if (i != 34 || i != 35 || (i != 36 || i != 37) || i != 38)
                    {
                        this.WeapHead[i].Value = this.GetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 30u, Stats.Weapons.Multi[i]);
                    }
                }
            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nReset Stats(Weapons)??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    byte[] buffer = new byte[4];
                    for (int j = 0; j < 39; j++)
                    {
                        PS3.SetMemory(Stats.StatsCombat + Stats.Weapons.Offsets[j], buffer);
                        PS3.SetMemory(Stats.StatsCombat + Stats.Weapons.Offsets[j] + 12u, buffer);
                        PS3.SetMemory(Stats.StatsCombat + Stats.Weapons.Offsets[j] + 24u, buffer);
                        PS3.SetMemory(Stats.StatsCombat + Stats.Weapons.Offsets[j] + 30u, buffer);
                    }
                }
            }
        }
        private void LoadGames()
        {
            try
            {
                for (int i = 0; i < Stats.Gamemodes.Offsets.Length; i++)
                {
                    this.GamesWin[i].Value = this.GetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 90u, Stats.Gamemodes.Multi[i]);
                    this.GamesLos[i].Value = this.GetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 42u, Stats.Gamemodes.Multi[i]);
                    this.GamesCur[i].Value = this.GetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i], Stats.Gamemodes.Multi[i]);
                    this.GamesBes[i].Value = this.GetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 96u, Stats.Gamemodes.Multi[i]);
                }
            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nReset Stats(Gamemodes)??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    byte[] buffer = new byte[4];
                    for (int j = 0; j < Stats.Gamemodes.Offsets.Length; j++)
                    {
                        PS3.SetMemory(Stats.StatsCombat - Stats.Gamemodes.Offsets[j], buffer);
                        PS3.SetMemory(Stats.StatsCombat - Stats.Gamemodes.Offsets[j] + 42u, buffer);
                        PS3.SetMemory(Stats.StatsCombat - Stats.Gamemodes.Offsets[j] + 90u, buffer);
                        PS3.SetMemory(Stats.StatsCombat - Stats.Gamemodes.Offsets[j] + 96u, buffer);
                    }
                }
            }
        }
        private void LoadMedals()
        {
            try
            {
                for (int i = 0; i < Stats.Medals.Offsets.Length; i++)
                {
                    this.MedalsNum[i].Value = PS6.Func.GetUInt32(Stats.MedalsSt - Stats.Medals.Offsets[i], true);
                }
            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nReset Stats(Medals)??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    byte[] buffer = new byte[4];
                    for (int j = 0; j < Stats.Medals.Offsets.Length; j++)
                    {
                        PS3.SetMemory(Stats.MedalsSt - Stats.Medals.Offsets[j], buffer);
                    }
                }
            }
        }
        private void LoadEuit()
        {
            try
            {
                for (int i = 0; i < Stats.Equipment.Use.Length; i++)
                {
                    this.EqutUse[i].Value = this.GetValue(Stats.StatsCombat + Stats.Equipment.Use[i], Stats.Equipment.Multi[i]);
                    this.EqutOth[i].Value = this.GetValue(Stats.StatsCombat + Stats.Equipment.Oth[i], Stats.Equipment.Multi[i]);
                }
            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nReset Stats(Equipment)??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    byte[] buffer = new byte[4];
                    for (int j = 0; j < Stats.Equipment.Use.Length; j++)
                    {
                        PS3.SetMemory(Stats.StatsCombat + Stats.Equipment.Use[j], buffer);
                        PS3.SetMemory(Stats.StatsCombat + Stats.Equipment.Oth[j], buffer);
                    }
                }
            }
        }
        private void LoadStatsBut_Click_1(object sender, EventArgs e)
        {
            this.LoadStreaks();
            this.LoadWeapons();
            this.LoadGames();
            this.LoadMedals();
            this.LoadEuit();
            label113.Visible = true;
            label113.Text = "Stats Loaded from Game!";
            label113.ForeColor = Color.Green;
        }
        private void SaveSF_Click(object sender, EventArgs e)
        {
            if (FileLS.WriteText(this.LSBox.Text, string.Concat(new string[]
            {
                "Adv|KAPKs=",
                this.KAPKs.Value.ToString(),
                "|TacKs=",
                this.TacKs.Value.ToString(),
                "|B23RKs=",
                this.B23RKs.Value.ToString(),
                "|ExeKs=",
                this.ExeKs.Value.ToString(),
                "|FivesKs=",
                this.FivesKs.Value.ToString(),
                "|MP7Ks=",
                this.MP7Ks.Value.ToString(),
                "|EVOKs=",
                this.EVOKs.Value.ToString(),
                "|PDWKs=",
                this.PDWKs.Value.ToString(),
                "|CQBKs=",
                this.CQBKs.Value.ToString(),
                "|MSMCKs=",
                this.MSMCKs.Value.ToString(),
                "|K10Ks=",
                this.K10Ks.Value.ToString(),
                "|PeaceKs=",
                this.PeaceKs.Value.ToString(),
                "|M8A1Ks=",
                this.M8A1Ks.Value.ToString(),
                "|SCARKs=",
                this.SCARKs.Value.ToString(),
                "|ANKs=",
                this.ANKs.Value.ToString(),
                "|SWATKs=",
                this.SWATKs.Value.ToString(),
                "|TypeKs=",
                this.TypeKs.Value.ToString(),
                "|FALKs=",
                this.FALKs.Value.ToString(),
                "|SMRKs=",
                this.SMRKs.Value.ToString(),
                "|M27Ks=",
                this.M27Ks.Value.ToString(),
                "|MTARKs=",
                this.MTARKs.Value.ToString(),
                "|MK48Ks=",
                this.MK48Ks.Value.ToString(),
                "|QBBKs=",
                this.QBBKs.Value.ToString(),
                "|LSATKs=",
                this.LSATKs.Value.ToString(),
                "|HAMRKs=",
                this.HAMRKs.Value.ToString(),
                "|BallistaKs=",
                this.BallistaKs.Value.ToString(),
                "|SVUKs=",
                this.SVUKs.Value.ToString(),
                "|DSRKs=",
                this.DSRKs.Value.ToString(),
                "|XPRKs=",
                this.XPRKs.Value.ToString(),
                "|R870Ks=",
                this.R870Ks.Value.ToString(),
                "|M1216Ks=",
                this.M1216Ks.Value.ToString(),
                "|S12Ks=",
                this.S12Ks.Value.ToString(),
                "|KSGKs=",
                this.KSGKs.Value.ToString(),
                "|SMAWKs=",
                this.SMAWKs.Value.ToString(),
                "|FHJKs=",
                this.FHJKs.Value.ToString(),
                "|RPGKs=",
                this.RPGKs.Value.ToString(),
                "|ShieldKs=",
                this.ShieldKs.Value.ToString(),
                "|BowKs=",
                this.BowKs.Value.ToString(),
                "|BallKnifeKs=",
                this.BallKnifeKs.Value.ToString(),
                "|KAPDe=",
                this.KAPDe.Value.ToString(),
                "|TacDe=",
                this.TacDe.Value.ToString(),
                "|B23RDe=",
                this.B23RDe.Value.ToString(),
                "|ExeDe=",
                this.ExeDe.Value.ToString(),
                "|FivesDe=",
                this.FivesDe.Value.ToString(),
                "|MP7De=",
                this.MP7De.Value.ToString(),
                "|EVODe=",
                this.EVODe.Value.ToString(),
                "|PDWDe=",
                this.PDWDe.Value.ToString(),
                "|CQBDe=",
                this.CQBDe.Value.ToString(),
                "|MSMCDe=",
                this.MSMCDe.Value.ToString(),
                "|K10De=",
                this.K10De.Value.ToString(),
                "|PeaceDe=",
                this.PeaceDe.Value.ToString(),
                "|M8A1De=",
                this.M8A1De.Value.ToString(),
                "|SCARDe=",
                this.SCARDe.Value.ToString(),
                "|ANDe=",
                this.ANDe.Value.ToString(),
                "|SWATDe=",
                this.SWATDe.Value.ToString(),
                "|TypeDe=",
                this.TypeDe.Value.ToString(),
                "|FALDe=",
                this.FALDe.Value.ToString(),
                "|SMRDe=",
                this.SMRDe.Value.ToString(),
                "|M27De=",
                this.M27De.Value.ToString(),
                "|MTARDe=",
                this.MTARDe.Value.ToString(),
                "|MK48De=",
                this.MK48De.Value.ToString(),
                "|QBBDe=",
                this.QBBDe.Value.ToString(),
                "|LSATDe=",
                this.LSATDe.Value.ToString(),
                "|HAMRDe=",
                this.HAMRDe.Value.ToString(),
                "|BallistaDe=",
                this.BallistaDe.Value.ToString(),
                "|SVUDe=",
                this.SVUDe.Value.ToString(),
                "|DSRDe=",
                this.DSRDe.Value.ToString(),
                "|XPRDe=",
                this.XPRDe.Value.ToString(),
                "|R870De=",
                this.R870De.Value.ToString(),
                "|M1216De=",
                this.M1216De.Value.ToString(),
                "|S12De=",
                this.S12De.Value.ToString(),
                "|KSGDe=",
                this.KSGDe.Value.ToString(),
                "|ShieldDe=",
                this.ShieldDe.Value.ToString(),
                "|BowDe=",
                this.BowDe.Value.ToString(),
                "|BallKnifeDe=",
                this.BallKnifeDe.Value.ToString(),
                "|KAPHd=",
                this.KAPHd.Value.ToString(),
                "|TacHd=",
                this.TacHd.Value.ToString(),
                "|B23RHd=",
                this.B23RHd.Value.ToString(),
                "|ExeHd=",
                this.ExeHd.Value.ToString(),
                "|FivesHd=",
                this.FivesHd.Value.ToString(),
                "|MP7Hd=",
                this.MP7Hd.Value.ToString(),
                "|EVOHd=",
                this.EVOHd.Value.ToString(),
                "|PDWHd=",
                this.PDWHd.Value.ToString(),
                "|CQBHd=",
                this.CQBHd.Value.ToString(),
                "|MSMCHd=",
                this.MSMCHd.Value.ToString(),
                "|K10Hd=",
                this.K10Hd.Value.ToString(),
                "|PeaceHd=",
                this.PeaceHd.Value.ToString(),
                "|M8A1Hd=",
                this.M8A1Hd.Value.ToString(),
                "|SCARHd=",
                this.SCARHd.Value.ToString(),
                "|ANHd=",
                this.ANHd.Value.ToString(),
                "|SWATHd=",
                this.SWATHd.Value.ToString(),
                "|TypeHd=",
                this.TypeHd.Value.ToString(),
                "|FALHd=",
                this.FALHd.Value.ToString(),
                "|SMRHd=",
                this.SMRHd.Value.ToString(),
                "|M27Hd=",
                this.M27Hd.Value.ToString(),
                "|MTARHd=",
                this.MTARHd.Value.ToString(),
                "|MK48Hd=",
                this.MK48Hd.Value.ToString(),
                "|QBBHd=",
                this.QBBHd.Value.ToString(),
                "|LSATHd=",
                this.LSATHd.Value.ToString(),
                "|HAMRHd=",
                this.HAMRHd.Value.ToString(),
                "|BallistaHd=",
                this.BallistaHd.Value.ToString(),
                "|SVUHd=",
                this.SVUHd.Value.ToString(),
                "|DSRHd=",
                this.DSRHd.Value.ToString(),
                "|XPRHd=",
                this.XPRHd.Value.ToString(),
                "|R870Hd=",
                this.R870Hd.Value.ToString(),
                "|M1216Hd=",
                this.M1216Hd.Value.ToString(),
                "|S12Hd=",
                this.S12Hd.Value.ToString(),
                "|KSGHd=",
                this.KSGHd.Value.ToString(),
                "|BallKnifeHd=",
                this.BallKnifeHd.Value.ToString(),
                "|KAPAc=",
                this.KAPAc.Value.ToString(),
                "|TacAc=",
                this.TacAc.Value.ToString(),
                "|B23RAc=",
                this.B23RAc.Value.ToString(),
                "|ExeAc=",
                this.ExeAc.Value.ToString(),
                "|FivesAc=",
                this.FivesAc.Value.ToString(),
                "|MP7Ac=",
                this.MP7Ac.Value.ToString(),
                "|EVOAc=",
                this.EVOAc.Value.ToString(),
                "|PDWAc=",
                this.PDWAc.Value.ToString(),
                "|CQBAc=",
                this.CQBAc.Value.ToString(),
                "|MSMCAc=",
                this.MSMCAc.Value.ToString(),
                "|K10Ac=",
                this.K10Ac.Value.ToString(),
                "|PeaceAc=",
                this.PeaceAc.Value.ToString(),
                "|M8A1Ac=",
                this.M8A1Ac.Value.ToString(),
                "|SCARAc=",
                this.SCARAc.Value.ToString(),
                "|ANAc=",
                this.ANAc.Value.ToString(),
                "|SWATAc=",
                this.SWATAc.Value.ToString(),
                "|TypeAc=",
                this.TypeAc.Value.ToString(),
                "|FALAc=",
                this.FALAc.Value.ToString(),
                "|SMRAc=",
                this.SMRAc.Value.ToString(),
                "|M27Ac=",
                this.M27Ac.Value.ToString(),
                "|MTARAc=",
                this.MTARAc.Value.ToString(),
                "|MK48Ac=",
                this.MK48Ac.Value.ToString(),
                "|QBBAc=",
                this.QBBAc.Value.ToString(),
                "|LSATAc=",
                this.LSATAc.Value.ToString(),
                "|HAMRAc=",
                this.HAMRAc.Value.ToString(),
                "|BallistaAc=",
                this.BallistaAc.Value.ToString(),
                "|SVUAc=",
                this.SVUAc.Value.ToString(),
                "|DSRAc=",
                this.DSRAc.Value.ToString(),
                "|XPRAc=",
                this.XPRAc.Value.ToString(),
                "|R870Ac=",
                this.R870Ac.Value.ToString(),
                "|M1216Ac=",
                this.M1216Ac.Value.ToString(),
                "|S12Ac=",
                this.S12Ac.Value.ToString(),
                "|KSGAc=",
                this.KSGAc.Value.ToString(),
                "|BowAc=",
                this.BowAc.Value.ToString(),
                "|BallKnifeAc=",
                this.BallKnifeAc.Value.ToString(),
                "|UAVUse=",
                this.UAVUse.Value.ToString(),
                "|RXUse=",
                this.RXUse.Value.ToString(),
                "|HtUse=",
                this.HtUse.Value.ToString(),
                "|CPacUse=",
                this.CPacUse.Value.ToString(),
                "|CoutUse=",
                this.CoutUse.Value.ToString(),
                "|GdiUse=",
                this.GdiUse.Value.ToString(),
                "|MisUse=",
                this.MisUse.Value.ToString(),
                "|StikUse=",
                this.StikUse.Value.ToString(),
                "|SenyUse=",
                this.SenyUse.Value.ToString(),
                "|DetUse=",
                this.DetUse.Value.ToString(),
                "|WarUse=",
                this.WarUse.Value.ToString(),
                "|DrgUse=",
                this.DrgUse.Value.ToString(),
                "|AGRUse=",
                this.AGRUse.Value.ToString(),
                "|ChopUse=",
                this.ChopUse.Value.ToString(),
                "|VSATUse=",
                this.VSATUse.Value.ToString(),
                "|DrnUse=",
                this.DrnUse.Value.ToString(),
                "|EMPUse=",
                this.EMPUse.Value.ToString(),
                "|WathUse=",
                this.WathUse.Value.ToString(),
                "|LodsUse=",
                this.LodsUse.Value.ToString(),
                "|VTOLUse=",
                this.VTOLUse.Value.ToString(),
                "|K9Use=",
                this.K9Use.Value.ToString(),
                "|SwrUse=",
                this.SwrUse.Value.ToString(),
                "|UAVOth=",
                this.UAVOth.Value.ToString(),
                "|RXOth=",
                this.RXOth.Value.ToString(),
                "|HtOth=",
                this.HtOth.Value.ToString(),
                "|CPacOth=",
                this.CPacOth.Value.ToString(),
                "|CoutOth=",
                this.CoutOth.Value.ToString(),
                "|GdiOth=",
                this.GdiOth.Value.ToString(),
                "|MisOth=",
                this.MisOth.Value.ToString(),
                "|StikOth=",
                this.StikOth.Value.ToString(),
                "|SenyOth=",
                this.SenyOth.Value.ToString(),
                "|DetOth=",
                this.DetOth.Value.ToString(),
                "|WarOth=",
                this.WarOth.Value.ToString(),
                "|DrgOth=",
                this.DrgOth.Value.ToString(),
                "|AGROth=",
                this.AGROth.Value.ToString(),
                "|ChopOth=",
                this.ChopOth.Value.ToString(),
                "|VSATOth=",
                this.VSATOth.Value.ToString(),
                "|DrnOth=",
                this.DrnOth.Value.ToString(),
                "|EMPOth=",
                this.EMPOth.Value.ToString(),
                "|WathOth=",
                this.WathOth.Value.ToString(),
                "|LodsOth=",
                this.LodsOth.Value.ToString(),
                "|VTOLOth=",
                this.VTOLOth.Value.ToString(),
                "|K9Oth=",
                this.K9Oth.Value.ToString(),
                "|SwrOth=",
                this.SwrOth.Value.ToString(),
                "|Medal=",
                this.Bouncer.Value.ToString(),
                "|Medal=",
                this.AssistedSuicide.Value.ToString(),
                "|Medal=",
                this.BackStabber.Value.ToString(),
                "|Medal=",
                this.Skewered.Value.ToString(),
                "|Medal=",
                this.Bomber.Value.ToString(),
                "|Medal=",
                this.Bankshot.Value.ToString(),
                "|Medal=",
                this.Hijacker.Value.ToString(),
                "|Medal=",
                this.Wipeout.Value.ToString(),
                "|Medal=",
                this.Comeback.Value.ToString(),
                "|Medal=",
                this.StrengthandHonor.Value.ToString(),
                "|Medal=",
                this.Deadeye.Value.ToString(),
                "|Medal=",
                this.Decimated.Value.ToString(),
                "|Medal=",
                this.Clutch1.Value.ToString(),
                "|Medal=",
                this.Hero.Value.ToString(),
                "|Medal=",
                this.Clutch2.Value.ToString(),
                "|Medal=",
                this.DroneHunter.Value.ToString(),
                "|Medal=",
                this.Fuzzbuster.Value.ToString(),
                "|Medal=",
                this.ShadowCatcher.Value.ToString(),
                "|Medal=",
                this.Demolished.Value.ToString(),
                "|Medal=",
                this.BigGameHunter.Value.ToString(),
                "|Medal=",
                this.BurnOut.Value.ToString(),
                "|Medal=",
                this.Rejected.Value.ToString(),
                "|Medal=",
                this.Exterminator.Value.ToString(),
                "|Medal=",
                this.TKO.Value.ToString(),
                "|Medal=",
                this.Flyswatter.Value.ToString(),
                "|Medal=",
                this.RoadRage.Value.ToString(),
                "|Medal=",
                this.Intercepted.Value.ToString(),
                "|Medal=",
                this.Uppercut.Value.ToString(),
                "|Medal=",
                this.Scrapped.Value.ToString(),
                "|Medal=",
                this.Hogtied.Value.ToString(),
                "|Medal=",
                this.NoTip.Value.ToString(),
                "|Medal=",
                this.Blackout.Value.ToString(),
                "|Medal=",
                this.Warbeast.Value.ToString(),
                "|Medal=",
                this.Elimination1.Value.ToString(),
                "|Medal=",
                this.Elimination2.Value.ToString(),
                "|Medal=",
                this.LastManStanding.Value.ToString(),
                "|Medal=",
                this.FirstBlood.Value.ToString(),
                "|Medal=",
                this.Playmaker.Value.ToString(),
                "|Medal=",
                this.CloseCall.Value.ToString(),
                "|Medal=",
                this.Hacked.Value.ToString(),
                "|Medal=",
                this.ChoppedUp.Value.ToString(),
                "|Medal=",
                this.Headshot.Value.ToString(),
                "|Medal=",
                this.SilentKiller.Value.ToString(),
                "|Medal=",
                this.Wingman.Value.ToString(),
                "|Medal=",
                this.DeathFromAbove.Value.ToString(),
                "|Medal=",
                this.Secure1.Value.ToString(),
                "|Medal=",
                this.Humiliation.Value.ToString(),
                "|Medal=",
                this.CleanUp.Value.ToString(),
                "|Medal=",
                this.Efficiency.Value.ToString(),
                "|Medal=",
                this.Afterlife.Value.ToString(),
                "|Medal=",
                this.Savior.Value.ToString(),
                "|Medal=",
                this.OneShotOneKill.Value.ToString(),
                "|Medal=",
                this.Dropshot.Value.ToString(),
                "|Medal=",
                this.Survivor.Value.ToString(),
                "|Medal=",
                this.Aggression.Value.ToString(),
                "|Medal=",
                this.Avenger.Value.ToString(),
                "|Medal=",
                this.Pancake.Value.ToString(),
                "|Medal=",
                this.BaitTaken.Value.ToString(),
                "|Medal=",
                this.Underdog.Value.ToString(),
                "|Medal=",
                this.Backfire.Value.ToString(),
                "|Medal=",
                this.Takedown1.Value.ToString(),
                "|Medal=",
                this.Gunslinger.Value.ToString(),
                "|Medal=",
                this.Regicide1.Value.ToString(),
                "|Medal=",
                this.Bankrupted.Value.ToString(),
                "|Medal=",
                this.SwitchHitter.Value.ToString(),
                "|Medal=",
                this.ComboBreaker.Value.ToString(),
                "|Medal=",
                this.Denied1.Value.ToString(),
                "|Medal=",
                this.Takedown2.Value.ToString(),
                "|Medal=",
                this.Denied2.Value.ToString(),
                "|Medal=",
                this.Merciless.Value.ToString(),
                "|Medal=",
                this.Ruthless.Value.ToString(),
                "|Medal=",
                this.Relentless.Value.ToString(),
                "|Medal=",
                this.Brutal.Value.ToString(),
                "|Medal=",
                this.Nuclear.Value.ToString(),
                "|Medal=",
                this.Bloodthirsty.Value.ToString(),
                "|Medal=",
                this.Unstoppable.Value.ToString(),
                "|Medal=",
                this.Regicide2.Value.ToString(),
                "|Medal=",
                this.Frugal.Value.ToString(),
                "|Medal=",
                this.HardpointSecure.Value.ToString(),
                "|Medal=",
                this.LongShot.Value.ToString(),
                "|Medal=",
                this.ShieldBash.Value.ToString(),
                "|Medal=",
                this.Cooked.Value.ToString(),
                "|Medal=",
                this.Bullseye.Value.ToString(),
                "|Medal=",
                this.FallingSkies.Value.ToString(),
                "|Medal=",
                this.GunExpert.Value.ToString(),
                "|Medal=",
                this.DoubleKill.Value.ToString(),
                "|Medal=",
                this.TripleKill.Value.ToString(),
                "|Medal=",
                this.FuryKill.Value.ToString(),
                "|Medal=",
                this.FrenzyKill.Value.ToString(),
                "|Medal=",
                this.SuperKill.Value.ToString(),
                "|Medal=",
                this.MegaKill.Value.ToString(),
                "|Medal=",
                this.UltraKill.Value.ToString(),
                "|Medal=",
                this.KillChain.Value.ToString(),
                "|Medal=",
                this.Boomstick.Value.ToString(),
                "|Medal=",
                this.OpeningMove.Value.ToString(),
                "|Medal=",
                this.StrikeDelivered.Value.ToString(),
                "|Medal=",
                this.Secure2.Value.ToString(),
                "|Medal=",
                this.RedBaron.Value.ToString(),
                "|Medal=",
                this.ForwardPosition.Value.ToString(),
                "|Medal=",
                this.Kaboom.Value.ToString(),
                "|Medal=",
                this.RainingDeath.Value.ToString(),
                "|Medal=",
                this.DistantThunder.Value.ToString(),
                "|Medal=",
                this.Retrieved.Value.ToString(),
                "|Medal=",
                this.Revenge.Value.ToString(),
                "|Medal=",
                this.Crackdown.Value.ToString(),
                "|Medal=",
                this.SharedAGR.Value.ToString(),
                "|Medal=",
                this.SharedCounterUAV.Value.ToString(),
                "|Medal=",
                this.SharedDeathMachine.Value.ToString(),
                "|Medal=",
                this.SharedK9Unit.Value.ToString(),
                "|Medal=",
                this.SharedEMPSystems.Value.ToString(),
                "|Medal=",
                this.SharedStealthChopper.Value.ToString(),
                "|Medal=",
                this.SharedEscortDrone.Value.ToString(),
                "|Medal=",
                this.SharedVTOLWarship.Value.ToString(),
                "|Medal=",
                this.SharedGuardian.Value.ToString(),
                "|Medal=",
                this.SharedHunterKiller.Value.ToString(),
                "|Medal=",
                this.SharedSwarm.Value.ToString(),
                "|Medal=",
                this.SharedWarMachine.Value.ToString(),
                "|Medal=",
                this.SharedLightningStrike.Value.ToString(),
                "|Medal=",
                this.SharedDragonfire.Value.ToString(),
                "|Medal=",
                this.SharedRCXD.Value.ToString(),
                "|Medal=",
                this.SharedHellstormMissile.Value.ToString(),
                "|Medal=",
                this.SharedLodestar.Value.ToString(),
                "|Medal=",
                this.SharedOrbitalVSAT.Value.ToString(),
                "|Medal=",
                this.SharedSentryGun.Value.ToString(),
                "|Medal=",
                this.SharedWarthog.Value.ToString(),
                "|Medal=",
                this.SharedUAV.Value.ToString(),
                "|Medal=",
                this.Stick.Value.ToString(),
                "|Medal=",
                this.BuzzKill.Value.ToString(),
                "|Medal=",
                this.Cropduster.Value.ToString(),
                "|Medal=",
                this.QuadFeed.Value.ToString(),
                "|Medal=",
                this.Victor.Value.ToString(),
                "|Medal=",
                this.DoubleDown.Value.ToString(),
                "|Value=",
                this.GrenadeUse.Value.ToString(),
                "|Value=",
                this.CombatAxeUse.Value.ToString(),
                "|Value=",
                this.SemtexUse.Value.ToString(),
                "|Value=",
                this.C4Use.Value.ToString(),
                "|Value=",
                this.BouncingBettyUse.Value.ToString(),
                "|Value=",
                this.ClaymoreUse.Value.ToString(),
                "|Value=",
                this.SmokeGrenadeUse.Value.ToString(),
                "|Value=",
                this.ConcussionUse.Value.ToString(),
                "|Value=",
                this.EMPGrenadeUse.Value.ToString(),
                "|Value=",
                this.SensorGrenadeUse.Value.ToString(),
                "|Value=",
                this.FlashbangUse.Value.ToString(),
                "|Value=",
                this.ShockChargeUse.Value.ToString(),
                "|Value=",
                this.BlackHatUse.Value.ToString(),
                "|Value=",
                this.TacticalInsertionUse.Value.ToString(),
                "|Value=",
                this.TrophySystemUse.Value.ToString(),
                "|Value=",
                this.GrenadeOth.Value.ToString(),
                "|Value=",
                this.CombatAxeOth.Value.ToString(),
                "|Value=",
                this.SemtexOth.Value.ToString(),
                "|Value=",
                this.C4Oth.Value.ToString(),
                "|Value=",
                this.BouncingBettyOth.Value.ToString(),
                "|Value=",
                this.ClaymoreOth.Value.ToString(),
                "|Value=",
                this.SmokeGrenadeOth.Value.ToString(),
                "|Value=",
                this.ConcussionOth.Value.ToString(),
                "|Value=",
                this.EMPGrenadeOth.Value.ToString(),
                "|Value=",
                this.SensorGrenadeOth.Value.ToString(),
                "|Value=",
                this.FlashbangOth.Value.ToString(),
                "|Value=",
                this.ShockChargeOth.Value.ToString(),
                "|Value=",
                this.BlackHatOth.Value.ToString(),
                "|Value=",
                this.TacticalInsertionOth.Value.ToString(),
                "|Value=",
                this.TrophySystemOth.Value.ToString(),
                "|Value=",
                this.TDMWin.Value.ToString(),
                "|Value=",
                this.FreeForAllWin.Value.ToString(),
                "|Value=",
                this.SDWin.Value.ToString(),
                "|Value=",
                this.DominationWin.Value.ToString(),
                "|Value=",
                this.HardpointWin.Value.ToString(),
                "|Value=",
                this.HeadquartersWin.Value.ToString(),
                "|Value=",
                this.DemolitionWin.Value.ToString(),
                "|Value=",
                this.CTFWin.Value.ToString(),
                "|Value=",
                this.KillConfirmedWin.Value.ToString(),
                "|Value=",
                this.GunGameWin.Value.ToString(),
                "|Value=",
                this.OneintheChamberWin.Value.ToString(),
                "|Value=",
                this.SharpshooterWin.Value.ToString(),
                "|Value=",
                this.SticksandStonesWin.Value.ToString(),
                "|Value=",
                this.HCTDMWin.Value.ToString(),
                "|Value=",
                this.HCSDWin.Value.ToString(),
                "|Value=",
                this.HCDominationWin.Value.ToString(),
                "|Value=",
                this.HCKillConfirmedWin.Value.ToString(),
                "|Value=",
                this.TDMLos.Value.ToString(),
                "|Value=",
                this.FreeForAllLos.Value.ToString(),
                "|Value=",
                this.SDLos.Value.ToString(),
                "|Value=",
                this.DominationLos.Value.ToString(),
                "|Value=",
                this.HardpointLos.Value.ToString(),
                "|Value=",
                this.HeadquartersLos.Value.ToString(),
                "|Value=",
                this.DemolitionLos.Value.ToString(),
                "|Value=",
                this.CTFLos.Value.ToString(),
                "|Value=",
                this.KillConfirmedLos.Value.ToString(),
                "|Value=",
                this.GunGameLos.Value.ToString(),
                "|Value=",
                this.OneintheChamberLos.Value.ToString(),
                "|Value=",
                this.SharpshooterLos.Value.ToString(),
                "|Value=",
                this.SticksandStonesLos.Value.ToString(),
                "|Value=",
                this.HCTDMLos.Value.ToString(),
                "|Value=",
                this.HCSDLos.Value.ToString(),
                "|Value=",
                this.HCDominationLos.Value.ToString(),
                "|Value=",
                this.HCKillConfirmedLos.Value.ToString(),
                "|Value=",
                this.TDMCur.Value.ToString(),
                "|Value=",
                this.FreeForAllCur.Value.ToString(),
                "|Value=",
                this.SDCur.Value.ToString(),
                "|Value=",
                this.DominationCur.Value.ToString(),
                "|Value=",
                this.HardpointCur.Value.ToString(),
                "|Value=",
                this.HeadquartersCur.Value.ToString(),
                "|Value=",
                this.DemolitionCur.Value.ToString(),
                "|Value=",
                this.CTFCur.Value.ToString(),
                "|Value=",
                this.KillConfirmedCur.Value.ToString(),
                "|Value=",
                this.GunGameCur.Value.ToString(),
                "|Value=",
                this.OneintheChamberCur.Value.ToString(),
                "|Value=",
                this.SharpshooterCur.Value.ToString(),
                "|Value=",
                this.SticksandStonesCur.Value.ToString(),
                "|Value=",
                this.HCTDMCur.Value.ToString(),
                "|Value=",
                this.HCSDCur.Value.ToString(),
                "|Value=",
                this.HCDominationCur.Value.ToString(),
                "|Value=",
                this.HCKillConfirmedCur.Value.ToString(),
                "|Value=",
                this.TDMBes.Value.ToString(),
                "|Value=",
                this.FreeForAllBes.Value.ToString(),
                "|Value=",
                this.SDBes.Value.ToString(),
                "|Value=",
                this.DominationBes.Value.ToString(),
                "|Value=",
                this.HardpointBes.Value.ToString(),
                "|Value=",
                this.HeadquartersBes.Value.ToString(),
                "|Value=",
                this.DemolitionBes.Value.ToString(),
                "|Value=",
                this.CTFBes.Value.ToString(),
                "|Value=",
                this.KillConfirmedBes.Value.ToString(),
                "|Value=",
                this.GunGameBes.Value.ToString(),
                "|Value=",
                this.OneintheChamberBes.Value.ToString(),
                "|Value=",
                this.SharpshooterBes.Value.ToString(),
                "|Value=",
                this.SticksandStonesBes.Value.ToString(),
                "|Value=",
                this.HCTDMBes.Value.ToString(),
                "|Value=",
                this.HCSDBes.Value.ToString(),
                "|Value=",
                this.HCDominationBes.Value.ToString(),
                "|Value=",
                this.HCKillConfirmedBes.Value.ToString()
            })))
            {
                this.SLStatus.ForeColor = Color.Green;
                this.SLStatus.Text = "Saved";
            }
            else
            {
                this.SLStatus.ForeColor = Color.Red;
                this.SLStatus.Text = "Failed To Save";
            }
        }
        // Token: 0x04000158 RID: 344
        private string DCC;

        // Token: 0x0400019A RID: 410
        private CheckBox[] EqutCheck;

        // Token: 0x0400019B RID: 411
        private NumericUpDown[] EqutOth;

        // Token: 0x0400019C RID: 412
        private NumericUpDown[] EqutUse;

        // Token: 0x040001D2 RID: 466
        private NumericUpDown[] GamesBes;

        // Token: 0x040001D3 RID: 467
        private CheckBox[] GamesCheck;

        // Token: 0x040001D4 RID: 468
        private NumericUpDown[] GamesCur;

        // Token: 0x040001D5 RID: 469
        private NumericUpDown[] GamesLos;

        // Token: 0x040001D6 RID: 470
        private NumericUpDown[] GamesWin;

        // Token: 0x0400022A RID: 554
        private string IPT;

        // Token: 0x04000394 RID: 916
        private CheckBox[] MedalsCheck;

        // Token: 0x04000395 RID: 917
        private NumericUpDown[] MedalsNum;

        // Token: 0x04000483 RID: 1155
        private CheckBox[] StreaksCheck;

        // Token: 0x04000484 RID: 1156
        private NumericUpDown[] StreaksOth;

        // Token: 0x04000485 RID: 1157
        private NumericUpDown[] StreaksUse;

        // Token: 0x040004F2 RID: 1266
        private NumericUpDown[] WeapAccy;

        // Token: 0x040004F3 RID: 1267
        private CheckBox[] WeapCheck;

        // Token: 0x040004F4 RID: 1268
        private NumericUpDown[] WeapDeath;

        // Token: 0x040004F5 RID: 1269
        private NumericUpDown[] WeapHead;

        // Token: 0x040004F6 RID: 1270
        private NumericUpDown[] WeapKill;
        private void TotalMB_Click(object sender, EventArgs e)
        {
            uint num = (uint)(this.K10Ks.Value + this.S12Ks.Value + this.DSRKs.Value + this.PeaceKs.Value + this.M1216Ks.Value + this.SCARKs.Value + this.CQBKs.Value + this.ANKs.Value + this.R870Ks.Value + this.BallistaKs.Value + this.KSGKs.Value + this.M27Ks.Value + this.TypeKs.Value + this.MP7Ks.Value + this.PDWKs.Value + this.MTARKs.Value + this.MSMCKs.Value + this.EVOKs.Value + this.TacKs.Value + this.SMRKs.Value + this.FivesKs.Value + this.KAPKs.Value + this.B23RKs.Value + this.SWATKs.Value + this.MK48Ks.Value + this.XPRKs.Value + this.M8A1Ks.Value + this.LSATKs.Value + this.ExeKs.Value + this.HAMRKs.Value + this.FALKs.Value + this.QBBKs.Value + this.SVUKs.Value + this.BowKs.Value + this.BallKnifeKs.Value + this.SMAWKs.Value + this.RPGKs.Value + this.ShieldKs.Value + this.FHJKs.Value + this.K9Oth.Value + this.StikOth.Value + this.HtOth.Value + this.SwrOth.Value + this.LodsOth.Value + this.CPacOth.Value + this.VTOLOth.Value + this.MisOth.Value + this.SenyOth.Value + this.ChopOth.Value + this.GdiOth.Value + this.DrnOth.Value + this.WathOth.Value + this.DrgOth.Value + this.RXOth.Value + this.WarOth.Value + this.AGROth.Value + this.DetOth.Value);
            uint num2 = (uint)(this.K10Hd.Value + this.S12Hd.Value + this.DSRHd.Value + this.PeaceHd.Value + this.M1216Hd.Value + this.SCARHd.Value + this.CQBHd.Value + this.ANHd.Value + this.R870Hd.Value + this.BallistaHd.Value + this.KSGHd.Value + this.M27Hd.Value + this.TypeHd.Value + this.MP7Hd.Value + this.PDWHd.Value + this.MTARHd.Value + this.MSMCHd.Value + this.EVOHd.Value + this.TacHd.Value + this.SMRHd.Value + this.FivesHd.Value + this.KAPHd.Value + this.B23RHd.Value + this.SWATHd.Value + this.MK48Hd.Value + this.XPRHd.Value + this.M8A1Hd.Value + this.LSATHd.Value + this.ExeHd.Value + this.HAMRHd.Value + this.FALHd.Value + this.QBBHd.Value + this.SVUHd.Value + this.BallKnifeHd.Value);
            uint num3 = (uint)(this.K10De.Value + this.S12De.Value + this.DSRDe.Value + this.PeaceDe.Value + this.M1216De.Value + this.SCARDe.Value + this.CQBDe.Value + this.ANDe.Value + this.R870De.Value + this.BallistaDe.Value + this.KSGDe.Value + this.M27De.Value + this.TypeDe.Value + this.MP7De.Value + this.PDWDe.Value + this.MTARDe.Value + this.MSMCDe.Value + this.EVODe.Value + this.TacDe.Value + this.SMRDe.Value + this.FivesDe.Value + this.KAPDe.Value + this.B23RDe.Value + this.SWATDe.Value + this.MK48De.Value + this.XPRDe.Value + this.M8A1De.Value + this.LSATDe.Value + this.ExeDe.Value + this.HAMRDe.Value + this.FALDe.Value + this.QBBDe.Value + this.SVUDe.Value + this.BowDe.Value + this.BallKnifeDe.Value + this.ShieldDe.Value);
            uint num4 = (uint)(this.TDMWin.Value + this.FreeForAllWin.Value + this.SDWin.Value + this.DominationWin.Value + this.HardpointWin.Value + this.HeadquartersWin.Value + this.DemolitionWin.Value + this.CTFWin.Value + this.KillConfirmedWin.Value + this.GunGameWin.Value + this.OneintheChamberWin.Value + this.SharpshooterWin.Value + this.SticksandStonesWin.Value + this.HCTDMWin.Value + this.HCSDWin.Value + this.HCDominationWin.Value + this.HCKillConfirmedWin.Value);
            uint num5 = (uint)(this.TDMLos.Value + this.FreeForAllLos.Value + this.SDLos.Value + this.DominationLos.Value + this.HardpointLos.Value + this.HeadquartersLos.Value + this.DemolitionLos.Value + this.CTFLos.Value + this.KillConfirmedLos.Value + this.GunGameLos.Value + this.OneintheChamberLos.Value + this.SharpshooterLos.Value + this.SticksandStonesLos.Value + this.HCTDMLos.Value + this.HCSDLos.Value + this.HCDominationLos.Value + this.HCKillConfirmedLos.Value);
            string text;
            if (num != 0u && num3 != 0u)
            {
                text = (num / num3).ToString("0.00").Replace(".00", string.Empty);
            }
            else
            {
                text = 0.0.ToString();
            }
            string text2;
            if (num4 != 0u && num5 != 0u)
            {
                text2 = (num4 / num5).ToString("0.00").Replace(".00", string.Empty);
            }
            else
            {
                text2 = 0.0.ToString();
            }
            MessageBox.Show(string.Concat(new object[]
            {
                "Kills: ",
                num,
                "\nDeaths: ",
                num3,
                "\nWins: ",
                num4,
                "\nLosses: ",
                num5,
                "\nHeadshots: ",
                num2,
                "\nK/D: ",
                text,
                "\nW/L: ",
                text2,
                "\n\nDon't Include Medals"
            }));
        }
        private void SetValue(uint Offset, decimal Value, uint Multi)
        {
            PS6.Func.SetUInt32(Offset, (uint)Value * Multi, true);
        }
        private void SaveStreaks()
        {
            for (int i = 0; i < this.StreaksCheck.Length; i++)
            {
                if (this.StreaksCheck[i].Checked)
                {
                    this.SetValue(Stats.Streaks.OffsetsUse[i] + Stats.StatsCombat, this.StreaksUse[i].Value, Stats.Streaks.Multi[i]);
                    this.SetValue(Stats.Streaks.OffsetsOther[i] + Stats.StatsCombat, this.StreaksOth[i].Value, Stats.Streaks.Multi[i]);
                }
            }
        }
        private void SaveGames()
        {
            for (int i = 0; i < Stats.Gamemodes.Offsets.Length; i++)
            {
                if (this.GamesCheck[i].Checked)
                {
                    this.SetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 90u, this.GamesWin[i].Value, Stats.Gamemodes.Multi[i]);
                    this.SetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 42u, this.GamesLos[i].Value, Stats.Gamemodes.Multi[i]);
                    this.SetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i], this.GamesCur[i].Value, Stats.Gamemodes.Multi[i]);
                    this.SetValue(Stats.StatsCombat - Stats.Gamemodes.Offsets[i] + 96u, this.GamesBes[i].Value, Stats.Gamemodes.Multi[i]);
                }
            }
        }
        private void SetAcValue(uint offset, decimal Value)
        {
            PS3.SetMemory(offset, BitConverter.GetBytes((uint)(Value / 100m * PS6.Func.GetUInt32(offset - 6u, true))));
        }
        private void SaveWeapons()
        {
            for (int i = 0; i < 39; i++)
            {
                if (this.WeapCheck[i].Checked)
                {
                    this.SetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i], this.WeapKill[i].Value, Stats.Weapons.Multi[i]);
                }
                if (i != 34 || i != 35 || i != 36)
                {
                    this.SetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 12u, this.WeapDeath[i].Value, Stats.Weapons.Multi[i]);
                }
                if (i != 34 || i != 35 || i != 36 || i != 37)
                {
                    this.SetAcValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 24u, this.WeapAccy[i].Value);
                }
                if (i != 34 || i != 35 || (i != 36 || i != 37) || i != 38)
                {
                    this.SetValue(Stats.StatsCombat + Stats.Weapons.Offsets[i] + 30u, this.WeapHead[i].Value, Stats.Weapons.Multi[i]);
                }
            }
        }
        private void SaveMedals()
        {
            for (int i = 0; i < Stats.Medals.Offsets.Length; i++)
            {
                if (this.MedalsCheck[i].Checked)
                {
                    PS6.Func.SetUInt32(Stats.MedalsSt - Stats.Medals.Offsets[i], (uint)this.MedalsNum[i].Value, true);
                    if (i == 41)
                    {
                        PS6.Func.SetUInt32(Stats.MedalsSt - 1488u, (uint)this.MedalsNum[i].Value, true);
                    }
                }
            }
        }

        private void SaveEuit()
        {
            for (int i = 0; i < Stats.Equipment.Use.Length; i++)
            {
                this.SetValue(Stats.StatsCombat + Stats.Equipment.Use[i], this.EqutUse[i].Value, Stats.Equipment.Multi[i]);
                this.SetValue(Stats.StatsCombat + Stats.Equipment.Oth[i], this.EqutOth[i].Value, Stats.Equipment.Multi[i]);
            }
        }
        private void SaveStatsBut_Click(object sender, EventArgs e)
        {

        }

        private void SaveStatsBut_Click_1(object sender, EventArgs e)
        {
            this.SaveStreaks();
            this.SaveWeapons();
            this.SaveGames();
            this.SaveMedals();
            this.SaveEuit();
        }
    }
}

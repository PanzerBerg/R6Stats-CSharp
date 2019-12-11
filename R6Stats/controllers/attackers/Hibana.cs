using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Stats.controllers.attackers
{
    static class Hibana
    {
        private static string timePlayed;
        private static string kills;
        private static string deaths;
        private static string kd;
        private static string wins;
        private static string losses;
        private static string wl;
        private static string meleeKills;
        private static string headshots;
        private static string dbnos;
        private static string gadgetUses;

        public static string TimePlayed { get => timePlayed; set => timePlayed = value; }
        public static string Kills { get => kills; set => kills = value; }
        public static string Deaths { get => deaths; set => deaths = value; }
        public static string KD { get => kd; set => kd = value; }
        public static string Wins { get => wins; set => wins = value; }
        public static string Losses { get => losses; set => losses = value; }
        public static string WL { get => wl; set => wl = value; }
        public static string MeleeKills { get => meleeKills; set => meleeKills = value; }
        public static string Headshots { get => headshots; set => headshots = value; }
        public static string DBNOS { get => dbnos; set => dbnos = value; }
        public static string GadgetUses { get => gadgetUses; set => gadgetUses = value; }

        public static void WinRatio()
        {
            double Wl = double.Parse(wins) / double.Parse(losses);
            WL = String.Format("{0:0.00}", wl);
        }

    }
}

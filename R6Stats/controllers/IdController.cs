using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Stats.controllers
{
    static class IdController
    {
        private static bool existe;
        public static bool Existe { get => existe; set => existe = value; }

        private static string contaWins;
        public static string ContaWins { get => contaWins; set => contaWins = value; }

        private static string contaLosses;
        public static string ContaLosses { get => contaLosses; set => contaLosses = value; }

        private static string contaWL;
        public static string ContaWL { get => contaWL; set => contaWL = value; }

        private static string contaKD;
        public static string ContaKD { get => contaKD; set => contaKD = value; }

        private static string opDef;
        public static string OpDef { get => opDef; set => opDef = value; }

        private static string opAtq;
        public static string OpAtq { get => opAtq; set => opAtq = value; }

        private static string opAtqTime;
        public static string OpAtqTime { get => opAtqTime; set => opAtqTime = value; }

        private static string opDefTime;
        public static string OpDefTime { get => opDefTime; set => opDefTime = value; }

        private static string opAtqKD;
        public static string OpAtqKD { get => opAtqKD; set => opAtqKD = value; }

        private static string opDefKD;
        public static string OpDefKD { get => opDefKD; set => opDefKD = value; }

        private static string opAtqWins;
        public static string OpAtqWins { get => opAtqWins; set => opAtqWins = value; }

        private static string opAtqLosses;
        public static string OpAtqLosses { get => opAtqLosses; set => opAtqLosses = value; }

        private static string opDefWins;
        public static string OpDefWins { get => opDefWins; set => opDefWins = value; }

        private static string opDefLosses;
        public static string OpDefLosses { get => opDefLosses; set => opDefLosses = value; }

        private static string opAtqWL;
        public static string OpAtqWL { get => opAtqWL; set => opAtqWL = value; }

        private static string opDefWL;
        public static string OpDefWL { get => opDefWL; set => opDefWL = value; }


        public static void WinRatio()
        {
            double atqWl = double.Parse(opAtqWins) / double.Parse(opAtqLosses);
            double defWl = double.Parse(opDefWins) / double.Parse(opDefLosses);
            double contaWl = double.Parse(contaWins.Replace(",", "")) / double.Parse(contaLosses.Replace(",", ""));
            opAtqWL = String.Format("{0:0.00}", atqWl);
            opDefWL = String.Format("{0:0.00}", defWl);
            contaWL = String.Format("{0:0.00}", contaWl);
        }

    }
}

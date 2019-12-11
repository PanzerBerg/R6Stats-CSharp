using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Stats.controllers
{
    static class IdController
    {
        private static bool   existe;
        private static string contaWins;
        private static string contaLosses;
        private static string contaWL;
        private static string contaKD;
        private static string contaName;
        private static string contaXP;

        private static string opDef;
        private static string opDefTime;
        private static string opDefKD;
        private static string opDefWins;
        private static string opDefLosses;
        private static string opDefWL;

        private static string opAtq;
        private static string opAtqTime;
        private static string opAtqKD;
        private static string opAtqWins;
        private static string opAtqLosses;
        private static string opAtqWL;

        public static bool   Existe         { get => existe; set => existe = value; }
        public static string ContaWins      { get => contaWins; set => contaWins = value; }
        public static string ContaLosses    { get => contaLosses; set => contaLosses = value; }
        public static string ContaWL        { get => contaWL; set => contaWL = value; }
        public static string ContaKD        { get => contaKD; set => contaKD = value; }
        public static string ContaName      { get => contaName; set => contaName = value; }
        public static string ContaXP       { get => contaXP; set => contaXP = value; }

        public static string OpDef          { get => opDef; set => opDef = value; }
        public static string OpDefTime      { get => opDefTime; set => opDefTime = value; }
        public static string OpDefKD        { get => opDefKD; set => opDefKD = value; }
        public static string OpDefWins      { get => opDefWins; set => opDefWins = value; }
        public static string OpDefLosses    { get => opDefLosses; set => opDefLosses = value; }
        public static string OpDefWL        { get => opDefWL; set => opDefWL = value; }

        public static string OpAtq          { get => opAtq; set => opAtq = value; }
        public static string OpAtqTime      { get => opAtqTime; set => opAtqTime = value; }
        public static string OpAtqKD        { get => opAtqKD; set => opAtqKD = value; }
        public static string OpAtqWins      { get => opAtqWins; set => opAtqWins = value; }
        public static string OpAtqLosses    { get => opAtqLosses; set => opAtqLosses = value; }
        public static string OpAtqWL        { get => opAtqWL; set => opAtqWL = value; }

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

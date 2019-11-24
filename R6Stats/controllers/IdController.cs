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
        private static string op_def;
        private static string op_atq;

        public static bool GetExiste()
        {
            return existe;
        }

        public static void SetExiste(bool value)
        {
            existe = value;
        }

        public static string GetOpDef()
        {
            return op_def;
        }

        public static void SetOpDef(string value)
        {
            op_def = value;
        }

        public static string GetOpAtq()
        {
            return op_atq;
        }

        public static void SetOpAtq(string value)
        {
            op_atq = value;
        }


    }
}

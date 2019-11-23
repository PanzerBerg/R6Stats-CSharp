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

        public static bool GetExiste()
        {
            return existe;
        }

        public static void SetExiste(bool value)
        {
            existe = value;
        }
    }
}

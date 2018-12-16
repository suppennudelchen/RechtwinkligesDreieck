using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechtwinkligesDreieck
{
    class PythBerechnung
    {

        // gegeben c und b
        //berechnet a
        public static double Seite_A_Pyth(double seite_c, double seite_b)
        {
            return Math.Sqrt(Math.Pow(seite_c, 2) - Math.Pow(seite_b, 2));
        }

        // gegeben c und a
        //berechnet b
        public static double Seite_B_Pyth(double seite_c, double seite_a)
        {
            return Math.Sqrt(Math.Pow(seite_c, 2) - Math.Pow(seite_a, 2));
        }


        // gegeben a und b
        //berechnet c
        public static double Seite_C_Pyth(double seite_a, double seite_b)
        {
            return Math.Sqrt(Math.Pow(seite_a, 2) + Math.Pow(seite_b, 2));
        }

        // gegeben a, b und c
        // berehnet hc
        public static double Hoehe(double seite_a, double seite_b, double seite_c)
        {
            return (seite_a * seite_b / seite_c);
        }

    }
}

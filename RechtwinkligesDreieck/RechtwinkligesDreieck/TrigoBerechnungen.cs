using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechtwinkligesDreieck
{
    class TrigoBerechnungen
    {
        //gegeben: c und alpha
        //berechnet: a mit Sinus
        public static double Seite_a_sin(double seite_c, double alpha)
        {
            return (seite_c * Math.Sin(alpha));
        }

        //gegeben: b und alpha
        //berechnet: a mit Tangens
        public static double Seite_a_tan(double seite_b, double alpha)
        {
            return (seite_b * Math.Tan(alpha));
        }


        //gegeben c und alpha
        // berechnet b mit Cosinus
        public static double Seite_b_Cos(double seite_c, double alpha)
        {
            return (seite_c * Math.Cos(alpha));
        }

        //gegeben a und alpha
        //berechnet b mit Tangens
        public static double Seite_b_tan(double seite_a, double alpha)
        {
            return (seite_a / Math.Tan(alpha));
        }

        //gegeben: a und alpha
        //berechnet: c
        public static double Seite_c_Sin(double seite_a, double alpha)
        {
            return (seite_a / Math.Sin(alpha));
        }

        //gegeben: b und alpha
        //berechnet: c
        public static double Seite_c_Cos(double seite_b, double alpha)
        {
            return (seite_b / Math.Cos(alpha));
        }

        //Beta berechnen
        public static double Beta(double alpha)
        {
            return (90 - alpha);
        }

        //Umfang
        public static double Umfang(double seite_a, double seite_b, double seite_c)
        {
            return (seite_a + seite_b + seite_c);
        }

        //Alpha mit ATangens aus a und b
        public static double Alpha(double seite_a, double seite_b)
        {
            double winkelInRadiant = Math.Atan(seite_a / seite_b);
            double Winkel = winkelInRadiant * 180 / Math.PI;
            return Winkel;
        }
    }
}

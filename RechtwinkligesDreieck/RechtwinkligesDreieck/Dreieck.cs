using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechtwinkligesDreieck
{
    class Dreieck
    {
        private double kathete_a;
        private double kathete_b;
        private double hypothenuse_c;
        private double winkel_alpha;
        private double winkel_beta;
        private double hoehe_hc;
        private double fläche_A;
        private double umfang_U;

        //Konstruktur mit a und b
        public Dreieck(string a, string b)
        {
            try
            {
                this.kathete_a = Convert.ToDouble(a);
                this.kathete_b = Convert.ToDouble(b);
            }
            catch
            {
                this.kathete_a = 0;
                this.kathete_b = 0;
            }
        }

        // Konstruktor mit a, b und c
        public Dreieck(string a, string b, string c)
        {
            try
            {
                this.kathete_a = Convert.ToDouble(a);
                this.kathete_b = Convert.ToDouble(b);
                this.hypothenuse_c = Convert.ToDouble(c);
            }
            catch
            {
                this.kathete_a = 0;
                this.kathete_b = 0;
                this.hypothenuse_c = 0;
            }
        }

        // Eigenschaft Hypothenuse
        public string HypothenuseMitPythagoras
        {
            get { return PythBerechnung.Seite_C_Pyth(kathete_a, kathete_b).ToString("0.000"); }
        }

        //Eigenschaft Umfang
        public string Umfang
        {
            get {return TrigoBerechnungen.Umfang(kathete_a, kathete_b, hypothenuse_c).ToString("0.000"); }
        }
    }
}

   
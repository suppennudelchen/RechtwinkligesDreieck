using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechtwinkligesDreieck
{
    public partial class RechtWDreieck : Form
    {
        public RechtWDreieck()
        {
            InitializeComponent();
        }

        //Startwerte in den Feldern im Formular
        private void Formular_Load(object sender, EventArgs e)
        {
            //TxtBox_alpha.Text = "45";
            //TxtBox_beta.Text = "45";
            //TxtBox_a.Text = "10";
            //TxtBox_b.Text = "10";
            //TxtBox_c.Text = "14.142";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dreieck dreieck_1 = new Dreieck(TxtBox_a.Text, TxtBox_b.Text);
            TxtBox_c.Text = dreieck_1.HypothenuseMitPythagoras;
            TxtBox_alpha.Text = dreieck_1.Alpha;
            Dreieck dreieck_2 = new Dreieck(TxtBox_a.Text, TxtBox_b.Text, TxtBox_c.Text);
            TxtBoxUmfang.Text = dreieck_2.Umfang;
            
        }
    }
}

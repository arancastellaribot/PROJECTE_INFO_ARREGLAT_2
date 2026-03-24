using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlightLib;

namespace MisForms
{
    public partial class FormCrearVuelos : Form
    {
        public FormCrearVuelos()
        {
            InitializeComponent();
        }

        private void FormCrearVuelos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public FlightPlan vol1;
        public FlightPlan vol2;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // --- DADES DEL VOL 1 ---
                string nom1 = id1.Text;
                double velocitatVol1 = Convert.ToDouble(vel1.Text);

                // Separem els dos números de la posició inicial (separats per un espai)
                string[] posIni1 = PosIni1.Text.Split(' ');
                double ix1 = Convert.ToDouble(posIni1[0]);
                double iy1 = Convert.ToDouble(posIni1[1]);

                string[] posFin1 = PosFin1.Text.Split(' ');
                double fx1 = Convert.ToDouble(posFin1[0]);
                double fy1 = Convert.ToDouble(posFin1[1]);

                this.vol1 = new FlightPlan(nom1, ix1, iy1, fx1, fy1, velocitatVol1);


                // --- DADES DEL VOL 2 ---
                string nom2 = id2.Text;
                double velocitatVol2 = Convert.ToDouble(vel2.Text);

                string[] posIni2 = PosIni2.Text.Split(' ');
                double ix2 = Convert.ToDouble(posIni2[0]);
                double iy2 = Convert.ToDouble(posIni2[1]);

                string[] posFin2 = PosFin2.Text.Split(' ');
                double fx2 = Convert.ToDouble(posFin2[0]);
                double fy2 = Convert.ToDouble(posFin2[1]);

                this.vol2 = new FlightPlan(nom2, ix2, iy2, fx2, fy2, velocitatVol2);


                // Missatge d'èxit
                MessageBox.Show("Els vols s'han guardat molt bé!", "Perfecte");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hi ha un error. Recorda posar un espai a les posicions i només números a la velocitat.", "Atenció");
            }
        }
    }
}

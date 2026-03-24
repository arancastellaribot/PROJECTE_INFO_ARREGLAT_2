using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MisForms
{
    public partial class FormSimulacion : Form
    {
        FlightPlan v1;
        FlightPlan v2;
        public FormSimulacion(FlightPlan vol1, FlightPlan vol2)
        {
            InitializeComponent();
            this.v1 = vol1;
            this.v2 = vol2;
        }

        private void FormSimulacion_Paint(object sender, PaintEventArgs e)
        {
            // 1. CREEM ELS LLAPIS (Pens)
            // El '2' és el gruix de la línia. Pots posar-hi '1' si la vols més fina.
            Pen penBlau = new Pen(Color.LightBlue, 2);
            Pen penVermell = new Pen(Color.MistyRose, 2);

            // 2. DIBUIXEM LA TRAJECTÒRIA DEL VOL 1 (Blau)
            e.Graphics.DrawLine(penBlau,
                (float)v1.GetInitialPosition().GetX(), (float)v1.GetInitialPosition().GetY(),
                (float)v1.GetFinalPostion().GetX(), (float)v1.GetFinalPostion().GetY());

            // 3. DIBUIXEM LA TRAJECTÒRIA DEL VOL 2 (Vermell)
            e.Graphics.DrawLine(penVermell,
                (float)v2.GetInitialPosition().GetX(), (float)v2.GetInitialPosition().GetY(),
                (float)v2.GetFinalPostion().GetX(), (float)v2.GetFinalPostion().GetY());

            // 4. DIBUIXEM ELS AVIONS (el codi que ja tenies)
            // Els dibuixem al final perquè el cercle es vegi per sobre de la línia
            e.Graphics.FillEllipse(Brushes.Blue, (float)v1.GetCurrentPosition().GetX(), (float)v1.GetCurrentPosition().GetY(), 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, (float)v2.GetCurrentPosition().GetX(), (float)v2.GetCurrentPosition().GetY(), 10, 10);

            // Alliberem els llapis per no gastar memòria
            penBlau.Dispose();
            penVermell.Dispose();
        }


        private void btnMover_Click(object sender, EventArgs e)
        {

            // Movem els dos avions usant el mètode Move creat a la Fase 1
            this.v1.Mover(1.0);
            this.v2.Mover(1.0);

            // Refresquem el formulari per veure el moviment (Fase 3 i 4)
            this.Invalidate();
        }

        private void FormSimulacion_Load_1(object sender, EventArgs e)
        {

        }

        private void FormSimulacion_MouseDown(object sender, MouseEventArgs e)
        {
            // 1. Obtenim la posició d'on ha clicat el ratolí
            Position posicioClic = new Position(e.X, e.Y);

            // 2. Definim un radi de sensibilitat (píxels)
            double radiSensibilitat = 10.0;

            // 3. Comprovem el Vol 1
            if (v1.GetCurrentPosition().Distancia(posicioClic) <= radiSensibilitat)
            {
                MostrarInfoAvio(v1);
            }
            // 4. Comprovem el Vol 2
            else if (v2.GetCurrentPosition().Distancia(posicioClic) <= radiSensibilitat)
            {
                MostrarInfoAvio(v2);
            }
        }
        private void MostrarInfoAvio(FlightPlan vol)
        {
            string missatge = "IDENTIFICADOR: " + vol.GetId() + "\n" +
                              "VELOCITAT: " + vol.GetVelocidad() + " km/h\n" +
                              "POSICIÓ ACTUAL: (" + Math.Round(vol.GetCurrentPosition().GetX(), 2) +
                              ", " + Math.Round(vol.GetCurrentPosition().GetY(), 2) + ")";

            MessageBox.Show(missatge, "Detalls del Vol");   
        }
    }
}

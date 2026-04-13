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
        double distSeguretat;
        double tempsCiclo;
        public FormSimulacion(FlightPlan vol1, FlightPlan vol2, double dSeg, double tCiclo)
        {
            InitializeComponent();
            this.v1 = vol1;
            this.v2 = vol2;
            this.distSeguretat = dSeg;
            this.tempsCiclo = tCiclo;
        }

        private void FormSimulacion_Paint(object sender, PaintEventArgs e)
        {
            // 1. DIBUIXEM LES LÍNIES DE TRAJECTÒRIA
            Pen penBlau = new Pen(Color.LightBlue, 2);
            Pen penVermell = new Pen(Color.MistyRose, 2);

            e.Graphics.DrawLine(penBlau,
                (float)v1.GetInitialPosition().GetX(), (float)v1.GetInitialPosition().GetY(),
                (float)v1.GetFinalPostion().GetX(), (float)v1.GetFinalPostion().GetY());

            e.Graphics.DrawLine(penVermell,
                (float)v2.GetInitialPosition().GetX(), (float)v2.GetInitialPosition().GetY(),
                (float)v2.GetFinalPostion().GetX(), (float)v2.GetFinalPostion().GetY());

            penBlau.Dispose();
            penVermell.Dispose();

            // 2. LÒGICA DE COLORS
            Brush colorV1 = Brushes.Blue;
            Brush colorV2 = Brushes.Red;
            double distanciaActual = v1.Distancia(v2);

            if (distanciaActual <= this.distSeguretat)
            {
                colorV1 = Brushes.Orange;
                colorV2 = Brushes.Orange;
            }

            // 3. DIBUIXEM ELS AVIONS
            // Restem 5 per alinear el centre (assumint que l'avió fa 10x10)
            float x1 = (float)v1.GetCurrentPosition().GetX() - 5;
            float y1 = (float)v1.GetCurrentPosition().GetY() - 5;
            float x2 = (float)v2.GetCurrentPosition().GetX() - 5;
            float y2 = (float)v2.GetCurrentPosition().GetY() - 5;

            e.Graphics.FillEllipse(colorV1, x1, y1, 10, 10);
            e.Graphics.FillEllipse(colorV2, x2, y2, 10, 10);

            // 4. EL·LIPSE DE SEGURETAT
            float radiSeg = (float)this.distSeguretat;
            float diametreSeg = radiSeg * 2;
            Pen penSeguretat = new Pen(Color.Black, 1);

            // Restem el radi perquè el centre del cercle gran coincideixi amb el centre de l'avió
            e.Graphics.DrawEllipse(penSeguretat, (float)v1.GetCurrentPosition().GetX() - radiSeg, (float)v1.GetCurrentPosition().GetY() - radiSeg, diametreSeg, diametreSeg);
            e.Graphics.DrawEllipse(penSeguretat, (float)v2.GetCurrentPosition().GetX() - radiSeg, (float)v2.GetCurrentPosition().GetY() - radiSeg, diametreSeg, diametreSeg);

            penSeguretat.Dispose();
        }


        private void btnMover_Click(object sender, EventArgs e)
        {

            // Movem els dos avions usant el temps de cicle configurat
            this.v1.Mover(this.tempsCiclo);
            this.v2.Mover(this.tempsCiclo);

            // Refresquem el formulari per veure el moviment
            this.Invalidate();
            // ---------------------------------------------------------
            // NOVA LÒGICA FASE 10.1: ALARMA DE SEPARACIÓ
            // ---------------------------------------------------------
            double distanciaActual = v1.Distancia(v2);

            if (distanciaActual < this.distSeguretat)
            {
                {
                    timerSimulacio.Stop(); // Parem el rellotge temporalment

                    MessageBox.Show("ALERTA: Pèrdua de separació detectada!\nDistància actual:" + Math.Round(distanciaActual, 2) + "unitats.",
                                    "Alarma de Seguretat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Si s'allunyen i tornen a estar a una distància segura, "baixem" la bandera 
                // per si es tornen a creuar en el futur
                if (v1.AvionDestino() && v2.AvionDestino())
                    timerSimulacio.Stop();
            }
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

        private void timerSimulacio_Tick(object sender, EventArgs e)
        {
            // Movem els avions amb el temps de cicle que hem configurat
            v1.Mover(this.tempsCiclo);
            v2.Mover(this.tempsCiclo);

            // Obliguem a repintar (això cridarà al mètode Paint)
            this.Invalidate();

            // Si tots dos han arribat, parem el rellotge
            if (v1.AvionDestino() && v2.AvionDestino())
                timerSimulacio.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Comprovem si hi haurà conflicte ABANS de començar
            if (v1.PrevisioConflicte(v2, this.distSeguretat))
            {
                // 2. Preguntem a l'usuari amb un MessageBox de Sí o No
                DialogResult resposta = MessageBox.Show(
                    "S'ha detectat un conflicte futur!\n\nVols que el programa resolgui el conflicte automàticament modificant la velocitat d'un avió?",
                    "Alerta ATC - Resolució",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // 3. Si l'usuari clica "Sí"
                if (resposta == DialogResult.Yes)
                {
                    double novaVelocitat = v2.GetVelocidad();

                    // ESTRATÈGIA A: Provem de frenar el Vol 2 (fins a un límit de 50 km/h)
                    while (v1.PrevisioConflicte(v2, this.distSeguretat) && novaVelocitat > 50)
                    {
                        novaVelocitat -= 10; // Reduïm de 10 en 10
                        v2.SetVelocidad(novaVelocitat);
                    }

                    // ESTRATÈGIA B: Si frenant al màxim encara xoquen, provem d'accelerar-lo
                    if (v1.PrevisioConflicte(v2, this.distSeguretat))
                    {
                        novaVelocitat = v2.GetVelocidad(); // Tornem a la velocitat on ens havíem quedat
                        while (v1.PrevisioConflicte(v2, this.distSeguretat) && novaVelocitat < 1500)
                        {
                            novaVelocitat += 10; // Augmentem de 10 en 10
                            v2.SetVelocidad(novaVelocitat);
                        }
                    }

                    // Avisem a l'usuari de l'ajust que hem fet
                    MessageBox.Show($"Conflicte resolt!\n\nS'ha ajustat la velocitat del vol {v2.GetId()} a {novaVelocitat} km/h per evitar la col·lisió.",
                        "Resolució Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si l'usuari clica "No", el programa simplement salta aquest 'if' i xocaran (tal com demana l'enunciat).
            }

            // 4. Finalment, engeguem el rellotge de la simulació amb les noves condicions
            timerSimulacio.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerSimulacio.Stop();
        }

        private void btnVeureDades_Click(object sender, EventArgs e)
        {
            // 1. Creem una instància de la nova finestra. 
            // Fixa't que li passem 'this.v1' i 'this.v2', que són els avions d'aquest formulari.
            FormDades finestraDades = new FormDades(this.v1, this.v2,this);

            // 2. L'obrim amb .Show(). 
            // Usem .Show() i NO .ShowDialog() perquè volem que les dues finestres 
            // estiguin obertes a la vegada. Així pots veure el mapa i la taula alhora!
            finestraDades.Show();
        }
        // Aquest mètode el cridarà el FormDades quan canviïs una velocitat
        public void ReiniciarSimulacioVisual()
        {
            timerSimulacio.Stop(); // Parem la simulació si estava corrent
            this.Invalidate();     // Forcem a repintar el mapa (els avions sortiran a l'origen)
        }
        private void btnPrediccio_Click(object sender, EventArgs e)
        {
            // 1. Cridem a la funció matemàtica que acabes de crear a la teva llibreria.
            // Li passem el segon avió (v2) i la distància de seguretat del formulari.
            bool hiHauraConflicte = v1.PrevisioConflicte(v2, this.distSeguretat);

            // 2. Mostrem el resultat a l'usuari
            if (hiHauraConflicte)
            {
                MessageBox.Show("PREDICCIÓ: S'ha detectat un conflicte futur en la trajectòria actual.\n\nEls avions passaran a una distància inferior a la de seguretat.",
                    "Alerta de Predicció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("PREDICCIÓ: Trajectòria neta.\n\nNo es preveuen conflictes entre aquests dos vols.",
                    "Predicció Segura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

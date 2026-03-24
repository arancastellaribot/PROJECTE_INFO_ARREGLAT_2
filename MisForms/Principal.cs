using FlightLib;

namespace MisForms
{
    public partial class Principal : Form
    {
        FlightPlan vol1_guardat;
        FlightPlan vol2_guardat;
        double distanciaSeguretat = 50.0; // Valor per defecte
        double tiempoCiclo = 1.0;
        public Principal()
        {
            InitializeComponent();
        }
        private void introducirVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearVuelos ventanaVuelos = new FormCrearVuelos();
            ventanaVuelos.ShowDialog();

            if (ventanaVuelos.vol1 != null && ventanaVuelos.vol2 != null)
            {
                vol1_guardat = ventanaVuelos.vol1;
                vol2_guardat = ventanaVuelos.vol2;
            }
        }

        // BOTÓN 2: CONFIGURAR SIMULACIÓN
        private void configurarSimulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig ventanaConfiguracion = new FormConfig();

            // Si l'usuari clica "Acceptar" al formulari de config
            if (ventanaConfiguracion.ShowDialog() == DialogResult.OK)
            {
                // Guardem els valors a les variables de Principal
                this.distanciaSeguretat = ventanaConfiguracion.distancia;
                this.tiempoCiclo = ventanaConfiguracion.tiempo;

                MessageBox.Show("Configuració guardada correctament.");
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vol1_guardat != null && vol2_guardat != null)
            {
                FormSimulacion ventanaSim = new FormSimulacion(vol1_guardat, vol2_guardat, distanciaSeguretat, tiempoCiclo);
                ventanaSim.ShowDialog();
            }
            else { MessageBox.Show("Introdueix els vols primer!"); }
        }
    }
}

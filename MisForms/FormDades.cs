using System;
using System.Windows.Forms;
using FlightLib; // Importem la llibreria dels avions

namespace MisForms
{
    public partial class FormDades : Form
    {
        // 1. Declarem els calaixos per guardar els vols que rebrem
        FlightPlan v1;
        FlightPlan v2;

        // 2. Modifiquem el constructor: ARA REP ELS DOS VOLS
        public FormDades(FlightPlan vol1, FlightPlan vol2)
        {
            InitializeComponent(); // Això NO es toca, és el que dibuixa la taula
            this.v1 = vol1;
            this.v2 = vol2;
        }

        // 3. Aquesta funció s'executa quan s'obre la finestra
        private void FormDades_Load(object sender, EventArgs e)
        {
            // Creem les capçaleres de la taula
            dgvVols.Columns.Add("ID", "Identificador");
            dgvVols.Columns.Add("Vel", "Velocitat (km/h)");
            dgvVols.Columns.Add("PosX", "Posició X");
            dgvVols.Columns.Add("PosY", "Posició Y");

            // Afegim les dades actuals dels vols
            dgvVols.Rows.Add(v1.GetId(), v1.GetVelocidad(), Math.Round(v1.GetCurrentPosition().GetX(), 2), Math.Round(v1.GetCurrentPosition().GetY(), 2));
            dgvVols.Rows.Add(v2.GetId(), v2.GetVelocidad(), Math.Round(v2.GetCurrentPosition().GetX(), 2), Math.Round(v2.GetCurrentPosition().GetY(), 2));

            // Fem que les columnes ocupin tot l'espai disponible
            dgvVols.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvVols_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifiquem que s'ha clicat una fila amb dades (no la capçalera)
            if (e.RowIndex >= 0)
            {
                // Calculem la distància actual entre v1 i v2
                double dx = v1.GetCurrentPosition().GetX() - v2.GetCurrentPosition().GetX();
                double dy = v1.GetCurrentPosition().GetY() - v2.GetCurrentPosition().GetY();
                double dist = Math.Sqrt(dx * dx + dy * dy);

                string text = $"Distància actual: {Math.Round(dist, 2)} unitats.";

                // Obrim el formulari de detall
                FormDistancia f = new FormDistancia(text);
                f.ShowDialog();
            }
        }
    }
}
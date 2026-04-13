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
        FormSimulacion formularioPadre;
        // 2. Modifiquem el constructor: ARA REP ELS DOS VOLS
        public FormDades(FlightPlan vol1, FlightPlan vol2, FormSimulacion padre)
        {
            InitializeComponent(); // Això NO es toca, és el que dibuixa la taula
            this.v1 = vol1;
            this.v2 = vol2;
            this.formularioPadre = padre;
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
            // Només obrim la finestra de distància si:
            // 1. La fila és vàlida (e.RowIndex >= 0)
            // 2. NO estem clicant a la columna de velocitat (e.ColumnIndex != 1)
            if (e.RowIndex >= 0 && e.ColumnIndex != 1)
            {
                double dx = v1.GetCurrentPosition().GetX() - v2.GetCurrentPosition().GetX();
                double dy = v1.GetCurrentPosition().GetY() - v2.GetCurrentPosition().GetY();
                double dist = Math.Sqrt(dx * dx + dy * dy);

                string text = $"Distància actual: {Math.Round(dist, 2)} unitats.";
                FormDistancia f = new FormDistancia(text);
                f.ShowDialog();
            }
        }
        private void dgvVols_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Comprovem que sigui la columna de velocitat
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                try
                {
                    double novaVel = Convert.ToDouble(dgvVols.Rows[e.RowIndex].Cells[1].Value);

                    // Agafem el vol corresponent (v1 o v2)
                    FlightPlan volSeleccionat = (e.RowIndex == 0) ? v1 : v2;

                    // NOMÉS si la velocitat és realment diferent, fem el procés
                    if (novaVel != volSeleccionat.GetVelocidad())
                    {
                        volSeleccionat.SetVelocidad(novaVel);
                        v1.ReiniciarPosicion();
                        v2.ReiniciarPosicion();

                        if (this.formularioPadre != null)
                            this.formularioPadre.Invalidate();

                        MessageBox.Show("Velocitat actualitzada a " + novaVel + " i trajectòria reiniciada.");
                    }
                }
                catch
                {
                    // Si l'usuari escriu lletres, tornem a posar el valor que hi havia
                    MessageBox.Show("Siusplau, introdueix un número vàlid.");
                }
            }
        }
        
     
        private void dgvVols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MisForms
{
    public partial class FormConfig : Form
    {
        // Creem variables per guardar el que escrigui l'usuari
        public double distancia;
        public double tiempo;

        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifiquem dades (Punt 3 de la Fase 2)
                this.distancia = Convert.ToDouble(txtDistancia.Text);
                this.tiempo = Convert.ToDouble(txtTiempo.Text);

                // Si tot és correcte, tanquem amb OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Introdueix números vàlids.");
            }
        }
    }
}

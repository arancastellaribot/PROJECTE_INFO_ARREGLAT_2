using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MisForms
{
    public partial class FormDistancia : Form
    {
        public FormDistancia(string missatge)
        {
            InitializeComponent();
            lblDistancia.Text = missatge;
        }
    }
}

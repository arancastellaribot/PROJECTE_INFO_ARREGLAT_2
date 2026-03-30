namespace MisForms
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            introducirVuelosToolStripMenuItem = new ToolStripMenuItem();
            configurarSimulaciónToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { introducirVuelosToolStripMenuItem, configurarSimulaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1037, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // introducirVuelosToolStripMenuItem
            // 
            introducirVuelosToolStripMenuItem.BackColor = Color.Navy;
            introducirVuelosToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            introducirVuelosToolStripMenuItem.ForeColor = Color.White;
            introducirVuelosToolStripMenuItem.Name = "introducirVuelosToolStripMenuItem";
            introducirVuelosToolStripMenuItem.Size = new Size(161, 27);
            introducirVuelosToolStripMenuItem.Text = "Introducir Vuelos";
            introducirVuelosToolStripMenuItem.Click += introducirVuelosToolStripMenuItem_Click;
            // 
            // configurarSimulaciónToolStripMenuItem
            // 
            configurarSimulaciónToolStripMenuItem.BackColor = Color.DarkSalmon;
            configurarSimulaciónToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            configurarSimulaciónToolStripMenuItem.ForeColor = Color.White;
            configurarSimulaciónToolStripMenuItem.Name = "configurarSimulaciónToolStripMenuItem";
            configurarSimulaciónToolStripMenuItem.Size = new Size(204, 27);
            configurarSimulaciónToolStripMenuItem.Text = "Configurar Simulación";
            configurarSimulaciónToolStripMenuItem.Click += configurarSimulaciónToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(366, 186);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(246, 90);
            button1.TabIndex = 1;
            button1.Text = "Iniciar simulació";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(274, 93);
            label2.Name = "label2";
            label2.Size = new Size(437, 54);
            label2.TabIndex = 3;
            label2.Text = "SIMULADOR AERI";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1037, 480);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 10F);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Principal";
            Text = "Form1";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem introducirVuelosToolStripMenuItem;
        private ToolStripMenuItem configurarSimulaciónToolStripMenuItem;
        private Button button1;
        private Label label2;
    }
}

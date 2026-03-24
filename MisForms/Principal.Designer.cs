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
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // introducirVuelosToolStripMenuItem
            // 
            introducirVuelosToolStripMenuItem.Name = "introducirVuelosToolStripMenuItem";
            introducirVuelosToolStripMenuItem.Size = new Size(163, 29);
            introducirVuelosToolStripMenuItem.Text = "Introducir Vuelos";
            introducirVuelosToolStripMenuItem.Click += introducirVuelosToolStripMenuItem_Click;
            // 
            // configurarSimulaciónToolStripMenuItem
            // 
            configurarSimulaciónToolStripMenuItem.Name = "configurarSimulaciónToolStripMenuItem";
            configurarSimulaciónToolStripMenuItem.Size = new Size(203, 29);
            configurarSimulaciónToolStripMenuItem.Text = "Configurar Simulación";
            configurarSimulaciónToolStripMenuItem.Click += configurarSimulaciónToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(360, 216);
            button1.Name = "button1";
            button1.Size = new Size(246, 113);
            button1.TabIndex = 1;
            button1.Text = "Iniciar simulació";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
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
    }
}

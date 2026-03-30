namespace MisForms
{
    partial class FormSimulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnMover = new Button();
            timerSimulacio = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            btnVeureDades = new Button();
            btnPrediccio = new Button();
            SuspendLayout();
            // 
            // btnMover
            // 
            btnMover.BackColor = Color.Navy;
            btnMover.FlatStyle = FlatStyle.Flat;
            btnMover.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMover.ForeColor = Color.White;
            btnMover.Location = new Point(562, 24);
            btnMover.Margin = new Padding(2);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(172, 45);
            btnMover.TabIndex = 0;
            btnMover.Text = "Moure un cicle";
            btnMover.UseVisualStyleBackColor = false;
            btnMover.Click += btnMover_Click;
            // 
            // timerSimulacio
            // 
            timerSimulacio.Tick += timerSimulacio_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(532, 75);
            button1.Name = "button1";
            button1.Size = new Size(222, 59);
            button1.TabIndex = 1;
            button1.Text = "Trajectòria automàtica";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(562, 140);
            button2.Name = "button2";
            button2.Size = new Size(172, 44);
            button2.TabIndex = 2;
            button2.Text = "Aturar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnVeureDades
            // 
            btnVeureDades.BackColor = Color.Navy;
            btnVeureDades.FlatStyle = FlatStyle.Flat;
            btnVeureDades.ForeColor = Color.White;
            btnVeureDades.Location = new Point(562, 191);
            btnVeureDades.Name = "btnVeureDades";
            btnVeureDades.Size = new Size(172, 48);
            btnVeureDades.TabIndex = 3;
            btnVeureDades.Text = "Veure Dades";
            btnVeureDades.UseVisualStyleBackColor = false;
            btnVeureDades.Click += btnVeureDades_Click;
            // 
            // btnPrediccio
            // 
            btnPrediccio.BackColor = Color.Navy;
            btnPrediccio.FlatStyle = FlatStyle.Flat;
            btnPrediccio.ForeColor = Color.White;
            btnPrediccio.Location = new Point(562, 245);
            btnPrediccio.Name = "btnPrediccio";
            btnPrediccio.Size = new Size(172, 58);
            btnPrediccio.TabIndex = 4;
            btnPrediccio.Text = "Predicció de conflicte";
            btnPrediccio.UseVisualStyleBackColor = false;
            btnPrediccio.Click += btnPrediccio_Click;
            // 
            // FormSimulacion
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 414);
            Controls.Add(btnPrediccio);
            Controls.Add(btnVeureDades);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMover);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Margin = new Padding(2);
            Name = "FormSimulacion";
            Text = "Form1";
            Load += FormSimulacion_Load_1;
            Paint += FormSimulacion_Paint;
            MouseDown += FormSimulacion_MouseDown;
            ResumeLayout(false);
        }

        private void FormSimulacion_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnMover;
        private System.Windows.Forms.Timer timerSimulacio;
        private Button button1;
        private Button button2;
        private Button btnVeureDades;
        private Button btnPrediccio;
    }
}
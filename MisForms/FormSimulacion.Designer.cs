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
            SuspendLayout();
            // 
            // btnMover
            // 
            btnMover.Location = new Point(562, 41);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(172, 34);
            btnMover.TabIndex = 0;
            btnMover.Text = "Moure un cicle";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // timerSimulacio
            // 
            timerSimulacio.Tick += timerSimulacio_Tick;
            // 
            // FormSimulacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMover);
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
    }
}
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
            SuspendLayout();
            // 
            // btnMover
            // 
            btnMover.Location = new Point(450, 33);
            btnMover.Margin = new Padding(2, 2, 2, 2);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(138, 27);
            btnMover.TabIndex = 0;
            btnMover.Text = "Moure un cicle";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // timerSimulacio
            // 
            timerSimulacio.Tick += timerSimulacio_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(450, 65);
            button1.Name = "button1";
            button1.Size = new Size(138, 51);
            button1.TabIndex = 1;
            button1.Text = "Moure tota la trajectòria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSimulacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(btnMover);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}
namespace MisForms
{
    partial class FormConfig
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
            label1 = new Label();
            label2 = new Label();
            txtDistancia = new TextBox();
            txtTiempo = new TextBox();
            btnAcceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 130);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Distància de seguretat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 137);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Temps de Cicle";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(173, 172);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(138, 31);
            txtDistancia.TabIndex = 2;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(572, 172);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(116, 31);
            txtTiempo.TabIndex = 3;
            // 
            // btnAcceptar
            // 
            btnAcceptar.Location = new Point(293, 250);
            btnAcceptar.Name = "btnAcceptar";
            btnAcceptar.Size = new Size(307, 90);
            btnAcceptar.TabIndex = 4;
            btnAcceptar.Text = "Acceptar";
            btnAcceptar.UseVisualStyleBackColor = true;
            btnAcceptar.Click += btnAcceptar_Click;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnAcceptar);
            Controls.Add(txtTiempo);
            Controls.Add(txtDistancia);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FormConfig";
            Text = "FormConfig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDistancia;
        private TextBox txtTiempo;
        private Button btnAcceptar;
    }
}
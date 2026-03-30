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
            label1.Location = new Point(114, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Distància de seguretat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Temps de Cicle";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(138, 138);
            txtDistancia.Margin = new Padding(2, 2, 2, 2);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(111, 27);
            txtDistancia.TabIndex = 2;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(458, 138);
            txtTiempo.Margin = new Padding(2, 2, 2, 2);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(94, 27);
            txtTiempo.TabIndex = 3;
            // 
            // btnAcceptar
            // 
            btnAcceptar.Location = new Point(234, 200);
            btnAcceptar.Margin = new Padding(2, 2, 2, 2);
            btnAcceptar.Name = "btnAcceptar";
            btnAcceptar.Size = new Size(246, 72);
            btnAcceptar.TabIndex = 4;
            btnAcceptar.Text = "Acceptar";
            btnAcceptar.UseVisualStyleBackColor = true;
            btnAcceptar.Click += btnAcceptar_Click;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcceptar);
            Controls.Add(txtTiempo);
            Controls.Add(txtDistancia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConfig";
            Text = "FormConfig";
            Load += FormConfig_Load;
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
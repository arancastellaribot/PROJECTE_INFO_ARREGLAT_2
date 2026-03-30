namespace MisForms
{
    partial class FormDistancia
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
            lblDistancia = new Label();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDistancia.Location = new Point(210, 192);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(254, 35);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Calculant distància...";
            lblDistancia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDistancia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDistancia);
            Name = "FormDistancia";
            Text = "FormDistancia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
    }
}
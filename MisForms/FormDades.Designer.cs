namespace MisForms
{
    partial class FormDades
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
            dgvVols = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVols).BeginInit();
            SuspendLayout();
            // 
            // dgvVols
            // 
            dgvVols.AllowUserToAddRows = false;
            dgvVols.AllowUserToDeleteRows = false;
            dgvVols.BackgroundColor = SystemColors.Info;
            dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVols.Location = new Point(52, 26);
            dgvVols.Name = "dgvVols";
            dgvVols.ReadOnly = true;
            dgvVols.RowHeadersWidth = 51;
            dgvVols.Size = new Size(707, 381);
            dgvVols.TabIndex = 0;
            dgvVols.CellClick += dgvVols_CellClick;
            // 
            // FormDades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVols);
            Name = "FormDades";
            Text = "Form1";
            Load += FormDades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVols).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVols;
    }
}
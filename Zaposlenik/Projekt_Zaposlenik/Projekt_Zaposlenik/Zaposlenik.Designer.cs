namespace Projekt_Zaposlenik
{
    partial class ZaposleniciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposlenici";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 98);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(776, 236);
            this.dgvZaposlenici.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(656, 358);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(132, 41);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "OBRIŠI ZAPOSLENIKA";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(341, 358);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(137, 41);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "AŽURIRAJ PODATKE";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 358);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 41);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "DODAJ ZAPOSLENIKA";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ZaposleniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.label1);
            this.Name = "ZaposleniciForm";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.ZaposleniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
    }
}
namespace Projekt_Zaposlenik
{
    partial class AzurirajZaposlenikaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdZaposlenika = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.datePickRodenje = new System.Windows.Forms.DateTimePicker();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ažuriraj podatke o zaposlenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id zaposlenika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rođenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "OIB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Korisničko ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lozinka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Uloga :";
            // 
            // txtIdZaposlenika
            // 
            this.txtIdZaposlenika.Enabled = false;
            this.txtIdZaposlenika.Location = new System.Drawing.Point(179, 81);
            this.txtIdZaposlenika.Name = "txtIdZaposlenika";
            this.txtIdZaposlenika.Size = new System.Drawing.Size(227, 20);
            this.txtIdZaposlenika.TabIndex = 10;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(179, 118);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(227, 20);
            this.txtIme.TabIndex = 11;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(179, 155);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(227, 20);
            this.txtPrezime.TabIndex = 12;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(179, 227);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(227, 20);
            this.txtAdresa.TabIndex = 13;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(179, 264);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(227, 20);
            this.txtOIB.TabIndex = 14;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(179, 299);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(227, 20);
            this.txtKorisnicko.TabIndex = 15;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(179, 334);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(227, 20);
            this.txtLozinka.TabIndex = 16;
            // 
            // datePickRodenje
            // 
            this.datePickRodenje.Location = new System.Drawing.Point(179, 191);
            this.datePickRodenje.Name = "datePickRodenje";
            this.datePickRodenje.Size = new System.Drawing.Size(227, 20);
            this.datePickRodenje.TabIndex = 18;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(244, 405);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 19;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(331, 405);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(179, 370);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(227, 21);
            this.cmbUloga.TabIndex = 21;
            // 
            // AzurirajZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.datePickRodenje);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtIdZaposlenika);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzurirajZaposlenikaForm";
            this.Text = "Azuriraj zaposlenika";
            this.Load += new System.EventHandler(this.AzurirajZaposlenikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdZaposlenika;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.DateTimePicker datePickRodenje;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbUloga;
    }
}
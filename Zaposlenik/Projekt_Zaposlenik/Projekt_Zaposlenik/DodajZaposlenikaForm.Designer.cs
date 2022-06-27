namespace Projekt_Zaposlenik
{
    partial class DodajZaposlenikaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.datePickRodenje = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi novog zaposlenika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "OIB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Korisničko ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lozinka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Uloga:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(143, 91);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(315, 22);
            this.txtIme.TabIndex = 11;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(143, 134);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(315, 22);
            this.txtPrezime.TabIndex = 12;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(143, 220);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(315, 22);
            this.txtAdresa.TabIndex = 13;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(143, 314);
            this.txtKorisnicko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(315, 22);
            this.txtKorisnicko.TabIndex = 14;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(143, 267);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(315, 22);
            this.txtOIB.TabIndex = 15;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(143, 361);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(315, 22);
            this.txtLozinka.TabIndex = 16;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(251, 454);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // datePickRodenje
            // 
            this.datePickRodenje.Location = new System.Drawing.Point(143, 180);
            this.datePickRodenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePickRodenje.Name = "datePickRodenje";
            this.datePickRodenje.Size = new System.Drawing.Size(315, 22);
            this.datePickRodenje.TabIndex = 19;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(359, 454);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 28);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(143, 416);
            this.cmbUloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(315, 24);
            this.cmbUloga.TabIndex = 21;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Relaxic\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Proj" +
    "ekt_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // DodajZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 514);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.datePickRodenje);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajZaposlenikaForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Dodaj zaposlenika";
            this.Load += new System.EventHandler(this.DodajZaposlenikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker datePickRodenje;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
namespace Projekt_Gost
{
    partial class KreiranjeNarudzbeForm
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxVrsteArtikla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMojaNarudzba = new System.Windows.Forms.DataGridView();
            this.buttonPotvrdiNarudzbu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonUkloniOdabranuStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojaNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(24, 88);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(685, 177);
            this.dgvMenu.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(288, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxVrsteArtikla
            // 
            this.comboBoxVrsteArtikla.FormattingEnabled = true;
            this.comboBoxVrsteArtikla.Location = new System.Drawing.Point(494, 59);
            this.comboBoxVrsteArtikla.Name = "comboBoxVrsteArtikla";
            this.comboBoxVrsteArtikla.Size = new System.Drawing.Size(118, 21);
            this.comboBoxVrsteArtikla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pretraži po nazivu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrsta artikla:";
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.FlatAppearance.BorderSize = 0;
            this.buttonFiltriraj.Location = new System.Drawing.Point(618, 58);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(91, 24);
            this.buttonFiltriraj.TabIndex = 6;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.Location = new System.Drawing.Point(635, 271);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(74, 26);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Količina:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKolicina.Location = new System.Drawing.Point(570, 275);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(59, 13);
            this.textBoxKolicina.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moja narudžba";
            // 
            // dgvMojaNarudzba
            // 
            this.dgvMojaNarudzba.Location = new System.Drawing.Point(24, 323);
            this.dgvMojaNarudzba.Name = "dgvMojaNarudzba";
            this.dgvMojaNarudzba.Size = new System.Drawing.Size(685, 177);
            this.dgvMojaNarudzba.TabIndex = 12;
            // 
            // buttonPotvrdiNarudzbu
            // 
            this.buttonPotvrdiNarudzbu.Location = new System.Drawing.Point(619, 506);
            this.buttonPotvrdiNarudzbu.Name = "buttonPotvrdiNarudzbu";
            this.buttonPotvrdiNarudzbu.Size = new System.Drawing.Size(90, 35);
            this.buttonPotvrdiNarudzbu.TabIndex = 13;
            this.buttonPotvrdiNarudzbu.Text = "Potvrdi narudžbu";
            this.buttonPotvrdiNarudzbu.UseVisualStyleBackColor = true;
            this.buttonPotvrdiNarudzbu.Click += new System.EventHandler(this.buttonPotvrdiNarudzbu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ukupno:";
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(82, 514);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(69, 20);
            this.textBoxUkupno.TabIndex = 15;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(520, 506);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(90, 35);
            this.buttonOdustani.TabIndex = 16;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonUkloniOdabranuStavku
            // 
            this.buttonUkloniOdabranuStavku.Location = new System.Drawing.Point(288, 506);
            this.buttonUkloniOdabranuStavku.Name = "buttonUkloniOdabranuStavku";
            this.buttonUkloniOdabranuStavku.Size = new System.Drawing.Size(89, 50);
            this.buttonUkloniOdabranuStavku.TabIndex = 17;
            this.buttonUkloniOdabranuStavku.Text = "Ukloni moju narudžbu";
            this.buttonUkloniOdabranuStavku.UseVisualStyleBackColor = true;
            this.buttonUkloniOdabranuStavku.Click += new System.EventHandler(this.button2_Click);
            // 
            // KreiranjeNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 588);
            this.Controls.Add(this.buttonUkloniOdabranuStavku);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPotvrdiNarudzbu);
            this.Controls.Add(this.dgvMojaNarudzba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVrsteArtikla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.label1);
            this.Name = "KreiranjeNarudzbeForm";
            this.Text = "KreiranjeNarudzbe";
            this.Load += new System.EventHandler(this.KreiranjeNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojaNarudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxVrsteArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMojaNarudzba;
        private System.Windows.Forms.Button buttonPotvrdiNarudzbu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonUkloniOdabranuStavku;
    }
}
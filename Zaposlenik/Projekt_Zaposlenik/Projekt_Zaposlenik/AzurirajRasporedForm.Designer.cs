namespace Projekt_Zaposlenik
{
    partial class AzurirajRasporedForm
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
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonPrihvati = new System.Windows.Forms.Button();
            this.comboBoxSmjena = new System.Windows.Forms.ComboBox();
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(153, 139);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 15;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonPrihvati
            // 
            this.buttonPrihvati.Location = new System.Drawing.Point(72, 139);
            this.buttonPrihvati.Name = "buttonPrihvati";
            this.buttonPrihvati.Size = new System.Drawing.Size(75, 23);
            this.buttonPrihvati.TabIndex = 14;
            this.buttonPrihvati.Text = "Prihvati";
            this.buttonPrihvati.UseVisualStyleBackColor = true;
            this.buttonPrihvati.Click += new System.EventHandler(this.buttonPrihvati_Click);
            // 
            // comboBoxSmjena
            // 
            this.comboBoxSmjena.FormattingEnabled = true;
            this.comboBoxSmjena.Location = new System.Drawing.Point(79, 90);
            this.comboBoxSmjena.Name = "comboBoxSmjena";
            this.comboBoxSmjena.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSmjena.TabIndex = 13;
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(79, 47);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(200, 21);
            this.comboBoxKorisnik.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Smjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Korisnik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dan:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Antun\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Projek" +
    "t_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // AzurirajRasporedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 191);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPrihvati);
            this.Controls.Add(this.comboBoxSmjena);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "AzurirajRasporedForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Azuriraj raspored";
            this.Load += new System.EventHandler(this.AzurirajRasporedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonPrihvati;
        private System.Windows.Forms.ComboBox comboBoxSmjena;
        private System.Windows.Forms.ComboBox comboBoxKorisnik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
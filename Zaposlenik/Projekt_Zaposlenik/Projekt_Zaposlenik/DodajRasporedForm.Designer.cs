﻿namespace Projekt_Zaposlenik
{
    partial class DodajRasporedForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.comboBoxSmjena = new System.Windows.Forms.ComboBox();
            this.buttonPrihvati = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smjena:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(76, 44);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(200, 21);
            this.comboBoxKorisnik.TabIndex = 4;
            // 
            // comboBoxSmjena
            // 
            this.comboBoxSmjena.FormattingEnabled = true;
            this.comboBoxSmjena.Location = new System.Drawing.Point(76, 87);
            this.comboBoxSmjena.Name = "comboBoxSmjena";
            this.comboBoxSmjena.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSmjena.TabIndex = 5;
            // 
            // buttonPrihvati
            // 
            this.buttonPrihvati.Location = new System.Drawing.Point(69, 136);
            this.buttonPrihvati.Name = "buttonPrihvati";
            this.buttonPrihvati.Size = new System.Drawing.Size(75, 23);
            this.buttonPrihvati.TabIndex = 6;
            this.buttonPrihvati.Text = "Prihvati";
            this.buttonPrihvati.UseVisualStyleBackColor = true;
            this.buttonPrihvati.Click += new System.EventHandler(this.buttonPrihvati_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(150, 136);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // DodajRasporedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 194);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPrihvati);
            this.Controls.Add(this.comboBoxSmjena);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajRasporedForm";
            this.Text = "Dodaj raspored";
            this.Load += new System.EventHandler(this.DodajRasporedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxKorisnik;
        private System.Windows.Forms.ComboBox comboBoxSmjena;
        private System.Windows.Forms.Button buttonPrihvati;
        private System.Windows.Forms.Button buttonOdustani;
    }
}
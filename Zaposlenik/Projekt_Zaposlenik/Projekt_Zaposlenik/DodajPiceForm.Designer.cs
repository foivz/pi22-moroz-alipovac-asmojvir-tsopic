namespace Projekt_Zaposlenik
{
    partial class DodajPiceForm
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
            this.textBoxArtikl = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSkladiste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj novo piće";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv artikla:";
            // 
            // textBoxArtikl
            // 
            this.textBoxArtikl.Location = new System.Drawing.Point(136, 104);
            this.textBoxArtikl.Name = "textBoxArtikl";
            this.textBoxArtikl.Size = new System.Drawing.Size(121, 20);
            this.textBoxArtikl.TabIndex = 4;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(136, 142);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(121, 20);
            this.textBoxKolicina.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Količina (u L):";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(394, 104);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(121, 20);
            this.textBoxCijena.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cijena:";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(394, 141);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVrsta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrsta artikla:";
            // 
            // textBoxSkladiste
            // 
            this.textBoxSkladiste.Location = new System.Drawing.Point(136, 181);
            this.textBoxSkladiste.Name = "textBoxSkladiste";
            this.textBoxSkladiste.Size = new System.Drawing.Size(121, 20);
            this.textBoxSkladiste.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Količina (na skladištu):";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(484, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(397, 233);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 14;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // DodajPiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 268);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSkladiste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArtikl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajPiceForm";
            this.Text = "DodajPiceForm";
            this.Load += new System.EventHandler(this.DodajPiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArtikl;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSkladiste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDodaj;
    }
}
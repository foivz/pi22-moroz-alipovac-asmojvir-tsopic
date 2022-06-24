namespace Projekt_Zaposlenik
{
    partial class GlavniIzbornikForm
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
            this.buttonNarudzbe = new System.Windows.Forms.Button();
            this.buttonRezervacije = new System.Windows.Forms.Button();
            this.buttonPopisPica = new System.Windows.Forms.Button();
            this.buttonSkladiste = new System.Windows.Forms.Button();
            this.buttonStatistika = new System.Windows.Forms.Button();
            this.buttonProfili = new System.Windows.Forms.Button();
            this.buttonRaspored = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNarudzbe
            // 
            this.buttonNarudzbe.FlatAppearance.BorderSize = 0;
            this.buttonNarudzbe.Location = new System.Drawing.Point(243, 144);
            this.buttonNarudzbe.Name = "buttonNarudzbe";
            this.buttonNarudzbe.Size = new System.Drawing.Size(245, 102);
            this.buttonNarudzbe.TabIndex = 0;
            this.buttonNarudzbe.Text = "Narudžbe";
            this.buttonNarudzbe.UseVisualStyleBackColor = true;
            this.buttonNarudzbe.Click += new System.EventHandler(this.buttonNarudzbe_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(54, 69);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(131, 50);
            this.buttonRezervacije.TabIndex = 1;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            // 
            // buttonPopisPica
            // 
            this.buttonPopisPica.Location = new System.Drawing.Point(54, 170);
            this.buttonPopisPica.Name = "buttonPopisPica";
            this.buttonPopisPica.Size = new System.Drawing.Size(131, 50);
            this.buttonPopisPica.TabIndex = 2;
            this.buttonPopisPica.Text = "Popis pića";
            this.buttonPopisPica.UseVisualStyleBackColor = true;
            this.buttonPopisPica.Click += new System.EventHandler(this.buttonPopisPica_Click);
            // 
            // buttonSkladiste
            // 
            this.buttonSkladiste.Location = new System.Drawing.Point(54, 287);
            this.buttonSkladiste.Name = "buttonSkladiste";
            this.buttonSkladiste.Size = new System.Drawing.Size(131, 50);
            this.buttonSkladiste.TabIndex = 3;
            this.buttonSkladiste.Text = "Skladište";
            this.buttonSkladiste.UseVisualStyleBackColor = true;
            // 
            // buttonStatistika
            // 
            this.buttonStatistika.Location = new System.Drawing.Point(544, 69);
            this.buttonStatistika.Name = "buttonStatistika";
            this.buttonStatistika.Size = new System.Drawing.Size(131, 50);
            this.buttonStatistika.TabIndex = 4;
            this.buttonStatistika.Text = "Statistika";
            this.buttonStatistika.UseVisualStyleBackColor = true;
            this.buttonStatistika.Click += new System.EventHandler(this.buttonStatistika_Click);
            // 
            // buttonProfili
            // 
            this.buttonProfili.Location = new System.Drawing.Point(544, 170);
            this.buttonProfili.Name = "buttonProfili";
            this.buttonProfili.Size = new System.Drawing.Size(131, 50);
            this.buttonProfili.TabIndex = 5;
            this.buttonProfili.Text = "Profili";
            this.buttonProfili.UseVisualStyleBackColor = true;
            // 
            // buttonRaspored
            // 
            this.buttonRaspored.Location = new System.Drawing.Point(544, 287);
            this.buttonRaspored.Name = "buttonRaspored";
            this.buttonRaspored.Size = new System.Drawing.Size(131, 50);
            this.buttonRaspored.TabIndex = 6;
            this.buttonRaspored.Text = "Raspored";
            this.buttonRaspored.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Glavni Izbornik";
            // 
            // GlavniIzbornikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaspored);
            this.Controls.Add(this.buttonProfili);
            this.Controls.Add(this.buttonStatistika);
            this.Controls.Add(this.buttonSkladiste);
            this.Controls.Add(this.buttonPopisPica);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonNarudzbe);
            this.Name = "GlavniIzbornikForm";
            this.Text = "GlavniIzbornikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNarudzbe;
        private System.Windows.Forms.Button buttonRezervacije;
        private System.Windows.Forms.Button buttonPopisPica;
        private System.Windows.Forms.Button buttonSkladiste;
        private System.Windows.Forms.Button buttonStatistika;
        private System.Windows.Forms.Button buttonProfili;
        private System.Windows.Forms.Button buttonRaspored;
        private System.Windows.Forms.Label label1;
    }
}
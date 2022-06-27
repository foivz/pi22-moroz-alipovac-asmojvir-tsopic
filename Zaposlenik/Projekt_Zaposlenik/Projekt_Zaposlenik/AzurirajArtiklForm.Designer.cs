namespace Projekt_Zaposlenik
{
    partial class AzurirajArtiklForm
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
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSkladiste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArtikl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(549, 310);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(100, 28);
            this.buttonAzuriraj.TabIndex = 27;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(665, 310);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxSkladiste
            // 
            this.textBoxSkladiste.Location = new System.Drawing.Point(201, 246);
            this.textBoxSkladiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSkladiste.Name = "textBoxSkladiste";
            this.textBoxSkladiste.Size = new System.Drawing.Size(160, 22);
            this.textBoxSkladiste.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Količina (na skladištu):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vrsta artikla:";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(545, 197);
            this.comboBoxVrsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(160, 24);
            this.comboBoxVrsta.TabIndex = 22;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(545, 151);
            this.textBoxCijena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(160, 22);
            this.textBoxCijena.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cijena:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(201, 198);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(160, 22);
            this.textBoxKolicina.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Količina (u L):";
            // 
            // textBoxArtikl
            // 
            this.textBoxArtikl.Location = new System.Drawing.Point(201, 151);
            this.textBoxArtikl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArtikl.Name = "textBoxArtikl";
            this.textBoxArtikl.Size = new System.Drawing.Size(160, 22);
            this.textBoxArtikl.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Naziv artikla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(311, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ažuriraj artikl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Relaxic\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Proj" +
    "ekt_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // AzurirajArtiklForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 352);
            this.Controls.Add(this.buttonAzuriraj);
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
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AzurirajArtiklForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "AzurirajArtiklForm";
            this.Load += new System.EventHandler(this.AzurirajArtiklForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSkladiste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArtikl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
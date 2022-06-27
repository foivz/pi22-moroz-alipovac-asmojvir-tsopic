namespace Projekt_Zaposlenik
{
    partial class PopisPicaForm
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
            this.dataGridViewPopis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVrsteArtikla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopis
            // 
            this.dataGridViewPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopis.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewPopis.Name = "dataGridViewPopis";
            this.dataGridViewPopis.Size = new System.Drawing.Size(775, 263);
            this.dataGridViewPopis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(340, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis pića";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(12, 97);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(223, 37);
            this.buttonPDF.TabIndex = 2;
            this.buttonPDF.Text = "Izvezi u PDF obliku";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(442, 112);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretraga.TabIndex = 3;
            this.textBoxPretraga.TextChanged += new System.EventHandler(this.textBoxPretraga_TextChanged);
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.FlatAppearance.BorderSize = 0;
            this.buttonFiltriraj.Location = new System.Drawing.Point(697, 112);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(91, 22);
            this.buttonFiltriraj.TabIndex = 9;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrsta artikla:";
            // 
            // comboBoxVrsteArtikla
            // 
            this.comboBoxVrsteArtikla.FormattingEnabled = true;
            this.comboBoxVrsteArtikla.Location = new System.Drawing.Point(573, 112);
            this.comboBoxVrsteArtikla.Name = "comboBoxVrsteArtikla";
            this.comboBoxVrsteArtikla.Size = new System.Drawing.Size(118, 21);
            this.comboBoxVrsteArtikla.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pretraži:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 409);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(223, 37);
            this.buttonDodaj.TabIndex = 11;
            this.buttonDodaj.Text = "Dodaj novo piće";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(564, 409);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(223, 37);
            this.buttonObrisi.TabIndex = 12;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(288, 409);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(223, 37);
            this.buttonAzuriraj.TabIndex = 13;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Antun\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Projek" +
    "t_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // PopisPicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxVrsteArtikla);
            this.Controls.Add(this.textBoxPretraga);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPopis);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "PopisPicaForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "PopisPicaForm";
            this.Load += new System.EventHandler(this.PopisPicaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVrsteArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
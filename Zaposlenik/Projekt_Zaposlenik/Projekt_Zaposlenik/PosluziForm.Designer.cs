namespace Projekt_Zaposlenik
{
    partial class PosluziForm
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
            this.dgvPosluzi = new System.Windows.Forms.DataGridView();
            this.buttonIzdajRacun = new System.Windows.Forms.Button();
            this.textBoxNarudzba = new System.Windows.Forms.TextBox();
            this.textBoxBrojStola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosluzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narudžba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj stola:";
            // 
            // dgvPosluzi
            // 
            this.dgvPosluzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosluzi.Location = new System.Drawing.Point(58, 136);
            this.dgvPosluzi.Name = "dgvPosluzi";
            this.dgvPosluzi.Size = new System.Drawing.Size(547, 180);
            this.dgvPosluzi.TabIndex = 2;
            // 
            // buttonIzdajRacun
            // 
            this.buttonIzdajRacun.Location = new System.Drawing.Point(467, 329);
            this.buttonIzdajRacun.Name = "buttonIzdajRacun";
            this.buttonIzdajRacun.Size = new System.Drawing.Size(138, 56);
            this.buttonIzdajRacun.TabIndex = 3;
            this.buttonIzdajRacun.Text = "Izdaj račun";
            this.buttonIzdajRacun.UseVisualStyleBackColor = true;
            this.buttonIzdajRacun.Click += new System.EventHandler(this.buttonIzdajRacun_Click);
            // 
            // textBoxNarudzba
            // 
            this.textBoxNarudzba.Location = new System.Drawing.Point(289, 51);
            this.textBoxNarudzba.Name = "textBoxNarudzba";
            this.textBoxNarudzba.ReadOnly = true;
            this.textBoxNarudzba.Size = new System.Drawing.Size(63, 20);
            this.textBoxNarudzba.TabIndex = 4;
            // 
            // textBoxBrojStola
            // 
            this.textBoxBrojStola.Location = new System.Drawing.Point(114, 95);
            this.textBoxBrojStola.Name = "textBoxBrojStola";
            this.textBoxBrojStola.ReadOnly = true;
            this.textBoxBrojStola.Size = new System.Drawing.Size(63, 20);
            this.textBoxBrojStola.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ukupno:";
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(109, 329);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(63, 20);
            this.textBoxUkupno.TabIndex = 7;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Antun\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Projek" +
    "t_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // PosluziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 408);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBrojStola);
            this.Controls.Add(this.textBoxNarudzba);
            this.Controls.Add(this.buttonIzdajRacun);
            this.Controls.Add(this.dgvPosluzi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "PosluziForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "PosluziForm";
            this.Load += new System.EventHandler(this.PosluziForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosluzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPosluzi;
        private System.Windows.Forms.Button buttonIzdajRacun;
        private System.Windows.Forms.TextBox textBoxNarudzba;
        private System.Windows.Forms.TextBox textBoxBrojStola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
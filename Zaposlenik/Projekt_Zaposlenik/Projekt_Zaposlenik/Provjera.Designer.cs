namespace Projekt_Zaposlenik
{
    partial class Provjera
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
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.brnPotvrdi = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(22, 56);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(178, 20);
            this.txtLozinka.TabIndex = 1;
            // 
            // brnPotvrdi
            // 
            this.brnPotvrdi.Location = new System.Drawing.Point(125, 91);
            this.brnPotvrdi.Name = "brnPotvrdi";
            this.brnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.brnPotvrdi.TabIndex = 2;
            this.brnPotvrdi.Text = "Potvrdi";
            this.brnPotvrdi.UseVisualStyleBackColor = true;
            this.brnPotvrdi.Click += new System.EventHandler(this.brnPotvrdi_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Antun\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Projek" +
    "t_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // Provjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(231, 124);
            this.Controls.Add(this.brnPotvrdi);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "Provjera";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Provjera";
            this.Load += new System.EventHandler(this.Provjera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button brnPotvrdi;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
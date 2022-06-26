namespace Projekt_Zaposlenik
{
    partial class SkladisteForm
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
            this.dataGridViewSkladiste = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.buttonProvjeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkladiste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSkladiste
            // 
            this.dataGridViewSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkladiste.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSkladiste.Name = "dataGridViewSkladiste";
            this.dataGridViewSkladiste.Size = new System.Drawing.Size(581, 227);
            this.dataGridViewSkladiste.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID artika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izbrojana količina:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonProvjeri);
            this.groupBox1.Controls.Add(this.textBoxKolicina);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provjera";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(104, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(104, 55);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolicina.TabIndex = 4;
            // 
            // buttonProvjeri
            // 
            this.buttonProvjeri.Location = new System.Drawing.Point(129, 81);
            this.buttonProvjeri.Name = "buttonProvjeri";
            this.buttonProvjeri.Size = new System.Drawing.Size(75, 23);
            this.buttonProvjeri.TabIndex = 5;
            this.buttonProvjeri.Text = "Provjeri";
            this.buttonProvjeri.UseVisualStyleBackColor = true;
            this.buttonProvjeri.Click += new System.EventHandler(this.buttonProvjeri_Click);
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSkladiste);
            this.Name = "SkladisteForm";
            this.Text = "Skladiste";
            this.Load += new System.EventHandler(this.SkladisteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkladiste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSkladiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonProvjeri;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxID;
    }
}
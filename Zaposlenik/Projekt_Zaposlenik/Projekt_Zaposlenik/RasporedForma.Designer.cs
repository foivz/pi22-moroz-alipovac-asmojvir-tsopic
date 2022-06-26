namespace Projekt_Zaposlenik
{
    partial class RasporedForma
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewRaspored = new System.Windows.Forms.DataGridView();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridViewRaspored
            // 
            this.dataGridViewRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaspored.Location = new System.Drawing.Point(13, 53);
            this.dataGridViewRaspored.Name = "dataGridViewRaspored";
            this.dataGridViewRaspored.Size = new System.Drawing.Size(758, 205);
            this.dataGridViewRaspored.TabIndex = 1;
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.Location = new System.Drawing.Point(615, 24);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltriraj.TabIndex = 2;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.Location = new System.Drawing.Point(615, 264);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.buttonAzuriraj.TabIndex = 3;
            this.buttonAzuriraj.Text = "Azuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOsvjezi
            // 
            this.buttonOsvjezi.Location = new System.Drawing.Point(696, 24);
            this.buttonOsvjezi.Name = "buttonOsvjezi";
            this.buttonOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.buttonOsvjezi.TabIndex = 5;
            this.buttonOsvjezi.Text = "Osvjezi";
            this.buttonOsvjezi.UseVisualStyleBackColor = true;
            this.buttonOsvjezi.Click += new System.EventHandler(this.buttonOsvjezi_Click);
            // 
            // RasporedForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 299);
            this.Controls.Add(this.buttonOsvjezi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.dataGridViewRaspored);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "RasporedForma";
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.RasporedForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaspored)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewRaspored;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonOsvjezi;
    }
}
﻿namespace Projekt_Zaposlenik
{
    partial class StanjeSkladistaForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(Projekt_Zaposlenik.Artikl);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpNavigator(this.reportViewer, System.Windows.Forms.HelpNavigator.Topic);
            reportDataSource1.Name = "DsStanjeSkladista";
            reportDataSource1.Value = this.artiklBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Projekt_Zaposlenik.StanjeSkladista.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.helpProvider1.SetShowHelp(this.reportViewer, true);
            this.reportViewer.Size = new System.Drawing.Size(800, 450);
            this.reportViewer.TabIndex = 0;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Antun\\Desktop\\mapa\\pi22-moroz-alipovac-asmojvir-tsopic\\Zaposlenik\\Projek" +
    "t_Zaposlenik\\Projekt_Zaposlenik\\Resources\\helpMe.chm";
            // 
            // StanjeSkladistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Name = "StanjeSkladistaForm";
            this.Text = "Izvještaj skladišta";
            this.Load += new System.EventHandler(this.StanjeSkladistaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
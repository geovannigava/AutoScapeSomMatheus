﻿namespace ScapeSaoMateus
{
    partial class RelEntrada
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDataSetRelatorio = new ScapeSaoMateus.projetoDataSetRelatorio();
            this.dtEntradaTableAdapter = new ScapeSaoMateus.projetoDataSetRelatorioTableAdapters.dtEntradaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetEntrad";
            reportDataSource2.Value = this.dtEntradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScapeSaoMateus.RelatorioEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(667, 627);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtEntradaBindingSource
            // 
            this.dtEntradaBindingSource.DataMember = "dtEntrada";
            this.dtEntradaBindingSource.DataSource = this.projetoDataSetRelatorio;
            // 
            // projetoDataSetRelatorio
            // 
            this.projetoDataSetRelatorio.DataSetName = "projetoDataSetRelatorio";
            this.projetoDataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtEntradaTableAdapter
            // 
            this.dtEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // RelEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 627);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Entradas";
            this.Load += new System.EventHandler(this.RelEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtEntradaBindingSource;
        private projetoDataSetRelatorio projetoDataSetRelatorio;
        private projetoDataSetRelatorioTableAdapters.dtEntradaTableAdapter dtEntradaTableAdapter;
    }
}
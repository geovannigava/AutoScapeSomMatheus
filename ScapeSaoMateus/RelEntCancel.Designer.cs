namespace ScapeSaoMateus
{
    partial class RelEntCancel
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
            this.projetoDataSetRelatorio = new ScapeSaoMateus.projetoDataSetRelatorio();
            this.dtEntCancelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtEntCancelTableAdapter = new ScapeSaoMateus.projetoDataSetRelatorioTableAdapters.dtEntCancelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntCancelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetEntCancel";
            reportDataSource2.Value = this.dtEntCancelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScapeSaoMateus.RelatorioEntCancel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(667, 627);
            this.reportViewer1.TabIndex = 0;
            // 
            // projetoDataSetRelatorio
            // 
            this.projetoDataSetRelatorio.DataSetName = "projetoDataSetRelatorio";
            this.projetoDataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtEntCancelBindingSource
            // 
            this.dtEntCancelBindingSource.DataMember = "dtEntCancel";
            this.dtEntCancelBindingSource.DataSource = this.projetoDataSetRelatorio;
            // 
            // dtEntCancelTableAdapter
            // 
            this.dtEntCancelTableAdapter.ClearBeforeFill = true;
            // 
            // RelEntCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 627);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEntCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Cancelamento de Entradas";
            this.Load += new System.EventHandler(this.RelEntCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntCancelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtEntCancelBindingSource;
        private projetoDataSetRelatorio projetoDataSetRelatorio;
        private projetoDataSetRelatorioTableAdapters.dtEntCancelTableAdapter dtEntCancelTableAdapter;
    }
}
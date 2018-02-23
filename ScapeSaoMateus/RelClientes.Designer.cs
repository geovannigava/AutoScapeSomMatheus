namespace ScapeSaoMateus
{
    partial class RelClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projetoDataSetRelatorio = new ScapeSaoMateus.projetoDataSetRelatorio();
            this.dtClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClienteTableAdapter = new ScapeSaoMateus.projetoDataSetRelatorioTableAdapters.dtClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCliente";
            reportDataSource1.Value = this.dtClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScapeSaoMateus.repRelCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(718, 627);
            this.reportViewer1.TabIndex = 0;
            // 
            // projetoDataSetRelatorio
            // 
            this.projetoDataSetRelatorio.DataSetName = "projetoDataSetRelatorio";
            this.projetoDataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClienteBindingSource
            // 
            this.dtClienteBindingSource.DataMember = "dtCliente";
            this.dtClienteBindingSource.DataSource = this.projetoDataSetRelatorio;
            // 
            // dtClienteTableAdapter
            // 
            this.dtClienteTableAdapter.ClearBeforeFill = true;
            // 
            // RelClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 627);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Clientes - Contatos / Aniversário";
            this.Load += new System.EventHandler(this.RelClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtClienteBindingSource;
        private projetoDataSetRelatorio projetoDataSetRelatorio;
        private projetoDataSetRelatorioTableAdapters.dtClienteTableAdapter dtClienteTableAdapter;
    }
}
namespace ScapeSaoMateus
{
    partial class AlertaProduto
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
            this.dtAlertaProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtAlertaProdTableAdapter = new ScapeSaoMateus.projetoDataSetRelatorioTableAdapters.dtAlertaProdTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlertaProdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetAlertaProd";
            reportDataSource1.Value = this.dtAlertaProdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScapeSaoMateus.RelAlertaProd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // projetoDataSetRelatorio
            // 
            this.projetoDataSetRelatorio.DataSetName = "projetoDataSetRelatorio";
            this.projetoDataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtAlertaProdBindingSource
            // 
            this.dtAlertaProdBindingSource.DataMember = "dtAlertaProd";
            this.dtAlertaProdBindingSource.DataSource = this.projetoDataSetRelatorio;
            // 
            // dtAlertaProdTableAdapter
            // 
            this.dtAlertaProdTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATENÇÃO !! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Os produtos listados abaixo estão abaixo do nível desejado no Estoque.";
            // 
            // AlertaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AlertaProduto";
            this.Text = "Aviso de Estoque - Produtos se Esgotando !";
            this.Load += new System.EventHandler(this.AlertaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlertaProdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtAlertaProdBindingSource;
        private projetoDataSetRelatorio projetoDataSetRelatorio;
        private projetoDataSetRelatorioTableAdapters.dtAlertaProdTableAdapter dtAlertaProdTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
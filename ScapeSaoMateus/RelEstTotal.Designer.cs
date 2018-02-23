namespace ScapeSaoMateus
{
    partial class RelEstTotal
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
            this.DataTableEstTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ScapeSaoMateus.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableEstTotalTableAdapter = new ScapeSaoMateus.DataSet1TableAdapters.DataTableEstTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEstTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableEstTotalBindingSource
            // 
            this.DataTableEstTotalBindingSource.DataMember = "DataTableEstTotal";
            this.DataTableEstTotalBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableEstTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScapeSaoMateus.repEstTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableEstTotalTableAdapter
            // 
            this.DataTableEstTotalTableAdapter.ClearBeforeFill = true;
            // 
            // RelEstTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 425);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEstTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque Total";
            this.Load += new System.EventHandler(this.RelEstTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEstTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableEstTotalBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTableEstTotalTableAdapter DataTableEstTotalTableAdapter;
    }
}
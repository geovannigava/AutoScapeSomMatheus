using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeSaoMateus
{
    public partial class RelVend : Form
    {
        DateTime dataini = new DateTime();
        DateTime datafim = new DateTime();

        public RelVend(DateTime datainicial, DateTime datafinal)
        {
            InitializeComponent();
            dataini = datainicial;
            datafim = datafinal;
        }

        private void RelVend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DataSet1.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            ReportParameter di = new ReportParameter("dataInicial", Convert.ToString(dataini));
            ReportParameter df = new ReportParameter("dataFinal", Convert.ToString(datafim));
            reportViewer1.LocalReport.SetParameters(di);
            reportViewer1.LocalReport.SetParameters(df);

            this.reportViewer1.RefreshReport();
        }
    }
}

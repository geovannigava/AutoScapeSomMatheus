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
    public partial class RelEntrada : Form
    {
        DateTime dataInicial = new DateTime();
        DateTime dataFinal = new DateTime();
        public RelEntrada(DateTime dataini, DateTime datafim)
        {
            InitializeComponent();
            dataInicial = dataini;
            dataFinal = datafim;
        }

        private void RelEntrada_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDataSetRelatorio.dtEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.dtEntradaTableAdapter.Fill(this.projetoDataSetRelatorio.dtEntrada);
            ReportParameter di = new ReportParameter("dataInicial", Convert.ToString(dataInicial));
            ReportParameter df = new ReportParameter("dataFinal", Convert.ToString(dataFinal));
            reportViewer1.LocalReport.SetParameters(di);
            reportViewer1.LocalReport.SetParameters(df);


            this.reportViewer1.RefreshReport();
        }
    }
}

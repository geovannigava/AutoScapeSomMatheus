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
    public partial class AlertaProduto : Form
    {
        public AlertaProduto()
        {
            InitializeComponent();
        }

        private void AlertaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDataSetRelatorio.dtAlertaProd'. Você pode movê-la ou removê-la conforme necessário.
            this.dtAlertaProdTableAdapter.Fill(this.projetoDataSetRelatorio.dtAlertaProd);

            this.reportViewer1.RefreshReport();
        }
    }
}

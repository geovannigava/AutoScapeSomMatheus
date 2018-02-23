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
    public partial class RelClientes : Form
    {
        public RelClientes()
        {
            InitializeComponent();
        }

        private void RelClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDataSetRelatorio.dtCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.dtClienteTableAdapter.Fill(this.projetoDataSetRelatorio.dtCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}

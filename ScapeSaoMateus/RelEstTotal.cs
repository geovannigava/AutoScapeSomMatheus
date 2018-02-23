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
    public partial class RelEstTotal : Form
    {
        public RelEstTotal()
        {
            InitializeComponent();
        }

        private void RelEstTotal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DataSet1.DataTableEstTotal'. Você pode movê-la ou removê-la conforme necessário.
            this.DataTableEstTotalTableAdapter.Fill(this.DataSet1.DataTableEstTotal);

            this.reportViewer1.RefreshReport();
        }
    }
}

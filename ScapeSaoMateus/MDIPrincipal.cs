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
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadCliente>().Count() == 0)
            {
                CadCliente cliente = new CadCliente(false);
                cliente.MdiParent = this;
                cliente.Show();

            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }



        private void entradaStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EstoqueEntrada>().Count() == 0)
            {
                EstoqueEntrada Entrada = new EstoqueEntrada();
                Entrada.MdiParent = this;
                Entrada.Show();

            }
        }



        private void cadprodutoStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadProduto>().Count() == 0)
            {
                CadProduto cad = new CadProduto(false);
                cad.MdiParent = this;
                cad.Show();

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadEscapamento>().Count() == 0)
            {
                CadEscapamento CadEscap = new CadEscapamento();
                CadEscap.MdiParent = this;
                CadEscap.Show();

            }
        }

        private void cadveiculoStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadCarroModelo>().Count() == 0)
            {
                CadCarroModelo carro = new CadCarroModelo();
                carro.MdiParent = this;
                carro.Show();

            }
        }

        private void vendasStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadVendas>().Count() == 0)
            {
                CadVendas vendas = new CadVendas();
                vendas.MdiParent = this;
                vendas.Show();
            }
        }

        private void consVendasStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConsVenda>().Count() == 0)
            {
                ConsVenda consVendas = new ConsVenda();
                consVendas.MdiParent = this;
                consVendas.Show();

            }
        }

        private void cancelEntraStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConsEntrada>().Count() == 0)
            {
                ConsEntrada consVendas = new ConsEntrada();
                consVendas.MdiParent = this;
                consVendas.Show();

            }
        }



        private void relatoriosStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EmiteRelatorios>().Count() == 0)
            {
                EmiteRelatorios emitirRel = new EmiteRelatorios();
                emitirRel.MdiParent = this;
                emitirRel.Show();

            }
        }

        private void estStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConsEstoque>().Count() == 0)
            {
                ConsEstoque consEstoque = new ConsEstoque();
                consEstoque.MdiParent = this;
                consEstoque.Show();

            }
        }

        private void avisoStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlertaProduto Alerta = new AlertaProduto();
            Alerta.ShowDialog();
            Alerta.Dispose();
        }
    }
}

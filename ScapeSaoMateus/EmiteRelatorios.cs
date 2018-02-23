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
    public partial class EmiteRelatorios : Form
    {
        public EmiteRelatorios()
        {
            InitializeComponent();
        }

        private void btn_VendPorPeriod_Click(object sender, EventArgs e)
        {
            if (validaVenda())
            {
                if (rdbtn_VendRealizadas.Checked)
                {
                    RelVend rel = new RelVend(Convert.ToDateTime(mktbox_Inicio.Text), Convert.ToDateTime(mktbox_Fim.Text));
                    rel.ShowDialog();
                    rel.Dispose();
                }
                if (rdbtn_VendCancel.Checked)
                {
                    RelVendCancel rel = new RelVendCancel(Convert.ToDateTime(mktbox_Inicio.Text), Convert.ToDateTime(mktbox_Fim.Text));
                    rel.ShowDialog();
                    rel.Dispose();
                }


            }
            
        }

        private bool validaVenda()
        {
            bool controle = true;

            if (!rdbtn_VendRealizadas.Checked && !rdbtn_VendCancel.Checked)
            {
                MessageBox.Show("Selecione Vendas Realizadas ou Vendas Canceladas ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controle = false;
            }

            try
            {
               DateTime dataInicial = Convert.ToDateTime(mktbox_Inicio.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Inicial Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_Inicio.Focus();
                controle = false;
            }
            try
            {
                DateTime dataFinal = Convert.ToDateTime(mktbox_Fim.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Final Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_Fim.Focus();
                controle = false;
            }

            return controle;
        }

        private void btn_EntporPeriodo_Click(object sender, EventArgs e)
        {
            if (validaEntrada())
            {
                if (rdbtn_EntRealiz.Checked)
                {
                    RelEntrada rel = new RelEntrada(Convert.ToDateTime(mktbox_EntIni.Text), Convert.ToDateTime(mktbox_EntFim.Text));
                    rel.ShowDialog();
                    rel.Dispose();
                }
                if (rdbtn_EntCancel.Checked)
                {
                    RelEntCancel rel = new RelEntCancel(Convert.ToDateTime(mktbox_EntIni.Text), Convert.ToDateTime(mktbox_EntFim.Text));
                    rel.ShowDialog();
                    rel.Dispose();
                }


            }
        }
        private bool validaEntrada()
        {
            bool controle = true;

            if (!rdbtn_EntRealiz.Checked && !rdbtn_EntCancel.Checked)
            {
                MessageBox.Show("Selecione Entradas Realizadas ou Entradas Canceladas ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controle = false;
            }

            try
            {
                DateTime dataInicial = Convert.ToDateTime(mktbox_EntIni.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Inicial Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_EntIni.Focus();
                controle = false;
            }
            try
            {
                DateTime dataFinal = Convert.ToDateTime(mktbox_EntFim.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Final Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_EntFim.Focus();
                controle = false;
            }

            return controle;
        }

        private void btn_estTotal_Click(object sender, EventArgs e)
        {
            RelEstTotal relEstTot = new RelEstTotal();
            relEstTot.ShowDialog();
            relEstTot.Dispose();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            RelClientes relC = new RelClientes();
            relC.ShowDialog();
            relC.Dispose();
        }
    }
}

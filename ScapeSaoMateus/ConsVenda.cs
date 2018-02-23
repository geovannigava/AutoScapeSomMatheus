using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.DataAccess;
using System.Configuration;


namespace ScapeSaoMateus
{
    public partial class ConsVenda : Form
    {
        DataTable tableVendas = new DataTable();
        DataTable tableItens = new DataTable();
        DateTime dataInicial = new DateTime();
        DateTime dataFinal = new DateTime();
        public ConsVenda()
        {
            InitializeComponent();
            
            //table vendas
            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Número da Venda";
            tableVendas.Columns.Add(colunaId);

            DataColumn colunaData = new DataColumn();
            colunaData.DataType = System.Type.GetType("System.DateTime");
            colunaData.ColumnName = "Data da Venda";
            colunaData.ReadOnly = true;
            tableVendas.Columns.Add(colunaData);

            DataColumn colunaValorVend = new DataColumn();
            colunaValorVend.DataType = System.Type.GetType("System.Decimal");
            colunaValorVend.ColumnName = "Valor Total";
            colunaValorVend.ReadOnly = true;
            tableVendas.Columns.Add(colunaValorVend);

            DataColumn colunaCliente = new DataColumn();
            colunaCliente.DataType = System.Type.GetType("System.String");
            colunaCliente.ColumnName = "Cliente";
            colunaCliente.ReadOnly = true;
            tableVendas.Columns.Add(colunaCliente);

            DataColumn colunaAtv = new DataColumn();
            colunaAtv.DataType = System.Type.GetType("System.Boolean");
            colunaAtv.ColumnName = "Venda Ativa ?";
            colunaAtv.ReadOnly = true;
            tableVendas.Columns.Add(colunaAtv);

            

            //table itens
            DataColumn colunaIditem = new DataColumn();
            colunaIditem.DataType = System.Type.GetType("System.Int32");
            colunaIditem.ColumnName = "Id";
            tableItens.Columns.Add(colunaIditem);

            DataColumn colunaProd = new DataColumn();
            colunaProd.DataType = System.Type.GetType("System.String");
            colunaProd.ColumnName = "Produto";
            colunaProd.ReadOnly = true;
            tableItens.Columns.Add(colunaProd);

            DataColumn colunaModVeic = new DataColumn();
            colunaModVeic.DataType = System.Type.GetType("System.String");
            colunaModVeic.ColumnName = "Modelo do Veic.";
            colunaModVeic.ReadOnly = true;
            tableItens.Columns.Add(colunaModVeic);

            DataColumn colunaValorItem = new DataColumn();
            colunaValorItem.DataType = System.Type.GetType("System.Decimal");
            colunaValorItem.ColumnName = "Valor Produto";
            colunaValorItem.ReadOnly = true;
            tableItens.Columns.Add(colunaValorItem);

            DataColumn colunaIdVenda = new DataColumn();
            colunaIdVenda.DataType = System.Type.GetType("System.Int32");
            colunaIdVenda.ColumnName = "IdVenda";
            colunaIdVenda.ReadOnly = true;
            tableItens.Columns.Add(colunaIdVenda);

            DataColumn colunaQtdeItem = new DataColumn();
            colunaQtdeItem.DataType = System.Type.GetType("System.Int32");
            colunaQtdeItem.ColumnName = "Quantidade Itens";
            colunaQtdeItem.ReadOnly = true;
            tableItens.Columns.Add(colunaQtdeItem);

            DataColumn colunaCouS = new DataColumn();
            colunaCouS.DataType = System.Type.GetType("System.Char");
            colunaCouS.ColumnName = "C ou S";
            colunaCouS.ReadOnly = true;
            tableItens.Columns.Add(colunaCouS);
        }

        private void btn_Pesq_Click(object sender, EventArgs e)
        {
            
            bool controle = true;
            try
            {
                 dataInicial = Convert.ToDateTime(mktbox_Inicio.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Inicial Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_Inicio.Focus();
                controle = false;
            }
            try
            {
                 dataFinal = Convert.ToDateTime(mktbox_Fim.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data Final Inválida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktbox_Fim.Focus();
                controle = false;
            }
            if (controle)
            { 
            preencheGridVendas(VendaDataAcess.ConsultaVenda(dataInicial.Date, dataFinal.Date));
            }
        }

        private void preencheGridVendas(List<Venda> vendas)
        {
            tableVendas.Clear();
            for(int x=0; x < vendas.Count; x++)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;

                row = tableVendas.NewRow(); // Adicionamos uma linha do DataTable
                row["Número da Venda"] = vendas[x].id;
                row["Data da Venda"] = vendas[x].data;
                row["Valor Total"] = vendas[x].valortotal;
                if(vendas[x].Cliente != null)
                    row["Cliente"] = vendas[x].Cliente.nome;
                row["Venda Ativa ?"] = vendas[x].ativo;   
                tableVendas.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            DataView view = new DataView(tableVendas); // O View recebe o Datatable Preenchido
            dataGridViewVend.DataSource = view;
            dataGridViewVend.Columns["Valor Total"].DefaultCellStyle.Format = "N2";
            dataGridViewVend.MultiSelect = false;
            //dataGridViewVend.Columns["Venda Ativa ?"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //alinha conteudo
            //dataGridViewVend.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // alinha titulo
            dataGridViewVend.Columns["Venda Ativa ?"].Visible = false;

            foreach (DataGridViewRow row in dataGridViewVend.Rows)
            {
                if (!Convert.ToBoolean(row.Cells["Venda Ativa ?"].Value))
                    row.DefaultCellStyle.BackColor = Color.Red;    
            }

        }
        private void preencheGridItens(int IdVenda, bool status)
        {
            tableItens.Clear();
            List<ItensVenda> Itens = ItensVendaDataAcess.BuscaItens(IdVenda);

            for (int x = 0; x < Itens.Count; x++)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;

                row = tableItens.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = Itens[x].id;
                row["Produto"] = Itens[x].Produto.descricao;
                row["Valor Produto"] = Itens[x].valor_venda;
                row["IdVenda"] = Itens[x].id_venda;
                row["Quantidade Itens"] = Itens[x].qtde; 
                row["Modelo do Veic."] = ModeloDataAcess.buscaModeloPorProd(Itens[x].id_produto).nome;
                row["C ou S"] = Itens[x].C_ou_S;
                tableItens.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            DataView view = new DataView(tableItens); // O View recebe o Datatable Preenchido
            dataGridViewItens.DataSource = view;
            dataGridViewItens.Columns[0].Visible = false;
            dataGridViewItens.Columns[4].Visible = false;
            dataGridViewItens.Columns["Valor Produto"].DefaultCellStyle.Format = "N2";

            dataGridViewItens.Columns["Produto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewItens.Columns["Modelo do Veic."].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewItens.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewItens.Columns["Produto"].Width = 400;
            dataGridViewItens.Columns["Modelo do Veic."].Width = 140;

            dataGridViewItens.MultiSelect = false;
            if (status)
                dataGridViewItens.DefaultCellStyle.BackColor = Color.White;
            else
                dataGridViewItens.DefaultCellStyle.BackColor = Color.Red;

        }

        private void dataGridViewVend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            preencheGridItens(Convert.ToInt32(dataGridViewVend.CurrentRow.Cells[0].Value), Convert.ToBoolean(dataGridViewVend.CurrentRow.Cells[4].Value));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dataGridViewVend.CurrentRow.Cells["Venda Ativa ?"].Value))
            {
                DialogResult confirm = MessageBox.Show("Deseja confirmar o cancelamento da venda ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    VendaCancel VendaCancel = new VendaCancel();
                    if (Application.OpenForms.OfType<MotivoCancel>().Count() == 0)
                    {
                        MotivoCancel motCancel = new MotivoCancel();
                        motCancel.ShowDialog();
                        VendaCancel.motivo = motCancel.motivo;
                        VendaCancel.id_venda = Convert.ToInt32(dataGridViewVend.CurrentRow.Cells[0].Value);
                        VendaCancel.data = DateTime.Now.Date;

                        // busca registro de intesvenda para somar no estoque
                        List<ItensVenda> itens = ItensVendaDataAcess.BuscaItens(Convert.ToInt32(dataGridViewVend.CurrentRow.Cells[0].Value));
                        List<Estoque> estoqueList = new List<Estoque>();
                        foreach (ItensVenda i in itens)
                        {
                            Estoque estoque = new Estoque();
                            estoque.id_produto = i.id_produto;
                            estoque.qtde_C = 0;
                            estoque.qtde_S = 0;
                            if (i.C_ou_S == 'C')
                                estoque.qtde_C = i.qtde;
                            if (i.C_ou_S == 'S')
                                estoque.qtde_S = i.qtde;
                            estoqueList.Add(estoque);
                        }
                        //grava na tabela Venda_Cancel
                        bool a = VendaCancelDataAcess.Inserir(VendaCancel);
                        //atualiza regristro na tabela Venda
                        bool b = VendaDataAcess.CancelaVenda(Convert.ToInt32(dataGridViewVend.CurrentRow.Cells[0].Value));
                        //soma no estoque
                        bool c = EstoqueDataAcess.GravaEstoque(estoqueList);

                        if (a && b && c)
                        {
                            MessageBox.Show("Cancelamento realizado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            preencheGridVendas(VendaDataAcess.ConsultaVenda(dataInicial.Date, dataFinal.Date));
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cancelar a Venda ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Essa Venda já foi Cancelada ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

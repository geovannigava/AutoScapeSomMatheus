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
    public partial class CadVendas : Form
    {
        Cliente cliente = new Cliente();
        DataTable table = new DataTable();
        Decimal total = 0;
        public CadVendas()
        {
            InitializeComponent();
            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            colunaId.ReadOnly = true;
            table.Columns.Add(colunaId);

            DataColumn colunaCod = new DataColumn();
            colunaCod.DataType = System.Type.GetType("System.String");
            colunaCod.ColumnName = "Código";
            colunaCod.ReadOnly = true;
            table.Columns.Add(colunaCod);

            DataColumn colunaDesc = new DataColumn();
            colunaDesc.DataType = System.Type.GetType("System.String");
            colunaDesc.ColumnName = "Descrição";
            colunaDesc.ReadOnly = true;
            table.Columns.Add(colunaDesc);

            DataColumn colunaVeic = new DataColumn();
            colunaVeic.DataType = System.Type.GetType("System.String");
            colunaVeic.ColumnName = "Modelo Veículo";
            colunaVeic.ReadOnly = true;
            table.Columns.Add(colunaVeic);

            DataColumn colunaQtde = new DataColumn();
            colunaQtde.DataType = System.Type.GetType("System.Int32");
            colunaQtde.ColumnName = "Quantidade";
            colunaQtde.ReadOnly = false;
            table.Columns.Add(colunaQtde);

            DataColumn colunaCusto = new DataColumn();
            colunaCusto.DataType = System.Type.GetType("System.Decimal");
            colunaCusto.ColumnName = "Preço de Venda";
            colunaCusto.ReadOnly = false;
            table.Columns.Add(colunaCusto);

            DataColumn colunatpVend = new DataColumn();
            colunatpVend.DataType = System.Type.GetType("System.Char");
            colunatpVend.ColumnName = "\"C\" ou \"S\"";
            colunatpVend.ReadOnly = false;
            table.Columns.Add(colunatpVend);

            DataColumn colunaEst = new DataColumn();
            colunaEst.DataType = System.Type.GetType("System.Decimal");
            colunaEst.ColumnName = "Qtde Estoque";
            colunaEst.ReadOnly = true;
            table.Columns.Add(colunaEst);

            DataColumn colunaEstC = new DataColumn();
            colunaEstC.DataType = System.Type.GetType("System.Int32");
            colunaEstC.ColumnName = "Estoque C";
            colunaEstC.ReadOnly = true;
            table.Columns.Add(colunaEstC);

            DataColumn colunaEstS = new DataColumn();
            colunaEstS.DataType = System.Type.GetType("System.Int32");
            colunaEstS.ColumnName = "Estoque S";
            colunaEstS.ReadOnly = true;
            table.Columns.Add(colunaEstS);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SelecionaProduto>().Count() == 0)
            {
                SelecionaProduto seleciona = new SelecionaProduto();
                seleciona.ShowDialog();
                //Console.WriteLine(seleciona.prodSelecionado.id);
                ProdModelo prod = seleciona.prodSelecionado;
                preencheGrid(prod);

            }

        }
        private void preencheGrid(ProdModelo prodModel)
        {
            bool controle = true;
            foreach (DataRow dr in table.Rows)
            {
                if ((int)dr[0] == prodModel.id)
                {
                    controle = false;
                    MessageBox.Show("Esse produto já foi Inserido na Lista !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (!prodModel.id.Equals(null) && prodModel.id != 0 && controle)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;

                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = prodModel.id;
                row["Código"] = prodModel.codigo;
                row["Descrição"] = prodModel.descricao;
                row["Modelo Veículo"] = prodModel.NomeModelo;
                row["Quantidade"] = 0;
                row["Preço de Venda"] = prodModel.valor;
                row["Qtde Estoque"] = EstoqueDataAcess.ConsultaEstoque(prodModel.id).qtde;
                row["Estoque C"] = EstoqueDataAcess.ConsultaEstoque(prodModel.id).qtde_C;
                row["Estoque S"] = EstoqueDataAcess.ConsultaEstoque(prodModel.id).qtde_S;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.

                // Create a DataView using the DataTable.
                DataView view = new DataView(table); // O View recebe o Datatable Preenchido
                dataGridViewVend.DataSource = view;
                dataGridViewVend.Columns[0].Visible = false;
                dataGridViewVend.Columns["Preço de Venda"].DefaultCellStyle.Format = "N2";
                dataGridViewVend.Columns["Quantidade"].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewVend.Columns["Preço de Venda"].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewVend.Columns["\"C\" ou \"S\""].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewVend.Columns["Qtde Estoque"].DefaultCellStyle.BackColor = Color.Red;
                dataGridViewVend.Columns["Quantidade"].DefaultCellStyle.Format = "N";
                dataGridViewVend.MultiSelect = false;
                dataGridViewVend.Columns["Estoque C"].DefaultCellStyle.BackColor = Color.YellowGreen;
                dataGridViewVend.Columns["Estoque S"].DefaultCellStyle.BackColor = Color.YellowGreen;
                dataGridViewVend.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewVend.Columns["Modelo Veículo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewVend.Columns["Descrição"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewVend.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dataGridViewVend.Columns["Descrição"].Width = 300;
                dataGridViewVend.Columns["Preço de Venda"].Width = 70;
                dataGridViewVend.Columns["Modelo Veículo"].Width = 120;
                dataGridViewVend.Columns["Quantidade"].Width = 70;
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            DataRow remove = null;
            foreach (DataRow dr in table.Rows)
            {
                if ((int)dr[0] == Convert.ToInt32(dataGridViewVend.CurrentRow.Cells[0].Value))
                {
                    remove = dr;
                }
            }
            if (remove != null)
                remove.Delete();
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SelecionaCliente>().Count() == 0)
            {
                SelecionaCliente seleciona = new SelecionaCliente();
                seleciona.ShowDialog();
                cliente = seleciona.clienteSelecionado;
                //verifica se foi encontrado um cliente, caso positivo preenche os tbox no form vendas
                if (cliente.id != 0)
                {
                    
                    tbox_nome.Text = cliente.nome;
                    tbox_celular.Text = cliente.celular;
                    tbox_email.Text = cliente.email;
                    tbox_telFixo.Text = cliente.tel_fixo;
                    tbox_rua.Text = cliente.Endereco.rua;
                    tbox_nro.Text = cliente.Endereco.numero;
                    tbox_bairro.Text = cliente.Endereco.bairro;
                    tbox_cidade.Text = cliente.Endereco.Cidade1.nome + " - " + cliente.Endereco.Cidade1.estado;
                    tbox_cep.Text = cliente.Endereco.cep;
                }

            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadCliente>().Count() == 0)
            {
                CadCliente CadCli = new CadCliente(true);
                CadCli.ShowDialog();
                cliente = CadCli.clienteInserido;
                
                //verifica se foi encontrado um cliente, caso positivo preenche os tbox no form vendas
                if (cliente.id != 0)
                {
                    Cidade cid = CidadeDataAcess.buscaCidade(cliente.Endereco.cidade);
                    tbox_nome.Text = cliente.nome;
                    tbox_celular.Text = cliente.celular;
                    tbox_email.Text = cliente.email;
                    tbox_telFixo.Text = cliente.tel_fixo;
                    tbox_rua.Text = cliente.Endereco.rua;
                    tbox_nro.Text = cliente.Endereco.numero;
                    tbox_bairro.Text = cliente.Endereco.bairro;
                    tbox_cidade.Text = cid.nome + " - " + cid.estado;
                    tbox_cep.Text = cliente.Endereco.cep;
                }
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            calculaTotal();
        }
        private void calculaTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in this.dataGridViewVend.Rows)
            {
                total = total + (Convert.ToDecimal(row.Cells["Quantidade"].Value) * Convert.ToDecimal(row.Cells["Preço de Venda"].Value));
            }
            label1.Text = "Valor total (R$):  " + total.ToString();
        }

        private void btn_finalizaVenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewVend.RowCount == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto para realizar a venda !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(validaQtde())
            {
                Venda venda = new Venda();
                calculaTotal();
                venda.valortotal = total;
                venda.data = DateTime.Now.Date;
                venda.ativo = true;
                if (cliente.id != 0)
                {
                    venda.id_cliente = cliente.id;
                }

                //grava na tabela vendas
                int idVenda = VendaDataAcess.Inserir(venda);

                if (idVenda != 0)
                {
                    List<ItensVenda> itens = new List<ItensVenda>();
                    List<Estoque> estoque = new List<Estoque>();
                    foreach (DataGridViewRow row in this.dataGridViewVend.Rows)
                    {
                        ItensVenda item = new ItensVenda();
                        item.id_produto = Convert.ToInt32(row.Cells["Id"].Value);
                        item.valor_venda = Convert.ToDecimal(row.Cells["Preço de Venda"].Value);
                        item.id_venda = idVenda;
                        item.qtde = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        item.C_ou_S = Convert.ToChar(Convert.ToString(row.Cells["\"C\" ou \"S\""].Value).ToUpper());
                        itens.Add(item);
                        Estoque est = new Estoque();
                        est.id_produto = Convert.ToInt32(row.Cells["Id"].Value);
                        est.qtde_C = 0;
                        est.qtde_S = 0;
                        if (item.C_ou_S == 'C')
                            est.qtde_C = item.qtde;
                        if (item.C_ou_S == 'S')
                            est.qtde_S = item.qtde;
                        estoque.Add(est);
                    }
                    //grava itens na tabela itens venda 
                    bool a = ItensVendaDataAcess.Inserir(itens);
                    //atualiza a quantidade no estoque (diminui) o estoque.
                    bool b = EstoqueDataAcess.DiminuiEstoque(estoque);
                    if (a && b) //colocar o B
                    {
                        MessageBox.Show("Venda realizada com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbox_nroVenda.Text = idVenda.ToString();
                        btn_finalizaVenda.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Problema ao realizar a Venda ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
                    
            }
            
        }

        private void limpaCliente()
        {
            cliente = new Cliente();
            tbox_nome.Text = "";
            tbox_bairro.Text = "";
            tbox_celular.Text = "";
            tbox_cep.Text = "";
            tbox_cidade.Text = "";
            tbox_email.Text = "";
            tbox_nro.Text = "";
            tbox_rua.Text = "";
            tbox_telFixo.Text = "";
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limpaCliente();
            table.Clear();
            tbox_nroVenda.Text = "";
            label1.Text = "Valor total (R$):  ";
            btn_finalizaVenda.Enabled = true;
        }

        private bool validaQtde()
        {
            bool controle = true;
            foreach (DataGridViewRow row in this.dataGridViewVend.Rows)
            {
                
                if(Convert.ToInt32(row.Cells["Quantidade"].Value) <= 0)
                {
                    MessageBox.Show("A quantidade do Produto não pode ser \"0\" !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewVend.CurrentCell = row.Cells["Quantidade"];
                    controle = false;
                }
                
                if (Convert.ToDouble(row.Cells["Preço de Venda"].Value) <= 0.01)
                {
                    MessageBox.Show("O valor do Produto não pode ser \" R$ 0,00\" !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewVend.CurrentCell = row.Cells["Preço de Venda"];
                    controle = false;
                }
                if (!DBNull.Value.Equals(row.Cells["\"C\" ou \"S\""].Value))
                {
                    if (!Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('S') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('s') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('C') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('c'))
                    {
                        MessageBox.Show("Preencha o camo C ou S apenas com as letras C ou S !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridViewVend.CurrentCell = row.Cells["\"C\" ou \"S\""];
                        controle = false;
                    } else if (Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('S') || Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('s'))
                    {
                        if (Convert.ToInt32(row.Cells["Quantidade"].Value) > Convert.ToInt32(row.Cells["Estoque S"].Value))
                        {
                            MessageBox.Show("Não há produtos suficientes no estoque, altere a quantidade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dataGridViewVend.CurrentCell = row.Cells["Quantidade"];
                            controle = false;
                        }
                        
                    } else
                    {
                        if (Convert.ToInt32(row.Cells["Quantidade"].Value) > Convert.ToInt32(row.Cells["Estoque C"].Value))
                        {
                            MessageBox.Show("Não há produtos suficientes no estoque, altere a quantidade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dataGridViewVend.CurrentCell = row.Cells["Quantidade"];
                            controle = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o camo C ou S com as letras C ou S !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewVend.CurrentCell = row.Cells["\"C\" ou \"S\""];
                    controle = false;
                }

            }
            return controle;
        }

    }
}

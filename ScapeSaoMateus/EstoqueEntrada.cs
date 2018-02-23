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
    public partial class EstoqueEntrada : Form
    {
        DataTable table = new DataTable();
        public EstoqueEntrada()
        {
            InitializeComponent();

            textBox1.Text = "UTILIZE A OPÇÃO (PESQUISAR PRODUTO) CASO JÁ TENHA FEITO A ENTRADA DO PRODUTO" +
                " ANTERIORMENTE. CASO SEJA A PRIMEIRA ENTRADA, UTILIZE A OPCAO (CADASTRAR NOVO PRODUTO)." + System.Environment.NewLine + System.Environment.NewLine + 
                "NA DÚVIDA, PRIMEIRO PESQUISE O PRODUTO PARA SABER SE ELE JÁ FOI CADASTRADO EM UM MOMENTO PASSADO, " +
                " CASO REALMENTE SEJA A PRIMEIRA ENTRADA, UTILIZE A OPÇÃO CADASTRAR NOVO PRODUTO.";

            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
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

            DataColumn colunaMarca = new DataColumn();
            colunaMarca.DataType = System.Type.GetType("System.String");
            colunaMarca.ColumnName = "Marca - Catálogo";
            colunaMarca.ReadOnly = true;
            table.Columns.Add(colunaMarca);

            DataColumn colunaValor = new DataColumn();
            colunaValor.DataType = System.Type.GetType("System.Decimal");
            colunaValor.ColumnName = "Valor";
            colunaValor.ReadOnly = true;
            table.Columns.Add(colunaValor);

            DataColumn colunaQtde = new DataColumn();
            colunaQtde.DataType = System.Type.GetType("System.Int32");
            colunaQtde.ColumnName = "Quantidade";
            colunaQtde.ReadOnly = false;
            table.Columns.Add(colunaQtde);

            DataColumn colunaCusto = new DataColumn();
            colunaCusto.DataType = System.Type.GetType("System.Decimal");
            colunaCusto.ColumnName = "Preço de Custo";
            colunaCusto.ReadOnly = false;
            table.Columns.Add(colunaCusto);

            DataColumn colunaTpEnt = new DataColumn();
            colunaTpEnt.DataType = System.Type.GetType("System.Char");
            colunaTpEnt.ColumnName = "\"C\" ou \"S\"";
            colunaTpEnt.ReadOnly = false;
            table.Columns.Add(colunaTpEnt);

            DataColumn colunaEst = new DataColumn();
            colunaEst.DataType = System.Type.GetType("System.Int32");
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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SelecionaProduto>().Count() == 0)
            {
                SelecionaProduto seleciona = new SelecionaProduto();
                seleciona.ShowDialog();
                //Console.WriteLine(seleciona.prodSelecionado.id);
                preencheTabela(seleciona.prodSelecionado);
                
            }
            
        }

        private void preencheTabela(Produto prod)
        {
            bool controle = true;
            foreach (DataRow dr in table.Rows)
            {
                if ((int)dr[0] == prod.id)
                {
                    controle = false;
                    MessageBox.Show("Esse produto já foi Inserido na Lista !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            if (!prod.id.Equals(null) && prod.id != 0 && controle)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;

                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = prod.id;
                row["Código"] = prod.codigo;
                row["Descrição"] = prod.descricao;
                row["Marca - Catálogo"] = prod.marca;
                //row["Espécie"] = prod.especie;
                row["Valor"] = prod.valor; 
                row["Qtde Estoque"] = EstoqueDataAcess.ConsultaEstoque(prod.id).qtde;
                row["Estoque C"] = EstoqueDataAcess.ConsultaEstoque(prod.id).qtde_C;
                row["Estoque S"] = EstoqueDataAcess.ConsultaEstoque(prod.id).qtde_S;
                row["Quantidade"] = 0;
                row["Preço de Custo"] = 0;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.

                // Create a DataView using the DataTable.
                DataView view = new DataView(table); // O View recebe o Datatable Preenchido
                dataGridViewProdEst.DataSource = view;
                dataGridViewProdEst.Columns[0].Visible = false;
                dataGridViewProdEst.Columns["Valor"].Visible = false;
                dataGridViewProdEst.Columns["Preço de Custo"].DefaultCellStyle.Format = "N2";
                dataGridViewProdEst.Columns["Quantidade"].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewProdEst.Columns["Preço de Custo"].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewProdEst.Columns["\"C\" ou \"S\""].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewProdEst.Columns["Qtde Estoque"].DefaultCellStyle.BackColor = Color.Green;
                dataGridViewProdEst.Columns["Preço de Custo"].DefaultCellStyle.Format = "N2";
                dataGridViewProdEst.Columns["Quantidade"].DefaultCellStyle.Format = "N";
                dataGridViewProdEst.MultiSelect = false;

                dataGridViewProdEst.Columns["Estoque C"].DefaultCellStyle.BackColor = Color.YellowGreen;
                dataGridViewProdEst.Columns["Estoque S"].DefaultCellStyle.BackColor = Color.YellowGreen;
                dataGridViewProdEst.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewProdEst.Columns["Descrição"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewProdEst.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dataGridViewProdEst.Columns["Descrição"].Width = 300;

            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

            DataRow remove = null;
            foreach (DataRow dr in table.Rows)
            {
                if ((int)dr[0] == Convert.ToInt32(dataGridViewProdEst.CurrentRow.Cells[0].Value))
                {
                    remove = dr;
                }
            }
            if (remove !=null)
                remove.Delete();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadProduto>().Count() == 0)
            {
                CadProduto CadProd = new CadProduto(true);
                CadProd.ShowDialog();
                preencheTabela(CadProd.produtoInserido);
            }


        }

        private void dataGridViewProdEst_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Apenas valores numéricos nos campos Preço de Custo e Quantidade ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja confirmar a entrada da lista de produtos  ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {

                if (valida())
                {
                    List<Entrada> prodsEntrada = new List<Entrada>();
                    List<Estoque> estoques = new List<Estoque>();

                    DataGridViewRow linha = null;

                    for (int j = 0; j < dataGridViewProdEst.RowCount; j++)
                    {
                        linha = dataGridViewProdEst.Rows[j];
                        Entrada entrada = new Entrada();


                        if (!DBNull.Value.Equals(linha.Cells["Id"].Value))
                        {
                            entrada.id_produto = Convert.ToInt32(linha.Cells["Id"].Value);
                        }

                        if (!DBNull.Value.Equals(linha.Cells["Quantidade"].Value))
                        {
                            entrada.qtde = Convert.ToInt32(linha.Cells["Quantidade"].Value);
                        }
                        else
                        {
                            entrada.qtde = 0;
                        }
                        if (!DBNull.Value.Equals(linha.Cells["Preço de Custo"].Value))
                        {
                            entrada.valor_compra = Convert.ToDecimal(linha.Cells["Preço de Custo"].Value);
                        }
                        else
                        {
                            entrada.valor_compra = 0;
                        }
                        if (!DBNull.Value.Equals(linha.Cells["\"C\" ou \"S\""].Value))
                        {
                            entrada.C_ou_S = Convert.ToChar(Convert.ToString(linha.Cells["\"C\" ou \"S\""].Value).ToUpper()) ;
                        }
                        
                        entrada.ativo = true;
                        entrada.data = DateTime.Now.Date;
                        prodsEntrada.Add(entrada);


                        Estoque estoque = new Estoque();
                        estoque.id_produto = entrada.id_produto;
                        estoque.qtde_C = 0;
                        estoque.qtde_S = 0;
                        if (entrada.C_ou_S == 'S')
                            estoque.qtde_S = entrada.qtde;
                        if (entrada.C_ou_S == 'C')
                            estoque.qtde_C = entrada.qtde;
                       
                        estoques.Add(estoque);
                    }

                    //grava produtos listados na tabela entrada, com a respectiva quantidade e preco de custo
                    bool a = EntradaDataAcess.Inserir(prodsEntrada);
                    //adiciona a quantidade no estoque
                    bool b = EstoqueDataAcess.GravaEstoque(estoques);
                    if (a && b)
                    {
                        MessageBox.Show("Entrada de produtos realizada com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Erro ao cadastrar Produtos no estoque ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    table.Clear();

                }

            }

        }

        private bool valida()
        {
            bool controle = true;
            foreach (DataGridViewRow row in this.dataGridViewProdEst.Rows)
            {
                if (Convert.ToInt32(row.Cells["Quantidade"].Value) <= 0)
                {
                    MessageBox.Show("A quantidade do Produto não pode ser \"0\" !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProdEst.CurrentCell = row.Cells["Quantidade"];
                    controle = false;
                }

                if (Convert.ToDouble(row.Cells["Preço de Custo"].Value) <= 0.01)
                {
                    MessageBox.Show("O valor do Produto não pode ser \" R$ 0,00\" !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProdEst.CurrentCell = row.Cells["Preço de Custo"];
                    controle = false;
                }

                if(!DBNull.Value.Equals(row.Cells["\"C\" ou \"S\""].Value))
                {
                    if (!Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('S') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('s') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('C') && !Convert.ToChar(row.Cells["\"C\" ou \"S\""].Value).Equals('c'))
                    {
                        MessageBox.Show("Preencha o camo C ou S apenas com as letras C ou S !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridViewProdEst.CurrentCell = row.Cells["\"C\" ou \"S\""];
                        controle = false;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o camo C ou S apenas com as letras C ou S !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProdEst.CurrentCell = row.Cells["\"C\" ou \"S\""];
                    controle = false;
                }

                
               

                }
            return controle;
        }
    }
}

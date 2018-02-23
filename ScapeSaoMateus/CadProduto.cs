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
    public partial class CadProduto : Form
    {
        public enum especie
        {
            NORMAL=1,
            PADRÃO=0
        };

        private int IdProduto = 0;
        public Produto produtoInserido = new Produto();
        //habilita ou desabilita o botao de transferencia de produto para tela entradaestoque
        //public bool controle = false;
       
        public CadProduto(bool controle)
        {
            InitializeComponent();

            carregaCombos();
            comboBoxEsp.DataSource = Enum.GetValues(typeof(especie));
            //maskedTextBox1.Text = maskedTextBox1.Text + maskedTextBox1.ToString("#,##0.00");
            AplicarEventos(tbox_valor);
            tbox_valor.Text = "0";
            //groupBox2.Enabled = false;
            comboBoxEsp.Visible = false;

            btn_adicionar.Enabled = false;
            comboBox2.Enabled = false;
            btn_transferir.Visible = false;
            tbox_qtdeAlerta.Text = "1";
            if(controle)
            {
                groupBox3.Visible = false;
                btn_novo.Visible = false;
                btn_transferir.Visible = true;
                btn_transferir.Enabled = false;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox2.DataSource = ModeloDataAcess.buscaModelos(Convert.ToInt32(comboBox1.SelectedValue));
            comboBox2.DisplayMember = "nome";
            comboBox2.ValueMember = "id";
            btn_adicionar.Enabled = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                gravaAltera();
            }else
                MessageBox.Show("Você deve Adicionar pelo menos um Modelo de veículo para o produto, caso o produto seja utilizável em todos os modelos, selecione a marca (Universal) ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void RetornarMascara(object sender, EventArgs e)
        {
            if (tbox_valor.TextLength == 0)
            {
                MessageBox.Show("Digite um valor válido, ou 0 para produtos sem preço definido ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_valor.Focus();
            }
            else
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("N2");
            }
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gravaAltera();

            if (dataGridView1.RowCount == 0)
            {
                ProdutoModelo prodModel = new ProdutoModelo();
                prodModel.id_produto = IdProduto;
                prodModel.id_modelo = Convert.ToInt32(comboBox2.SelectedValue);
                ProdutoModeloDataAcess.Inserir(prodModel);
                preencheGridModelos(IdProduto);
            } else
            {
                MessageBox.Show("O produto só pode pertencer a um Modelo, você deve remover o modelo selecionado para inserir novo modelo ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void preencheGridModelos(int CodProduto)
        {
            List<MarcaModelo> marcaModelos = ModeloDataAcess.buscaModelosPorProd(CodProduto);
            // Criando um Datatable
            DataTable table = new DataTable();


            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            table.Columns.Add(colunaId);

            DataColumn colunaModel = new DataColumn();
            colunaModel.DataType = System.Type.GetType("System.String");
            colunaModel.ColumnName = "Modelo";
            table.Columns.Add(colunaModel);

            DataColumn colunaMarca = new DataColumn();
            colunaMarca.DataType = System.Type.GetType("System.String");
            colunaMarca.ColumnName = "Marca";
            table.Columns.Add(colunaMarca);

            // DataRow é o objeto para linha no Datatable
            DataRow row;
            // Iniciamos um For para Adicionar  itens no DataTable

            for (int i = 0; i < marcaModelos.Count; i++)
            {
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = marcaModelos[i].id;
                row["Modelo"] = marcaModelos[i].nome; // Iniciamos a inserção na coluna “Item” como Iema + contador.
                row["Marca"] = marcaModelos[i].marca;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            // Create a DataView using the DataTable.
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            // Set a DataGrid control’s DataSource to the DataView.
            dataGridView1.DataSource = view; // O DataGridView recebe o View carregado.
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {

                List<int> mods = new List<int>();

                for (int i = 0; i < selectedCellCount; i++)
                {
                    int linha = dataGridView1.SelectedCells[i].RowIndex;
                    mods.Add((int)(dataGridView1.Rows[linha].Cells[0].Value));
                }


                if (!ProdutoModeloDataAcess.Excluir(mods))
                {
                    MessageBox.Show("Erro ao Excluir Modelo ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Modelo Excluído com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //preencheGrid(Convert.ToInt32(comboBox1.SelectedValue));
                    preencheGridModelos(IdProduto);
                }


            }
        }

        private void carregaCombos()
        {
            comboBox1.DataSource = MarcaDataAcess.buscarMarcas();
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id";

            comboBoxTpProd.DataSource = TipoProdutoDataAcess.buscaTipoProdutos();
            comboBoxTpProd.DisplayMember = "nome";
            comboBoxTpProd.ValueMember = "id";

            comboBox_Prod.DataSource = ProdutoDataAcess.BuscarProdCombo();
            comboBox_Prod.DisplayMember = "descricao";
            comboBox_Prod.ValueMember = "id"; 
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = ProdutoDataAcess.BuscaProduto(Convert.ToInt32(comboBox_Prod.SelectedValue));

            
            tbox_codigo.Text = produto.codigo;
            tbox_descricao.Text = produto.descricao;
            tbox_valor.Text = Convert.ToString(produto.valor);
            tbox_marca_prod.Text = produto.marca;
            tbox_modelo.Text = produto.modelo;
            tbox_qtdeAlerta.Text = Convert.ToString(produto.qtde_alerta);
            comboBoxTpProd.SelectedValue = produto.id_tipo_produto;
            if (produto.especie == "NORMAL")
                comboBoxEsp.SelectedIndex = 1;
            else
                comboBoxEsp.SelectedIndex = 0;

            IdProduto = produto.id;
            groupBox2.Enabled = true;
            preencheGridModelos(IdProduto);
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            IdProduto = 0;
            tbox_codigo.Text = "";
            tbox_descricao.Text = "";
            tbox_valor.Text = "0";
            tbox_marca_prod.Text = "";
            tbox_modelo.Text = "";
            comboBoxEsp.SelectedIndex = 1;
            tbox_qtdeAlerta.Text = "1";
            btn_adicionar.Enabled = false;
            dataGridView1.DataSource = null; //Remover a datasource
            dataGridView1.Columns.Clear(); //Remover as colunas
            dataGridView1.Rows.Clear();    //Remover as linhas
            dataGridView1.Refresh();    //Para a grid se actualizar
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbox_qtdeAlerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void gravaAltera()
        {
            Produto produto = new Produto();

            produto.codigo = tbox_codigo.Text.ToUpper();
            produto.descricao = tbox_descricao.Text.ToUpper();
            produto.valor = Convert.ToDecimal(tbox_valor.Text);
            produto.marca = tbox_marca_prod.Text.ToUpper();
            produto.modelo = tbox_modelo.Text.ToUpper();
            produto.id_tipo_produto = Convert.ToInt32(comboBoxTpProd.SelectedValue);
            produto.especie = Convert.ToString(comboBoxEsp.SelectedValue);
            produto.cod_equi = " ";

            if (tbox_qtdeAlerta.TextLength > 0)
            {
                produto.qtde_alerta = Convert.ToInt32(tbox_qtdeAlerta.Text);
            }
            else
                produto.qtde_alerta = 0;


            if (IdProduto == 0)
            {
                //verifica o retorno - caso retorne um ID diferente de 0, o produto foi gravado com sucesso.
                IdProduto = ProdutoDataAcess.Inserir(produto);

                if (IdProduto == 0)
                {
                    MessageBox.Show("Erro ao cadastrar Produto ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro Inserido com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                }
            }
            else
            {
                produto.id = IdProduto;
                if (!ProdutoDataAcess.Alterar(produto))
                {
                    MessageBox.Show("Erro ao alterar Produto ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro alterado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //variavel obj public pois preenche a tela entrada estoque, estoqueentrada.cs puxa ela aqui.
            produtoInserido = produto;
            btn_transferir.Enabled = true;
            carregaCombos();
        }
    }
}

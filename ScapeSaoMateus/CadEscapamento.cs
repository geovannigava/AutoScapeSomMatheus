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
    public partial class CadEscapamento : Form
    {
        DataGridViewComboBoxColumn cmb_tipoProd = new DataGridViewComboBoxColumn();
        DataRow row;
        DataTable table = new DataTable();
        DataGridViewComboBoxCell teste = new DataGridViewComboBoxCell();

        public CadEscapamento()
        {
            InitializeComponent();
            //preencheGrid();
            
            comboBoxMarca.DataSource = MarcaDataAcess.buscarMarcas();
            comboBoxMarca.DisplayMember = "nome";
            comboBoxMarca.ValueMember = "id";

            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            table.Columns.Add(colunaId);

            DataColumn colunaModel = new DataColumn();
            colunaModel.DataType = System.Type.GetType("System.String");
            colunaModel.ColumnName = "Código";
            table.Columns.Add(colunaModel);

            DataColumn colunaCodequi = new DataColumn();
            colunaCodequi.DataType = System.Type.GetType("System.String");
            colunaCodequi.ColumnName = "Cod. Equi.";
            table.Columns.Add(colunaCodequi);

            DataColumn colunaMarca = new DataColumn();
            colunaMarca.DataType = System.Type.GetType("System.String");
            colunaMarca.ColumnName = "Marca/Catálogo";
            table.Columns.Add(colunaMarca);

            DataColumn colunaDesc = new DataColumn();
            colunaDesc.DataType = System.Type.GetType("System.String");
            colunaDesc.ColumnName = "Descrição";
            table.Columns.Add(colunaDesc);

            DataColumn colunaValor = new DataColumn();
            colunaValor.DataType = System.Type.GetType("System.Decimal");
            colunaValor.ColumnName = "Valor";
            table.Columns.Add(colunaValor);

            DataColumn colunaQtde = new DataColumn();
            colunaQtde.DataType = System.Type.GetType("System.Int32");
            colunaQtde.ColumnName = "Qtde Mínima";
            table.Columns.Add(colunaQtde);

            cmb_tipoProd.Name = "Tipo de Produto";
            cmb_tipoProd.DataPropertyName = "Tipo de Produto";   // The DataTable column name.
            cmb_tipoProd.HeaderText = "Tipo de Produto";
            cmb_tipoProd.DataSource = TipoProdutoDataAcess.buscaTipoProdutos();
            //cmb_tipoProd.DisplayMember = "nome";
            //cmb_tipoProd.ValueMember = "id";

            //List<TipoProduto> tipos = TipoProdutoDataAcess.tipoProdutoPorModel(Convert.ToInt32(comboBoxModelo.SelectedValue));

            //if (!dataGridViewProd.Columns.Contains(cmb_tipoProd))
           // {
            
            //}

            // Create a DataView using the DataTable.
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido

            dataGridViewProd.DataSource = view;

            
            dataGridViewProd.Columns["Valor"].DefaultCellStyle.Format = "N2";
            dataGridViewProd.Columns["Qtde Mínima"].DefaultCellStyle.Format = "N";

            //dataGridViewProd.Columns["Descrição"].Width = 270;
            

            //row = table.NewRow(); // Adicionamos uma linha do DataTable

            //table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            //dataGridViewProd.Columns.Add(cmb_tipoProd);
            dataGridViewProd.Columns[0].Visible = false;
        }
        private void preencheGrid()
        {

            table.Clear();
            List<Produto> ProdporModelos = ProdutoDataAcess.buscaProdporModel(Convert.ToInt32(comboBoxModelo.SelectedValue));
            // Iniciamos um For para Adicionar  itens no DataTable
            for (int i = 0; i < ProdporModelos.Count; i++)
            {
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = ProdporModelos[i].id;
                row["Código"] = ProdporModelos[i].codigo; 
                row["Cod. Equi."] = ProdporModelos[i].cod_equi; 
                row["Marca/Catálogo"] = ProdporModelos[i].marca;
                row["Descrição"] = ProdporModelos[i].descricao;
                row["Valor"] = ProdporModelos[i].valor; 
                row["Qtde Mínima"] = ProdporModelos[i].qtde_alerta;

                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            if (!dataGridViewProd.Columns.Contains(cmb_tipoProd))
            {
                
                dataGridViewProd.Columns.Add(cmb_tipoProd);
            }

            int contador = 0;
            foreach (DataGridViewRow row2 in dataGridViewProd.Rows)
            {
                DataGridViewComboBoxCell ContactCombo = new DataGridViewComboBoxCell();
                ContactCombo = (DataGridViewComboBoxCell)(row2.Cells[7]);
                ContactCombo.DataSource = TipoProdutoDataAcess.buscaTipoProdutos();
                ContactCombo.DisplayMember = "nome";
                ContactCombo.ValueMember = "id";
                if(contador < ProdporModelos.Count)
                ContactCombo.Value = ProdporModelos[contador].id_tipo_produto;
                contador++;
            }
            //parei aqui 
            dataGridViewProd.Columns["Cod. Equi."].Width = 70;
            dataGridViewProd.Columns["Código"].Width = 70;
            dataGridViewProd.Columns["Marca/Catálogo"].Width = 85;
            dataGridViewProd.Columns["Valor"].Width = 80;
            dataGridViewProd.Columns["Qtde Mínima"].Width = 70;
            dataGridViewProd.Columns["Descrição"].Width = 300; 
            dataGridViewProd.Columns["Tipo de Produto"].Width = 120;
        }

        private void comboBoxMarca_Leave(object sender, EventArgs e)
        {
            comboBoxModelo.Enabled = true;
            comboBoxModelo.DataSource = ModeloDataAcess.buscaModelos(Convert.ToInt32(comboBoxMarca.SelectedValue));
            comboBoxModelo.DisplayMember = "nome";
            comboBoxModelo.ValueMember = "id";
        }

        private void dataGridViewProd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Digite corretamente o Valor ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                List<Produto> prodsInserir = new List<Produto>();
                List<Produto> prodsAlterar = new List<Produto>();
                bool controle = false;

                //DataGridViewRow linha = null;
                foreach (DataGridViewRow row in this.dataGridViewProd.Rows)
                {

                    Produto prod = new Produto();


                    if (!DBNull.Value.Equals(row.Cells["Id"].Value))
                    {
                        prod.id = Convert.ToInt32(row.Cells["Id"].Value);
                    }
                    else
                        prod.id = 0;

                    if (!DBNull.Value.Equals(row.Cells["Código"].Value))
                    {
                        prod.codigo = Convert.ToString(row.Cells["Código"].Value).ToUpper();
                    }
                    else
                        prod.codigo = "";
                    if (!DBNull.Value.Equals(row.Cells["Cod. Equi."].Value))
                    {
                        prod.cod_equi = Convert.ToString(row.Cells["Cod. Equi."].Value).ToUpper();
                    }
                    else
                        prod.cod_equi = "";
                    if (!DBNull.Value.Equals(row.Cells["Marca/Catálogo"].Value))
                    {
                        prod.marca=  Convert.ToString(row.Cells["Marca/Catálogo"].Value).ToUpper();
                    }
                    else
                        prod.marca = "";

                    if (!DBNull.Value.Equals(row.Cells["Descrição"].Value))
                    {
                        prod.descricao = Convert.ToString(row.Cells["Descrição"].Value).ToUpper();
                    }
                    else
                        prod.descricao = "";

                    if (!DBNull.Value.Equals(row.Cells["Valor"].Value))
                    {
                        prod.valor = Convert.ToDecimal(row.Cells["Valor"].Value);
                    }
                    else
                        prod.valor = 0;
                    if (!DBNull.Value.Equals(row.Cells["Qtde Mínima"].Value))
                    {
                        prod.qtde_alerta = Convert.ToInt32(row.Cells["Qtde Mínima"].Value);
                    }
                    else
                        prod.qtde_alerta = 0;


                    if (row.Index != this.dataGridViewProd.NewRowIndex)
                    {
                        DataGridViewComboBoxCell cell = row.Cells[7] as DataGridViewComboBoxCell;
                        prod.id_tipo_produto = Convert.ToInt32(cell.Value);

                    }

                    prod.modelo = " ";
                    prod.especie = "NORMAL";

                    if (prod.id == 0)
                    {
                        prodsInserir.Add(prod);
                    }
                    else
                    {
                        controle = ProdutoDataAcess.Alterar(prod);
                    }

                }

                List<int> idProds = ProdutoDataAcess.InserirProds(prodsInserir);
                foreach (int prod in idProds)
                {
                    ProdutoModelo prodModel = new ProdutoModelo();
                    prodModel.id_modelo = Convert.ToInt32(comboBoxModelo.SelectedValue);
                    prodModel.id_produto = prod;
                    ProdutoModeloDataAcess.Inserir(prodModel);
                }
                if (controle || idProds.Any())
                {
                    MessageBox.Show("Registro Inserido/Alterado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro ao cadastrar Produto ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxModelo_Leave(object sender, EventArgs e)
        {
            preencheGrid();
            btn_novo.Enabled = true;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            row = table.NewRow();
            table.Rows.Add(row);
            foreach (DataGridViewRow row2 in dataGridViewProd.Rows)
            {
                DataGridViewComboBoxCell ContactCombo = new DataGridViewComboBoxCell();
                ContactCombo = (DataGridViewComboBoxCell)(row2.Cells[7]);
                ContactCombo.DataSource = TipoProdutoDataAcess.buscaTipoProdutos();
                ContactCombo.DisplayMember = "nome";
                ContactCombo.ValueMember = "id";

            }
        }

        private void dataGridViewProd_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Preencha um Valor válido ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridViewProd_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {   
            if (e.ColumnIndex == 6 && string.IsNullOrEmpty((string)e.FormattedValue))
            {
                e.Cancel = true;
                MessageBox.Show("Escolha o Tipo de Produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool valida()
        {
            bool controle = true;
            foreach (DataGridViewRow row in this.dataGridViewProd.Rows)
            {
                if (String.IsNullOrEmpty(row.Cells["Código"].Value.ToString()))
                {
                    MessageBox.Show("Digite o código !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProd.CurrentCell = row.Cells["Código"];
                    controle = false;
                }
                else if(String.IsNullOrEmpty(row.Cells["Marca/Catálogo"].Value.ToString()))
                {
                    MessageBox.Show("Digite a Marca/Catálogo !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProd.CurrentCell = row.Cells["Marca/Catálogo"];
                    controle = false;
                }
                else if (String.IsNullOrEmpty(row.Cells["Descrição"].Value.ToString()))
                {
                    MessageBox.Show("Digite a Descrição do Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProd.CurrentCell = row.Cells["Descrição"];
                    controle = false;
                }
                else if (String.IsNullOrEmpty(row.Cells["Valor"].Value.ToString()))
                {
                    MessageBox.Show("Digite o Valor de Produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProd.CurrentCell = row.Cells["Valor"];
                    controle = false;
                }
                else if (row.Cells["Tipo de Produto"].Value == null)
                {
                    MessageBox.Show("Selecione o tipo de produto !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewProd.CurrentCell = row.Cells["Tipo de Produto"];
                    controle = false;
                }
                            
                        
                }
            return controle;
        }

    }
}

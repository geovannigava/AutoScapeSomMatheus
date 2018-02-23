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
    public partial class SelecionaProduto : Form
    {
        public ProdModelo prodSelecionado = new ProdModelo();
        List<ProdModelo> ProdporModelos = new List<ProdModelo>();
        public SelecionaProduto()
        {
            InitializeComponent();
        }

        private void btn_PesqporNome_Click(object sender, EventArgs e)
        {
            preencheGrid(2);
        }

        // o parametro cod esta relacionado com tipo de busca, ou seja, por nome, codigo, marca/modelo
        // 1 - busca por codigo / 2 - busca por nome / 3 - busca por marca/modelo
        private void preencheGrid(int cod)
        {
            // Criando um Datatable
            DataTable table = new DataTable();

            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            table.Columns.Add(colunaId);

            DataColumn colunaCod = new DataColumn();
            colunaCod.DataType = System.Type.GetType("System.String");
            colunaCod.ColumnName = "Código";
            table.Columns.Add(colunaCod);

            DataColumn colunaDesc = new DataColumn();
            colunaDesc.DataType = System.Type.GetType("System.String");
            colunaDesc.ColumnName = "Descrição";
            table.Columns.Add(colunaDesc);

            DataColumn colunaMarca = new DataColumn();
            colunaMarca.DataType = System.Type.GetType("System.String");
            colunaMarca.ColumnName = "Marca - Catálogo";
            table.Columns.Add(colunaMarca);


            DataColumn colunaValor = new DataColumn();
            colunaValor.DataType = System.Type.GetType("System.Decimal");
            colunaValor.ColumnName = "Valor";
            table.Columns.Add(colunaValor);

            DataColumn colunaMod = new DataColumn();
            colunaMod.DataType = System.Type.GetType("System.String");
            colunaMod.ColumnName = "Modelo Veículo";
            table.Columns.Add(colunaMod);

            DataColumn colunaEst = new DataColumn();
            colunaEst.DataType = System.Type.GetType("System.Int32");
            colunaEst.ColumnName = "Qtde Estoque";
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

            // DataRow é o objeto para linha no Datatable
            DataRow row;

            if (cod == 1)
            {
                ProdporModelos = ProdutoDataAcess.BuscaProdporCodigo(tbox_codigo.Text);
            }
            if (cod == 2)
            {
                ProdporModelos = ProdutoDataAcess.BuscaProdporNome(tbox_nome.Text);
            }
            // Iniciamos um For para Adicionar  itens no DataTable
            for (int i = 0; i < ProdporModelos.Count; i++)
            {
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = ProdporModelos[i].id;
                row["Código"] = ProdporModelos[i].codigo;
                row["Descrição"] = ProdporModelos[i].descricao;
                row["Marca - Catálogo"] = ProdporModelos[i].marca;
                //row["Espécie"] = ProdporModelos[i].especie;
                row["Valor"] = ProdporModelos[i].valor;
                row["Modelo Veículo"] = ProdporModelos[i].NomeModelo;
                row["Qtde Estoque"] = EstoqueDataAcess.ConsultaEstoque(ProdporModelos[i].id).qtde;
                row["Estoque C"] = EstoqueDataAcess.ConsultaEstoque(ProdporModelos[i].id).qtde_C;
                row["Estoque S"] = EstoqueDataAcess.ConsultaEstoque(ProdporModelos[i].id).qtde_S;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }

            // Create a DataView using the DataTable.
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            dataGridViewSelProd.DataSource = view;
            dataGridViewSelProd.Columns[0].Visible = false;
            dataGridViewSelProd.Columns["Valor"].DefaultCellStyle.Format = "N2";
            dataGridViewSelProd.Columns["Qtde Estoque"].DefaultCellStyle.BackColor = Color.Green;
            dataGridViewSelProd.Columns["Estoque C"].DefaultCellStyle.BackColor = Color.YellowGreen;
            dataGridViewSelProd.Columns["Estoque S"].DefaultCellStyle.BackColor = Color.YellowGreen;
            dataGridViewSelProd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSelProd.MultiSelect = false;
            dataGridViewSelProd.Columns["Modelo Veículo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSelProd.Columns["Descrição"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSelProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewSelProd.Columns["Descrição"].Width = 300;
            dataGridViewSelProd.Columns["Valor"].Width = 70; 
            dataGridViewSelProd.Columns["Modelo Veículo"].Width = 120;
        }

        private void btn_PesqporCod_Click(object sender, EventArgs e)
        {
            preencheGrid(1);
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {

            if (dataGridViewSelProd.RowCount == 0)
            {
                MessageBox.Show("Selecione um produto !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow linha = null;

                for (int j = 0; j < dataGridViewSelProd.RowCount; j++)
                {
                    linha = dataGridViewSelProd.Rows[j];
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[0].Value))
                        prodSelecionado.id = Convert.ToInt32(dataGridViewSelProd.CurrentRow.Cells[0].Value);
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[1].Value))
                        prodSelecionado.codigo = Convert.ToString(dataGridViewSelProd.CurrentRow.Cells[1].Value);
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[2].Value))
                        prodSelecionado.descricao = Convert.ToString(dataGridViewSelProd.CurrentRow.Cells[2].Value);
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[3].Value))
                        prodSelecionado.marca = Convert.ToString(dataGridViewSelProd.CurrentRow.Cells[3].Value);
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[4].Value))
                        prodSelecionado.valor = Convert.ToDecimal(dataGridViewSelProd.CurrentRow.Cells[4].Value);
                    if (!DBNull.Value.Equals(dataGridViewSelProd.CurrentRow.Cells[5].Value))
                        prodSelecionado.NomeModelo = Convert.ToString(dataGridViewSelProd.CurrentRow.Cells[5].Value);
                }
                this.Close();
            }
        }
    }
}

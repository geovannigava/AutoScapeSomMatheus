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
    public partial class CadCarroModelo : Form
    {
        public CadCarroModelo()
        {
            InitializeComponent();
            //dataGridView1.DataSource = ModeloDataAcess.buscaModelos(1);
            //dataGridView1.Columns["marca"].Visible = false;
            //dataGridView1.Columns["Marca1"].Visible = false;

            //DataTable teste = new DataTable();
            //teste = ModeloDataAcess.buscaModelos(1);
            comboBox1.DataSource = MarcaDataAcess.buscarMarcas();
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id";
        }

        public void preencheGrid(int id)
        {
            //buscando os dados no banco
            List<Modelo> modelos = new List<Modelo>();
            modelos = ModeloDataAcess.buscaModelos(id);

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

            // DataRow é o objeto para linha no Datatable
            DataRow row;
            // Iniciamos um For para Adicionar  itens no DataTable

            for (int i = 0; i < modelos.Count; i++)
            {
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = modelos[i].id;
                row["Modelo"] = modelos[i].nome; // Iniciamos a inserção na coluna “Item” como Iema + contador.
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            // Create a DataView using the DataTable.
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            // Set a DataGrid control’s DataSource to the DataView.
            dataGridView1.DataSource = view; // O DataGridView recebe o View carregado.
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Modelo mod = new Modelo();
            mod.nome = tbox_nome.Text.ToUpper();
            mod.marca = Convert.ToInt32(comboBox1.SelectedValue);

            if (tbox_nome.TextLength >0)
            {
                if (!ModeloDataAcess.Inserir(mod))
                {
                    MessageBox.Show("Erro ao adicionar Modelo ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Modelo adcionado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencheGrid(Convert.ToInt32(comboBox1.SelectedValue));
                    tbox_nome.Text = "";
                    tbox_nome.Focus();
                }
            }
            else
            {
                MessageBox.Show("Preencha o Nome do Modelo ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_nome.Focus();
            }

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            preencheGrid(Convert.ToInt32(comboBox1.SelectedValue));
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


                if (!ModeloDataAcess.Excluir(mods))
                {
                    MessageBox.Show("Erro ao Excluir Modelo ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Modelo Excluído com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencheGrid(Convert.ToInt32(comboBox1.SelectedValue));
                }


            }
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            preencheGrid(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}

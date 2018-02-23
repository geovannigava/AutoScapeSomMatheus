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
    public partial class SelecionaCliente : Form
    {
        public Cliente clienteSelecionado = new Cliente();
        List<Cliente> clientes = new List<Cliente>();

        public SelecionaCliente()
        {
            InitializeComponent();
        }

        private void preencheGrid()
        {
            // Criando um Datatable
            DataTable table = new DataTable();

            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            table.Columns.Add(colunaId);

            DataColumn colunaNome= new DataColumn();
            colunaNome.DataType = System.Type.GetType("System.String");
            colunaNome.ColumnName = "Nome";
            table.Columns.Add(colunaNome);

            DataColumn colunaTel = new DataColumn();
            colunaTel.DataType = System.Type.GetType("System.String");
            colunaTel.ColumnName = "Telefone";
            table.Columns.Add(colunaTel);

            DataRow row;

            clientes = ClienteDataAcess.buscarClientesporNome(tbox_nome.Text);

            for (int i = 0; i < clientes.Count; i++)
            {
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = clientes[i].id;
                row["Nome"] = clientes[i].nome;
                row["Telefone"] = clientes[i].celular;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            // Create a DataView using the DataTable.
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            dataGridViewClientes.DataSource = view;
            dataGridViewClientes.Columns[0].Visible = false;
            dataGridViewClientes.MultiSelect = false;

        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {

            if(dataGridViewClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione um Cliente !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow linha = null;
                for (int j = 0; j < dataGridViewClientes.RowCount; j++)
                {
                    linha = dataGridViewClientes.Rows[j];
                    if (!DBNull.Value.Equals(dataGridViewClientes.CurrentRow.Cells[0].Value))
                        clienteSelecionado = ClienteDataAcess.buscarCliente(Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells[0].Value));
                    //Console.WriteLine(clienteSelecionado.Endereco.cep);
                }
                this.Close();
            }

        }
    }
}

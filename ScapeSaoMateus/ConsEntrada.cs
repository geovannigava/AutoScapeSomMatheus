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
    public partial class ConsEntrada : Form
    {
        DateTime dataInicial = new DateTime();
        DateTime dataFinal = new DateTime();
        DataTable table = new DataTable();
        
        public ConsEntrada()
        {

            InitializeComponent();

            //table vendas
            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Número da Entrada";
            colunaId.ReadOnly = true;
            table.Columns.Add(colunaId);

            DataColumn colunaData = new DataColumn();
            colunaData.DataType = System.Type.GetType("System.DateTime");
            colunaData.ColumnName = "Data da Entrada";
            colunaData.ReadOnly = true;
            table.Columns.Add(colunaData);

            DataColumn colunaProd = new DataColumn();
            colunaProd.DataType = System.Type.GetType("System.String");
            colunaProd.ColumnName = "Produto";
            colunaProd.ReadOnly = true;
            table.Columns.Add(colunaProd);

            DataColumn colunaValor = new DataColumn();
            colunaValor.DataType = System.Type.GetType("System.Decimal");
            colunaValor.ColumnName = "Preço de Custo";
            colunaValor.ReadOnly = true;
            table.Columns.Add(colunaValor);

            DataColumn colunaVlr = new DataColumn();
            colunaVlr.DataType = System.Type.GetType("System.Int32");
            colunaVlr.ColumnName = "Quantidade";
            colunaVlr.ReadOnly = true;
            table.Columns.Add(colunaVlr);

            DataColumn colunaAtv = new DataColumn();
            colunaAtv.DataType = System.Type.GetType("System.Boolean");
            colunaAtv.ColumnName = "Entrada Ativa ?";
            colunaAtv.ReadOnly = true;
            table.Columns.Add(colunaAtv);

            DataColumn colunaCouS = new DataColumn();
            colunaCouS.DataType = System.Type.GetType("System.Char");
            colunaCouS.ColumnName = "C ou S";
            colunaCouS.ReadOnly = true;
            table.Columns.Add(colunaCouS);

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
                preencheGrid(EntradaDataAcess.ConsultaEnt(dataInicial.Date, dataFinal.Date));
            }

        }

        private void preencheGrid(List<Entrada> entradas)
        {
            
            table.Clear();
            for (int x = 0; x < entradas.Count; x++)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;

                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Número da Entrada"] = entradas[x].id;
                row["Data da Entrada"] = entradas[x].data;
                if (entradas[x].Produto != null)
                    row["Produto"] = entradas[x].Produto.descricao;
                row["Preço de Custo"] = entradas[x].valor_compra; 
                row["Quantidade"] = entradas[x].qtde;
                row["Entrada Ativa ?"] = entradas[x].ativo;
                row["C ou S"] = entradas[x].C_ou_S;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            dataGridViewEnt.DataSource = view;
            dataGridViewEnt.Columns["Preço de Custo"].DefaultCellStyle.Format = "N2";
            dataGridViewEnt.Columns["Entrada Ativa ?"].Visible = false;
            dataGridViewEnt.MultiSelect = false;
            dataGridViewEnt.Columns["Entrada Ativa ?"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //alinha conteudo
            dataGridViewEnt.Columns["Entrada Ativa ?"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // alinha titulo

            dataGridViewEnt.Columns["Produto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridViewEnt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewEnt.Columns["Produto"].Width = 350;
            dataGridViewEnt.Columns["Quantidade"].Width = 60;
            dataGridViewEnt.Columns["Número da Entrada"].Width = 70;
            dataGridViewEnt.Columns["Data da Entrada"].Width = 70;
            dataGridViewEnt.Columns["C ou S"].Width = 80;
            //dataGridViewSelProd.Columns["Modelo Veículo"].Width = 120;


            foreach (DataGridViewRow row in dataGridViewEnt.Rows)
            {
                if (!Convert.ToBoolean(row.Cells["Entrada Ativa ?"].Value))
                    row.DefaultCellStyle.BackColor = Color.Red;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToBoolean(dataGridViewEnt.CurrentRow.Cells["Entrada Ativa ?"].Value))
            {
                EntradaCancel EntCancel = new EntradaCancel();
                if (Application.OpenForms.OfType<MotivoCancel>().Count() == 0)
                {
                    MotivoCancel motCancel = new MotivoCancel();
                    motCancel.ShowDialog();
                    EntCancel.motivo = motCancel.motivo;
                    EntCancel.id_entrada = Convert.ToInt32(dataGridViewEnt.CurrentRow.Cells[0].Value);
                    EntCancel.data = DateTime.Now.Date;

                    // busca registro de entrada para diminuir no estoque
                    Entrada entrada = EntradaDataAcess.BuscaEntrada(Convert.ToInt32(dataGridViewEnt.CurrentRow.Cells[0].Value));


                    List<Estoque> estoque = new List<Estoque>();
                    Estoque est = new Estoque();
                    est.qtde_C = 0;
                    est.qtde_S = 0;
                    if (entrada.C_ou_S.Equals('S'))
                        est.qtde_S = entrada.qtde;
                    if (entrada.C_ou_S.Equals('C'))
                        est.qtde_C = entrada.qtde;
                    est.id_produto = entrada.id_produto;
                    estoque.Add(est);

                    //grava na tabela Entrada_Cancel
                    bool a = EntradaCancelDataAcess.Inserir(EntCancel);
                    //atualiza regristro na Entrada 
                    bool b = EntradaDataAcess.CancelaEntrada(Convert.ToInt32(dataGridViewEnt.CurrentRow.Cells[0].Value));
                    //diminui no estoque
                    bool c = EstoqueDataAcess.DiminuiEstoque(estoque);

                    if (a && b && c)
                    {
                        MessageBox.Show("Cancelamento realizado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        preencheGrid(EntradaDataAcess.ConsultaEnt(dataInicial.Date, dataFinal.Date));
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cancelar a Entrada ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Essa Entrada já foi Cancelada ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    
    
}

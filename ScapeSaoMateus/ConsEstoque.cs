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
    
    public partial class ConsEstoque : Form
    {
        DataTable table = new DataTable();
        public ConsEstoque()
        {
            InitializeComponent();
            carregaCombos();

            //table vendas
            DataColumn colunaId = new DataColumn();
            colunaId.DataType = System.Type.GetType("System.Int32");
            colunaId.ColumnName = "Id";
            table.Columns.Add(colunaId);

            DataColumn colunaCod = new DataColumn();
            colunaCod.DataType = System.Type.GetType("System.String");
            colunaCod.ColumnName = "Código";
            colunaCod.ReadOnly = true;
            table.Columns.Add(colunaCod);

            DataColumn colunaProd = new DataColumn();
            colunaProd.DataType = System.Type.GetType("System.String");
            colunaProd.ColumnName = "Produto";
            colunaProd.ReadOnly = true;
            table.Columns.Add(colunaProd);

            DataColumn colunaModV = new DataColumn();
            colunaModV.DataType = System.Type.GetType("System.String");
            colunaModV.ColumnName = "Modelo Veículo";
            colunaModV.ReadOnly = true;
            table.Columns.Add(colunaModV);

            DataColumn colunaEstC = new DataColumn();
            colunaEstC.DataType = System.Type.GetType("System.Int32");
            colunaEstC.ColumnName = "Quantidade C";
            colunaEstC.ReadOnly = true;
            table.Columns.Add(colunaEstC);

            DataColumn colunaEstS = new DataColumn();
            colunaEstS.DataType = System.Type.GetType("System.Int32");
            colunaEstS.ColumnName = "Quantidade S";
            colunaEstS.ReadOnly = true;
            table.Columns.Add(colunaEstS);

            DataColumn colunaTot = new DataColumn();
            colunaTot.DataType = System.Type.GetType("System.Int32");
            colunaTot.ColumnName = "Quantidade Total";
            colunaTot.ReadOnly = true;
            table.Columns.Add(colunaTot);

            DataColumn colunaUltComp = new DataColumn();
            colunaUltComp.DataType = System.Type.GetType("System.DateTime");
            colunaUltComp.ColumnName = "Última Entrada";
            colunaUltComp.ReadOnly = true;
            table.Columns.Add(colunaUltComp);


        }

        private void btn_estTotal_Click(object sender, EventArgs e)
        {
            preencheGrid(1);
        }

        private void preencheGrid(int tpConsulta)
        {
            List<ProdModelo> prods = new List<ProdModelo>();
            table.Clear();
            if (tpConsulta == 1)
            {
                 prods = EstoqueDataAcess.ConsultaEstTotal();
            }
            if (tpConsulta == 2)
            {
                prods = EstoqueDataAcess.ConsultaEstPorNome(tbox_NomeDesc.Text);
            }
            if (tpConsulta == 3)
            {
                prods = EstoqueDataAcess.ConsultaEstPorModel(Convert.ToInt32(cmb_modeloVeic.SelectedValue));
            }
            if (tpConsulta == 4)
            {
                prods = EstoqueDataAcess.ConsultaEstPorTpProd(Convert.ToInt32(cmb_tpProd.SelectedValue));
            }
            if (tpConsulta == 5)
            {
                prods = EstoqueDataAcess.ConsultaEstPorMarcaVeic(Convert.ToInt32(cmb_VeicMarca.SelectedValue));
            }

            for (int x = 0; x < prods.Count; x++)
            {
                // DataRow é o objeto para linha no Datatable
                DataRow row;
                row = table.NewRow(); // Adicionamos uma linha do DataTable
                row["Id"] = prods[x].id;
                row["Código"] = prods[x].codigo;
                row["Produto"] = prods[x].descricao;
                row["Modelo Veículo"] = prods[x].NomeModelo;
                row["Quantidade C"] = prods[x].QtdeEstoqueC;
                row["Quantidade S"] = prods[x].QtdeEstoqueS;
                row["Quantidade Total"] = prods[x].QtdeEstoque; ;
                if (prods[x].DataUltComp != null)
                    row["Última Entrada"] = prods[x].DataUltComp;
                table.Rows.Add(row); // No final adicionamos a linha no Datatable.
            }
            DataView view = new DataView(table); // O View recebe o Datatable Preenchido
            dataGridViewEstoque.DataSource = view;
            dataGridViewEstoque.Columns["Id"].Visible = false;
            dataGridViewEstoque.MultiSelect = false;

            dataGridViewEstoque.Columns["Produto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewEstoque.Columns["Modelo Veículo"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEstoque.Columns["Produto"].Width = 270;
            dataGridViewEstoque.Columns["Modelo Veículo"].Width = 200;
            dataGridViewEstoque.Columns["Código"].Width = 60;
            dataGridViewEstoque.Columns["Quantidade Total"].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridViewEstoque.Columns["Quantidade C"].DefaultCellStyle.BackColor = Color.YellowGreen;
            dataGridViewEstoque.Columns["Quantidade S"].DefaultCellStyle.BackColor = Color.YellowGreen;

        }

        private void btn_consNome_Click(object sender, EventArgs e)
        {
            preencheGrid(2);
        }

        private void carregaCombos()
        {
            cmb_marcaVeic.DataSource = MarcaDataAcess.buscarMarcas();
            cmb_marcaVeic.DisplayMember = "nome";
            cmb_marcaVeic.ValueMember = "id";

            cmb_tpProd.DataSource = TipoProdutoDataAcess.buscaTipoProdutos();
            cmb_tpProd.DisplayMember = "nome";
            cmb_tpProd.ValueMember = "id";

            cmb_VeicMarca.DataSource = MarcaDataAcess.buscarMarcas();
            cmb_VeicMarca.DisplayMember = "nome";
            cmb_VeicMarca.ValueMember = "id";

        }

        private void cmb_marcaVeic_Leave(object sender, EventArgs e)
        {
            cmb_modeloVeic.Enabled = true;
            cmb_modeloVeic.DataSource = ModeloDataAcess.buscaModelos(Convert.ToInt32(cmb_marcaVeic.SelectedValue));
            cmb_modeloVeic.DisplayMember = "nome";
            cmb_modeloVeic.ValueMember = "id";
            btn_consMarcModel.Enabled = true;
        }

        private void btn_consMarcModel_Click(object sender, EventArgs e)
        {
            preencheGrid(3);
        }

        private void btn_consTpProd_Click(object sender, EventArgs e)
        {
            preencheGrid(4);
        }

        private void btn_consEsp_Click(object sender, EventArgs e)
        {
            preencheGrid(5);
        }
    }
}

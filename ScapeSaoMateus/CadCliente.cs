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
    public partial class CadCliente : Form
    {

        public Cliente clienteInserido = new Cliente();
        public CadCliente(bool controle)
        {
            InitializeComponent();
            carregaCombos();
            habilitaCampos(false);
            btn_Alterar.Enabled = false;
            btn_Inserir.Enabled = false;
            btn_transferir.Visible = false;
            if (controle)
            {
                btn_transferir.Visible = true;
                groupBoxSeleciona.Visible = false;
                btn_transferir.Enabled = false;
            }
            
        }

        private int idCliente = 0;
        private int idEndereco = 0;
        
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
          
            Endereco NovoEnd = new Endereco();
            Cliente NovoCliente = new Cliente();
            Cidade NovaCid = new Cidade();

            NovoEnd.rua = tbox_Rua.Text.ToUpper();
            NovoEnd.numero = tbox_numero.Text.ToUpper();
            NovoEnd.bairro = tbox_Bairro.Text.ToUpper();
            NovoEnd.cidade = Convert.ToInt32(comboBox1.SelectedValue);
            NovoEnd.cep = mktbox_cep.Text;
            

            NovoCliente.nome = tbox_Nome.Text.ToUpper();
            NovoCliente.email = tbox_Email.Text.ToUpper();
            NovoCliente.tel_fixo = mktbox_telfixo.Text.ToUpper();
            NovoCliente.celular = mktbox_cel.Text.ToUpper();

            try
            {
                NovoCliente.data_nasc = Convert.ToDateTime(mktbox_dataNasc.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Data de Nascimento Invalida ou em Branco ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //NovoCliente.data_nasc = Convert.ToDateTime(mktbox_dataNasc.Text);

            NovoCliente.id = idCliente;

            if (idCliente==0)
            {
                NovoCliente.Endereco = NovoEnd;
                if (!ClienteDataAcess.Inserir(NovoCliente))
                {
                    MessageBox.Show("Erro ao cadastrar Cliente ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro Inserido com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clienteInserido = NovoCliente;
                    carregaCombos();
                }

                btn_transferir.Enabled = true;
            }
            else
            {
                NovoEnd.id = idEndereco;
                if (!ClienteDataAcess.Alterar(NovoCliente, NovoEnd))
                {
                    MessageBox.Show("Erro ao alterar dados do Cliente ! ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro Alterado com sucesso ! ", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregaCombos();
                }

            }

            btnSelecionaCliente.Enabled = true;
            habilitaCampos(false);
            btn_Alterar.Enabled = false;
            comboBox2.Enabled = true;
            btn_Novo.Enabled = true;
        }

        private void btnSelecionaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteDataAcess.buscarCliente(Convert.ToInt32(comboBox2.SelectedValue));
            Endereco end = EnderecoDataAcess.buscarEnd(cliente.id_endereco);
            tbox_Nome.Text = cliente.nome;
            tbox_Email.Text = cliente.email;
            mktbox_telfixo.Text = cliente.tel_fixo;
            mktbox_cel.Text = cliente.celular;
            tbox_Rua.Text = end.rua;
            tbox_numero.Text = end.numero;
            tbox_Bairro.Text = end.bairro;
            comboBox1.SelectedValue = end.cidade;
            mktbox_cep.Text = end.cep;
            mktbox_dataNasc.Text = Convert.ToString(cliente.data_nasc);

            //atribui id para variavel idCliente para identificar se é alteraçao ou inclusao
            idCliente = cliente.id;
            //atribui id para variavel idCliente para identificar se é alteraçao ou inclusao
            idEndereco = end.id;

            btn_Alterar.Enabled = true;
            btn_Inserir.Enabled = false;
            btn_Novo.Enabled = false;

        }

        private void carregaCombos() {
            comboBox1.DataSource = CidadeDataAcess.preencheCombo();
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id_cidade";

            comboBox2.DataSource = ClienteDataAcess.buscarClientes();
            comboBox2.DisplayMember = "nome";
            comboBox2.ValueMember = "id";
        }

        private void habilitaCampos(bool control)
        {
            if (control)
            {
                tbox_Nome.Enabled = true;
                tbox_Email.Enabled = true;
                mktbox_telfixo.Enabled = true;
                mktbox_cel.Enabled = true;
                tbox_Rua.Enabled = true;
                tbox_numero.Enabled = true;
                tbox_Bairro.Enabled = true;
                comboBox1.Enabled = true;
                mktbox_cep.Enabled = true;
                mktbox_dataNasc.Enabled = true;
            }
            else
            {
                tbox_Nome.Enabled = false;
                tbox_Email.Enabled = false;
                mktbox_telfixo.Enabled = false;
                mktbox_cel.Enabled = false;
                tbox_Rua.Enabled = false;
                tbox_numero.Enabled = false;
                tbox_Bairro.Enabled = false;
                comboBox1.Enabled = false;
                mktbox_cep.Enabled = false;
                mktbox_dataNasc.Enabled = false;
            }


        }

        private void limpaCampos()
        {
            tbox_Nome.Text = "";
            tbox_Email.Text = "";
            mktbox_telfixo.Text = "";
            mktbox_cel.Text = "";
            tbox_Rua.Text = "";
            tbox_numero.Text = "";
            tbox_Bairro.Text = "";
            carregaCombos();
            mktbox_cep.Text = "";
            mktbox_dataNasc.Text = "";
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            idCliente = 0;
            idEndereco = 0;
            habilitaCampos(true);
            limpaCampos();
            btnSelecionaCliente.Enabled = false;
            comboBox2.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Inserir.Enabled = true;
            btn_Novo.Enabled = false;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            idCliente = 0;
            idEndereco = 0;
            limpaCampos();
            habilitaCampos(false);
            btnSelecionaCliente.Enabled = true;
            comboBox2.Enabled = true;
            btn_Inserir.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Novo.Enabled = true;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            btn_Inserir.Enabled = true;
        }



        private void tbox_Nome_Leave(object sender, EventArgs e)
        {
            if (tbox_Nome.TextLength == 0)
            {
                MessageBox.Show("Digite o Nome do cliente ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_Nome.Focus();
            }
        }

        private void tbox_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

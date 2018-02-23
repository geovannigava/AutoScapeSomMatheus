namespace ScapeSaoMateus
{
    partial class CadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktbox_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Nome = new System.Windows.Forms.TextBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.mktbox_cel = new System.Windows.Forms.MaskedTextBox();
            this.mktbox_telfixo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_Email = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mktbox_cep = new System.Windows.Forms.MaskedTextBox();
            this.tbox_numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Bairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_Rua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSelecionaCliente = new System.Windows.Forms.Button();
            this.groupBoxSeleciona = new System.Windows.Forms.GroupBox();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_transferir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSeleciona.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktbox_dataNasc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_Nome);
            this.groupBox1.Controls.Add(this.btn_Alterar);
            this.groupBox1.Controls.Add(this.mktbox_cel);
            this.groupBox1.Controls.Add(this.mktbox_telfixo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbox_Email);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 315);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // mktbox_dataNasc
            // 
            this.mktbox_dataNasc.Location = new System.Drawing.Point(86, 135);
            this.mktbox_dataNasc.Mask = "00/00/0000";
            this.mktbox_dataNasc.Name = "mktbox_dataNasc";
            this.mktbox_dataNasc.Size = new System.Drawing.Size(68, 20);
            this.mktbox_dataNasc.TabIndex = 7;
            this.mktbox_dataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_dataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data de Nasc.:";
            // 
            // tbox_Nome
            // 
            this.tbox_Nome.Location = new System.Drawing.Point(87, 29);
            this.tbox_Nome.Name = "tbox_Nome";
            this.tbox_Nome.Size = new System.Drawing.Size(490, 20);
            this.tbox_Nome.TabIndex = 3;
            this.tbox_Nome.Leave += new System.EventHandler(this.tbox_Nome_Leave);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(6, 281);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(104, 24);
            this.btn_Alterar.TabIndex = 19;
            this.btn_Alterar.Text = "Habilitar Edição";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // mktbox_cel
            // 
            this.mktbox_cel.Location = new System.Drawing.Point(87, 109);
            this.mktbox_cel.Mask = "(999) 00000-0000";
            this.mktbox_cel.Name = "mktbox_cel";
            this.mktbox_cel.Size = new System.Drawing.Size(94, 20);
            this.mktbox_cel.TabIndex = 6;
            this.mktbox_cel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mktbox_telfixo
            // 
            this.mktbox_telfixo.Location = new System.Drawing.Point(87, 82);
            this.mktbox_telfixo.Mask = "(999) 0000-0000";
            this.mktbox_telfixo.Name = "mktbox_telfixo";
            this.mktbox_telfixo.Size = new System.Drawing.Size(94, 20);
            this.mktbox_telfixo.TabIndex = 5;
            this.mktbox_telfixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tel. Fixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            // 
            // tbox_Email
            // 
            this.tbox_Email.Location = new System.Drawing.Point(87, 56);
            this.tbox_Email.Name = "tbox_Email";
            this.tbox_Email.Size = new System.Drawing.Size(238, 20);
            this.tbox_Email.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mktbox_cep);
            this.groupBox3.Controls.Add(this.tbox_numero);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbox_Bairro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbox_Rua);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 108);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "CEP:";
            // 
            // mktbox_cep
            // 
            this.mktbox_cep.Location = new System.Drawing.Point(513, 72);
            this.mktbox_cep.Mask = "00000-000";
            this.mktbox_cep.Name = "mktbox_cep";
            this.mktbox_cep.Size = new System.Drawing.Size(58, 20);
            this.mktbox_cep.TabIndex = 12;
            // 
            // tbox_numero
            // 
            this.tbox_numero.Location = new System.Drawing.Point(512, 20);
            this.tbox_numero.Name = "tbox_numero";
            this.tbox_numero.Size = new System.Drawing.Size(58, 20);
            this.tbox_numero.TabIndex = 9;
            this.tbox_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_numero_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cidade:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Bairro:";
            // 
            // tbox_Bairro
            // 
            this.tbox_Bairro.Location = new System.Drawing.Point(80, 49);
            this.tbox_Bairro.Name = "tbox_Bairro";
            this.tbox_Bairro.Size = new System.Drawing.Size(238, 20);
            this.tbox_Bairro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Logradouro:";
            // 
            // tbox_Rua
            // 
            this.tbox_Rua.Location = new System.Drawing.Point(80, 20);
            this.tbox_Rua.Name = "tbox_Rua";
            this.tbox_Rua.Size = new System.Drawing.Size(402, 20);
            this.tbox_Rua.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nº:";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(505, 400);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(104, 24);
            this.btn_Inserir.TabIndex = 13;
            this.btn_Inserir.Text = "Salvar";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(467, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // btnSelecionaCliente
            // 
            this.btnSelecionaCliente.Location = new System.Drawing.Point(502, 24);
            this.btnSelecionaCliente.Name = "btnSelecionaCliente";
            this.btnSelecionaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaCliente.TabIndex = 2;
            this.btnSelecionaCliente.Text = "Selecionar";
            this.btnSelecionaCliente.UseVisualStyleBackColor = true;
            this.btnSelecionaCliente.Click += new System.EventHandler(this.btnSelecionaCliente_Click);
            // 
            // groupBoxSeleciona
            // 
            this.groupBoxSeleciona.Controls.Add(this.comboBox2);
            this.groupBoxSeleciona.Controls.Add(this.btnSelecionaCliente);
            this.groupBoxSeleciona.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSeleciona.Name = "groupBoxSeleciona";
            this.groupBoxSeleciona.Size = new System.Drawing.Size(597, 61);
            this.groupBoxSeleciona.TabIndex = 22;
            this.groupBoxSeleciona.TabStop = false;
            this.groupBoxSeleciona.Text = "Selecione o Cliente:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(17, 400);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(104, 24);
            this.btn_Novo.TabIndex = 20;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(127, 400);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(104, 24);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_transferir
            // 
            this.btn_transferir.Location = new System.Drawing.Point(395, 400);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(104, 24);
            this.btn_transferir.TabIndex = 78;
            this.btn_transferir.Text = "Transferir";
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 432);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSeleciona);
            this.Name = "CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSeleciona.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_Email;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_Bairro;
        private System.Windows.Forms.TextBox tbox_Rua;
        private System.Windows.Forms.MaskedTextBox mktbox_cel;
        private System.Windows.Forms.MaskedTextBox mktbox_telfixo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox mktbox_cep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSelecionaCliente;
        private System.Windows.Forms.TextBox tbox_Nome;
        private System.Windows.Forms.GroupBox groupBoxSeleciona;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox tbox_numero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mktbox_dataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_transferir;
    }
}
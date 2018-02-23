namespace ScapeSaoMateus
{
    partial class CadVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.dataGridViewVend = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_cep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_cidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_bairro = new System.Windows.Forms.TextBox();
            this.tbox_nro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_rua = new System.Windows.Forms.TextBox();
            this.tbox_telFixo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_celular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_finalizaVenda = new System.Windows.Forms.Button();
            this.tbox_nroVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVend)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.btn_remover);
            this.groupBox1.Controls.Add(this.btn_adicionar);
            this.groupBox1.Controls.Add(this.dataGridViewVend);
            this.groupBox1.Location = new System.Drawing.Point(7, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor total (R$): ";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(618, 273);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(96, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular Total";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(89, 273);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(8, 273);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // dataGridViewVend
            // 
            this.dataGridViewVend.AllowUserToAddRows = false;
            this.dataGridViewVend.AllowUserToDeleteRows = false;
            this.dataGridViewVend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVend.Location = new System.Drawing.Point(8, 19);
            this.dataGridViewVend.Name = "dataGridViewVend";
            this.dataGridViewVend.Size = new System.Drawing.Size(878, 248);
            this.dataGridViewVend.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tbox_telFixo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbox_email);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbox_celular);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbox_nome);
            this.groupBox2.Location = new System.Drawing.Point(111, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbox_cep);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbox_cidade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbox_bairro);
            this.groupBox3.Controls.Add(this.tbox_nro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbox_rua);
            this.groupBox3.Location = new System.Drawing.Point(7, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 70);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CEP:";
            // 
            // tbox_cep
            // 
            this.tbox_cep.Location = new System.Drawing.Point(584, 45);
            this.tbox_cep.Name = "tbox_cep";
            this.tbox_cep.ReadOnly = true;
            this.tbox_cep.Size = new System.Drawing.Size(80, 20);
            this.tbox_cep.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cidade:";
            // 
            // tbox_cidade
            // 
            this.tbox_cidade.Location = new System.Drawing.Point(279, 45);
            this.tbox_cidade.Name = "tbox_cidade";
            this.tbox_cidade.ReadOnly = true;
            this.tbox_cidade.Size = new System.Drawing.Size(267, 20);
            this.tbox_cidade.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bairro:";
            // 
            // tbox_bairro
            // 
            this.tbox_bairro.Location = new System.Drawing.Point(76, 45);
            this.tbox_bairro.Name = "tbox_bairro";
            this.tbox_bairro.ReadOnly = true;
            this.tbox_bairro.Size = new System.Drawing.Size(150, 20);
            this.tbox_bairro.TabIndex = 12;
            // 
            // tbox_nro
            // 
            this.tbox_nro.Location = new System.Drawing.Point(604, 22);
            this.tbox_nro.Name = "tbox_nro";
            this.tbox_nro.ReadOnly = true;
            this.tbox_nro.Size = new System.Drawing.Size(60, 20);
            this.tbox_nro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logradouro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nº:";
            // 
            // tbox_rua
            // 
            this.tbox_rua.Location = new System.Drawing.Point(76, 22);
            this.tbox_rua.Name = "tbox_rua";
            this.tbox_rua.ReadOnly = true;
            this.tbox_rua.Size = new System.Drawing.Size(499, 20);
            this.tbox_rua.TabIndex = 10;
            // 
            // tbox_telFixo
            // 
            this.tbox_telFixo.Location = new System.Drawing.Point(406, 44);
            this.tbox_telFixo.Name = "tbox_telFixo";
            this.tbox_telFixo.ReadOnly = true;
            this.tbox_telFixo.Size = new System.Drawing.Size(115, 20);
            this.tbox_telFixo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tel. Fixo:";
            // 
            // tbox_email
            // 
            this.tbox_email.Location = new System.Drawing.Point(47, 44);
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.ReadOnly = true;
            this.tbox_email.Size = new System.Drawing.Size(297, 20);
            this.tbox_email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(575, 44);
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.ReadOnly = true;
            this.tbox_celular.Size = new System.Drawing.Size(102, 20);
            this.tbox_celular.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(47, 21);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.ReadOnly = true;
            this.tbox_nome.Size = new System.Drawing.Size(630, 20);
            this.tbox_nome.TabIndex = 1;
            // 
            // btn_pesq
            // 
            this.btn_pesq.Location = new System.Drawing.Point(722, 161);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(75, 23);
            this.btn_pesq.TabIndex = 0;
            this.btn_pesq.Text = "Pesquisar";
            this.btn_pesq.UseVisualStyleBackColor = true;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(111, 161);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_finalizaVenda
            // 
            this.btn_finalizaVenda.Location = new System.Drawing.Point(749, 524);
            this.btn_finalizaVenda.Name = "btn_finalizaVenda";
            this.btn_finalizaVenda.Size = new System.Drawing.Size(152, 28);
            this.btn_finalizaVenda.TabIndex = 3;
            this.btn_finalizaVenda.Text = "Finalizar a Venda";
            this.btn_finalizaVenda.UseVisualStyleBackColor = true;
            this.btn_finalizaVenda.Click += new System.EventHandler(this.btn_finalizaVenda_Click);
            // 
            // tbox_nroVenda
            // 
            this.tbox_nroVenda.Location = new System.Drawing.Point(806, 498);
            this.tbox_nroVenda.Name = "tbox_nroVenda";
            this.tbox_nroVenda.ReadOnly = true;
            this.tbox_nroVenda.Size = new System.Drawing.Size(95, 20);
            this.tbox_nroVenda.TabIndex = 18;
            this.tbox_nroVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(746, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Venda Nº:";
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(19, 501);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(152, 28);
            this.btn_novo.TabIndex = 19;
            this.btn_novo.Text = "Nova Venda";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // CadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 563);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbox_nroVenda);
            this.Controls.Add(this.btn_finalizaVenda);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_pesq);
            this.Name = "CadVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVend)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewVend;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_rua;
        private System.Windows.Forms.TextBox tbox_telFixo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_celular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_bairro;
        private System.Windows.Forms.TextBox tbox_nro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_cep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_cidade;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_finalizaVenda;
        private System.Windows.Forms.TextBox tbox_nroVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_novo;
    }
}
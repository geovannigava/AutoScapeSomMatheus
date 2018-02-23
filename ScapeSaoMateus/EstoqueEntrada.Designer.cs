namespace ScapeSaoMateus
{
    partial class EstoqueEntrada
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
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dataGridViewProdEst = new System.Windows.Forms.DataGridView();
            this.btn_remover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdEst)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(36, 19);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(81, 29);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Localizar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // dataGridViewProdEst
            // 
            this.dataGridViewProdEst.AllowUserToAddRows = false;
            this.dataGridViewProdEst.AllowUserToDeleteRows = false;
            this.dataGridViewProdEst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdEst.Location = new System.Drawing.Point(18, 136);
            this.dataGridViewProdEst.Name = "dataGridViewProdEst";
            this.dataGridViewProdEst.Size = new System.Drawing.Size(881, 273);
            this.dataGridViewProdEst.TabIndex = 3;
            this.dataGridViewProdEst.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewProdEst_DataError);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(18, 421);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(162, 22);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover Produto da Lista";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(507, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Produto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_inserir);
            this.groupBox2.Location = new System.Drawing.Point(689, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Novo Produto:";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(34, 19);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(81, 29);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir ";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(418, 421);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 39);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Confirmar Entrada de Produtos";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 298);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Produtos / Entrada:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(465, 109);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EstoqueEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 472);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProdEst);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "EstoqueEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdEst)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dataGridViewProdEst;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}
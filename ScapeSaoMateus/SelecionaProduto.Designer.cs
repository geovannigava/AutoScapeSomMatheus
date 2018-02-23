namespace ScapeSaoMateus
{
    partial class SelecionaProduto
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
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.btn_PesqporCod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.btn_PesqporNome = new System.Windows.Forms.Button();
            this.dataGridViewSelProd = new System.Windows.Forms.DataGridView();
            this.btn_transferir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelProd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_codigo);
            this.groupBox1.Controls.Add(this.btn_PesqporCod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Código do Produto:";
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(6, 34);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.Size = new System.Drawing.Size(194, 20);
            this.tbox_codigo.TabIndex = 1;
            // 
            // btn_PesqporCod
            // 
            this.btn_PesqporCod.Location = new System.Drawing.Point(125, 60);
            this.btn_PesqporCod.Name = "btn_PesqporCod";
            this.btn_PesqporCod.Size = new System.Drawing.Size(75, 23);
            this.btn_PesqporCod.TabIndex = 0;
            this.btn_PesqporCod.Text = "Pesquisar";
            this.btn_PesqporCod.UseVisualStyleBackColor = true;
            this.btn_PesqporCod.Click += new System.EventHandler(this.btn_PesqporCod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_nome);
            this.groupBox2.Controls.Add(this.btn_PesqporNome);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por Nome:";
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(6, 34);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(638, 20);
            this.tbox_nome.TabIndex = 2;
            // 
            // btn_PesqporNome
            // 
            this.btn_PesqporNome.Location = new System.Drawing.Point(569, 60);
            this.btn_PesqporNome.Name = "btn_PesqporNome";
            this.btn_PesqporNome.Size = new System.Drawing.Size(75, 23);
            this.btn_PesqporNome.TabIndex = 1;
            this.btn_PesqporNome.Text = "Pesquisar";
            this.btn_PesqporNome.UseVisualStyleBackColor = true;
            this.btn_PesqporNome.Click += new System.EventHandler(this.btn_PesqporNome_Click);
            // 
            // dataGridViewSelProd
            // 
            this.dataGridViewSelProd.AllowUserToAddRows = false;
            this.dataGridViewSelProd.AllowUserToDeleteRows = false;
            this.dataGridViewSelProd.AllowUserToOrderColumns = true;
            this.dataGridViewSelProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelProd.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSelProd.Name = "dataGridViewSelProd";
            this.dataGridViewSelProd.ReadOnly = true;
            this.dataGridViewSelProd.Size = new System.Drawing.Size(864, 317);
            this.dataGridViewSelProd.TabIndex = 2;
            // 
            // btn_transferir
            // 
            this.btn_transferir.Location = new System.Drawing.Point(374, 455);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(186, 41);
            this.btn_transferir.TabIndex = 3;
            this.btn_transferir.Text = "Selecionar Produto";
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewSelProd);
            this.groupBox3.Location = new System.Drawing.Point(12, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 342);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos:";
            // 
            // SelecionaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 508);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "SelecionaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_PesqporCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Button btn_PesqporNome;
        private System.Windows.Forms.DataGridView dataGridViewSelProd;
        private System.Windows.Forms.Button btn_transferir;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
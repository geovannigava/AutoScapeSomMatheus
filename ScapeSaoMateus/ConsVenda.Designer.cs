namespace ScapeSaoMateus
{
    partial class ConsVenda
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
            this.dataGridViewVend = new System.Windows.Forms.DataGridView();
            this.mktbox_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.mktbox_Fim = new System.Windows.Forms.MaskedTextBox();
            this.btn_Pesq = new System.Windows.Forms.Button();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVend
            // 
            this.dataGridViewVend.AllowUserToAddRows = false;
            this.dataGridViewVend.AllowUserToDeleteRows = false;
            this.dataGridViewVend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVend.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewVend.Name = "dataGridViewVend";
            this.dataGridViewVend.ReadOnly = true;
            this.dataGridViewVend.Size = new System.Drawing.Size(803, 186);
            this.dataGridViewVend.TabIndex = 0;
            this.dataGridViewVend.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVend_CellClick);
            // 
            // mktbox_Inicio
            // 
            this.mktbox_Inicio.Location = new System.Drawing.Point(72, 26);
            this.mktbox_Inicio.Mask = "00/00/0000";
            this.mktbox_Inicio.Name = "mktbox_Inicio";
            this.mktbox_Inicio.Size = new System.Drawing.Size(68, 20);
            this.mktbox_Inicio.TabIndex = 8;
            this.mktbox_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_Inicio.ValidatingType = typeof(System.DateTime);
            // 
            // mktbox_Fim
            // 
            this.mktbox_Fim.Location = new System.Drawing.Point(212, 26);
            this.mktbox_Fim.Mask = "00/00/0000";
            this.mktbox_Fim.Name = "mktbox_Fim";
            this.mktbox_Fim.Size = new System.Drawing.Size(68, 20);
            this.mktbox_Fim.TabIndex = 9;
            this.mktbox_Fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_Fim.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Pesq
            // 
            this.btn_Pesq.Location = new System.Drawing.Point(205, 56);
            this.btn_Pesq.Name = "btn_Pesq";
            this.btn_Pesq.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesq.TabIndex = 10;
            this.btn_Pesq.Text = "Consultar";
            this.btn_Pesq.UseVisualStyleBackColor = true;
            this.btn_Pesq.Click += new System.EventHandler(this.btn_Pesq_Click);
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.AllowUserToAddRows = false;
            this.dataGridViewItens.AllowUserToDeleteRows = false;
            this.dataGridViewItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.ReadOnly = true;
            this.dataGridViewItens.Size = new System.Drawing.Size(803, 154);
            this.dataGridViewItens.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Pesq);
            this.groupBox1.Controls.Add(this.mktbox_Inicio);
            this.groupBox1.Controls.Add(this.mktbox_Fim);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por Período:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewVend);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 208);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewItens);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 176);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens por Venda:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(332, 482);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(137, 27);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar Venda";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // ConsVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 521);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ConsVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar/Cancelar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVend;
        private System.Windows.Forms.MaskedTextBox mktbox_Inicio;
        private System.Windows.Forms.MaskedTextBox mktbox_Fim;
        private System.Windows.Forms.Button btn_Pesq;
        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
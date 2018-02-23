namespace ScapeSaoMateus
{
    partial class ConsEntrada
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pesq = new System.Windows.Forms.Button();
            this.mktbox_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.mktbox_Fim = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEnt = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Pesq);
            this.groupBox1.Controls.Add(this.mktbox_Inicio);
            this.groupBox1.Controls.Add(this.mktbox_Fim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 85);
            this.groupBox1.TabIndex = 14;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewEnt);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 307);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas de Produto:";
            // 
            // dataGridViewEnt
            // 
            this.dataGridViewEnt.AllowUserToAddRows = false;
            this.dataGridViewEnt.AllowUserToDeleteRows = false;
            this.dataGridViewEnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnt.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewEnt.Name = "dataGridViewEnt";
            this.dataGridViewEnt.ReadOnly = true;
            this.dataGridViewEnt.Size = new System.Drawing.Size(803, 285);
            this.dataGridViewEnt.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(342, 419);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(143, 37);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar Entrada de Produtos";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // ConsEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 465);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ConsEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta/Cancelar Entrada de Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pesq;
        private System.Windows.Forms.MaskedTextBox mktbox_Inicio;
        private System.Windows.Forms.MaskedTextBox mktbox_Fim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewEnt;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
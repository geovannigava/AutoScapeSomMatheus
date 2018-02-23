namespace ScapeSaoMateus
{
    partial class EmiteRelatorios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtn_EntCancel = new System.Windows.Forms.RadioButton();
            this.rdbtn_EntRealiz = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_EntporPeriodo = new System.Windows.Forms.Button();
            this.mktbox_EntIni = new System.Windows.Forms.MaskedTextBox();
            this.mktbox_EntFim = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtn_VendCancel = new System.Windows.Forms.RadioButton();
            this.rdbtn_VendRealizadas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VendPorPeriod = new System.Windows.Forms.Button();
            this.mktbox_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.mktbox_Fim = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_estTotal = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entradas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtn_EntCancel);
            this.groupBox2.Controls.Add(this.rdbtn_EntRealiz);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_EntporPeriodo);
            this.groupBox2.Controls.Add(this.mktbox_EntIni);
            this.groupBox2.Controls.Add(this.mktbox_EntFim);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas por Período";
            // 
            // rdbtn_EntCancel
            // 
            this.rdbtn_EntCancel.AutoSize = true;
            this.rdbtn_EntCancel.Location = new System.Drawing.Point(51, 92);
            this.rdbtn_EntCancel.Name = "rdbtn_EntCancel";
            this.rdbtn_EntCancel.Size = new System.Drawing.Size(126, 17);
            this.rdbtn_EntCancel.TabIndex = 18;
            this.rdbtn_EntCancel.TabStop = true;
            this.rdbtn_EntCancel.Text = "Entradas Canceladas";
            this.rdbtn_EntCancel.UseVisualStyleBackColor = true;
            // 
            // rdbtn_EntRealiz
            // 
            this.rdbtn_EntRealiz.AutoSize = true;
            this.rdbtn_EntRealiz.Location = new System.Drawing.Point(51, 71);
            this.rdbtn_EntRealiz.Name = "rdbtn_EntRealiz";
            this.rdbtn_EntRealiz.Size = new System.Drawing.Size(122, 17);
            this.rdbtn_EntRealiz.TabIndex = 17;
            this.rdbtn_EntRealiz.TabStop = true;
            this.rdbtn_EntRealiz.Text = "Entradas Realizadas";
            this.rdbtn_EntRealiz.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Inicial:";
            // 
            // btn_EntporPeriodo
            // 
            this.btn_EntporPeriodo.Location = new System.Drawing.Point(319, 92);
            this.btn_EntporPeriodo.Name = "btn_EntporPeriodo";
            this.btn_EntporPeriodo.Size = new System.Drawing.Size(106, 23);
            this.btn_EntporPeriodo.TabIndex = 15;
            this.btn_EntporPeriodo.Text = "Gerar Relatório";
            this.btn_EntporPeriodo.UseVisualStyleBackColor = true;
            this.btn_EntporPeriodo.Click += new System.EventHandler(this.btn_EntporPeriodo_Click);
            // 
            // mktbox_EntIni
            // 
            this.mktbox_EntIni.Location = new System.Drawing.Point(117, 30);
            this.mktbox_EntIni.Mask = "00/00/0000";
            this.mktbox_EntIni.Name = "mktbox_EntIni";
            this.mktbox_EntIni.Size = new System.Drawing.Size(68, 20);
            this.mktbox_EntIni.TabIndex = 12;
            this.mktbox_EntIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_EntIni.ValidatingType = typeof(System.DateTime);
            // 
            // mktbox_EntFim
            // 
            this.mktbox_EntFim.Location = new System.Drawing.Point(255, 30);
            this.mktbox_EntFim.Mask = "00/00/0000";
            this.mktbox_EntFim.Name = "mktbox_EntFim";
            this.mktbox_EntFim.Size = new System.Drawing.Size(68, 20);
            this.mktbox_EntFim.TabIndex = 13;
            this.mktbox_EntFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_EntFim.ValidatingType = typeof(System.DateTime);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_VendCancel);
            this.groupBox1.Controls.Add(this.rdbtn_VendRealizadas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_VendPorPeriod);
            this.groupBox1.Controls.Add(this.mktbox_Inicio);
            this.groupBox1.Controls.Add(this.mktbox_Fim);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas por Período";
            // 
            // rdbtn_VendCancel
            // 
            this.rdbtn_VendCancel.AutoSize = true;
            this.rdbtn_VendCancel.Location = new System.Drawing.Point(51, 92);
            this.rdbtn_VendCancel.Name = "rdbtn_VendCancel";
            this.rdbtn_VendCancel.Size = new System.Drawing.Size(120, 17);
            this.rdbtn_VendCancel.TabIndex = 18;
            this.rdbtn_VendCancel.TabStop = true;
            this.rdbtn_VendCancel.Text = "Vendas Canceladas";
            this.rdbtn_VendCancel.UseVisualStyleBackColor = true;
            // 
            // rdbtn_VendRealizadas
            // 
            this.rdbtn_VendRealizadas.AutoSize = true;
            this.rdbtn_VendRealizadas.Location = new System.Drawing.Point(51, 71);
            this.rdbtn_VendRealizadas.Name = "rdbtn_VendRealizadas";
            this.rdbtn_VendRealizadas.Size = new System.Drawing.Size(116, 17);
            this.rdbtn_VendRealizadas.TabIndex = 17;
            this.rdbtn_VendRealizadas.TabStop = true;
            this.rdbtn_VendRealizadas.Text = "Vendas Realizadas";
            this.rdbtn_VendRealizadas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Inicial:";
            // 
            // btn_VendPorPeriod
            // 
            this.btn_VendPorPeriod.Location = new System.Drawing.Point(320, 92);
            this.btn_VendPorPeriod.Name = "btn_VendPorPeriod";
            this.btn_VendPorPeriod.Size = new System.Drawing.Size(105, 23);
            this.btn_VendPorPeriod.TabIndex = 15;
            this.btn_VendPorPeriod.Text = "Gerar Relatório";
            this.btn_VendPorPeriod.UseVisualStyleBackColor = true;
            this.btn_VendPorPeriod.Click += new System.EventHandler(this.btn_VendPorPeriod_Click);
            // 
            // mktbox_Inicio
            // 
            this.mktbox_Inicio.Location = new System.Drawing.Point(117, 30);
            this.mktbox_Inicio.Mask = "00/00/0000";
            this.mktbox_Inicio.Name = "mktbox_Inicio";
            this.mktbox_Inicio.Size = new System.Drawing.Size(68, 20);
            this.mktbox_Inicio.TabIndex = 12;
            this.mktbox_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_Inicio.ValidatingType = typeof(System.DateTime);
            // 
            // mktbox_Fim
            // 
            this.mktbox_Fim.Location = new System.Drawing.Point(255, 30);
            this.mktbox_Fim.Mask = "00/00/0000";
            this.mktbox_Fim.Name = "mktbox_Fim";
            this.mktbox_Fim.Size = new System.Drawing.Size(68, 20);
            this.mktbox_Fim.TabIndex = 13;
            this.mktbox_Fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktbox_Fim.ValidatingType = typeof(System.DateTime);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(443, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estoque";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_estTotal);
            this.groupBox3.Location = new System.Drawing.Point(157, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estoque Total:";
            // 
            // btn_estTotal
            // 
            this.btn_estTotal.Location = new System.Drawing.Point(13, 19);
            this.btn_estTotal.Name = "btn_estTotal";
            this.btn_estTotal.Size = new System.Drawing.Size(89, 39);
            this.btn_estTotal.TabIndex = 0;
            this.btn_estTotal.Text = "Gerar Relatório";
            this.btn_estTotal.UseVisualStyleBackColor = true;
            this.btn_estTotal.Click += new System.EventHandler(this.btn_estTotal_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(443, 223);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Clientes);
            this.groupBox4.Location = new System.Drawing.Point(157, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 74);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relatório Clientes:";
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(13, 19);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(89, 39);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "Gerar Relatório";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // EmiteRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmiteRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emissão de Relatórios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn_VendCancel;
        private System.Windows.Forms.RadioButton rdbtn_VendRealizadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VendPorPeriod;
        private System.Windows.Forms.MaskedTextBox mktbox_Inicio;
        private System.Windows.Forms.MaskedTextBox mktbox_Fim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtn_EntCancel;
        private System.Windows.Forms.RadioButton rdbtn_EntRealiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_EntporPeriodo;
        private System.Windows.Forms.MaskedTextBox mktbox_EntIni;
        private System.Windows.Forms.MaskedTextBox mktbox_EntFim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_estTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Clientes;
    }
}
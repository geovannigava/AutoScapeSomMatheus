namespace ScapeSaoMateus
{
    partial class ConsEstoque
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_consEsp = new System.Windows.Forms.Button();
            this.cmb_VeicMarca = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_consTpProd = new System.Windows.Forms.Button();
            this.cmb_tpProd = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_consMarcModel = new System.Windows.Forms.Button();
            this.cmb_modeloVeic = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_marcaVeic = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbox_NomeDesc = new System.Windows.Forms.TextBox();
            this.btn_consNome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_estTotal = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(53, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Consulta";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_consEsp);
            this.groupBox6.Controls.Add(this.cmb_VeicMarca);
            this.groupBox6.Location = new System.Drawing.Point(616, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 85);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Por Modelo de Veículo:";
            // 
            // btn_consEsp
            // 
            this.btn_consEsp.Location = new System.Drawing.Point(97, 59);
            this.btn_consEsp.Name = "btn_consEsp";
            this.btn_consEsp.Size = new System.Drawing.Size(76, 22);
            this.btn_consEsp.TabIndex = 24;
            this.btn_consEsp.Text = "Consultar";
            this.btn_consEsp.UseVisualStyleBackColor = true;
            this.btn_consEsp.Click += new System.EventHandler(this.btn_consEsp_Click);
            // 
            // cmb_VeicMarca
            // 
            this.cmb_VeicMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_VeicMarca.FormattingEnabled = true;
            this.cmb_VeicMarca.Location = new System.Drawing.Point(6, 34);
            this.cmb_VeicMarca.Name = "cmb_VeicMarca";
            this.cmb_VeicMarca.Size = new System.Drawing.Size(167, 21);
            this.cmb_VeicMarca.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_consTpProd);
            this.groupBox5.Controls.Add(this.cmb_tpProd);
            this.groupBox5.Location = new System.Drawing.Point(616, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 74);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Por tipo de Produto:";
            // 
            // btn_consTpProd
            // 
            this.btn_consTpProd.Location = new System.Drawing.Point(97, 48);
            this.btn_consTpProd.Name = "btn_consTpProd";
            this.btn_consTpProd.Size = new System.Drawing.Size(76, 22);
            this.btn_consTpProd.TabIndex = 4;
            this.btn_consTpProd.Text = "Consultar";
            this.btn_consTpProd.UseVisualStyleBackColor = true;
            this.btn_consTpProd.Click += new System.EventHandler(this.btn_consTpProd_Click);
            // 
            // cmb_tpProd
            // 
            this.cmb_tpProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tpProd.FormattingEnabled = true;
            this.cmb_tpProd.Location = new System.Drawing.Point(6, 25);
            this.cmb_tpProd.Name = "cmb_tpProd";
            this.cmb_tpProd.Size = new System.Drawing.Size(167, 21);
            this.cmb_tpProd.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_consMarcModel);
            this.groupBox4.Controls.Add(this.cmb_modeloVeic);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmb_marcaVeic);
            this.groupBox4.Location = new System.Drawing.Point(16, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 85);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selecione Marca/Modelo do Veículo";
            // 
            // btn_consMarcModel
            // 
            this.btn_consMarcModel.Enabled = false;
            this.btn_consMarcModel.Location = new System.Drawing.Point(512, 59);
            this.btn_consMarcModel.Name = "btn_consMarcModel";
            this.btn_consMarcModel.Size = new System.Drawing.Size(76, 22);
            this.btn_consMarcModel.TabIndex = 4;
            this.btn_consMarcModel.Text = "Consultar";
            this.btn_consMarcModel.UseVisualStyleBackColor = true;
            this.btn_consMarcModel.Click += new System.EventHandler(this.btn_consMarcModel_Click);
            // 
            // cmb_modeloVeic
            // 
            this.cmb_modeloVeic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modeloVeic.FormattingEnabled = true;
            this.cmb_modeloVeic.Location = new System.Drawing.Point(164, 34);
            this.cmb_modeloVeic.Name = "cmb_modeloVeic";
            this.cmb_modeloVeic.Size = new System.Drawing.Size(424, 21);
            this.cmb_modeloVeic.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Modelo do Veículo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Marca do Veículo:";
            // 
            // cmb_marcaVeic
            // 
            this.cmb_marcaVeic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marcaVeic.FormattingEnabled = true;
            this.cmb_marcaVeic.Location = new System.Drawing.Point(6, 33);
            this.cmb_marcaVeic.Name = "cmb_marcaVeic";
            this.cmb_marcaVeic.Size = new System.Drawing.Size(152, 21);
            this.cmb_marcaVeic.TabIndex = 19;
            this.cmb_marcaVeic.Leave += new System.EventHandler(this.cmb_marcaVeic_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbox_NomeDesc);
            this.groupBox3.Controls.Add(this.btn_consNome);
            this.groupBox3.Location = new System.Drawing.Point(135, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por descrição do Produto ou descrição do veículo:";
            // 
            // tbox_NomeDesc
            // 
            this.tbox_NomeDesc.Location = new System.Drawing.Point(6, 25);
            this.tbox_NomeDesc.Name = "tbox_NomeDesc";
            this.tbox_NomeDesc.Size = new System.Drawing.Size(463, 20);
            this.tbox_NomeDesc.TabIndex = 3;
            // 
            // btn_consNome
            // 
            this.btn_consNome.Location = new System.Drawing.Point(393, 48);
            this.btn_consNome.Name = "btn_consNome";
            this.btn_consNome.Size = new System.Drawing.Size(76, 22);
            this.btn_consNome.TabIndex = 2;
            this.btn_consNome.Text = "Consultar";
            this.btn_consNome.UseVisualStyleBackColor = true;
            this.btn_consNome.Click += new System.EventHandler(this.btn_consNome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_estTotal);
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque Total:";
            // 
            // btn_estTotal
            // 
            this.btn_estTotal.Location = new System.Drawing.Point(13, 19);
            this.btn_estTotal.Name = "btn_estTotal";
            this.btn_estTotal.Size = new System.Drawing.Size(89, 39);
            this.btn_estTotal.TabIndex = 0;
            this.btn_estTotal.Text = "Consultar Estoque Total";
            this.btn_estTotal.UseVisualStyleBackColor = true;
            this.btn_estTotal.Click += new System.EventHandler(this.btn_estTotal_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridViewEstoque);
            this.groupBox7.Location = new System.Drawing.Point(7, 198);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(883, 337);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Estoque:";
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(5, 17);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(872, 315);
            this.dataGridViewEstoque.TabIndex = 0;
            // 
            // ConsEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 542);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estoque ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_estTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_consNome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbox_NomeDesc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_consEsp;
        private System.Windows.Forms.ComboBox cmb_VeicMarca;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_consTpProd;
        private System.Windows.Forms.ComboBox cmb_tpProd;
        private System.Windows.Forms.Button btn_consMarcModel;
        private System.Windows.Forms.ComboBox cmb_modeloVeic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_marcaVeic;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
    }
}
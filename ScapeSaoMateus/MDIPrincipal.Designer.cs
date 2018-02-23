namespace ScapeSaoMateus
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadprodutoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelEntraStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consVendasStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadveiculoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.avisoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.entradaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(61, 20);
            this.fileMenu.Text = "&Clientes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clienteToolStripMenuItem.Text = "&Cadastro de Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "Sai&r";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadprodutoStripMenuItem1,
            this.toolStripMenuItem2});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadprodutoStripMenuItem1
            // 
            this.cadprodutoStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cadprodutoStripMenuItem1.Image")));
            this.cadprodutoStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.cadprodutoStripMenuItem1.Name = "cadprodutoStripMenuItem1";
            this.cadprodutoStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.cadprodutoStripMenuItem1.Text = "&Cadastro de Produtos";
            this.cadprodutoStripMenuItem1.Click += new System.EventHandler(this.cadprodutoStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItem2.Text = "&Cadastro de Produtos/Catálogo";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaStripMenuItem1,
            this.cancelEntraStripMenuItem1});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.estoqueToolStripMenuItem.Text = "Entrada";
            // 
            // entradaStripMenuItem1
            // 
            this.entradaStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("entradaStripMenuItem1.Image")));
            this.entradaStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.entradaStripMenuItem1.Name = "entradaStripMenuItem1";
            this.entradaStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.entradaStripMenuItem1.Text = "&Entrada de Produtos";
            this.entradaStripMenuItem1.Click += new System.EventHandler(this.entradaStripMenuItem1_Click);
            // 
            // cancelEntraStripMenuItem1
            // 
            this.cancelEntraStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cancelEntraStripMenuItem1.Image")));
            this.cancelEntraStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.cancelEntraStripMenuItem1.Name = "cancelEntraStripMenuItem1";
            this.cancelEntraStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.cancelEntraStripMenuItem1.Text = "&Consultar/Cancelar Entrada";
            this.cancelEntraStripMenuItem1.Click += new System.EventHandler(this.cancelEntraStripMenuItem1_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estStripMenuItem1,
            this.avisoStripMenuItem1});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.entradaToolStripMenuItem.Text = "Estoque";
            // 
            // estStripMenuItem1
            // 
            this.estStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("estStripMenuItem1.Image")));
            this.estStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.estStripMenuItem1.Name = "estStripMenuItem1";
            this.estStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.estStripMenuItem1.Text = "&Consultar Estoque";
            this.estStripMenuItem1.Click += new System.EventHandler(this.estStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasStripMenuItem1,
            this.consVendasStripMenuItem1});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasStripMenuItem1
            // 
            this.vendasStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("vendasStripMenuItem1.Image")));
            this.vendasStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.vendasStripMenuItem1.Name = "vendasStripMenuItem1";
            this.vendasStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.vendasStripMenuItem1.Text = "&Cadastro de Vendas";
            this.vendasStripMenuItem1.Click += new System.EventHandler(this.vendasStripMenuItem1_Click);
            // 
            // consVendasStripMenuItem1
            // 
            this.consVendasStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("consVendasStripMenuItem1.Image")));
            this.consVendasStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.consVendasStripMenuItem1.Name = "consVendasStripMenuItem1";
            this.consVendasStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.consVendasStripMenuItem1.Text = "&Consultar/Cancelar Vendas";
            this.consVendasStripMenuItem1.Click += new System.EventHandler(this.consVendasStripMenuItem1_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatoriosStripMenuItem1
            // 
            this.relatoriosStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("relatoriosStripMenuItem1.Image")));
            this.relatoriosStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.relatoriosStripMenuItem1.Name = "relatoriosStripMenuItem1";
            this.relatoriosStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.relatoriosStripMenuItem1.Text = "&Emissão de Relatórios";
            this.relatoriosStripMenuItem1.Click += new System.EventHandler(this.relatoriosStripMenuItem1_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadveiculoStripMenuItem1});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // cadveiculoStripMenuItem1
            // 
            this.cadveiculoStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cadveiculoStripMenuItem1.Image")));
            this.cadveiculoStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.cadveiculoStripMenuItem1.Name = "cadveiculoStripMenuItem1";
            this.cadveiculoStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.cadveiculoStripMenuItem1.Text = "&Cadastro de Veículos/Modelos";
            this.cadveiculoStripMenuItem1.Click += new System.EventHandler(this.cadveiculoStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // avisoStripMenuItem1
            // 
            this.avisoStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("avisoStripMenuItem1.Image")));
            this.avisoStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.avisoStripMenuItem1.Name = "avisoStripMenuItem1";
            this.avisoStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.avisoStripMenuItem1.Text = "Alerta (Produtos Esgotando)";
            this.avisoStripMenuItem1.Click += new System.EventHandler(this.avisoStripMenuItem1_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "Auto Scape Som Mateus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadprodutoStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadveiculoStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consVendasStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelEntraStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avisoStripMenuItem1;
    }
}




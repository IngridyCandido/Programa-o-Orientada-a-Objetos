namespace LocadoraFilmes
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.listarUsuárioToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "&Usuário";
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFilmeToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmeToolStripMenuItem.Text = "&Filme";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "&Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // listarUsuárioToolStripMenuItem
            // 
            this.listarUsuárioToolStripMenuItem.Name = "listarUsuárioToolStripMenuItem";
            this.listarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarUsuárioToolStripMenuItem.Text = "&Listar Usuário";
            this.listarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.listarUsuárioToolStripMenuItem_Click);
            // 
            // cadastrarFilmeToolStripMenuItem
            // 
            this.cadastrarFilmeToolStripMenuItem.Name = "cadastrarFilmeToolStripMenuItem";
            this.cadastrarFilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarFilmeToolStripMenuItem.Text = "&Cadastrar Filme";
            this.cadastrarFilmeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFilmeToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem.Text = "&Listar Filmes";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}


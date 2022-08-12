namespace LibraryManagement
{
    partial class PainelDeControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelDeControle));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.emprestarLivroToolStripMenuItem,
            this.devolverLivroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarLivroToolStripMenuItem,
            this.VerLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(100, 54);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // adicionarLivroToolStripMenuItem
            // 
            this.adicionarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarLivroToolStripMenuItem.Image")));
            this.adicionarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adicionarLivroToolStripMenuItem.Name = "adicionarLivroToolStripMenuItem";
            this.adicionarLivroToolStripMenuItem.Size = new System.Drawing.Size(186, 54);
            this.adicionarLivroToolStripMenuItem.Text = "Adicionar Livro";
            this.adicionarLivroToolStripMenuItem.Click += new System.EventHandler(this.adicionarLivroToolStripMenuItem_Click);
            // 
            // VerLivrosToolStripMenuItem
            // 
            this.VerLivrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VerLivrosToolStripMenuItem.Image")));
            this.VerLivrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VerLivrosToolStripMenuItem.Name = "VerLivrosToolStripMenuItem";
            this.VerLivrosToolStripMenuItem.Size = new System.Drawing.Size(186, 54);
            this.VerLivrosToolStripMenuItem.Text = "Ver Livros";
            this.VerLivrosToolStripMenuItem.Click += new System.EventHandler(this.VerLivrosToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarAlunoToolStripMenuItem,
            this.listarAlunoToolStripMenuItem});
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(99, 54);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // adicionarAlunoToolStripMenuItem
            // 
            this.adicionarAlunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarAlunoToolStripMenuItem.Image")));
            this.adicionarAlunoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adicionarAlunoToolStripMenuItem.Name = "adicionarAlunoToolStripMenuItem";
            this.adicionarAlunoToolStripMenuItem.Size = new System.Drawing.Size(194, 56);
            this.adicionarAlunoToolStripMenuItem.Text = "Adicionar Aluno";
            this.adicionarAlunoToolStripMenuItem.Click += new System.EventHandler(this.adicionarAlunoToolStripMenuItem_Click);
            // 
            // listarAlunoToolStripMenuItem
            // 
            this.listarAlunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarAlunoToolStripMenuItem.Image")));
            this.listarAlunoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listarAlunoToolStripMenuItem.Name = "listarAlunoToolStripMenuItem";
            this.listarAlunoToolStripMenuItem.Size = new System.Drawing.Size(194, 56);
            this.listarAlunoToolStripMenuItem.Text = "Ver Aluno";
            this.listarAlunoToolStripMenuItem.Click += new System.EventHandler(this.listarAlunoToolStripMenuItem_Click);
            // 
            // emprestarLivroToolStripMenuItem
            // 
            this.emprestarLivroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.emprestarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emprestarLivroToolStripMenuItem.Image")));
            this.emprestarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emprestarLivroToolStripMenuItem.Name = "emprestarLivroToolStripMenuItem";
            this.emprestarLivroToolStripMenuItem.Size = new System.Drawing.Size(149, 54);
            this.emprestarLivroToolStripMenuItem.Text = "Emprestar Livro";
            this.emprestarLivroToolStripMenuItem.Click += new System.EventHandler(this.emprestarLivroToolStripMenuItem_Click);
            // 
            // devolverLivroToolStripMenuItem
            // 
            this.devolverLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolverLivroToolStripMenuItem.Image")));
            this.devolverLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            this.devolverLivroToolStripMenuItem.Size = new System.Drawing.Size(134, 54);
            this.devolverLivroToolStripMenuItem.Text = "Devolver Livro";
            this.devolverLivroToolStripMenuItem.Click += new System.EventHandler(this.devolverLivroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(86, 54);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // PainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1090, 739);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PainelDeControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelDeControle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}
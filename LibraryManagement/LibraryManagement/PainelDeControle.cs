using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class PainelDeControle : Form
    {
        public PainelDeControle()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair?","Confirmar",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // fechar a aplicação
                Application.Exit();
            }
        }

        private void adicionarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarLivro al = new AdicionarLivro();
            al.Show();
        }

        private void VerLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarLivros listarLivros = new ListarLivros();
            listarLivros.Show();
        }

        private void adicionarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarEstudante ae = new AdicionarEstudante();
            ae.Show();
        }

        private void listarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAluno va = new VerAluno();
            va.Show();
        }

        private void emprestarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmprestarLivro el = new EmprestarLivro();
            el.Show();
        }

        private void devolverLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverLivro dl = new DevolverLivro();
            dl.Show();
        }
    }
}

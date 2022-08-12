using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AdicionarLivro : Form
    {
        public AdicionarLivro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            if (txtNomeLivro.Text != "" && txtNomeAutor.Text != "" && txtEditora.Text != ""
                && txtNumEdicao.Text != "" && txtQtdLivro.Text != "")
            {
                String nome = txtNomeLivro.Text;
                String autor = txtNomeAutor.Text;
                String editora = txtEditora.Text;
                Int64 numEdicao = Int64.Parse(txtNumEdicao.Text);
                String data = dateTimeLivro.Text;
                Int64 quantidade = Int64.Parse(txtQtdLivro.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into livro(nome,autor,editora,numEdicao,data,quantidade)" +
                    "values('" + nome + "','" + autor + "','" + editora + "'," + numEdicao + ",'" + data + "'," + quantidade + ")";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Livro salvo", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomeLivro.Clear();
                txtNomeAutor.Clear();
                txtEditora.Clear();
                txtNumEdicao.Clear();
                dateTimeLivro.Value = DateTime.Now;
                txtQtdLivro.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarLivro_Click(object sender, EventArgs e)
        {
            txtNomeLivro.Text = "";
            txtNomeAutor.Text = "";
            txtEditora.Text = "";
            txtNumEdicao.Text = "";
            dateTimeLivro.Value = DateTime.Now;
            txtQtdLivro.Text = "";
            this.Close();
        }
    }
}

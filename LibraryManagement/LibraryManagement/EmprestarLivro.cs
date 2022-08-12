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
    public partial class EmprestarLivro : Form
    {
        String nomeAluno;
        String telefone;
        String email;
        String nomeLivro;
        String dataDevolucao;
        Int64 qtd;
        int id;
        public EmprestarLivro()
        {
            InitializeComponent();
        }

        private void txtPesquisaLivro_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaLivro.Text != "")
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select id,nome, quantidade from livro where nome like '" + txtPesquisaLivro.Text + "%' and quantidade > 0";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvLivro.DataSource = ds.Tables[0];
            }
            else
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select id,nome,quantidade from livro where quantidade > 0";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvLivro.DataSource = ds.Tables[0];
            }
        }

        private void txtPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaAluno.Text != "")
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select nome,telefone,email from aluno where nome like '" + txtPesquisaAluno.Text + "%'";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvAluno.DataSource = ds.Tables[0];
            }
            else
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select nome,telefone,email from aluno";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvAluno.DataSource = ds.Tables[0];
            }
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Emprestar Livro?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataDevolucao = txtDataDevolucao.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into emprestimo(nomeAluno,telefone,email,idLivro,nomeLivro,dataDevolucao)" +
                    "values('" + nomeAluno + "','" + telefone + "','" + email + "',"+id+",'" + nomeLivro + "','" + dataDevolucao + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                LivroEmprestado(qtd - 1);
                MessageBox.Show("Livro Emprestado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAluno.Rows.Count > 0)
            {
                nomeAluno = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
                telefone = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
                email = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            //MessageBox.Show(nomeAluno + "\n" + telefone + "\n" + email);
        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvLivro.Rows.Count > 0)
            {
                id = int.Parse(dgvLivro.Rows[e.RowIndex].Cells[0].Value.ToString());
                nomeLivro = dgvLivro.Rows[e.RowIndex].Cells[1].Value.ToString();
                qtd = Int64.Parse(dgvLivro.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void LivroEmprestado (Int64 q)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update livro set quantidade =" + q + " where id = " + id+ "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}

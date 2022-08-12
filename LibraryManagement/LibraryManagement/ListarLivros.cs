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
    public partial class ListarLivros : Form
    {
        private int id;
        private int rowId;

        public ListarLivros()
        {
            InitializeComponent();
        }

        private void ListarLivros_Load(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from livro";
            // comando para preencher o dataset
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // data grid view
            dgvLivro.DataSource = ds.Tables[0];
        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLivro.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(dgvLivro.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from livro where id = "+id+"";
            // comando para preencher o dataset
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            rowId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtNomeLivro.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNomeAutor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtEditora.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNumEdicao.Text = ds.Tables[0].Rows[0][4].ToString();
            dtpLivro.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQtdLivros.Text = ds.Tables[0].Rows[0][6].ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Atualizar Livro?","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                String nome = txtNomeLivro.Text;
                String autor = txtNomeAutor.Text;
                String editora = txtEditora.Text;
                Int64 numEdicao = Int64.Parse(txtNumEdicao.Text);
                String data = dtpLivro.Text;
                Int64 quantidade = Int64.Parse(txtQtdLivros.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update livro set nome='" + nome + "',autor='" + autor + "',editora='" + editora + "',numEdicao=" + numEdicao + ",data='" + data + "',quantidade=" + quantidade + " where id = " + rowId + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeLivro.Text = "";
            txtNomeAutor.Text = "";
            txtEditora.Text = "";
            txtNumEdicao.Text = "";
            dtpLivro.Value = DateTime.Now;
            txtQtdLivros.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from livro where id = " + rowId + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            

            MessageBox.Show("Livro deletado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPesquisaLivro_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisaLivro.Text != "")
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select * from livro where nome like '"+txtPesquisaLivro.Text+"%'";
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
                cmd.CommandText = "select * from livro";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvLivro.DataSource = ds.Tables[0];
            }
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            txtPesquisaLivro.Clear();
        }

    }
}

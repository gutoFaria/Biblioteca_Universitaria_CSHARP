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
    public partial class DevolverLivro : Form
    {
        int id;
        int idLivro;
        public DevolverLivro()
        {
            InitializeComponent();
        }

        private void dgvEmprestimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmprestimo.Rows.Count > 0)
            {
                id = int.Parse(dgvEmprestimo.Rows[e.RowIndex].Cells[0].Value.ToString());
                idLivro = int.Parse(dgvEmprestimo.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void txtPesquisaEmprestimo_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaEmprestimo.Text != "")
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select * from emprestimo where nomeAluno like '" + txtPesquisaEmprestimo.Text + "%'";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvEmprestimo.DataSource = ds.Tables[0];
            }
            else
            {
                //panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select * from emprestimo";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvEmprestimo.DataSource = ds.Tables[0];
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from emprestimo where id = " + id + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            MessageBox.Show("Emprestimo deletado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DevolveLivro();
        }

        private void DevolveLivro()
        {
            int q;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update livro set quantidade += 1 where id = " + idLivro + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}

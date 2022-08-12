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
    public partial class VerAluno : Form
    {
        private int id;
        private int rowId;
        public VerAluno()
        {
            InitializeComponent();
        }

        private void VerAluno_Load(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from aluno";
            // comando para preencher o dataset
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // data grid view
            dgvAluno.DataSource = ds.Tables[0];
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluno.Rows[e.RowIndex].Cells[0].Value != null)
            {
                id = int.Parse(dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from aluno where id = " + id + "";
            // comando para preencher o dataset
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            rowId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtNome.Text = ds.Tables[0].Rows[0][1].ToString();
            txtMatricula.Text = ds.Tables[0].Rows[0][2].ToString();
            txtCurso.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSemestre.Text = ds.Tables[0].Rows[0][4].ToString();
            txtTelefone.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atualizar Aluno?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String nome = txtNome.Text;
                String matricula = txtMatricula.Text;
                String curso = txtCurso.Text;
                String semestre = txtSemestre.Text;
                String telefone = txtTelefone.Text;
                String email = txtEmail.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update aluno set nome='" + nome + "',matricula='" + matricula + "',curso='" + curso + "',semestre='" + semestre + "',telefone='" + telefone + "',email='" + email + "' where id = " + rowId + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from aluno where id = " + rowId + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            MessageBox.Show("Aluno deletado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtMatricula.Text = "";
            txtCurso.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
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
                cmd.CommandText = "select * from aluno where nome like '" + txtPesquisaAluno.Text + "%'";
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
                cmd.CommandText = "select * from aluno";
                // comando para preencher o dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // data grid view
                dgvAluno.DataSource = ds.Tables[0];
            }
        }

        private void btnAtual_Click(object sender, EventArgs e)
        {
            txtPesquisaAluno.Clear();
        }
    }
}

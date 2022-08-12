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
    public partial class AdicionarEstudante : Form
    {
        public AdicionarEstudante()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtMatricula.Text != "" && txtCurso.Text != ""
                && txtSemestre.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "")
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

                con.Open();
                cmd.CommandText = "insert into aluno(nome,matricula,curso,semestre,telefone,email)" +
                    "values('" + nome + "','" + matricula + "','" + curso + "','" + semestre + "','" + telefone + "','" + email + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Aluno salvo", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtMatricula.Clear();
                txtCurso.Clear();
                //txtSemestre.Items.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtCurso.Clear();
            //txtSemestre.Items.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }
    }
}

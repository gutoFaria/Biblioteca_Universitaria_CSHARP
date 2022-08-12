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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            // quando o mou se apertar dentro da caixa de texto 
            // limpar a caixa
            if(txtUsuario.Text == "Usuário")
            {
                txtUsuario.Clear();
            }
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtSenha.Text == "Senha")
            {
                txtSenha.Clear();
                // mudar os caracteres pa asteriscos
                txtSenha.PasswordChar = '*';
            }
        }

       

        private void pictureBoxCapes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www-periodicos-capes-gov-br.ezl.periodicos.capes.gov.br/index.php?");
        }

        private void pictureBoxCnpq_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gov.br/cnpq/pt-br");
        }

        private void pictureBoxFapesp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fapesp.br/");
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=biblioteca;Data Source=DESKTOP-96580IO\\SQLEXPRESS01;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from login where usuario ='" + txtUsuario.Text + "' and senha='" + txtSenha.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                // fecha o painel atual
                this.Hide();
                // abre o painel de controle
                PainelDeControle pdc = new PainelDeControle();
                pdc.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }
    }
}

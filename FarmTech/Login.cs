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



namespace FarmTech
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(252, 250, 250);
        }

        public void verificaLogin() {
            SqlConnection conn = new SqlConnection(Biblioteca.connectionString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM TBColaborador WHERE LoginColaborador=@usuario AND SenhaColaborador=@senha";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario", txtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            int conta = (int)cmd.ExecuteScalar();
            conn.Close();

            if (conta > 0)
            {
                Menu m1 = new Menu();
                m1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro!", MessageBoxButtons.OK);
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }
            
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                verificaLogin();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //if (txtLogin.Text == "Teste" && txtSenha.Text == "Teste")
            //{
            //    Menu m1 = new Menu();
            //    m1.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha incorretos!", "Erro!", MessageBoxButtons.OK);
            //    txtLogin.Clear();
            //    txtSenha.Clear();
            //    txtLogin.Focus();
            //}

            verificaLogin();
        }
    }
}

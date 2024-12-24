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
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void btnCancelCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string query = "INSERT INTO TBCliente (NomeCliente, CPF, Genero, DataNascimento, TelCliente, EmailCliente, Logradouro, Numero, Complemento, Bairro, Cidade, Estado, CEP, LoginCliente, SenhaCliente) " +
                        "VALUES (@Nome, @CPF, @Genero, @DataNascimento, @Telefone, @Email, @Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @LoginCliente, @SenhaCliente);";
                    using (SqlCommand command = new SqlCommand(query, _con))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNmCli.Text);
                        command.Parameters.AddWithValue("@CPF", txtCPFCli.Text);
                        command.Parameters.AddWithValue("@Genero", cbxGenCli.Text);
                        command.Parameters.AddWithValue("@DataNascimento", dtNascCol.Value.Date);
                        command.Parameters.AddWithValue("@Telefone", txtTelCli.Text);
                        command.Parameters.AddWithValue("@Email", txtMailCli.Text);
                        command.Parameters.AddWithValue("@Logradouro", txtLogradouroCol.Text);
                        command.Parameters.AddWithValue("@Numero", txtNmEndCol.Text);
                        command.Parameters.AddWithValue("@Complemento", txtComplCol.Text);
                        command.Parameters.AddWithValue("@Bairro", txtBairrCol.Text);
                        command.Parameters.AddWithValue("@Cidade", txtCidadeCol.Text);
                        command.Parameters.AddWithValue("@Estado", txtEstadoCol.Text);
                        command.Parameters.AddWithValue("@CEP", txtCEPCli.Text);
                        command.Parameters.AddWithValue("@LoginCliente", txtLoginCli.Text);
                        command.Parameters.AddWithValue("@SenhaCliente", txtSenhaCli.Text);

                        _con.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Novo cliente cadastrado com sucesso!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConsultaClientes cc = new ConsultaClientes();
            cc.Show();
        }
    }
}

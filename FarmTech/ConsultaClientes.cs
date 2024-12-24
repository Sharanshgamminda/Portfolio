using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmTech
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string queryStatement = "SELECT idCliente AS ID, NomeCliente AS Nome, CPF, Genero AS 'Gênero', DataNascimento AS 'Data de Nascimento', TelCliente AS Telefone, EmailCliente AS 'E-mail', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBCliente;";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable clienteTabela = new DataTable("Clientes");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(clienteTabela);
                    resulBuscaCliente.DataSource = clienteTabela;
                    _con.Close();
                }
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(CadastroClientes));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                CadastroClientes cc = new CadastroClientes();
                cc.Show();
                this.Close();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string queryStatement = "SELECT idCliente AS ID, NomeCliente AS Nome, CPF, Genero AS 'Gênero', DataNascimento AS 'Data de Nascimento', TelCliente AS Telefone, EmailCliente AS 'E-mail', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBCliente WHERE NomeCliente LIKE '%" + txtBuscaClientes.Text + "%';";

                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        DataTable clienteTabela = new DataTable("Clientes");

                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _con.Open();
                        _dap.Fill(clienteTabela);
                        resulBuscaCliente.DataSource = clienteTabela;
                        _con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
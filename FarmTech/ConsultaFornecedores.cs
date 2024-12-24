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
    public partial class ConsultaFornecedores : Form
    {
        public ConsultaFornecedores()
        {
            InitializeComponent();
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string queryStatement = "SELECT idFornecedor AS ID, RazaoSocial AS 'Razão Social', CNPJ, RamoAtividade AS 'Ramo de Atividade', DataAbertura AS 'Data de Abertura', DataContratacao AS 'Data de Contratação', Telefone, Email AS 'E-mail', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBFornecedor;";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable fornecedorTabela = new DataTable("Fornecedores");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(fornecedorTabela);
                    resulBuscaFornecedor.DataSource = fornecedorTabela;
                    _con.Close();

                }
            }
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(CadastroFornecedor));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                CadastroFornecedor cf = new CadastroFornecedor();
                cf.Show();
                this.Close();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string queryStatement = "SELECT idFornecedor AS ID, RazaoSocial AS 'Razão Social', CNPJ, RamoAtividade AS 'Ramo de Atividade', DataAbertura AS 'Data de Abertura', DataContratacao AS 'Data de Contratação', Telefone, Email AS 'E-mail', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBFornecedor WHERE RazaoSocial LIKE '%" + txtBuscaFornecedores.Text + "%';";

                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        DataTable fornecedorTabela = new DataTable("Clientes");

                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _con.Open();
                        _dap.Fill(fornecedorTabela);
                        resulBuscaFornecedor.DataSource = fornecedorTabela;
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

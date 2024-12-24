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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCancelCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCol_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string query = "INSERT INTO TBFornecedor (RazaoSocial, CNPJ, RamoAtividade, DataAbertura, DataContratacao, Telefone, Email, Logradouro, Numero, Complemento, Bairro, Cidade, Estado, CEP) " +
                        "VALUES (@RazaoSocial, @CNPJ, @RamoAtividade, @DataAbertura, @DataContratacao, @Telefone, @Email, @Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP);";
                    using (SqlCommand command = new SqlCommand(query, _con))
                    {
                        command.Parameters.AddWithValue("@RazaoSocial", txtRazaoSocialForn.Text);
                        command.Parameters.AddWithValue("@CNPJ", txtCNPJForn.Text);
                        command.Parameters.AddWithValue("@RamoAtividade", txtRamoAtividade.Text);
                        command.Parameters.AddWithValue("@DataAbertura", dtAberturaForn.Value.Date);
                        command.Parameters.AddWithValue("@DataContratacao", dtDataContratForn.Value.Date);
                        command.Parameters.AddWithValue("@Telefone", txtTel.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Logradouro", txtLogradouroForn.Text);
                        command.Parameters.AddWithValue("@Numero", txtNmEndForn.Text);
                        command.Parameters.AddWithValue("@Complemento", txtComplForn.Text);
                        command.Parameters.AddWithValue("@Bairro", txtBairrForn.Text);
                        command.Parameters.AddWithValue("@Cidade", txtCidadeForn.Text);
                        command.Parameters.AddWithValue("@Estado", txtEstadoForn.Text);
                        command.Parameters.AddWithValue("@CEP", txtCEPForn.Text);

                        _con.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Novo fornecedor cadastrado com sucesso!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void CadastroFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConsultaFornecedores cf = new ConsultaFornecedores();
            cf.Show();
        }
    }
}

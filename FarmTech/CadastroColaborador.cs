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
    public partial class CadastroColaborador : Form
    {
        public CadastroColaborador()
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
                    string query = "INSERT INTO TBColaborador (NomeColaborador, Cargo, DataAdmissao, CPF, RG, Genero, DataNascimento, EstadoCivil, Logradouro, Numero, Complemento, Bairro, Cidade, Estado, CEP, LoginColaborador, SenhaColaborador) " +
                        "VALUES (@Nome, @Cargo, @DataAdmissao, @CPF, @RG, @Genero, @DataNascimento, @EstadoCivil, @Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @LoginColaborador, @SenhaColaborador);";
                    using (SqlCommand command = new SqlCommand(query, _con))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNmCol.Text);
                        command.Parameters.AddWithValue("@Cargo", cbxCargo.Text);
                        command.Parameters.AddWithValue("@DataAdmissao", dtAdmissCol.Value.Date);
                        command.Parameters.AddWithValue("@CPF", txtCPFCol.Text);
                        command.Parameters.AddWithValue("@RG", txtRGCol.Text);
                        command.Parameters.AddWithValue("@Genero", cbxGenCol.Text);
                        command.Parameters.AddWithValue("@DataNascimento", dtNascCol.Value.Date);
                        command.Parameters.AddWithValue("@EstadoCivil", cbxEstCivilCol.Text);
                        command.Parameters.AddWithValue("@Logradouro", txtLogradouroCol.Text);
                        command.Parameters.AddWithValue("@Numero", txtNmEndCol.Text);
                        command.Parameters.AddWithValue("@Complemento", txtComplCol.Text);
                        command.Parameters.AddWithValue("@Bairro", txtBairrCol.Text);
                        command.Parameters.AddWithValue("@Cidade", txtCidadeCol.Text);
                        command.Parameters.AddWithValue("@Estado", txtEstadoCol.Text);
                        command.Parameters.AddWithValue("@CEP", txtCEPCol.Text);
                        command.Parameters.AddWithValue("@LoginColaborador", txtLoginCol.Text);
                        command.Parameters.AddWithValue("@SenhaColaborador", txtSenhaCol.Text);

                        _con.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Novo colaborador cadastrado com sucesso!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConsultaColaboradores cc = new ConsultaColaboradores();
            cc.Show();
        }
    }
}

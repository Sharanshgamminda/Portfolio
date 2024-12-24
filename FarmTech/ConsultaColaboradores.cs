using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmTech
{
    public partial class ConsultaColaboradores : Form
    {
        public ConsultaColaboradores()
        {
            InitializeComponent();
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string queryStatement = "SELECT idColaborador AS ID, NomeColaborador AS Nome, Cargo, DataAdmissao AS 'Data de Admissão', CPF, RG, Genero AS Gênero, DataNascimento AS 'Data de Nascimento', EstadoCivil AS 'Estado Civil', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBColaborador;";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable colaboradorTabela = new DataTable("Colaboradores");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(colaboradorTabela);
                    resulBuscaColaborador.DataSource = colaboradorTabela;
                    _con.Close();

                }
            }
        }

        private void btnCadastrarColaborador_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(CadastroColaborador));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                CadastroColaborador cc = new CadastroColaborador();
                cc.Show();
                this.Close();
            }
        }

        private void btnBuscarColaborador_Click(object sender, EventArgs e)
        {
            try { 
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string queryStatement = "SELECT idColaborador AS ID, NomeColaborador AS Nome, Cargo, DataAdmissao AS 'Data de Admissão', CPF, RG, Genero AS Gênero, DataNascimento AS 'Data de Nascimento', EstadoCivil AS 'Estado Civil', Logradouro, Numero AS Nº, Complemento, Bairro, Cidade, Estado, CEP FROM TBColaborador WHERE NomeColaborador LIKE '%" + txtBuscaColaborador.Text + "%';";

                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        DataTable colaboradorTabela = new DataTable("Colaboradores");

                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _con.Open();
                        _dap.Fill(colaboradorTabela);
                        resulBuscaColaborador.DataSource = colaboradorTabela;
                        _con.Close();

                    }
                }
            } catch(Exception ex) {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
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
                    string query = "INSERT INTO TBProduto (NmProduto, Unidade, TipoEmbalagem, CustoProduto) " +
                        "VALUES (@Produto, @Unidade, @Embalagem, @Custo);";
                    using (SqlCommand command = new SqlCommand(query, _con))
                    {
                        command.Parameters.AddWithValue("@Produto", txtProduto.Text);
                        command.Parameters.AddWithValue("@Unidade", txtUnidade.Text);
                        command.Parameters.AddWithValue("@Embalagem", txtTipoEmbalagem.Text);
                        command.Parameters.AddWithValue("@Custo", txtCusto.Text);

                        _con.Open();
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Novo produto cadastrado com sucesso!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void CadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConsultaProdutos cp = new ConsultaProdutos();
            cp.Show();
        }
    }
}

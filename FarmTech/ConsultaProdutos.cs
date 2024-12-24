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
    public partial class ConsultaProdutos : Form
    {
        public ConsultaProdutos()
        {
            InitializeComponent();
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string queryStatement = "SELECT NmProduto AS Produto, Unidade, TipoEmbalagem AS Embalagem, CustoProduto AS Custo FROM TBProduto;";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable produtoTabela = new DataTable("Produtos");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(produtoTabela);
                    resulBuscaProduto.DataSource = produtoTabela;
                    _con.Close();
                }
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(CadastroProdutos));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                CadastroProdutos cp = new CadastroProdutos();
                cp.Show();
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                {
                    string queryStatement = "SELECT NmProduto AS Produto, Unidade, TipoEmbalagem AS Embalagem, CustoProduto AS Custo FROM TBProduto WHERE NmProduto LIKE '%" + txtBuscaProduto.Text + "%';";

                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        DataTable produtoTabela = new DataTable("Produtos");

                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _con.Open();
                        _dap.Fill(produtoTabela);
                        resulBuscaProduto.DataSource = produtoTabela;
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

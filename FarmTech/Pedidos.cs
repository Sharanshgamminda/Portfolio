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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();

            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string queryStatement = "SELECT ProdutoPedido AS Produto, ValorPedido AS Valor, ItensPedido AS Itens, DtPedido AS 'Data do pedido', nmCliente AS Cliente, SituacaoPedido AS 'Situação do pedido', FretePedido AS Frete FROM TBPedido;";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable pedidoTabela = new DataTable("Pedidos");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(pedidoTabela);
                    resulBuscaPedidos.DataSource = pedidoTabela;
                    _con.Close();
                }
            }
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(CadastroPedido));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                CadastroPedido cp = new CadastroPedido();
                cp.Show();
                this.Close();
            }
        }
    }
}

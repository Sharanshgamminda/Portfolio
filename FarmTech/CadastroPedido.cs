using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmTech
{
    public partial class CadastroPedido : Form
    {
        public CadastroPedido()
        {
            InitializeComponent();
            ReferenciaComboBoxCliente();
            ReferenciaComboBoxProduto();

        }
        public void ReferenciaComboBoxCliente()
        {
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string query = "SELECT NomeCliente from TBCliente";

                SqlCommand cmd = new SqlCommand(query, _con);

                SqlDataAdapter dap = new SqlDataAdapter(query, _con);
                DataSet dt = new DataSet();
                dap.Fill(dt);

                cbxCliente.DataSource = dt.Tables[0];
                cbxCliente.DisplayMember = "NomeCliente";
            }
        }

        public void ReferenciaComboBoxProduto()
        {
            using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
            {
                string query = "SELECT NmProduto from TBProduto";

                SqlCommand cmd = new SqlCommand(query, _con);

                SqlDataAdapter dap = new SqlDataAdapter(query, _con);
                DataSet dt = new DataSet();
                dap.Fill(dt);

                cbxProduto.DataSource = dt.Tables[0];
                cbxProduto.DisplayMember = "NmProduto";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dtgItensPedido.Rows.Add(cbxProduto.Text, nmQtdProduto.Value, txtValorProduto.Text, Convert.ToDecimal(txtValorProduto.Text)*nmQtdProduto.Value);
            int somaItens = 0;
            for (int i = 0; i < dtgItensPedido.Rows.Count; i++)
            {
                somaItens += Convert.ToInt32(dtgItensPedido.Rows[i].Cells[1].Value);
            }
            txtItensPedido.Text = somaItens.ToString();

            decimal somaTotal = 0;
            for (int i = 0; i < dtgItensPedido.Rows.Count; i++)
            {
                somaTotal += Convert.ToDecimal(dtgItensPedido.Rows[i].Cells[3].Value);
            }
            txtTotalPedido.Text = somaTotal.ToString();

        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgItensPedido.Rows.Count; i++)
            {
                try
                {
                    using (SqlConnection _con = new SqlConnection(Biblioteca.connectionString))
                    {
                        string query = "INSERT INTO TBPedido (ProdutoPedido, ValorPedido, itensPedido, DtPedido, NmCliente, SituacaoPedido, FretePedido) " +
                            "VALUES (@Produto, @Valor, @Itens, @Data, @Cliente, @Situacao, @Frete);";
                        using (SqlCommand command = new SqlCommand(query, _con))
                        {
                            command.Parameters.AddWithValue("@Produto", dtgItensPedido.Rows[i].Cells[0].Value);
                            command.Parameters.AddWithValue("@Valor", dtgItensPedido.Rows[i].Cells[3].Value);
                            command.Parameters.AddWithValue("@Itens", dtgItensPedido.Rows[i].Cells[1].Value);
                            command.Parameters.AddWithValue("@Data", dtPedido.Value.Date);
                            command.Parameters.AddWithValue("@Cliente", cbxCliente.Text);
                            command.Parameters.AddWithValue("@Situacao", cbxSituPedido.Text);
                            command.Parameters.AddWithValue("@Frete", cbxFrete.Text);

                            _con.Open();
                            int result = command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Novo pedido cadastrado com sucesso!", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
            this.Close();
        }

        private void CadastroPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pedidos pp = new Pedidos();
            pp.Show();
        }
    }
}

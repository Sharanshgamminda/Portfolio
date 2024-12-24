using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmTech
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(252, 250, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(ConsultaColaboradores));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else 
            {
                ConsultaColaboradores cc = new ConsultaColaboradores();
                cc.Show();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(ConsultaClientes));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                ConsultaClientes cc = new ConsultaClientes();
                cc.Show();
            }
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(Pedidos));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                Pedidos pp = new Pedidos();
                pp.Show();
            }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(ConsultaFornecedores));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                ConsultaFornecedores cf = new ConsultaFornecedores();
                cf.Show();
            }
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Form openForm = Biblioteca.FormJaAberto(typeof(ConsultaProdutos));
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                ConsultaProdutos cp = new ConsultaProdutos();
                cp.Show();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}

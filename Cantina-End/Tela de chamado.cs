using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_End
{
    public partial class Tela_de_chamado : Form
    {
        public Tela_de_chamado()
        {
            InitializeComponent();
            foreach (var pedido in ProdutoRepository.Pedidos)
            {
                if (pedido.Status is statusDoPedido.Finalizado)
                {
                    listBox1.Items.Add(pedido.Nome);
                }
            }


        }

        private void Tela_de_chamado_Load(object sender, EventArgs e)
        {

        }

        private void proxButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string primeiroitem = listBox1.Items[0].ToString();

                label1.Text = primeiroitem;
                listBox1.Items.Remove(primeiroitem);
            }
            else
            {
                MessageBox.Show("Não há pedidos finalizados no momento.");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

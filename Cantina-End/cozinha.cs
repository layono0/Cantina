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
    public partial class cozinha : Form
    {
        int avanco = 0;

        public cozinha()
        {
            InitializeComponent();
            foreach (var pedido in ProdutoRepository.Pedidos)
            {
                if (pedido.Status == statusDoPedido.Preparando)
                {
                    var item = new ListViewItem(pedido.Nome);
                    item.SubItems.Add(pedido.Data.ToString());
                    item.Tag = pedido;
                    listView1.Items.Add(item);
                }
            }
            
            
        }

        private void cozinha_Load(object sender, EventArgs e)
        {

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (ListViewItem pedidoAtual in listView1.SelectedItems)
            {
                if (pedidoAtual.Tag is Pedido pedidoselecionado)
                {

                    foreach (var Itens in pedidoselecionado.Itens)
                    {
                        listBox1.Items.Add(Itens);
                    }

                }
            }
        }

        private void avancarButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                switch (avanco)
                {
                    case 0:
                        barra1.BackColor = Color.Green;
                        check1.Visible = true;
                        avanco++;
                        return;
                    case 1:
                        barra2.BackColor = Color.Green;
                        check2.Visible = true;
                        avanco++;
                        return;
                    case 2:
                        barra3.BackColor = Color.Green;
                        check3.Visible = true;
                        avanco++;
                        return;
                    case 3:
                        barra4.BackColor = Color.Green;
                        check4.Visible = true;
                        avanco++;
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.Tag is Pedido pedidoAtual)
                            {
                                pedidoAtual.Status = statusDoPedido.Finalizado;
                            }
                        }

                        return;

                }
            }
            else
            {
                MessageBox.Show("selecione um item para começar o processo!", "erro");
            }
        }
    }
}

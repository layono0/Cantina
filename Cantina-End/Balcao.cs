using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_End
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
            /* List<Pedido> historicoPedidos = new List<Pedido>();
             string caminho = @"C:\Users\PC\Documents\historicodepedidos.txt";

             if (File.Exists(caminho))
             {
                 string[] linhas = File.ReadAllLines(caminho);

                 foreach (string linha in linhas)
                 {
                     StatusPedido statusConvertido = StatusPedido.Pendente; // valor padrão
                     if (!Enum.TryParse(partes[4], out statusConvertido))
                     {
                         MessageBox.Show($"Status inválido no pedido: {partes[0]}");
                         continue; // ignora esse pedido se o status estiver errado
                     }
                     var partes = linha.Split('|');
                     if (partes.Length >= 4)
                     {
                         var pedido = new Pedido
                         {
                             Nome = partes[0],
                             Itens = partes[1].Split(';').ToList(),
                             Data = DateTime.Parse(partes[2]),
                             Total = partes[3],
                             Status = Enum.Parse(partes[4])
                         };

                         pedidos.Add(pedido);
                     }
                 }
             }*/

            foreach (var pedidos in ProdutoRepository.Pedidos)
            {
                if (pedidos.Status == statusDoPedido.Criado)
                {
                    var items = new ListViewItem(pedidos.Nome);
                    items.SubItems.Add(pedidos.Total.ToString());
                    items.SubItems.Add(pedidos.Status.ToString());
                    items.Tag = pedidos;
                    pedidosAtuaisView.Items.Add(items);
                }
                else
                {

                }
            }

            foreach (var pedidofinalizado in ProdutoRepository.Pedidos)
            {
                if (pedidofinalizado.Status == statusDoPedido.Finalizado)
                {
                    var items = new ListViewItem(pedidofinalizado.Nome);
                    items.SubItems.Add(pedidofinalizado.Total.ToString());
                    items.SubItems.Add(pedidofinalizado.Status.ToString());
                    items.Tag = pedidofinalizado;
                    historicoDePedidosView.Items.Add(items);
                }

                else
                {

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balcao_Load(object sender, EventArgs e)
        {

        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem pedidoAtual in pedidosAtuaisView.SelectedItems)
            {
                if (pedidoAtual.Tag is Pedido pedidoselecionado)
                {
                    string statusfinalizado = "Finalizado";

                    pedidoselecionado.Status = (statusDoPedido)Enum.Parse(typeof(statusDoPedido), statusfinalizado);

                    var items = new ListViewItem(pedidoselecionado.Nome);
                    items.SubItems.Add(pedidoselecionado.Data.ToString());
                    items.SubItems.Add(pedidoselecionado.Status.ToString());
                    items.Tag = pedidoselecionado;
                    historicoDePedidosView.Items.Add(items);
                }
                pedidosAtuaisView.Items.Remove(pedidoAtual);
            }
            itensView.Items.Clear();

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem pedidoAtual in pedidosAtuaisView.SelectedItems)
            {
                if (pedidoAtual.Tag is Pedido pedidoselecionado)
                {
                    string statusfinalizado = "Cancelado";

                    pedidoselecionado.Status = (statusDoPedido)Enum.Parse(typeof(statusDoPedido), statusfinalizado);

                    var items = new ListViewItem(pedidoselecionado.Nome);
                    items.SubItems.Add(pedidoselecionado.Data.ToString());
                    items.SubItems.Add(pedidoselecionado.Status.ToString());
                    items.Tag = pedidoselecionado;
                    historicoDePedidosView.Items.Add(items);
                }
                pedidosAtuaisView.Items.Remove(pedidoAtual);
            }
            itensView.Items.Clear();
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            itensView.Items.Clear();

            foreach (ListViewItem pedidoAtual in pedidosAtuaisView.SelectedItems)
            {
                if (pedidoAtual.Tag is Pedido pedidoselecionado)
                {

                    foreach (var Itens in pedidoselecionado.Itens)
                    {
                        itensView.Items.Add(Itens);
                    }

                }
            }

        }

        private void cuzinhabutton_Click(object sender, EventArgs e)
        {

        }
    }
}

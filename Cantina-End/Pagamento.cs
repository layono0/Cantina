using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cantina_End.Produto;

namespace Cantina_End
{
    public partial class Pagamento : Form
    {
        private List<string> _carrinhoStrings;
        private string _totalfim;
        public Pagamento(List<string> carrinhoStrings, string totalfim)
        {
            InitializeComponent();

            _totalfim = totalfim;
            _carrinhoStrings = carrinhoStrings;
            trocofimLabel.Text = _totalfim;


        }

        private void Pagamento_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            trocoTextBox.Enabled = true;

        }

        private void trocoTextBox_TextChanged(object sender, EventArgs e)
        {
            troco.Enabled = true;
        }

        private void troco_Click(object sender, EventArgs e)
        {
            double totalFinal = double.Parse(_totalfim);


            if (double.TryParse(trocoTextBox.Text, out double valorRecebido))
            {
                var troco = valorRecebido - totalFinal;
                recebidoLabel.Text = valorRecebido.ToString();

                trocoLabel.Text = troco.ToString();
                finalizarButton.Enabled = true;
                nomeTextbox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Digite um número válido.");
            }

        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (trocofimLabel.Text != "0")
            {
                historicolistview.Items.Clear();
                var novoPedido = new Pedido
                {
                    Nome = nomeTextbox.Text,
                    Itens = _carrinhoStrings,
                    Data = DateTime.Now,
                    Total = trocofimLabel.Text,
                    Status = statusDoPedido.Criado

                };

                ProdutoRepository.Pedidos.Add(novoPedido);

                foreach (var pedidos in ProdutoRepository.Pedidos)
                {

                    var items = new ListViewItem(pedidos.Nome);
                    items.SubItems.Add(pedidos.Data.ToString());
                    items.SubItems.Add(pedidos.Total.ToString());

                    historicolistview.Items.Add(items);


                }

            }
            else
            {
                MessageBox.Show("O total é 0, o pedido não pode ser finalizado");
            }
            recebidoLabel.Text = "0";

            string caminho = @"C:\Users\PC\Documents\historicodepedidos.txt";
            using (StreamWriter writer = new StreamWriter(caminho))
            {
                foreach (var pedido in ProdutoRepository.Pedidos)
                {

                    string itensString = string.Join(";", pedido.Itens);

                    string linha = $"{pedido.Nome}|{itensString}|{pedido.Data}|{pedido.Total}|{pedido.Status}";
                    writer.WriteLine(linha);
                }
            }
        }

        private void pixButton_Click(object sender, EventArgs e)
        {
            recebidoLabel.Text = _totalfim;
            finalizarButton.Enabled = true;
            nomeTextbox.Enabled = true;

        }

        private void cartaoButton_Click(object sender, EventArgs e)
        {
            recebidoLabel.Text = _totalfim;
            finalizarButton.Enabled = true;
            nomeTextbox.Enabled = true;
        }

        private void recebidoLabel_Click(object sender, EventArgs e)
        {

        }
        private void balcaoButton_Click(object sender, EventArgs e)
        {

        }

        private void balcaoButton_Click_1(object sender, EventArgs e)
        {
            var balcao = new Balcao();
            this.Close();
            balcao.Show();
        }
    }
}

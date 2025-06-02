using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static Cantina_End.Produto;

namespace Cantina_End
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProdutoRepository.CarregarItems();
            foreach (var produto in ProdutoRepository.ListaProdutos)
            {

                var items = new ListViewItem(produto.Nome);
                items.SubItems.Add(produto.Quantidade.ToString());
                items.SubItems.Add(produto.Codigo);
                items.SubItems.Add(produto.Valor.ToString());
                items.Tag = produto;
                estoqueList.Items.Add(items);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void pedidoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCarrinho_Click(object sender, EventArgs e)
        {
            if (estoqueList.SelectedItems.Count > 0)
            {
                var item = estoqueList.SelectedItems[0];
                var produto = (Produto)item.Tag;
                string quantidadeAdd = "1";
                if (produto.Quantidade > 0)
                {
                    produto.Quantidade--;
                    item.SubItems[1].Text = produto.Quantidade.ToString();
                    var newItem = new ListViewItem(produto.Codigo);
                    newItem.SubItems.Add(produto.Nome);
                    newItem.SubItems.Add(produto.Valor.ToString("F2"));
                    newItem.SubItems.Add(quantidadeAdd);
                    newItem.Tag = produto;
                    pedidoList.Items.Add(newItem);

                }
                else
                {
                    MessageBox.Show("Produto esgotado");

                }

                double total = 0;
                foreach (ListViewItem produtos in pedidoList.Items)
                {
                    if (produtos.Tag is Produto produtoadicionado)
                    {
                        total += produtoadicionado.Valor;
                    }

                }    
                numLabel.Text = total.ToString("C");
            }
        }

        private void removCarrinho_Click(object sender, EventArgs e)
        {
            if (pedidoList.SelectedItems.Count > 0)
            {
                var itemRemovido = pedidoList.SelectedItems[0];
                var produtoRemovido = (Produto)itemRemovido.Tag;
                double total = double.Parse(numLabel.Text, System.Globalization.NumberStyles.Currency, new CultureInfo("pt-BR"));

                produtoRemovido.Quantidade++;

                foreach (ListViewItem itemEstoque in estoqueList.Items)
                {
                    var produtoEstoque = (Produto)itemEstoque.Tag;
                    if (produtoEstoque.Codigo == produtoRemovido.Codigo)
                    {
                        itemEstoque.SubItems[1].Text = produtoEstoque.Quantidade.ToString();
                        break;
                    }
                }
                var totalfinal = total - produtoRemovido.Valor;
                numLabel.Text = totalfinal.ToString();
                pedidoList.Items.Remove(itemRemovido);
            }
        }

        private void pagarButton_Click(object sender, EventArgs e)
        {
            
            Modal();




        }
        public void Modal()
        {
            List<Produto> carrinhoStrings = new List<Produto>();
            foreach (ListViewItem item in pedidoList.Items)
            {
                carrinhoStrings.Add(item.Tag as Produto);
            }


            var totalfim = numLabel.Text;

            Form frm = new Form()
            {
                BackColor = Color.Black,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                Opacity = 0.7,
                Size = SystemInformation.WorkingArea.Size 
            };
            frm.Show();
            var pagamento = new Pagamento(carrinhoStrings, totalfim);
            pagamento.ShowDialog();
            frm.Close();
        }
    }
}

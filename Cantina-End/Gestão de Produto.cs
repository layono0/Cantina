using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina_End
{
    public partial class Gestão_de_Produto : Form
    {
        public Gestão_de_Produto()
        {
            InitializeComponent();
            Estoque.carregamento();
            foreach (var produtos in ProdutoRepository.ListaEstoque)
            {
                var items = new ListViewItem(produtos.Nome);
                items.SubItems.Add(produtos.Quantidade.ToString());
                items.Tag = produtos;

                estoqueList.Items.Add(items);
            }
            ProdutoRepository.CarregarItems();
            foreach (var produto in ProdutoRepository.ListaProdutos)
            {

                var items = new ListViewItem(produto.Nome);
                items.SubItems.Add(produto.Quantidade.ToString());
                items.SubItems.Add(produto.Codigo);
                items.SubItems.Add(produto.Valor.ToString());
                items.Tag = produto;
                cardapioList.Items.Add(items);

            }
        }

        private void Gestão_de_Produto_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string localProdutos = Path.Combine(caminhoRaiz, "listadeitems.txt");
            string ischapa = isChapa.Checked.ToString().ToLower();

            if (isChapa.CheckState == CheckState.Checked)
            {
                string novaLinha = $"{nomeProduto.Text};{codigoProduto.Text};{quantProduto.Value};{valorProduto.Text}; true";
                File.AppendAllLines(localProdutos, new[] { novaLinha });
            }
            else
            {
                string novaLinha = $"{nomeProduto.Text};{codigoProduto.Text};{quantProduto.Value};{valorProduto.Text}; false";

                File.AppendAllLines(localProdutos, new[] { novaLinha });
            }


            // Atualiza a interface, se necessário
            ListViewItem novoItem = new ListViewItem(nomeProduto.Text);
            novoItem.SubItems.Add(quantProduto.Value.ToString());
            cardapioList.Items.Add(novoItem);


        }

        private void removerbutton_Click(object sender, EventArgs e)
        {
            if (estoqueList.SelectedItems.Count > 0)
            {
                var itemSelecionado = estoqueList.SelectedItems[0];
                string nomeItem = itemSelecionado.Text;

                string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string localProdutos = Path.Combine(caminhoRaiz, "listadeitems.txt");

                var linhas = File.ReadAllLines(localProdutos).ToList();
                linhas.RemoveAll(linha => linha.Split(';')[0] == nomeItem);
                File.WriteAllLines(localProdutos, linhas);

                cardapioList.Items.Remove(itemSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void addestoque_Click(object sender, EventArgs e)
        {
            string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string localEstoque = Path.Combine(caminhoRaiz, "Estoque.txt");
            string novaLinha = $"{nomeEstoque.Text};{quantEstoque.Text}; false";
            File.AppendAllLines(localEstoque, new[] { novaLinha });

            // Atualiza a interface, se necessário
            ListViewItem novoItem = new ListViewItem(nomeEstoque.Text);
            novoItem.SubItems.Add(quantEstoque.Value.ToString());
            estoqueList.Items.Add(novoItem);
        }

        private void removestoq_Click(object sender, EventArgs e)
        {
            if (estoqueList.SelectedItems.Count > 0)
            {
                var itemSelecionado = estoqueList.SelectedItems[0];
                string nomeItem = itemSelecionado.Text;

                string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string localEstoque = Path.Combine(caminhoRaiz, "Estoque.txt");

                var linhas = File.ReadAllLines(localEstoque).ToList();
                linhas.RemoveAll(linha => linha.Split(';')[0] == nomeItem);
                File.WriteAllLines(localEstoque, linhas);

                estoqueList.Items.Remove(itemSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

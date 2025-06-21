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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            Estoque.carregamento();
            foreach (var produtos in ProdutoRepository.ListaEstoque)
            {
                var items = new ListViewItem(produtos.Nome);
                items.SubItems.Add(produtos.Quantidade.ToString());
                items.Tag = produtos;

                listView1.Items.Add(items);
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    if (item.Tag is Estoque itemdoestoque && itemdoestoque.Quantidade > 0 && numeral.Value <= itemdoestoque.Quantidade)
                    {

                        itemdoestoque.Quantidade -= numeral.Value;
                        
                        item.SubItems[1].Text = itemdoestoque.Quantidade.ToString();

                         string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                        string local = Path.Combine(caminhoRaiz, "Estoque.txt");
                        string localProdutos = Path.Combine(caminhoRaiz, "listadeitems.txt");
                        var linhas = File.ReadAllLines(local).ToList();
                        var linhasProdutos = File.ReadAllLines(localProdutos).ToList();
                        for (int i = 0; i < linhas.Count; i++)
                        {
                            var partes = linhas[i].Split(';');
                            if (partes[0] == itemdoestoque.Nome)
                            {

                                linhas[i] = $"{itemdoestoque.Nome};{itemdoestoque.Quantidade};{itemdoestoque.isLow}";
                                break;
                            }
                        }


                        File.WriteAllLines(local, linhas);
                        for (int i = 0; i < linhasProdutos.Count; i++)
                        {
                            var partes = linhasProdutos[i].Split(';');
                            if (partes[0] == itemdoestoque.Nome)
                            {
                                if (decimal.TryParse(partes[2], out decimal quantidadeAtual))
                                {
                                    decimal novaQuantidade = quantidadeAtual + numeral.Value;
                                    linhasProdutos[i] = $"{partes[0]};{partes[1]}; {novaQuantidade};{partes[3]};{partes[4]}";
                                }
                                break;
                            }
                        }
                        File.WriteAllLines(localProdutos, linhasProdutos);
                    }

                    else
                    {
                        MessageBox.Show("Não é possível descontar do valor atual do estoque.");
                    }

                }
            }
            else
            {
                MessageBox.Show("selecione um item para adicionar ou descontar do estoque.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    if (item.Tag is Estoque itemdoestoque && itemdoestoque.Quantidade >= 0 && numeral.Value >0 )
                    {

                        itemdoestoque.Quantidade += numeral.Value;
                        item.SubItems[1].Text = itemdoestoque.Quantidade.ToString();

                        string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                        string local = Path.Combine(caminhoRaiz, "Estoque.txt");

                        var linhas = File.ReadAllLines(local).ToList();

                        for (int i = 0; i < linhas.Count; i++)
                        {
                            var partes = linhas[i].Split(';');
                            if (partes[0] == itemdoestoque.Nome) 
                            {
                                
                                linhas[i] = $"{itemdoestoque.Nome};{itemdoestoque.Quantidade};{itemdoestoque.isLow}";
                                break;
                            }
                        }
                        File.WriteAllLines(local, linhas);


                    }
                    else
                    {
                        MessageBox.Show("O valor escolhido deve ser maior que 0.");
                    }
                }
            }
            else
            {
                MessageBox.Show("selecione um item para adicionar ou descontar do estoque.");
            }
        }
    }
}

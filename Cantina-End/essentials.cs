using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static Cantina_End.Produto;

namespace Cantina_End
{
    internal class essentials
    {
    }
    public class Produto
    {


        public Produto(string linhatexto)
        {
            var items = linhatexto.Split(',');
            Nome = items[0];
            Codigo = items[1].ToString();
            Quantidade = int.Parse(items[2]);
            Valor = double.Parse(items[3]);


        }
        public class Pedido
        {
            public int Id { get; set; }
            public List<string> Itens { get; set; } = new List<string>();
            public DateTime Data { get; set; }
            public string Total { get; set; }
        }



        public override string ToString()
        {
            return $"{Nome} - {Codigo} - {Quantidade}x - R${Valor:F2}";
        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }


    }
    public static class ProdutoRepository
    {

        public static BindingList<Produto> ListaProdutos { get; private set; } = new BindingList<Produto>();
        public static List<Pedido> Pedidos = new List<Pedido>();


        public static void CarregarItems()
        {
            string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string local = Path.Combine(caminhoRaiz, "listadeitems.txt");
            var linhas = File.ReadAllLines(local);

            foreach (var line in linhas)
            {
                Produto produto = new Produto(line);
                ProdutoRepository.ListaProdutos.Add(produto);

            }
        }
        public static List<ListViewItem> adicionaritems()
        {
            var last = new List<ListViewItem>();
            foreach (var produto in ListaProdutos)
            {

                var items = new ListViewItem(produto.Nome);
                items.SubItems.Add(produto.Quantidade.ToString());
                items.SubItems.Add(produto.Valor.ToString());
                items.SubItems.Add(produto.Codigo);
                items.Tag = produto;
                last.Add(items);
            }
            return last;
        }


    }

}

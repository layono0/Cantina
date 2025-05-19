using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public static void CarregarItems()
        {

            string local = @"C:\Users\PC\Documents\listadeitems.txt";
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

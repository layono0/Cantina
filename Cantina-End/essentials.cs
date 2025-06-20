using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var items = linhatexto.Split(';');
            Nome = items[0];
            Codigo = items[1].ToString();
            Quantidade = int.Parse(items[2]);
            Valor = double.Parse(items[3]);
            isChapa = bool.Parse(items[4]);


        }



        public override string ToString()
        {
            return $"{Nome} - R${Valor:F2}";
        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public bool isChapa {  get; set; }


    }


    public class Pedido
    {
        public string Nome { get; set; }
        public List<Produto> Itens { get; set; } = new List<Produto>();
        public DateTime Data { get; set; }
        public string Total { get; set; }
        public statusDoPedido Status { get; set; }
    }
    public partial class Estoque
    {
        public Estoque(string linhatexto)
        {

            var items = linhatexto.Split(';');
            Nome = items[0];
            Quantidade = int.Parse(items[1]);
            isLow = bool.Parse(items[2]);

        }
        public static void carregamento()
        {
            string caminhoRaiz = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string local = Path.Combine(caminhoRaiz, "Estoque.txt");
            var linhas = File.ReadAllLines(local);

            foreach (var line in linhas)
            {
                Estoque produtos = new Estoque(line);
                ProdutoRepository.ListaEstoque.Add(produtos);

            }
        }

        public string Nome { get; set; }
        public decimal Quantidade {  get; set; }
        public bool isLow {  get; set; }
    }
  



    public enum statusDoPedido
    {
        Criado,
        Preparando,
        Finalizado,
        Entregue,
        Cancelado
    }
    public static class ProdutoRepository
    {

        public static BindingList<Produto> ListaProdutos { get; private set; } = new BindingList<Produto>();
        public static List<Pedido> Pedidos = new List<Pedido>();
        public static BindingList<Estoque> ListaEstoque { get; private set; } = new BindingList<Estoque>();


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

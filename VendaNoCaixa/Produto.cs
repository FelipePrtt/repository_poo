using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Produto
    {
        //Atributos
        private long codigo;
        private string nome;
        private double preco;
        private int estoque;

        public static List<Produto> produtos {get; set;} = new List<Produto>();

        public long Codigo
        {
            get {return codigo;}
            set {codigo = value;}
        }
        public string Nome
        {
            get {return nome;}
            set {nome = value;}
        }
        public double Preco
        {
            get {return preco;}
            set {preco = value;}
        }
        public int Estoque
        {
            get {return estoque;}
            set {estoque = value;}
        }

        //Construtores
        public Produto()
        {}
        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        //Métodos
        public void adicionarProdutoNoEstoque(Produto produto)
        {
            produtos.Add(produto);
        }
        public void removerProduto(int cod)
        {
            Produto produtoRemover = null;
            foreach (Produto p in produtos)
            {
                if (p.Codigo == cod)
                    produtoRemover = p;
            }
            if (produtoRemover == null)
            {
                Console.WriteLine("Produto não encontrado!");
            }
            else
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
        }
        public void exibirProdutos()
        {
            foreach (Produto p in produtos)
                Console.WriteLine($"Código: {p.Codigo}\t\tNome: {p.Nome}\t\tPreco: R${p.Preco}\t\tQuantidade em estoque: {p.Estoque}");
        }
    }
}
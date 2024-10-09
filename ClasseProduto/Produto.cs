using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int qtde;
        public string nome;
        public double preco;

        //declaração dos métodos
        public void AdicionarProduto(int qtd)
        {
            qtde = qtde + qtd;
        }
        public void RemoverProduto(int qtd)
        {
            qtde = qtde - qtd;
        }
        public double ValorTotalEstoque()
        {
            return qtde * preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " + nome + "\tQuantidade: "
            + qtde + "\tPreço: " + preco);
        }
    }
}
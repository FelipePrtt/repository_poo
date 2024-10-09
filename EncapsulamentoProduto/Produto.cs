using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        //declaração dos atributos
        private int qtde;
        private string nome;
        private double preco;

        //declarar métodos do encapsulamento
        public int Qtde //declarando a propriedade
        {
            get { return qtde;}
            set 
            { 
                if (value > 0)
                    this.qtde = value;
                else
                    Console.WriteLine("Quantidade inválida");
            }
        }
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        

        //declaração dos métodos
        public void AdicionarProduto(int qtd)
        {
            Qtde = Qtde + qtd;
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
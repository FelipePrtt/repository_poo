using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVendaExercicio
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private static int cod_produto = 500;
        public List<Produto> Produtos {get; set;}
        

        public Produto()
        {
            
        }

        public Produto(string nome, double preco)
        {
            Codigo = cod_produto++;
            Nome = nome;
            Preco = preco;
        }

        //get e set
        public int Codigo
        {
            get 
            {
                return codigo; 
            }
            private set 
            {
                codigo = cod_produto;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != null)
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("O produto deve apresentar um nome.");
                }
            }
        }

        public double Preco
        {
            get 
            {
                return preco;
            }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    Console.WriteLine("O produto não pode ter um preço igual ou menor que zero.");
                }
            }
        }

        //métodos
        public void MostrarAtributos()
        {
            Console.WriteLine($"Produto: {Nome} \nCódigo: {Codigo} \nPreço: {Preco:C}\n");
        }

    }
}
//main

using ConstrutorProduto;

Produto p1 = new Produto(10);

p1.MostrarConteudo();

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo {get; set;}

        public string Nome {get; set;}

        public decimal Preco {get; set;}

        public int Qtde {get; set;}

        //criação de 3 construtores 
        public Produto(int codigo)
        {
            if (codigo > 0)
            {
                this.Codigo = codigo;
            }
            else
            {
                Console.WriteLine("Código nulo.");
            }
        }


        //criação do método MostrarConteúdo
        public void MostrarConteudo()
        {
            Console.WriteLine("Codigo: "+ Codigo);
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataProduto
{
    public abstract class Produto
    {
        public int Codigo { get; set; }
        public double Preco { get; set; }

        public abstract void atualizarPreco(double Preco);

        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código do produto: {Codigo}\nPreço: R$ {Preco}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataProduto
{
    public class Livro : Produto
    {
        public string Autor { get; set; }
        public long Isbn { get; set; }

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
            Isbn = isbn;            
        }

        public override void atualizarPreco(double preco)
        {
            Preco = preco;
        }

        public override void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\nPreço: R$ {Preco}\nAutor: {Autor}\nIsbn: {Isbn}");
        }
    }
}
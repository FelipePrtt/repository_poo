using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataProduto
{
    public class Disco : Produto
    {
        public string Artista { get; set; }
        public string Gravadora { get; set; }


        public Disco(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }


        public override void atualizarPreco(double preco)
        {
            Preco = preco;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine($"Artista: {Artista}\nGravadora: {Gravadora}\n");
        }
    }
}
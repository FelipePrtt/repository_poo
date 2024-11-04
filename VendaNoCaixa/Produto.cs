using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Produto
    {
        private long codigo;
        private string nome;
        private double preco;
        private int estoque;

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
    }
}
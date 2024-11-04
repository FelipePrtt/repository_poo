using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;

        public int Quantidade
        {
            get {return quantidade;}
            set {quantidade = value;}
        }
        public double Preco
        {
            get {return preco;}
            set {preco = value;}
        }
    }
}
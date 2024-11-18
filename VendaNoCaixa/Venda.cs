using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Venda
    {
        private DateTime data;
        private double total;
        public DateTime Data
        {
            get {return data;}
            set {data = value;}
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        //Construtores
        public Venda()
        {}
        public Venda(ItemVenda itensVenda)
        {
            Data = DateTime.Now;
            Total = itensVenda.Subtotal;
        }

        //Método
        public void resumoVenda()
        {
            Console.WriteLine($"Resumo da Venda\nData da Venda: {Data}\nTotal da Venda: R${Total}");
        }
    }
}
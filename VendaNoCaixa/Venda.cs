using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Venda
    {
        //Atributos
        private DateTime data;
        private double total;
        private Pagamento tipoPagamento;
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
        public Pagamento TipoPagamento
        {
            get { return tipoPagamento; }
            set { tipoPagamento = value; }
        }

        //Construtores
        public Venda()
        {}
        public Venda(ItemVenda itensVenda, Pagamento tipoPagamento)
        {
            Data = DateTime.Now;
            Total = itensVenda.Subtotal;
            TipoPagamento = tipoPagamento;
        }

        //Método
        public void resumoVenda()
        {
            Console.WriteLine($"Resumo da Venda\nData da Venda: {Data}\nTotal da Venda: R${Total}\n");
            TipoPagamento.mostrarDadosCompra();
        }
    }
}
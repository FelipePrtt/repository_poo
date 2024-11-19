using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Cheque : Pagamento
    {
        private long numero;
        private DateTime dataDeposito;
        private int situacao;

        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        //Construtores
        public Cheque()
        {}
        public Cheque(long numero)
        {
            Numero = numero;
            DataDeposito = DateTime.Now;
        }

        //Métodos
        public void realizarPagamento()
        {
            Console.WriteLine($"Venda realizada com sucesso!");
        }
        public void verificarStatus(int status)
        {
            if (status == 1)
            {
                Situacao = 1;
            }
            else
            {
                Situacao = 0;
            }
        }
        public override void mostrarDadosCompra()
        {
            Console.WriteLine($"Tipo de pagamento: Cheque\nNúmero do cheque: {Numero}\nData de depósito: {DataDeposito}");
        }
    }
}
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
        public void Depositar(int status)
        {
            if (status == 1)
            {
                Console.WriteLine("Pagamento realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Pagamento não realizado!");
            }
        }
    }
}
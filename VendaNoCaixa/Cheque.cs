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
        public int situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
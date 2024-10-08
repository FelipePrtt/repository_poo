using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; } //Relacionamento entre classe por meio do atributo
        public double Saldo { get; set; }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}
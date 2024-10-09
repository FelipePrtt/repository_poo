using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }


        public ContaCorrente(double saldo, double cheque_especial)
        {
            Saldo = saldo;
            ChequeEspecial = cheque_especial;
        }

        public void Depositar(double valor)
        {   
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"SALDO EM CONTA: R${Saldo}.\n");
        }

        ~ContaCorrente()
        {
            Console.WriteLine("Destruindo conta corrente");
        }
    }
}
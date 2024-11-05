using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        //Atributos
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtores
        public ContaCorrente()
        {
            
        }
        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        //Métodos
        public double CalcularTributos()
        {
            return Saldo * 0.05;
        }
    }
}
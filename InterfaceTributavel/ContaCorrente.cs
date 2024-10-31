using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        public double CalcularTributos(double saldo)
        {
            return saldo * 0.05;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroDeVida : ITributavel
    {
        //Atributos
        private double valorSeguro;

        public double ValorSeguro
        {
            get {return valorSeguro;}
            set {valorSeguro = value;}
        }

        //Contrutores
        public SeguroDeVida()
        {
            
        }
        public SeguroDeVida(double valorSeguro)
        {
            ValorSeguro = valorSeguro;
        }

        //Métodos
        public double CalcularTributos()
        {
            return 75;
        }

        
    }
}
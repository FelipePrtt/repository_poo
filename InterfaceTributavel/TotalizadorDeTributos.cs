using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        //Atributos
        private double total;

        public double Total
        {
            get {return total;}
            private set {total = value;}
        }

        //Construtor
        public TotalizadorDeTributos()
        {
            
        }

        //Métodos
        public void Adicionar(ITributavel t)
        {
            Total += t.CalcularTributos();
        }
    }
}
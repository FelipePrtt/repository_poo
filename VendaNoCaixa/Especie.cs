using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Especie : Pagamento
    {
        private double quantia;
        private double troco;

        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        public double Troco
        {
            get {return troco;}
            set {troco = value;}
        }

    }
}
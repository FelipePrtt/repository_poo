using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVendaExercicio
{
    public class Vendedor
    {

        private double comissao;

        public Vendedor()
        {
            
        }

        public double Comissao
        {
            get
            {
                return comissao;
            }
            set
            {
                comissao += value;
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão atual do Vendedor: {Comissao:C}.\n");
        }
    }
}
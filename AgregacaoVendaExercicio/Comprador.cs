using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVendaExercicio
{
    public class Comprador
    {
        private double verba;

        public Comprador()
        {
            
        }
        public Comprador(double verbaIn)
        {
            Verba = verbaIn;
        }
        public double Verba
        {
            get 
            {
                return verba;
            }
            set
            {
                verba = value;
            }
        }

        public bool Confirmar_Compra(double preco)
        {
            if (Verba >= preco)
            {
                Verba -= preco;    
                return true;  
            }
            else{
                return false;
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Verba restante: {Verba:C}\n");
        }
    }
}
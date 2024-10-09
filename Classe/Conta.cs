using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Conta
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos
        public void Sacar()
        {

        }
        public void Depositar()
        {

        }
        
        public void Transferencia(double valorTransferencia, Conta outroObjeto)
        {
            saldo  = saldo - valorTransferencia;
            outroObjeto.saldo += valorTransferencia;
        }
    }
}
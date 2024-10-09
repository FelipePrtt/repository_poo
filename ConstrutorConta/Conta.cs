using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //declaração dos atributos
        private int numero;
        private string titular;
        private double saldo;

        private static int contador;
        public static int Contador{
            get {return contador;}
        }
        //declaração dos métodos

        public Conta()
        {
            contador ++;
            //Construtor padrão
        }

        public Conta(int numero)
        {
            contador ++;
            this.numero = numero;
        }

        public Conta(int numero, string titular)
        {
            contador ++;
            this.numero = numero;
            this.titular = titular;
        }

        public Conta(int numero, string titular, double saldo)
        {
            contador ++;
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo {saldo:c}");
        }
        
    }
}
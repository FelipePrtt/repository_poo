using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public double Saldo { get; set; }
        

        public Poupanca(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        public void GerarRendimento()
        {
            //Usando um rendimento de 1% ao mês
            Console.WriteLine($"Rendimento mensal a juros de 1%\nLucro Mensal: R${Saldo * 0.1 }");
        }

        ~Poupanca()
        {
            Console.WriteLine("Destruindo conta poupança");
        }
    }
}
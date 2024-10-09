using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public string Nome { get; set; }

        //vetor de poupanças
        public List<Poupanca> Poups{ get; set; }

        //vetor de correntes
        public List<ContaCorrente> Contas { get; set; }

        public Banco()
        {
            
        }

        public Banco(string nome)
        {
            IniciaBanco(nome);
        }

        public void IniciaBanco(string nome)
        {
            Nome = nome;
            Contas = new List<ContaCorrente>();
            Poups = new List<Poupanca>();
        }


        public void AbrirContaCorrente(double saldo, double cheque_especial)
        {
            Contas.Add(new ContaCorrente(saldo, cheque_especial));
        }

        public void AbrirContaPoupanca(double saldo)
        {
            Poups.Add(new Poupanca(saldo));
        }

        ~Banco()
        {
            Console.WriteLine("Destruindo o banco");  
            Poups = null;
            Contas = null;
        }
    }
}
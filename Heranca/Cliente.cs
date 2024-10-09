using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cliente
    {
        //A superclasse deve usa protected no lugar de private, caso contrário as classe que herdão seus atributos n conseguem ver eles
        protected int codigo;
        protected string nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public void Mostrar()
        {
            Console.WriteLine($"\nCódigo: {Codigo}\nNome: {Nome}");
        }
        
        public Cliente()
        {
        
        }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }  
    }
}
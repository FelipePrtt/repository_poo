using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }

        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }

        public Cliente()//Esse construtor precisa ser criado, mesmo que não tenha nada dentro, apenas para atender as necessidades do program.cs
        {
            
        }
    }
}
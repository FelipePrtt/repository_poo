using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Cliente : IAutenticavel //Apesar de parecer, não é uma herança, a classe cliente IMPLEMENTA a interface IAutenticavel
    {
        public int Senha { get; set; }

        public bool Autentica(int senha)
        {
            if(Senha == senha)
            {
                Console.WriteLine($"Cliente autenticado com sucesso!");
                return true;
            }
            return false;
        }
    }
}
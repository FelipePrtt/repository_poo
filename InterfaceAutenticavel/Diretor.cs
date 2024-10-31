using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autentica(int senha)
        {
            if(Senha == senha)
            {
                Console.WriteLine($"Diretor autenticado com sucesso!");
                return true;
            }
            return false;
        }
    }
}
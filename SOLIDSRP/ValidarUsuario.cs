using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDSRP
{
    public class ValidarUsuario
    {
        public bool ValidarTitular(string nomeTitular, string nomeAValidar)
        {
            return (nomeTitular == nomeAValidar);
        }
    }
}
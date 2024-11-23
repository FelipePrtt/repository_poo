using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDLPS
{
    public class Pagamento
    {
        public virtual void ValidarDetalhesPagamento(string idConta, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(idConta))
                Console.WriteLine("ID da conta é requerido.");
            if (valor <= 0)
                Console.WriteLine("O valor deve ser maior que zero.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDLPS
{
    public class PayPal : Pagamento, IPagamento
    {
        public void ProcessarPagamento(string idConta, decimal valor)
        {
            ValidarDetalhesPagamento(idConta, valor);
            Console.WriteLine($"Processado pagamento de {valor:C} da conta: {idConta}");
        }
    }
}
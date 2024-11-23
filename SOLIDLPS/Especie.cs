using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDLPS
{
    public class Especie : Pagamento, IPagamento
    {
        public override void ValidarDetalhesPagamento(string idconta, decimal valor)
        {
                if (valor <= 0)
                Console.WriteLine("O valor deve ser maior que zero.");
        }


        public void ProcessarPagamento(string idconta, decimal valor)
        {
            ValidarDetalhesPagamento(null, valor);
            Console.WriteLine($"Processado pagamento em espécie de R${valor:C}.");
        }
    }
}
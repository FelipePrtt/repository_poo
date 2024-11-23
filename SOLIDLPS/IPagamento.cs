using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDLPS
{
    public interface IPagamento
    {
        void ProcessarPagamento(string idConta, decimal valor);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDSRP
{
    public class GeradorRelatorio
    {
        public string GerarRelatorio(string titular, decimal saldo)
        {
            return ($"Titular: {titular}, Saldo: {saldo}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int numeroNF, string data)
        {
            NumeroNF = numeroNF;
            Data = data;

            //a compisção acontece agora pois os objetos NotaFiscal e VetItens são instanciados juntos
            VetItens = new List<ItemNotaFiscal>();
        }

        ~NotaFiscal()
        {
            VetItens = null;
            Console.WriteLine("Destruir a nota fiscal.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }   

        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }


        //Destrutor n pode ter public, private e nem parametros, porém deve possuir ()
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destruir item nota fiscal.");
        }
    }
}
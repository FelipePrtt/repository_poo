using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Venda
    {
        private DateTime data;

        public DateTime Data
        {
            get {return data;}
            set {data = value;}
        }

        public Venda()
        {
            
        }

        public Venda(DateTime data)
        {
            Data = data;
        }
    }
}
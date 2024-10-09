using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dataValidade;
        private string dataFabricacao;
        private int lote;
    

        public string DataValidade
        {
            get {return dataValidade;}
            set{dataValidade = value;}
        }
        public string DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }
        public int Lote
        {
            get{return lote;}
            set{lote = value;}
        }

        public Perecivel()
        {
            
        }
        public Perecivel(int codigo, string nome, double preco, string dataValidade, string dataFabricacao, int lote) : base(codigo, nome, preco)
        {
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            Lote = lote;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Data de Validade: {DataValidade}\nData de Fabricação: {DataFabricacao}\nLote: {Lote}");
        }
    }
}
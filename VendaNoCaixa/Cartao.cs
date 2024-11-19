using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao;
        private int resultadoTransacao;

        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }

        //Constutor
        public Cartao()
        {}
        public Cartao(string dadosTransacao)
        {
            DadosTransacao = dadosTransacao;
        }
        
        //Métodos 
        public void realizarPagamento()
        {
                Console.WriteLine("Pagamento realizado com sucesso!");
        }
        public void verificarStatus(int status)
        {
            if (status == 1)
            {
                ResultadoTransacao = 1;
            }
            else
            {
                ResultadoTransacao = 0;
            }
        }
        public override void mostrarDadosCompra()
        {
            Console.WriteLine($"Tipo de pagamento: Cartão\nDados da Transação: {DadosTransacao}");
        }
    }
}
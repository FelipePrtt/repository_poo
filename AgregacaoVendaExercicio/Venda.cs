using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace AgregacaoVendaExercicio
{
    public class Venda
    {
        public Comprador comprador;
        public Vendedor vendedor;
        public Produto produto;
        public Venda venda;

        public bool Realizar_Venda()
        {   
            if (comprador.Confirmar_Compra(produto.Preco))
            {
                vendedor.Comissao = (produto.Preco * 0.02);
                return true;
            }
            else{
                Console.WriteLine($"Venda não realizada\nProduto indeferido: {produto.Nome}\n");
                return false;
            }    
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Venda realizada com sucesso!");
            Console.WriteLine($"Produto vendido:{produto.Nome}");
            Console.WriteLine($"Comissão gerada: R${produto.Preco * 0.02:C}\n");
            
        }
    }
}  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaNoCaixa
{
    public class ItemVenda
    {
        //Atributos
        private int quantidade;
        private double preco;
        private double subtotal;

        public int Quantidade
        {
            get {return quantidade;}
            set {quantidade = value;}
        }
        public double Preco
        {
            get {return preco;}
            set {preco = value;}
        }
        public double Subtotal
        {
            get {return subtotal;}
            set {subtotal = value;}
        }

        // Métodos
        private void calcularSubtotal(int quantidadeItem, double valorItem)
        {
            if (quantidadeItem >= 50)
            {
                Console.WriteLine($"Qtde: {quantidadeItem} Valor item: {valorItem}");
                Subtotal += (valorItem * quantidadeItem) - (valorItem * quantidadeItem * 0.20);
            }
            else
            {
                Subtotal += valorItem * quantidadeItem;
            }
        }
        public void adicionarProdutoAVenda(int quantidade, double preco)
        {
            Quantidade = quantidade;
            Preco = preco;
            calcularSubtotal(quantidade, preco);
        }
    }
}
//main


using VendaNoCaixa;



//Instanciamento de produtos
Produto p1 = new Produto(01, "Mouse", 100, 200);
Produto p2 = new Produto(02, "Teclado", 120, 200);
Produto p3 = new Produto(03, "Monitor", 300, 200);
Produto p4 = new Produto(04, "Impressora", 150, 200);
Produto p5 = new Produto(05, "Fone de Ouvido", 80, 200);

//Cria uma instancia estoque da classe produto, para ser utilizada como referência na hora de adicionar itens a classe produto com mais facilidade
Produto estoque = new Produto();

estoque.adicionarProdutoNoEstoque(p1);
estoque.adicionarProdutoNoEstoque(p2);
estoque.adicionarProdutoNoEstoque(p3);
estoque.adicionarProdutoNoEstoque(p4);
estoque.adicionarProdutoNoEstoque(p5);

int op = 1;
while (op != 0 && op <= 10)
{
    Console.Clear();

    Console.WriteLine($"1 - Adicionar Produto\n2 - Remover Produto\n3 - Vizualizar Produtos do Estoque\n4 - Iniciar Venda");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    { 
        case 1:
            Console.Clear();

            Console.WriteLine("Informe o código do produto: ");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            double precoProduto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto: ");
            int quantidadeProduto = Convert.ToInt32(Console.ReadLine());
            Produto p = new Produto(codigoProduto, nomeProduto, precoProduto, quantidadeProduto);
            estoque.adicionarProdutoNoEstoque(p);
            break;
        case 2:
            Console.Clear();

            Console.WriteLine("Informe o código do produto que deseja remover: ");
            int codigoProdutoRemover = Convert.ToInt32(Console.ReadLine());
            estoque.removerProduto(codigoProdutoRemover);
            break;
        case 3:
            Console.Clear();

            estoque.exibirProdutos();
            break;
        case 4:
            Console.Clear();

            int opMaisProdutos = 1;
            ItemVenda itens = new ItemVenda();
            Produto produtoSelecionado = null;
            int quantidadeVenda = 0;
            int codProdutoVenda = 0;

            //Loop que controla a inserção de novos produtos no ItemVenda
            while (opMaisProdutos != 0 && opMaisProdutos == 1)
            {
                Console.Write("Qual o código do produto que deseja adicionar à venda: ");
                codProdutoVenda = Convert.ToInt32(Console.ReadLine());

                produtoSelecionado = null; //variavel para selecionar o produto desejado

                foreach (Produto novoProduto in Produto.produtos) //Percorre por cada produto do estoque
                {
                    if (novoProduto.Codigo == codProdutoVenda)
                    {
                        produtoSelecionado = novoProduto;
                        Console.Write("Qual a quantidade que deseja comprar?: ");
                        quantidadeVenda = Convert.ToInt32(Console.ReadLine());
                        itens.adicionarProdutoAVenda(quantidadeVenda, produtoSelecionado.Preco);
                        break;
                    }
                }
                if (produtoSelecionado != null)
                {
                    Console.Write("Deseja adicionar mais produtos? (1 - Sim, 0 - Não): ");
                    opMaisProdutos = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Produto não encontrado!");
                }
            }

            int formaPagamento = 0;
            Console.Write($"Qual a forma de pagamento?\n1 - Dinheiro\n2 - Cartão\n3 - Cheque");
            formaPagamento = Convert.ToInt32(Console.ReadLine());
            switch (formaPagamento)//switch para escolher a forma de pagamento
            {
                case 1://dinheiro
                    Console.Write($"Quantia entregue: ");
                    double dinheiroEntregue = Convert.ToDouble(Console.ReadLine());
                    Especie pagamentoEsp = new Especie(dinheiroEntregue);
                    pagamentoEsp.calcularTroco(dinheiroEntregue);
                    Console.Write("Pressione ENTER para finalizar a compra:");
                    break;
                case 2://cartão
                    Console.Write($"Informe os dados do cartão: ");
                    string dados = Console.ReadLine();
                    Cartao pagamentoCar = new Cartao(dados);
                    if (pagamentoCar.verificarStatus(1))
                    {   
                        pagamentoCar.realizarPagamento();
                    }
                    else
                    {
                        Console.WriteLine("Compra negada!");
                    }
                    break;
                case 3://cheque

            }
            Venda venda = new Venda(itens);

            break;

    }
    Console.ReadLine(); 
}
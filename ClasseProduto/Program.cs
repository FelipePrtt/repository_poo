// função Main()
using ClasseProduto;

//fazer as instâncias
Produto p1 = new Produto();
p1.nome = "mouse";
p1.qtde = 10;
p1.preco = 60;
p1.AdicionarProduto(5);
p1.MostrarAtributos();

Produto p2 = new Produto();
Console.Write("Digite o nome do produto: ");
p2.nome = Console.ReadLine();
Console.Write("Digite a quantidad do produto: ");
p2.qtde = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o preço do produto: ");
p2.preco = Convert.ToDouble(Console.ReadLine());
p2.RemoverProduto(10);
p2.MostrarAtributos();
Console.WriteLine($"Valor total {p2.ValorTotalEstoque():c}");

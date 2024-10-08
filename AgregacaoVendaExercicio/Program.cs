//main
using AgregacaoVendaExercicio;

Comprador c1 = new Comprador(2000); // Cria um comprador/cliente com uma verba inicial de R$ 2.000,00
Vendedor v1 = new Vendedor(); // Cria um vendedor sem nenhuma comissão recebida

Produto p1 = new Produto("Monitor", 1000);
Produto p2 = new Produto("Teclado", 200);

List<Produto> vetProduto = new List<Produto>();

vetProduto.Add(p1);
vetProduto.Add(p2);

foreach(Produto p in vetProduto)
{
    p.MostrarAtributos();
}

Venda venda1 = new Venda();
venda1.comprador = c1;
venda1.vendedor = v1;
venda1.produto = vetProduto[0];

if (venda1.Realizar_Venda())
{
    venda1.MostrarAtributos();
}

Venda venda2 = new Venda();
venda2.comprador = c1;
venda2.vendedor = v1;
venda2.produto = vetProduto[1];

if (venda2.Realizar_Venda())
{
    venda2.MostrarAtributos();
}

Venda venda3 = new Venda();
venda3.comprador = c1;
venda3.vendedor = v1;
venda3.produto = vetProduto[0];

if (venda3.Realizar_Venda())
{
    venda3.MostrarAtributos();
}

Venda venda4 = new Venda();
venda4.comprador = c1;
venda4.vendedor = v1;
venda4.produto = vetProduto[1];

if (venda4.Realizar_Venda())
{
    venda4.MostrarAtributos();
}
c1.MostrarAtributos();
v1.MostrarAtributos();
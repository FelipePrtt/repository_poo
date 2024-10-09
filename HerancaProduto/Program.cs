// main

using HerancaProduto;

Produto p1 = new Produto();
p1.Codigo = 101;
p1.Nome = "Colher";
p1.Preco = 100;

Produto p2 = new Produto(102, "Prato", 120);

p1.Mostrar();
p2.Mostrar();


Perecivel pr1 = new Perecivel();
pr1.Codigo = 201;
pr1.Nome = "Frango";
pr1.DataValidade = "01/01/2025";
pr1.DataFabricacao = "08/12/2024";
pr1.Lote = 10;

Perecivel pr2 = new Perecivel(202, "Leite", "30/12/2024", "29/11/2024", 09);

pr1.Mostrar();
pr2.Mostrar();
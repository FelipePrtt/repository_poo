//main

using ClasseAbstrataProduto;


Disco disco1 = new Disco(001, 10.21, "MK", "Gravadora PB");
disco1.MostrarAtributos();

Livro livro1 = new Livro(002, 9.18, "Carlos", 18362658762758);
livro1.MostrarAtributos();


Console.WriteLine("ATUALIZAÇÃO DE PREÇOS!");

disco1.atualizarPreco(9.21);
disco1.MostrarAtributos();

livro1.atualizarPreco(7.90);
livro1.MostrarAtributos();
 //main

using AgregacaoContaArray;

//Criação dos cliente
Cliente cli1 = new Cliente("Ana", 111);
Cliente cli2 = new Cliente("Bia", 222);
Cliente cli3 = new Cliente("Leo", 333);

//Criação da conta
Conta c1 = new Conta(1, 10000);

c1.Titular = new List<Cliente>();
c1.Titular.Add(cli1);
c1.Titular.Add(cli2);
c1.Titular.Add(cli3);

Console.WriteLine(".........Apresentação de conta.........");
c1.MostrarAtributos();
foreach(Cliente c in c1.Titular)
{
    c.MostrarAtributos();
}
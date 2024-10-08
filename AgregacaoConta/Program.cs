// main

using AgregacaoConta;

Cliente cli1 = new Cliente("Ana", 1237);
Conta c1 = new Conta(1, 100);
c1.Titular = cli1;

Console.WriteLine("Número: " + c1.Numero + "\tTitular - Nome: " + c1.Titular.Nome + "\tTitular - RG: " + c1.Titular.Rg + "\t Saldo: " + c1.Saldo);


Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente(); //Construtor padrão
c2.Titular.Nome = "Bia";
c2.Titular.Rg = 2000;

Console.WriteLine("Número: " + c2.Numero + "\tTitular - Nome: " + c2.Titular.Nome + "\tTitular - RG: " + c2.Titular.Rg + "\t Saldo: " + c2.Saldo);

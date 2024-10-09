//Método main

using ConstrutorConta;

//Tipos de construtores

//Construtor vazio
Conta c1 = new Conta();
c1.MostrarAtributos();

//Construtor com int setado
Conta c2 = new Conta(20);
c2.MostrarAtributos();

//Contrutor com int e string setados
Conta c3 = new Conta(30, "Ana");
c3.MostrarAtributos();


//Construtor com int, string e double setados
Conta c4 = new Conta(32, "Joao", 10.05);
c4.MostrarAtributos();

Console.WriteLine("Quantidade de instância: "+ Conta.Contador);
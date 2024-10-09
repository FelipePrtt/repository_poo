// Método Main()

using EncapsulamentoFuncionario;
/* exemplo de encapsulamento mais detalhado e parecido
com Java e PHP
Funcionario f1 = new Funcionario();
f1.setCodigo(1);
System.Console.WriteLine("Codigo: " + f1.getCodigo());

Funcionario chuchu = new Funcionario();
chuchu.setCodigo(9);
System.Console.WriteLine("Codigo: " + chuchu.getCodigo());
*/
Funcionario f1 = new Funcionario();
f1.Codigo = 1;//aqui é executado o método set
Console.WriteLine("Codigo: " + f1.Codigo);// aqui chama get
f1.Nome = "Ana";
f1.Salario = 100;
Console.WriteLine("Nome: " + f1.Nome);// aqui chama get
Console.WriteLine("Salário: " + f1.Salario);// aqui chama get
//if (f1.Codigo == 3)

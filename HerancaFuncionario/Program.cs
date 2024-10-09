//main

using HerancaFuncionario;

Funcionario f = new Funcionario(1,"Ana", 1000);
f.MostrarAtributos();
Console.WriteLine($"Bonificação: {f.CalcularBonificacao():c}\n");

Secretario s = new Secretario(2,"Lia", 1000);
s.MostrarAtributos();
Console.WriteLine($"Bonificação: {s.CalcularBonificacao():c}\n");

Gerente g = new Gerente(3,"Marcos",1000);
g.MostrarAtributos();
Console.WriteLine($"Bonificação: {g.CalcularBonificacao():c}\n");

Diretor d = new Diretor(4,"Leo",1000);
d.MostrarAtributos();
Console.WriteLine($"Bonificação: {d.CalcularBonificacao():c}\n");
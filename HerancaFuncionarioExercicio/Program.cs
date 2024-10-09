//main

using HerancaFuncionarioExercicio;

GerenciadorBonificacao g = new GerenciadorBonificacao();

Funcionario funcionario = new Funcionario(1,"Ana", 1000);
g.TotalizadorBonificacao(funcionario);
Console.WriteLine(g.TotalBonificacao);

Secretario secretario = new Secretario(2,"Lia", 1000);
g.TotalizadorBonificacao(secretario);
Console.WriteLine(g.TotalBonificacao);

Gerente gerente = new Gerente(3,"Marcos",1000);
g.TotalizadorBonificacao(gerente);
Console.WriteLine(g.TotalBonificacao);

Diretor diretor = new Diretor(4,"Leo",1000);
g.TotalizadorBonificacao(diretor);
Console.WriteLine(g.TotalBonificacao);

Console.WriteLine($"Valor total das bonificações: {g.TotalBonificacao}");
//main

using InterfaceTributavel;

ITributavel itr;
TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

ContaCorrente ct = new ContaCorrente(10000);
itr = ct;
Console.WriteLine($"Valor dos tributos a serem pagos pela Conta Corrente: R$ {itr.CalcularTributos()}");
totalizador.Adicionar(itr);


SeguroDeVida sv = new SeguroDeVida();
itr = sv;
Console.WriteLine($"Valor dos tributos a serem pagos pelo Seguro de Vida: R$ {itr.CalcularTributos()}"); 
totalizador.Adicionar(itr);


Console.WriteLine($"Total de tributos acumulados: R${totalizador.Total}");
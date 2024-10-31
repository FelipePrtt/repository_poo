//main

using InterfaceTributavel;


ContaCorrente ct = new ContaCorrente();
ct.Saldo = 100;
ITributavel itr = ct;
Console.WriteLine($"Valor dos tributos a serem pagos pela Conta Corrente: R$ {itr.CalcularTributos(1000)}");


SeguroDeVida sv = new SeguroDeVida();
itr = sv;
Console.WriteLine($"Valor dos tributos a serem pagos pelo Seguro de Vida: R$ {itr.CalcularTributos(0)}"); 
/*
No calcular tributos do Seguro de Vida pode ser colocado qualquer valor no parametro, 
pois ele n será usado no calculo, 
apenas está aqui para que as necessidades do sistema sejam atendidas
*/
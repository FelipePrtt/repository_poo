//main

using ComposicaoBanco;

Banco banc = new Banco("MEU BANCO");

banc.AbrirContaCorrente(100, 1000);
banc.AbrirContaPoupanca(200);



Console.WriteLine("\nContas Correntes do banco "+banc.Nome);
foreach (ContaCorrente conta in banc.Contas)
{
    Console.WriteLine($"\nSaldo: R${conta.Saldo:C}, Cheque Especial: R${conta.ChequeEspecial:C}");
}

Console.WriteLine("\nContas Poupança do banco "+banc.Nome);
foreach (Poupanca poupanca in banc.Poups)
{
    Console.WriteLine($"\nSaldo: R${poupanca.Saldo:C}");
}



banc.Contas[0].Sacar(100);
banc.Contas[0].Depositar(50);

banc.Poups[0].Sacar(100);
banc.Poups[0].Depositar(50);



Console.WriteLine("\nContas Correntes do banco "+banc.Nome);
foreach (ContaCorrente conta in banc.Contas)
{
    Console.WriteLine($"\nSaldo: R${conta.Saldo:C}, Cheque Especial: R${conta.ChequeEspecial:C}");
}

Console.WriteLine("\nContas Poupança do banco "+banc.Nome);
foreach (Poupanca poupanca in banc.Poups)
{
    Console.WriteLine($"\nSaldo: R${poupanca.Saldo:C}");
}



banc = null;
GC.Collect();

//Por algum motivo os console.write dos destrutores não aparecem, então chamei novamente os foreachs para verificar se existem as contas correntes e poupanças
foreach (ContaCorrente conta in banc.Contas)
{
    Console.WriteLine($"\nSaldo: R${conta.Saldo:C}, Cheque Especial: R${conta.ChequeEspecial:C}");
}
foreach (Poupanca poupanca in banc.Poups)
{
    Console.WriteLine($"\nSaldo: R${poupanca.Saldo:C}");
}
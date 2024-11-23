//main

using SOLIDSRP;

//Criação de gerador de relatorio, validador de usuario e um objeto Conta
GeradorRelatorio gerador = new GeradorRelatorio();
ValidarUsuario validador = new ValidarUsuario();
Conta conta = new Conta("Marcos");
conta.Deposito(200);
conta.Sacar(50);

//Etapa de validação da conta
Console.WriteLine("Informe o nome do usuárío que desej valida: ");
string nomeAValidar = Console.ReadLine();
if (validador.ValidarTitular(conta.Titular, nomeAValidar))
{
    Console.WriteLine("O titular da conta é válido");
    Console.WriteLine(gerador.GerarRelatorio(conta.Titular, conta.Saldo));
}
else
{
    Console.WriteLine("O titular da conta não é válido");
}
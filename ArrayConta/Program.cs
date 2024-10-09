// Método Main()

using ArrayConta;

//declarar o vetor de objetos
Conta[] vetContas = new Conta[3];

//manipular o vetor instanciando e cadastrando
for (int i = 0; i < vetContas.Length; i++)
{
    vetContas[i] = new Conta();
    Console.Write("Cadastre o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetContas)
    c.MostrarAtributos();
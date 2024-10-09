// Método Main()

using ArrayFuncionario;

//Criar um vetor de 3 elementos
//Cadastrar/digitar
//declarar o vetor de objetos
Funcionario[] vetF = new Funcionario[3];
double soma = 0;
//manipular o vetor instanciando e cadastrando
for (int i = 0; i < vetF.Length; i++)
{
    vetF[i] = new Funcionario();
    Console.Write("Cadastre o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Cadastre o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
    soma = soma + vetF[i].salario; 
}

Console.WriteLine($"Total {soma:c}");

foreach (Funcionario f in vetF)
    f.MostrarAtributos();

bool achei = false;
foreach (Funcionario f in vetF)
    if (f.salario == 100)
        achei = true;

if (achei) //(achei == true)       
    Console.WriteLine("Funcionário encontrado!");
else
    Console.WriteLine("Funcionário não encontrado!");


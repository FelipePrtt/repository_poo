// função main()
//abre a comunicação entre arquivos
using ClasseFuncionario;
//instanciar objeto para conseguir cadastrar algo
Funcionario f1 = new Funcionario();

Console.Write("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.nome = Console.ReadLine();
Console.Write("Digite o salário: ");
f1.salario = Convert.ToDouble(Console.ReadLine()); 
f1.MontraAtributos();//enviando uma mensagem
f1.CalcularAumento(5);
f1.MontraAtributos();

Funcionario f2 = new Funcionario();
Console.Write("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f2.nome = Console.ReadLine();
Console.Write("Digite o salário: ");
f2.salario = Convert.ToDouble(Console.ReadLine()); 
f2.MontraAtributos();//enviando uma mensagem
f2.CalcularAumento(7);
f2.MontraAtributos();
double somaSalarios = f1.salario + f2.salario;
System.Console.WriteLine("Total R$ " + somaSalarios);

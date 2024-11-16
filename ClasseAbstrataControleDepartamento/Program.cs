//main

using ClasseAbstrataControleDepartamento;

int op = 1;
List<Departamento> departamentos = new List<Departamento>();

while (op != 0 && op <= 7)
{
    Console.WriteLine("1 - Cadastrar Departamento");
    Console.WriteLine("2 - Cadastrar Funcionário");
    Console.WriteLine("3 - Listar Funcionários");
    Console.WriteLine("4 - Demitir Funcionário");
    Console.WriteLine("5 - Gerar Folha de Pagamento");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("Selecione a operação");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.Write("Digite o código do departamento: ");
            int codigoDepartamento = Convert.ToInt32(Console.ReadLine());
            Departamento dep = new Departamento(codigoDepartamento, nomeDepartamento);
            departamentos.Add(dep);
            Console.WriteLine("Departamento cadastrado com sucesso.");
            break;
    
        case 2:
            // Coleta as informações básicas do funcionário, usadas futuramente para criar a instância
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            double salarioFuncionario = Convert.ToDouble(Console.ReadLine());

            // Informações do endereço do funcionario
            Console.Write("Digite o bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Digite a rua: ");
            string rua = Console.ReadLine();
            Console.Write("Digite o número: ");
            string numero = Console.ReadLine();
            Console.Write("Digite a cidade: ");
            string cidade = Console.ReadLine();
            // Cria uma instância do tipo Endereço que recebe os valores, usada futuramente para criar uma instância do funcionário
            Endereco enderecoFuncionario = new Endereco(rua, numero, bairro, cidade);

            // Selecionar o tipo de funcionário
            Console.Write("Digite o tipo de funcionário (1 - Assalariado, 2 - Comissionado): ");
            int tipoFuncionario = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario; // Declare a variável aqui
            if (tipoFuncionario == 1)
            {
                funcionario = new Assalariado(nomeFuncionario, salarioFuncionario, enderecoFuncionario);
            }
            else
            {
                funcionario = new Comissionado(nomeFuncionario, salarioFuncionario, enderecoFuncionario);
            }

            // Selecionar o departamento que o funcionário pertence
            Console.Write("Digite o código do departamento para adicionar o funcionário: ");
            int codigoDep = Convert.ToInt32(Console.ReadLine());
            bool departamentoEncontrado = false; // Variável para rastrear se o departamento foi encontrado

            foreach (Departamento departamento in departamentos) // Renomeie 'dep' para 'departamento'
            {
                if (departamento.Codigo == codigoDep) // Use a propriedade pública Codigo
                {
                    departamento.admitirFuncionario(funcionario);
                    Console.WriteLine("Funcionário cadastrado com sucesso.");  
                    departamentoEncontrado = true; // Marca que o departamento foi encontrado
                    break; // Sai do loop, pois já encontramos o departamento
                }
            }

            if (!departamentoEncontrado) // Se não encontrou nenhum departamento correspondente
            {
                Console.WriteLine("Departamento não encontrado.");
            }
            break;

        case 3:
            Console.Write("Digite o código do departamento para listar os funcionários: ");
            int codigoDepListar = Convert.ToInt32(Console.ReadLine());
            var depListar = departamentos.Find(d => d.Codigo == codigoDepListar);
            if (depListar != null)
            {
                depListar.listaFuncionarios();
            }
            else
            {
                Console.WriteLine("Departamento não encontrado.");
            }
            break;

        case 4:
            Console.Write("Digite o código do departamento para demitir um funcionário: ");
            int codigoDepDemitir = Convert.ToInt32(Console.ReadLine());
            var depDemitir = departamentos.Find(d => d.Codigo == codigoDepDemitir);
            if (depDemitir != null)
            {
                Console.Write("Digite o código do funcionário a ser demitido: ");
                int codigoFuncionarioDemitir = Convert.ToInt32(Console.ReadLine());
                depDemitir.demitirFuncionario(codigoFuncionarioDemitir);
            }
            else
            {
                Console.WriteLine("Departamento não encontrado.");
            }
            break;

        case 5:
            Console.Write("Digite o código do departamento para gerar a folha de pagamento: ");
            int codigoDepFolha = Convert.ToInt32(Console.ReadLine());
            var depFolha = departamentos.Find(d => d.Codigo == codigoDepFolha);
            if (depFolha != null)
            {
                Console.Write("Digite o número de dias úteis: ");
                int diasUteis = Convert.ToInt32(Console.ReadLine());
                double totalFolha = depFolha.calcularFolhaPagamento(diasUteis);
                Console.WriteLine($"Total da folha de pagamento: R$ {totalFolha}");
            }
            break;
    }
}
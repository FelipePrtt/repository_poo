//main

using ClasseAbstrataControleDepartamento;

//Inicizalização de instâncias para facilitar os testes

//Departamentos
Departamento departamento1 = new Departamento(1, "Estoque");
Departamento departamento2 = new Departamento(2, "RH");

List<Departamento> departamentos = new List<Departamento>();
departamentos.Add(departamento1);
departamentos.Add(departamento2);

int op = 1;
while (op != 0 && op <= 9)
{   
    Console.Clear();

    Console.WriteLine("1 - Cadastrar Departamento");
    Console.WriteLine("2 - Cadastrar Funcionário");
    Console.WriteLine("3 - Listar Funcionários");
    Console.WriteLine("4 - Demitir Funcionário");
    Console.WriteLine("5 - Gerar Folha de Pagamento");
    Console.WriteLine("6 - Total de Dependentes");
    Console.WriteLine("7 - Cadastrar Dependente");
    Console.WriteLine("8 - Remover Dependente");
    Console.WriteLine("9 - Listar Dependentes");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("Selecione a operação");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {   

        // Cada console.Clear() é apenas para melhor vizualização estética no prompt

        case 1:
            //Adicionar um departamento
            Console.Clear();
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.Write("Digite o código do departamento: ");
            int codigoDepartamento = Convert.ToInt32(Console.ReadLine());
            Departamento dep = new Departamento(codigoDepartamento, nomeDepartamento);
            departamentos.Add(dep);
            Console.WriteLine("Departamento cadastrado com sucesso.");
            break;
    
        case 2:
            Console.Clear();

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
            
            // Procura em todos os departamentos por algum com o código correspondente
            foreach (Departamento departamento in departamentos) 
            {
                if (departamento.Codigo == codigoDep) 
                {
                    departamento.admitirFuncionario(funcionario);
                    Console.WriteLine("Funcionário cadastrado com sucesso.");  
                    departamentoEncontrado = true; 
                    break; 
                }
            }

            // Se não encontrou nenhum departamento
            if (!departamentoEncontrado) 
            {
                Console.WriteLine("Departamento não encontrado.");
            }
            break;

        case 3:
            Console.Clear();

            // Primeiro busca o departamento que ira ser buscado o funcionário
            Console.Write("Digite o código do departamento para listar os funcionários: ");
            int codigoDepLista = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach(Departamento depLista in departamentos)
            {
                if (codigoDepLista == depLista.Codigo)
                {
                    depLista.listaFuncionarios();
                    departamentoEncontrado = true;
                    break;
                }
            }
            //Exibe mensagem caso o departamento não seja encontrado
            if (!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado.");
            }
            break;

        case 4:
            Console.Clear();
            
            // Primeiro localiza o departamento onde será removido o funcionario
            Console.Write("Digite o código do departamento para demitir um funcionário: ");
            int codigoDepDemitir = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach  (Departamento d in departamentos)
            {
                if (codigoDepDemitir == d.Codigo)
                {
                    Console.Write($"Informe o código do funcionário: ");
                    int codigoFuncionarioDemitir = Convert.ToInt32(Console.ReadLine());
                    d.demitirFuncionario(codigoFuncionarioDemitir);
                    departamentoEncontrado = true;
                    break;
                }      
            }
            if (!departamentoEncontrado)
            {
                Console.WriteLine($"Departamento não encontrado!");
            } 
            break;

        case 5:
            Console.Clear();

            // Escolhe o departamento para gerar a folha de pagamento
            Console.Write("Digite o código do departamento para gerar a folha de pagamento: ");
            int codigoDepFolha = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach (Departamento d in departamentos)
            {
                if (codigoDepFolha == d.Codigo)
                {
                    Console.WriteLine("Digite o número de dias úteis: ");
                    int diasUteis = Convert.ToInt32(Console.ReadLine());
                    double totalFolha = d.calcularFolhaPagamento(diasUteis);
                    Console.WriteLine($"Total da folha de pagamento: R${totalFolha:F2}");
                    departamentoEncontrado = true;
                    break;
                }
            }
            if (!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado!");
            }
            break;

        case 6:
            Console.Clear();

            //Escolhe o departamento que o funcionário se encontra
            Console.WriteLine("Digite o código do departamento que o funcionário trabalha: ");
            int codigoDepFuncionario = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach (Departamento d in departamentos)
            {
                if (codigoDepFuncionario == d.Codigo)
                {
                    //Se o departamento foi encontrado, agora busa o funcionário pelo código.
                    Console.WriteLine("Digite o código do funcionário: ");
                    int codigoFuncionario = Convert.ToInt32(Console.ReadLine());

                    foreach (Funcionario f in d.VetFuncionarios)
                    {
                        if (codigoFuncionario == f.Codigo)
                        {
                            Console.WriteLine($"O total de dependentes do funcionário é: {f.calcularTotalDependentes()}");
                            break;
                        }
                    }
                    departamentoEncontrado = true;
                    break;
                }
            }
            if(!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado!");
            }
            break;

        case 7:
            Console.Clear();
            //Instância do dependente
            Console.Write("Informe o nome do dependente: ");
            string dependenteNome = Console.ReadLine();
            Console.Write("Informe a idade do dependente: ");
            int dependenteIdade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o código do dependente: ");
            int dependenteCodigo = Convert.ToInt32(Console.ReadLine());
            Dependente dependente = new Dependente(dependenteNome, dependenteIdade, dependenteCodigo);

            //Escolhe o departamento que o funcionário se encontra
            Console.WriteLine("Digite o código do departamento que o funcionário trabalha: ");
            codigoDepFuncionario = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach (Departamento d in departamentos)
            {
                if (d.Codigo == codigoDepFuncionario)
                {
                    departamentoEncontrado = true;
                    //Busca pelo funcionárionario que receberá o dependente
                    Console.WriteLine("Digite o código do funcionário: ");
                    int codigoFuncionario = Convert.ToInt32(Console.ReadLine());

                    foreach (Funcionario f in d.VetFuncionarios)
                    {
                        if (f.Codigo == codigoFuncionario)
                        {
                            f.cadastrarDependente(dependente);
                            break;
                        }
                    }
                    break;
                }
            }
            if(!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado!");
            }
            break;

        case 8:
            Console.Clear();

            //Verifica o departamento que o funcionário está
            Console.WriteLine("Digite o código do departamento que o funcionário trabalha: ");
            codigoDepFuncionario = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach (Departamento d in departamentos)
            {
                if (d.Codigo == codigoDepFuncionario)
                {
                    departamentoEncontrado = true;
                    //Busca pelo funcionários responsável pelo dependente
                    Console.WriteLine("Digite o código do funcionário responsável: ");
                    int codigoFuncionario = Convert.ToInt32(Console.ReadLine());
                    
                    foreach (Funcionario f in d.VetFuncionarios)
                    {
                        if (f.Codigo == codigoFuncionario)
                        {
                            //Informa o dependente
                            Console.WriteLine("Digite o código do dependente: ");
                            int codigoDependente = Convert.ToInt32(Console.ReadLine());
                            f.removerDependente(codigoDependente);
                            break;
                        }
                    }
                    break;
                }
            }
            if(!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado!");
            }
            break;
        case 9:
            Console.Clear();

            //Verifica o departamento que o funcionário está
            Console.WriteLine("Digite o código do departamento que o funcionário trabalha: ");
            codigoDepFuncionario = Convert.ToInt32(Console.ReadLine());
            departamentoEncontrado = false;

            foreach (Departamento d in departamentos)
            {
                if (d.Codigo == codigoDepFuncionario)
                {
                    departamentoEncontrado = true;

                    //Buscar pelo funcionário responsável pelo(s) dependente(s)
                    Console.WriteLine("Digite o código do funcionário responsável: ");
                    int codigoFuncionario = Convert.ToInt32(Console.ReadLine());
                    foreach (Funcionario f in d.VetFuncionarios)
                    {
                        if (f.Codigo == codigoFuncionario)
                        {
                            f.listarDependentes();
                            break;
                        }
                    }
                    break;
                }
            }
            if(!departamentoEncontrado)
            {
                Console.WriteLine("Departamento não encontrado!");
            }
            break;
    }   
    Console.ReadLine();
}
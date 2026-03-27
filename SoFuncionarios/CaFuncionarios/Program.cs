// See https://aka.ms/new-console-template for more information

using CaFuncionarios;
using System;
using System.Linq;

Console.Title = "Cadastro de Funcionários";
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;

List<Funcionarios> funcionarios = new List<Funcionarios>();

try
{
    int opcao = 0;
    do
    {
        Console.Clear();

        Funcionarios funcionario;

        Console.WriteLine(Console.Title);
        Console.WriteLine("Escolha uma das opções abaixo:" +
            "\n1. Cadastrar funcionário" +
            "\n2. Listar funcionários" +
            "\n3. Editar funcionário" +
            "\n4. Consultar funcionário" +
            "\n5. Excluir funcionário" +
            "\n0. Sair");

        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1://cadastrar funcionario
                Console.Clear();
                funcionario = new Funcionarios();

                Console.WriteLine("Cadastrar um Funcionario");
                Console.WriteLine("Informe a matricula");
                int novaMatricula = int.Parse(Console.ReadLine()!);

                if (funcionarios.Any(f => f.Matricula == novaMatricula))//verificar matricula já existente
                {
                    Console.WriteLine("Já existe um funcionário com essa matrícula!");
                    break;
                }

                funcionario.Matricula = novaMatricula;

                Console.WriteLine("Informe o nome:");
                funcionario.Nome = Console.ReadLine()!;
                Console.WriteLine("Informe o endereço:");
                funcionario.Endereco = Console.ReadLine()!;
                Console.WriteLine("Informe a cidade:");
                funcionario.Cidade = Console.ReadLine()!;
                Console.WriteLine("Informe o estado:");
                funcionario.Uf = Console.ReadLine()!;
                Console.WriteLine("Informe o CEP:");
                funcionario.Cep = Console.ReadLine()!;
                Console.WriteLine("Informe o CPF:");
                funcionario.Cpf = Console.ReadLine()!;
                Console.WriteLine("Informe o telefone:");
                funcionario.Telefone = Console.ReadLine()!;
                Console.WriteLine("Informe o email:");
                funcionario.Email = Console.ReadLine()!;
                Console.WriteLine("Informe a Data de Nascimento (dd/mm/aaaa):");
                funcionario.DataNasc = DateTime.Parse(Console.ReadLine()!);

                funcionarios.Add(funcionario);
                Console.WriteLine("Funcionário cadastrado com sucesso!");
                break;

            case 2://listar funcionario
                Console.Clear();
                Console.WriteLine("Listagem dos Funcionarios");

                if (funcionarios.Count == 0)
                {
                    Console.WriteLine("Nenhum funcionário cadastrado.");
                }
                else
                {
                    foreach (var item in funcionarios)
                    {
                        Console.WriteLine(item.ToString() + "\n");
                    }
                }
                break;

            case 3://editar funcionario
                Console.Clear();
                Console.WriteLine("Alterando Funcionario");
                Console.WriteLine("Informe a matricula desejada:");
                int mat = int.Parse(Console.ReadLine()!);

                bool naoAchou = true;

                foreach (var func in funcionarios)
                {
                    if (func.Matricula == mat)
                    {
                        naoAchou = false;

                        Console.WriteLine("Informe o nome:");
                        func.Nome = Console.ReadLine()!;
                        Console.WriteLine("Informe o endereço:");
                        func.Endereco = Console.ReadLine()!;
                        Console.WriteLine("Informe a cidade:");
                        func.Cidade = Console.ReadLine()!;
                        Console.WriteLine("Informe o estado:");
                        func.Uf = Console.ReadLine()!;
                        Console.WriteLine("Informe o CEP:");
                        func.Cep = Console.ReadLine()!;
                        Console.WriteLine("Informe o CPF:");
                        func.Cpf = Console.ReadLine()!;
                        Console.WriteLine("Informe o telefone:");
                        func.Telefone = Console.ReadLine()!;
                        Console.WriteLine("Informe o email:");
                        func.Email = Console.ReadLine()!;
                        Console.WriteLine("Informe a Data de Nascimento:");
                        func.DataNasc = DateTime.Parse(Console.ReadLine()!);

                        Console.WriteLine("Alterado com sucesso!");
                        break;
                    }
                }

                if (naoAchou)
                {
                    Console.WriteLine("Usuário não encontrado");
                }
                break;

            case 4://consulta
                Console.Clear();
                Console.WriteLine("Consulta do Funcionario");
                Console.WriteLine("Informe a matricula que deseja consultar: ");
                int con = int.Parse(Console.ReadLine()!);

                bool encontrou = false;

                foreach (var item in funcionarios)
                {
                    if (item.Matricula == con)
                    {
                        Console.WriteLine(item.ToString() + "\n");
                        encontrou = true;
                    }
                }

                if (!encontrou)
                {
                    Console.WriteLine("Funcionário não encontrado.");
                }
                break;

            case 5://excluir
                Console.Clear();
                Console.WriteLine("Excluir Funcionário");
                Console.WriteLine("Informe a matrícula que deseja excluir: ");
                int matriculaExcluir = int.Parse(Console.ReadLine()!);

                Funcionarios? funcionarioRemover = null;

                foreach (var func in funcionarios)
                {
                    if (func.Matricula == matriculaExcluir)
                    {
                        funcionarioRemover = func;
                        break;
                    }
                }

                if (funcionarioRemover != null)//confirmar exclusão
                {
                    Console.Clear();
                    Console.WriteLine("Confira os dados do funcionário:\n");

                    Console.WriteLine($"Matrícula: {funcionarioRemover.Matricula}");
                    Console.WriteLine($"Nome: {funcionarioRemover.Nome}");
                    Console.WriteLine($"CPF: {funcionarioRemover.Cpf}");
                    Console.WriteLine($"Email: {funcionarioRemover.Email}");
                    Console.WriteLine($"Telefone: {funcionarioRemover.Telefone}");

                    Console.WriteLine("\nDigite novamente a matrícula para confirmar a exclusão:");
                    int confirmacaoMatricula = int.Parse(Console.ReadLine()!);

                    if (confirmacaoMatricula == funcionarioRemover.Matricula)
                    {
                        funcionarios.Remove(funcionarioRemover);
                        Console.WriteLine("Funcionário removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Matrícula não confere. Exclusão cancelada.");
                    }
                }
                else
                {
                    Console.WriteLine("Funcionário não encontrado.");
                }
                break;

            case 0:
                Console.WriteLine("Até Breve!");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

    } while (opcao != 0);
}
catch (Exception ex)
{
    Console.WriteLine("Aconteceu um erro: \n" + ex.Message);
}
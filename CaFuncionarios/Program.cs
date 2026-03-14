// See https://aka.ms/new-console-template for more information

using CaFuncionarios;

Console.Title = "Cadastro de Funcionários";
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;

try
{
    do
    {
        Console.Clear();

        Funcionarios funcionario;

        Console.WriteLine(Console.Title);
        Console.WriteLine("Escolha uma das opções abaixo:" +
            "\n1. Cadastrar funcionário" +
            "\n2. Listar funcionário" +
            "\n3. Editar funcionário" +
            "\n4. Consultar funcionário" +
            "\n5. Excluir funcionário" +
            "\n0. Sair");
        //Continuaremos aqui
    }
    while (true);
}
catch (Exception ex)
{

    Console.WriteLine("Aconteceu um erro: \n" + ex.Message);
}
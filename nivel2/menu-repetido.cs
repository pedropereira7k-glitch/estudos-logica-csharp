using System;

bool menu = true;

while (menu)
{
    Console.WriteLine("=== Clínica Central ===");
    Console.WriteLine("1. Consulta");
    Console.WriteLine("2. Exame");
    Console.WriteLine("3. Retorno");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    //Força o usuário digitar um número inteiro e que esteja entre 1 e 4
    int opcao;
    while (!int.TryParse(Console.ReadLine(), out opcao) || 
    opcao < 1 
    || opcao > 4)
    {
        Console.Write("Digite uma opção que esteja entre 1 e 4: ");
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Dirija-se ao setor de consultas.");
            break;

        case 2:
            Console.WriteLine("Dirija-se ao setor de exames.");
            break;

        case 3:
            Console.WriteLine("Dirija-se ao setor de retorno.");
            break;
        case 4:
            Console.WriteLine("Encerrando o sistema.");
            menu = false;
            break;
    }
    Console.WriteLine();
}
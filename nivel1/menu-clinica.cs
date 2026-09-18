using System;

Console.WriteLine("=== Clínica Central ===");
Console.WriteLine("1. Consulta");
Console.WriteLine("2. Exame");
Console.WriteLine("3. Retorno");
Console.WriteLine("4. Sair");


Console.Write("Escolha uma opção: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao){
  case 1:
    Console.WriteLine("Você selecionou: Consulta");
    Console.WriteLine("Dirija-se ao setor de consultas.");
    break;
  case 2:
    Console.WriteLine("Você selecionou: Exame");
    Console.WriteLine("Dirija-se ao setor de exames.");
    break;
  case 3:
    Console.WriteLine("Você selecionou: Retorno");
    Console.WriteLine("Dirija-se ao setor de retorno.");
    break;
  case 4:
    Console.WriteLine("Encerrando o sistema.");
    break;
  default:
    Console.WriteLine("Opção inválida.");
    break;
}
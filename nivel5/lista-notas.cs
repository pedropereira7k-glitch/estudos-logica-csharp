using System;
using System.Collections.Generic;
using System.Globalization;


List<double> notas = new List<double>();

bool rodando = true;

Console.WriteLine("=== Gerenciador de Notas ===");
while (rodando)
{
    Console.WriteLine("1. Adicionar nota");
    Console.WriteLine("2. Remover nota");
    Console.WriteLine("3. Exibir notas");
    Console.WriteLine("4. Sair");
    Console.WriteLine("Escolha: ");

    int opcao;

    while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
    {
        Console.Write("Digite uma opção que esteja entre 1 e 4: ");
    }
    switch (opcao)
    {
        case 1:
            Console.Write("Nota: ");
            if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double novaNota))
            {
                notas.Add(novaNota);
                Console.WriteLine("Nota adicionada.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            break;
        case 2:
            Console.Write("Nota a remover: ");
            if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double notaRemover))
            {
                if (notas.Remove(notaRemover))
                {
                    Console.WriteLine("Nota removida.");
                }
                else
                {
                    Console.WriteLine("Nota não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida");
            }
            break;
        case 3:
            if (notas.Count == 0)
            {
                Console.WriteLine("Nenhuma nota cadastrada.");
            }
            else
            {
                Console.Write("Notas: ");
                foreach (double nota in notas)
                {
                    Console.Write($"{nota} ");
                }
                Console.WriteLine("\n");
            }
            break;
        case 4:
            Console.WriteLine("Encerrando.");
            rodando = false;
            break;
    }
}
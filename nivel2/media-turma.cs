using System;

Console.Write("Quantidade de alunos: ");

if (int.TryParse(Console.ReadLine(), out int alunos) && alunos > 0)
{
    double somaNotas = 0; // Antes do for
    Console.WriteLine();
    for (int i = 1; i <= alunos; i++)
    {
        Console.Write($"Nota do aluno {i}: ");

        double nota = double.Parse(Console.ReadLine()); // Dentro do for

        somaNotas += nota; // Dentro do for
    }

    double media = somaNotas / alunos; // Depois do for
    Console.WriteLine();
    Console.WriteLine($"Média da turma: {media:F2}"); // Depois do for
}
else
{
    Console.WriteLine("Entrada inválida.");
}

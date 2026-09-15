using System;

Console.Write("Quantidade de alunos: ");

if (int.TryParse(Console.ReadLine(), out int qtdAlunos) && qtdAlunos > 0)
{

    Console.WriteLine();

    double somaNotas = CadastrarNotasAlunos(qtdAlunos);

    Console.WriteLine();

    double media = CalcularMedia(somaNotas, qtdAlunos);

    ExibirMedia(media);
}
else
{
    Console.WriteLine("Entrada inválida.");
}

double CadastrarNotasAlunos(int qtdAlunos)
{

    double somaNotas = 0;

    for (int i = 1; i <= qtdAlunos; i++)
    {
        Console.Write($"Nota do aluno {i}: ");

        double nota = double.Parse(Console.ReadLine());

        somaNotas += nota;
    }
    return somaNotas;
}

double CalcularMedia(double somaNotas, int qtdAlunos)
{
    return somaNotas / qtdAlunos;
}

void ExibirMedia(double media)
{
    Console.WriteLine($"Média da turma: {media:F2}");
}
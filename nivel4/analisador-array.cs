using System;
using System.Globalization;

double[] notas = new double[5];

Console.WriteLine("=== Analisador de Notas ===");

PreencherArray(notas);
double somaNotas = CalcularNotas(notas);
double media = CalcularMedia(somaNotas, notas.Length);
double maiorNota = EncontrarMaior(notas);
double menorNota = EncontrarMenor(notas);
Console.WriteLine();
ExibirResultado(somaNotas, media, maiorNota, menorNota);
void PreencherArray(double[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write($"Nota do aluno {i + 1}: ");
        notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}

double CalcularNotas(double[] notas)
{
    double somaNotas = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        somaNotas += notas[i];
    }
    return somaNotas;
}

double CalcularMedia(double somaNotas, int qtdAlunos)
{
    return somaNotas / qtdAlunos;
}

double EncontrarMaior(double[] notas)
{
    double maiorNota = notas[0];

    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > maiorNota)
        {
            maiorNota = notas[i];
        }
    }
    return maiorNota;
}

double EncontrarMenor(double[] notas)
{
    double menorNota = notas[0];

    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] < menorNota)
        {
            menorNota = notas[i];
        }
    }
    return menorNota;
}

void ExibirResultado(double somaNotas, double media, double maiorNota, double menorNota)
{
    Console.WriteLine("=== Resultados ===");
    Console.WriteLine($"Soma: {somaNotas:F2}");
    Console.WriteLine($"Média: {media:F2}");
    Console.WriteLine($"Maior nota: {maiorNota:F2}");
    Console.WriteLine($"Menor nota: {menorNota:F2}");
}
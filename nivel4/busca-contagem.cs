using System;
using System.Globalization;

double[] notas = new double[5];
Console.WriteLine("=== Sistemas notas ===");
PreencherArray(notas);

Console.Write("Digite a nota que deseja buscar: ");
double notaBuscada = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

int[] posicoes = new int[notas.Length];
int ocorrencia = 0;

// Percorre o vetor "notas" do início ao fim (índice 0 até o último).
// A cada iteração, compara o elemento atual com "notaBuscada".
// Se forem iguais, salva a posição (i + 1, pois posições começam em 1)
// no vetor "posicoes" e incrementa o contador de ocorrências.
for (int i = 0; i < notas.Length; i++)
{
    if (notaBuscada == notas[i])
    {
        posicoes[ocorrencia] = i + 1; // converte índice 0-based para posição 1-based
        ocorrencia++;
    }
}
if (ocorrencia > 0)
{
    Console.WriteLine($"Nota {notaBuscada:F2} encontrada {ocorrencia} vezes.");
    Console.Write("Posições: ");
    // Percorre apenas as casas preenchidas do vetor posicoes
    for (int i = 0; i < ocorrencia; i++)
    {
        // Imprime a posição guardada
        Console.Write(posicoes[i]);
        // Imprime vírgula entre os valores, mas não no último
        if (i < ocorrencia - 1)
        {
            Console.Write(", ");
        }
    }
}
else
{
    Console.WriteLine($"Nota {notaBuscada:F2} não encontrada.");
}
void PreencherArray(double[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write($"Nota do aluno {i + 1}: ");
        notas[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
    }
}
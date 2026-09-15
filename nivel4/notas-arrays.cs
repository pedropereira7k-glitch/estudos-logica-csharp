using System;
using System.Globalization;
using System.Net.WebSockets;

double[] notas = new double[5];

Console.WriteLine("=== Registro de Notas ===");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Nota do aluno {i + 1}: ");
    notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine();
Console.WriteLine("=== Notas Registrads ===");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Aluno {i + 1}: {notas[i]}");
}
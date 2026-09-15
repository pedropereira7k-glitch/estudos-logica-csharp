using System;
using System.Globalization;

Console.Write("Peso(kg): ");
double peso = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

Console.Write("Altura(m): ");
double altura = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

// Cálculo do IMC
double imc = peso / (altura * altura);

// Exibição dos resultados
Console.WriteLine($"\nPeso (kg): {peso}");
Console.WriteLine($"Altura (m): {altura}");
Console.WriteLine($"IMC: {imc:F2}"); // F2 força 2 casas decimais
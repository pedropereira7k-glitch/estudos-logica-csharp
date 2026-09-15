using System;

Console.WriteLine("=== Calculadora ===");

Console.Write("Digite o primeiro número: ");
bool numero1Valido = double.TryParse(Console.ReadLine(), out double numero1);

Console.Write("Digite o segundo número: ");
bool numero2Valido = double.TryParse(Console.ReadLine(), out double numero2);

if (numero1Valido && numero2Valido)
{
    Console.WriteLine();
    Console.WriteLine($"Soma: {Somar(numero1, numero2)}");
    Console.WriteLine($"Subtração: {Subtrair(numero1, numero2)}");
    Console.WriteLine($"Multiplicação: {Multiplicar(numero1, numero2)}");

    if (numero2 != 0)
    {
        Console.WriteLine($"Divisão: {Dividir(numero1, numero2):F2}");
    }
    else
    {
        Console.WriteLine("Divisão por zero não é permitida.");
    }
}

else
{
    Console.WriteLine("Entrada inválida.");
}

double Somar(double numero1, double numero2)
{
    return numero1 + numero2;
}

double Subtrair(double numero1, double numero2)
{
    return numero1 - numero2;
}

double Multiplicar(double numero1, double numero2)
{
    return numero1 * numero2;
}

double Dividir(double numero1, double numero2)
{
    return numero1 / numero2;
}
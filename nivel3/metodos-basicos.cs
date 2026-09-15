using System;

void ExibirCabecalho()
{
    Console.WriteLine("=== Tabuada Completa ===");
}

void ExibirTabuada(int numero)
{
    Console.WriteLine($"Tabuada do {numero}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{numero} x {j} = {numero * j}");
    }
}

ExibirCabecalho();

for (int i = 1; i <= 10; i++)
{
    ExibirTabuada(i);
}
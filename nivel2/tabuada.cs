using System;

Console.Write("Digite um número: ");

if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (numero < 0)
    {
        Console.WriteLine("Apenas número positivos.");
    }
    else
    {
        for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    } 
    }
}
else
{
    Console.WriteLine("Valor inválido. Digite apenas números inteiros.");
}
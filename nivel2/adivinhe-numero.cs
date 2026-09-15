using System;

Console.WriteLine("=== Adivinhe o número ===");
Console.WriteLine("O número secreto está entre 1 e 20.");

Random random = new Random();
int numeroSecreto = random.Next(1, 21);
int tentativas = 0;
//Palpite começa em zero. Entradas inválidas não contam como tentativas.
int palpite = 0;
do
{
    Console.Write("Digite seu palpite: ");
    if (int.TryParse(Console.ReadLine(), out palpite))
    {

        tentativas++;
        if (palpite < numeroSecreto)
        {
            Console.WriteLine("Muito baixo! Tente novamente.");
        }
        else if (palpite > numeroSecreto)
        {
            Console.WriteLine("Muito alto! Tente novamente.");
        }
        else
        {
            Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida.");
    }
} while (palpite != numeroSecreto);
using System;

Console.Write("Pressão sistólica: ");
int pressaoSistolica = int.Parse(Console.ReadLine());

string classificacao;

if (pressaoSistolica <= 120)
{
    classificacao = "Normal";
}

else if (pressaoSistolica <= 139)
{
    classificacao = "Elevada";
}

else
{
    classificacao = "Alta";
}

Console.WriteLine($"Classificação: {classificacao}");
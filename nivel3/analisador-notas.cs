using System;

Console.WriteLine("=== Avaliador de Turmas ===");
Console.WriteLine("Turma A");
Console.Write("Quantidade de alunos: ");

if (int.TryParse(Console.ReadLine(), out int qtdAlunos) && qtdAlunos > 0)
{
    double somaNotas = CadastroNotasAlunos(qtdAlunos);
    double media = CalcularMedia(somaNotas, qtdAlunos);
    Console.WriteLine();

    Console.WriteLine("Turma B");
    Console.Write("Quantidade de alunos: ");
    if (int.TryParse(Console.ReadLine(), out int qtdAlunos1) && qtdAlunos1 > 0)
    {
        double somaNotas1 = CadastroNotasAlunos(qtdAlunos1);
        double media1 = CalcularMedia(somaNotas1, qtdAlunos1);
        Console.WriteLine();

        string classificarMedia = ClassificarMedia(media);
        string classificarMedia1 = ClassificarMedia(media1);

        ExibirResultado(media, classificarMedia, media1, classificarMedia1);
    }
    else
    {
        Console.WriteLine("Entrada inválida");
    }
}
else
{
    Console.WriteLine("Entrada inválida");
}
double CadastroNotasAlunos(int qtdAlunos)
{
    double somaNotas = 0;

    for (int i = 1; i <= qtdAlunos; i++)
    {
        Console.Write($"Nota do aluno {i}: ");
        double nota = double.Parse(Console.ReadLine() ?? "0");
        somaNotas += nota;
    }
    return somaNotas;
}

double CalcularMedia(double somaNotas, int qtdAlunos)
{
    return somaNotas / qtdAlunos;
}

string ClassificarMedia(double media)
{
    string classificacao;
    if (media >= 7)
    {
        classificacao = "Aprovado";
    }
    else
    {
        classificacao = "Reprovado";
    }
    return classificacao;
}

void ExibirResultado(double media, string classificacao, double media1, string classificacao1)
{
    Console.WriteLine("=== Resultados ===");
    Console.WriteLine($"Média da Turma A: {media:F2} — {classificacao}");
    Console.WriteLine($"Média da Turma B: {media1:F2} — {classificacao1}");
}
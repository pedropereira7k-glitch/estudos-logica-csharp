using System;

Console.WriteLine("=== Analisador de Texto ===");

Console.Write("Digite uma frase: ");

//Ler a frase com Console.ReadLine()
string entradaOriginal = Console.ReadLine() ?? "";
//Aplicar Trim()
string entradaTrim = entradaOriginal.Trim();
//Verificar se contém mundo
string contemMundo = entradaTrim.Contains("Mundo") ? "Sim" : "Não";
//Inversão da string usando ToCharArray
char[] arrayCaracteres = entradaTrim.ToCharArray();

string invertida = "";

for (int i = arrayCaracteres.Length - 1; i >= 0; i--)
{
    invertida += arrayCaracteres[i];
}
Console.WriteLine("\n=== Resultados ===");
Console.WriteLine($"Original:    {entradaOriginal}");
Console.WriteLine($"Maiúsculas:  {entradaTrim.ToUpper()}");
Console.WriteLine($"Minúsculas:  {entradaTrim.ToLower()}");
Console.WriteLine($"Sem espaços extras: {entradaTrim}");
Console.WriteLine($"Tamanho: {entradaTrim.Length} caracteres");
Console.WriteLine($"Contém \"Mundo\": {contemMundo}");
Console.WriteLine($"Invertida: {invertida}");
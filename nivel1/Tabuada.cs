using System;

Console.Write("Digite um núnero de 1-10: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("De: ");
int de = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Até: ");
int ate = int.Parse(Console.ReadLine() ?? "0");

if (de > ate){
  int aux = de;
  de = ate;
  ate = aux;

  Console.WriteLine("Aviso: os números foram trocados para que o programa funcione normalmente.");
}
Console.WriteLine($"Tabuada do número {numero}:");
for (int i = de; i <= ate; i++){
  Console.WriteLine($"{numero} x {i} = {numero * i}");
}
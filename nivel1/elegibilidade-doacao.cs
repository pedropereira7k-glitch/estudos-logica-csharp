using System;

Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Peso (kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Dias desde a última doação: ");
int diasDesdeAUltimaDoacao = int.Parse(Console.ReadLine());

string aptoParaDoacao;

if ((idade >= 18 && idade <= 65) && peso > 50 && diasDesdeAUltimaDoacao > 90){
  aptoParaDoacao = "Sim";
}
else{
  aptoParaDoacao = "Não";
}

Console.WriteLine($"Apto para doação: {aptoParaDoacao}");

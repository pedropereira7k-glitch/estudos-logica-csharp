using System;

Console.Write("Peso (kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Altura (m): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);
string classificacao;
if (imc < 18.5){
  classificacao = "Abaixo do peso";
}
else if (imc < 25){
  classificacao = "Peso normal";
}
else if (imc < 30){
  classificacao = "Sobrepeso";
}
else if(imc < 40){
  classificacao = "Obesidade";
}
else{
  classificacao = "Obesidade grave";
}
Console.WriteLine($"IMC: {imc:F2}");
Console.WriteLine($"Classificação: {classificacao}");
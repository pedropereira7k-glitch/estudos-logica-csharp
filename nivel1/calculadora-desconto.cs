using System;

Console.Write("Valor da consulta: ");
double valorDaConsulta = double.Parse(Console.ReadLine());

Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Possui convênio? (s/n): ");
string possuiConvenio = Console.ReadLine().ToLower();

double descontoAplicado;

if (idade < 12){
descontoAplicado = 30;
}
else if (idade >= 60 && idade <= 80){
descontoAplicado = 25;
}
else if (idade > 80){
descontoAplicado = 40;
}
//Todas as idades já foram filtradas, só sobrou a faixa 12 e 59
else if (possuiConvenio == "s"){
descontoAplicado = 15;
}
else{
descontoAplicado = 0;
}
// Cálculo e exibição dos resultados
double valorFinal = valorDaConsulta * (1 - (descontoAplicado / 100));

Console.WriteLine($"Desconto aplicado: {descontoAplicado}%");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");

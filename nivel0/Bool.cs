using System;

Console.Write("Idade do paciente: ");
int idade = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Pressão sistólica: ");
int pressaoSistolica = int.Parse(Console.ReadLine() ?? "0");

bool idadeAcima18 = idade >= 18;
bool pressaoElevada = pressaoSistolica > 120;
bool aptoParaConsulta = pressaoElevada && !pressaoElevada;

Console.WriteLine($"Idade acima de 18 anos: {idadeAcima18}");
Console.WriteLine($"Pressão elevada (acima de 120): {pressaoElevada}");
Console.WriteLine($"Apto para consulta: {aptoParaConsulta}");


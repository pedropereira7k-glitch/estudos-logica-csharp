using System;

Console.Write("Digite sua idade: ");
string entrada = Console.ReadLine();
// validação de entrada
bool deuCerto = int.TryParse(entrada, out int idade);
//Se entrada for um número inteiro e maior igual a zero
if (deuCerto && idade >= 0){
  Console.WriteLine($"Idade registrada: {idade} anos");
}
//Se entrada não for um número inteiro e menor que zero
else{
  if (idade < 0){
  Console.WriteLine("Idade inválida. O sistema será encerrado.");
  }
  else{
  Console.WriteLine("Entrada inválida. O sistema será encerrado.");
  }
}
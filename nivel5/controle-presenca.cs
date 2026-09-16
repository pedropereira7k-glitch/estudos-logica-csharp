using System;
using System.Collections.Generic;

HashSet<string> presentes = new HashSet<string>();

Console.WriteLine("=== Controle de Presença ===");

bool rodarMenu = true;

while(rodarMenu){
    Console.WriteLine("1. Registar presença");
    Console.WriteLine("2. Verificar presença");
    Console.WriteLine("3. Exibir presentes");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha: ");

    int opcao;

    while(!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4){
        Console.WriteLine("Digite uma opção entre 1 e 4: ");
    }
    switch(opcao){
        case 1:
            Console.Write("Nome do aluno: ");
            string alunoAdicionar = Console.ReadLine();

            if (presentes.Add(alunoAdicionar)){
                Console.WriteLine("Presença registrada.");
                break;
            }
            else{
                Console.WriteLine("Presença já registrada.");
            }
            break;
        case 2:
            Console.Write("Nome do aluno: ");
            string alunoBuscar = Console.ReadLine();

            if (presentes.Contains(alunoBuscar)){
                Console.WriteLine($"{alunoBuscar} está presente.");
                break;
            }
            else{
                Console.WriteLine($"{alunoBuscar} não está presente.");
            }
            break;
        case 3:
             if (presentes.Count == 0){
                Console.WriteLine("Nenhum aluno presente.");
                break;
             }
             else{
                Console.Write($"Alunos presentes: ");
                bool primeiroElemento = true;
                foreach(string aluno in presentes){
                    if (!primeiroElemento) Console.Write(", ");
                    Console.Write(aluno);
                    primeiroElemento = false;
                }
                Console.WriteLine();
             }
             break;
        case 4:
            Console.WriteLine("Encerrando.");
            rodarMenu = false;
            break;
    }
}
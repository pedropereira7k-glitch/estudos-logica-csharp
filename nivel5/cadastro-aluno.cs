using System;
using System.Collections.Generic;
using System.Globalization;

Dictionary<int, string> alunos = new Dictionary<int, string>();
Console.WriteLine("=== Cadastro de Alunos ===");

bool rodarMenu = true;

while(rodarMenu){
    Console.WriteLine("1. Adicionar aluno");
    Console.WriteLine("2. Buscar aluno");
    Console.WriteLine("3. Remover aluno");
    Console.WriteLine("4. Exibir todos");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha: ");

    int opcao;

    while(!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5){
        Console.WriteLine("Digite uma opcao que esteja entre 1 e 5: ");
    }
    switch(opcao){
        case 1:
            Console.Write("ID: ");
            if (!int.TryParse(Console.ReadLine(), out int idAdicionar)){
                Console.WriteLine("ID inválido. Use apenas números inteiros.");
                break;
            }
            
            if (alunos.ContainsKey(idAdicionar)){
                Console.WriteLine("ID já cadastrado.");
            }
            else{
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                alunos.Add(idAdicionar, nome);
                Console.WriteLine("Aluno cadastrado.");
                
            }
            break;
        case 2:
            Console.Write("ID: ");
            if (!int.TryParse(Console.ReadLine(), out int idBuscar)){
                Console.WriteLine("ID inválido.");
                break;
            }
            if (alunos.ContainsKey(idBuscar)){
                Console.WriteLine($"Aluno encontrado: {alunos[idBuscar]}");
            }
            else{
                Console.WriteLine("Aluno não encontrado.");
            }
            break;
        case 3:
            Console.Write("ID: ");
            if (!int.TryParse(Console.ReadLine(), out int idRemover)){
                Console.WriteLine("ID inválido.");
                break;
            }
            if (alunos.ContainsKey(idRemover)){
                alunos.Remove(idRemover);
                Console.WriteLine("Aluno removido com sucesso.");
            }
            else{
                Console.WriteLine("ID não encontrado.");
            }
            break;
        case 4:
            if (alunos.Count == 0){
                Console.WriteLine("Nenhum aluno cadastrado.");
                break;
            }
            foreach (KeyValuePair<int, string> aluno in alunos){
                Console.WriteLine($"{aluno.Key} - {aluno.Value}");
            }
            break;
        case 5:
            Console.WriteLine("Encerrando.");
            rodarMenu = false;
            break;
    }
}
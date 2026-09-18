using System;
using System.Collections.Generic;

List<Produto> listaProdutos = new List<Produto>();

Produto p1 = new Produto("Notebook", 2500.00, 10);
Console.WriteLine("=== Cadastro de Produtos ===");
Console.WriteLine($"Nome: {p1.Nome}");
Console.WriteLine($"Preço: {p1.Preco:F2}");
Console.WriteLine($"Estoque: {p1.Estoque}");
listaProdutos.Add(p1);

Console.WriteLine();

Produto p2 = new Produto("Mouse", 150.00, 50);
Console.WriteLine("=== Cadastro de Produtos ===");
Console.WriteLine($"Nome: {p2.Nome}");
Console.WriteLine($"Preço: {p2.Preco:F2}");
Console.WriteLine($"Estoque: {p2.Estoque}");
listaProdutos.Add(p2);

Console.WriteLine();

Console.WriteLine("=== Produtos Cadastrados ===");
foreach(Produto produto in listaProdutos){
    Console.WriteLine($"{produto.Nome} - R$ {produto.Preco:F2} - Estoque: {produto.Estoque}");
}
class Produto{
    public string Nome;
    public double Preco;
    public int Estoque;

    public Produto(string nome, double preco, int estoque){
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}
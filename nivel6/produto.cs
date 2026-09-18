using System;
using System.Collections.Generic;

List<Produto> listaProdutos = new List<Produto>();

Produto p1 = new Produto();
p1.Nome = "Notebook";
p1.Preco = 2500.00;
p1.Estoque = 10;
listaProdutos.Add(p1);

Console.WriteLine("=== Cadastro de Produtos ===");
Console.WriteLine($"Nome: {p1.Nome}");
Console.WriteLine($"Preço: {p1.Preco:F2}");
Console.WriteLine($"Estoque: {p1.Estoque}");

Console.WriteLine();

Produto p2 = new Produto();
p2.Nome = "Mouse";
p2.Preco = 150.00;
p2.Estoque = 50;
listaProdutos.Add(p2);

Console.WriteLine("=== Cadastro de Produtos ===");
Console.WriteLine($"Nome: {p2.Nome}");
Console.WriteLine($"Preço: {p2.Preco:F2}");
Console.WriteLine($"Estoque: {p2.Estoque}");

Console.WriteLine();

Console.WriteLine("=== Produtos Cadastrados ===");

foreach (Produto p in listaProdutos)
{
    Console.WriteLine($"{p.Nome} - R$ {p.Preco:F2} - Estoque: {p.Estoque}");
}

class Produto
{
    public string Nome;
    public double Preco;
    public int Estoque;
}

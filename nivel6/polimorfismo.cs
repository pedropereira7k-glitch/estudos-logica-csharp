using System;
using System.Collections.Generic;

class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, double salario) {
        this.Nome = nome;
        this.Salario = salario;
    }
    
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: R$ {Salario:0.00}");
    }
}

class Gerente : Funcionario
{
    public int Equipe { get; set; }
    public double Bonus { get; set; }

    public Gerente(string nome, double salario, int equipe, double bonus)
        : base(nome, salario)
    {
        this.Equipe = equipe;
        this.Bonus = bonus;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine();
        base.ExibirInfo();
        Console.WriteLine($"Equipe: {Equipe} pessoas");
        Console.WriteLine($"Bônus: R$ {Bonus:0.00}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Funcionario> listaFuncionarios = new List<Funcionario>
        {
            new Funcionario("Ana", 3000),
            new Gerente("Carlos", 8000, 5, 1500),
            new Funcionario("João", 3500)
        };

        foreach (Funcionario funcionario in listaFuncionarios){
            funcionario.ExibirInfo();
        }
    }
}

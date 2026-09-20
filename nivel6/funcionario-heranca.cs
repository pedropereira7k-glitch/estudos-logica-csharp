using System;

//Classe Funcionário, construtor e método
class Funcionario {
    public string Nome { get; set; }
    public double Salario { get; set; } 

    public Funcionario (string nome, double salario){
        this.Nome = nome;
        this.Salario = salario;
    }

    public virtual void ExibirInfo() {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Salário: R$ {this.Salario:0.00}");
    }
}

//Classe Gerente, usa classe funcionario como base + alguns outros atributos e sobescrição do método da classe funcionário

class Gerente : Funcionario{
    public int Equipe { get; set; }
    public double Bonus {get; set; }

    public Gerente (string nome, double salario, int equipe, double bonus)
        :base(nome, salario){
            this.Equipe = equipe;
            this.Bonus = bonus;
        }
        public override void ExibirInfo(){
            base.ExibirInfo();
            Console.WriteLine($"Equipe: {this.Equipe} pessoas");
            Console.WriteLine($"Bônus: R$ {this.Bonus:0.00}");
        }
}
class Program{
    static void Main(){
        Funcionario f = new Funcionario("Ana", 3000);
        Gerente g = new Gerente("Carlos", 8000, 5, 1500);

        Console.WriteLine("=== Funcionário ===");
        f.ExibirInfo();

        Console.WriteLine("\n=== Gerente ===");
        g.ExibirInfo();
    }
}
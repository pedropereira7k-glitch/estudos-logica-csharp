using System;

interface IDescritivel 
{
    void ExibirDescricao();
}

public abstract class Forma : IDescritivel 
{
    public string Nome { get; set; }

    public Forma(string nome)
    {
        this.Nome = nome;
    }

    public abstract double CalcularArea();

    public abstract void ExibirDescricao();
}

public class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo (double raio) : base("Círculo")
    {
        this.Raio = raio;
    }

    public override double CalcularArea ()
    {
        return Math.PI * Raio * Raio;
    }

    public override void ExibirDescricao ()
    {
        Console.WriteLine($"Forma: {this.Nome}");
        Console.WriteLine($"Raio: {this.Raio:F2}");
        Console.WriteLine($"Área: {CalcularArea():F2}");
        Console.WriteLine();
    }
}

public class Retangulo : Forma 
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo (double largura, double altura) : base("Retângulo")
    {
        this.Largura = largura;
        this.Altura = altura;
    }

    public override double CalcularArea () 
    {
        return Largura * Altura;
    }

    public override void ExibirDescricao () 
    {
        Console.WriteLine($"Forma: {this.Nome}");
        Console.WriteLine($"Largura: {this.Largura:F2}");
        Console.WriteLine($"Altura: {this.Altura:F2}");
        Console.WriteLine($"Área: {CalcularArea():F2}");
        Console.WriteLine();
    }
}

public class Program 
{
    public static void Main () 
    {
        Console.WriteLine("=== Formas Geométricas ===");

        Circulo circulo = new Circulo (5);
        Retangulo retangulo = new Retangulo (4, 6);

        circulo.ExibirDescricao();
        retangulo.ExibirDescricao();
    }
}
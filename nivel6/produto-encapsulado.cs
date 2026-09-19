using System;

class Produto
{
    private string _nome;
    private double _preco;
    private int _estoque;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public double Preco
    {
        get { return _preco; }
        set
        {
            if (value > 0)
                _preco = value;
        }
    }

    public int Estoque
    {
        get { return _estoque; }
        set
        {
            if (value >= 0)
                _estoque = value;
        }
    }

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Estoque: {Estoque}");
        Console.WriteLine();
    }

    public void AtualizarEstoque(int quantidade)
    {
        _estoque += quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto("Notebook", 2500.00, 10);

        p.ExibirInfo();
        p.AtualizarEstoque(5);
        p.ExibirInfo();
        p.Preco = -100;
        p.ExibirInfo();
    }
}

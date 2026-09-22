using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Cadastro de Produto ===");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        double preco = 0;
        bool precoValido = false;

        do
        {
            try
            {
                Console.Write("Preço: ");
                preco = double.Parse(Console.ReadLine());

                if (preco > 0)
                {
                    precoValido = true;
                }
                else
                {
                    Console.WriteLine("Erro: preço deve ser maior que zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: formato de preço inválido. Tente novamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        } while (!precoValido);

        int estoque = 0;
        bool estoqueValido = false;

        do
        {
            try
            {
                Console.Write("Estoque: ");
                estoque = int.Parse(Console.ReadLine());

                if (estoque >= 0)
                {
                    estoqueValido = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: formato de estoque inválido. Tente novamente.");
            }
            catch  (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

        } while (!estoqueValido);

        Console.WriteLine("Produto cadastrado:");
        Console.WriteLine($"{nome} - R$ {preco:0.00} - Estoque: {estoque}");
    }
}
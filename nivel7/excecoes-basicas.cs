using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Teste de Exceções ===");
        try
        {
            int dividendo = 10;
            int divisor = 0;
            int resultado = dividendo / divisor;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Teste 1 - Divisão por zero:");   
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finalizado.");                    
        }

        try
        {
            int[] array = new int[3];                            
            int valor = array[10];
        }
        catch (IndexOutOfRangeException ex)                     
        {
            Console.WriteLine("Teste 2 - Índice inválido:");
            Console.WriteLine($"Erro: {ex.Message}");             
        }
        finally
        {
            Console.WriteLine("Finalizado.");
        }

        try
        {
            int numero = int.Parse("abc");
        }
        catch (FormatException ex)                               
        {
            Console.WriteLine("Teste 3 - Conversão inválida:");    
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finalizado.");
        }
    }
}   
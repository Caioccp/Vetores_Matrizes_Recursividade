using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a posição: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Resultado: {Fibonacci(numero)}");
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
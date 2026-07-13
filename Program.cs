using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Soma: {SomarAteN(numero)}");
    }

    static int SomarAteN(int n)
    {
        if (n > 1)
        {
            return n + SomarAteN(n - 1);
        }

        return n;
    }
}
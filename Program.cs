using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        ContagemRegressiva(numero);
    }

    static int ContagemRegressiva(int n)
    {
        Console.WriteLine(n);

        if (n <= 0)
        {
            return 0;
        }

        return ContagemRegressiva(n - 1);
    }
}
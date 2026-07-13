using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tabela = new int[2, 3];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o valor [{linha},{coluna}]: ");
                tabela[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine();

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(tabela[linha, coluna] + "\t");
            }

            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] presenca = new int[3, 5];

        for (int aluno = 0; aluno < 3; aluno++)
        {
            Console.WriteLine($"Aluno {aluno + 1}");

            for (int dia = 0; dia < 5; dia++)
            {
                Console.Write($"Dia {dia + 1} (1 = Presente / 0 = Ausente): ");
                presenca[aluno, dia] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine();
        }

        for (int aluno = 0; aluno < 3; aluno++)
        {
            int total = 0;

            for (int dia = 0; dia < 5; dia++)
            {
                total += presenca[aluno, dia];
            }

            Console.WriteLine($"Aluno {aluno + 1}: {total} presenças");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] alunos = new string[5];
        double[,] notas = new double[5, 3];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º aluno: ");
            alunos[i] = Console.ReadLine()!;

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a {j + 1}ª nota: ");
                notas[i, j] = double.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            double media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
            string situacao;

            if (media >= 7)
            {
                situacao = "Aprovado";
            }
            else if (media >= 5)
            {
                situacao = "Recuperação";
            }
            else
            {
                situacao = "Reprovado";
            }

            Console.WriteLine($"Aluno: {alunos[i]}");
            Console.WriteLine($"Média: {media:F2}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine();
        }
    }
}
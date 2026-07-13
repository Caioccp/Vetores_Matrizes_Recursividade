using System;

class Program
{
    static void Main(string[] args)
    {
        string[] alunos = new string[5];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º aluno: ");
            alunos[i] = Console.ReadLine()!;
        }

        Console.WriteLine("\nAlunos cadastrados:");

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
}
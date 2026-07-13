using System;

class Program
{
    static void Main(string[] args)
    {
        double[] notas = new double[5];
        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota do {i + 1}º aluno: ");
            notas[i] = double.Parse(Console.ReadLine()!);
            soma += notas[i];
        }

        double media = soma / notas.Length;

        Console.WriteLine($"\nMédia da turma: {media:F2}");
    }
}
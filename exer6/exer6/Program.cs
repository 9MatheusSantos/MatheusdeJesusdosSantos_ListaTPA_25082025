using System;

class Program
{
    static void Main()
    {
        double soma = 0;
        int quantidade = 10;

        for (int i = 1; i <= quantidade; i++)
        {
            double nota;

            while (true) 
            {
                Console.Write($"Digite a {i}ª nota (0 a 10): ");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite uma nota entre 0 e 10.");
                }
            }

            soma += nota;
        }

        double media = soma / quantidade;

        Console.WriteLine($"\nA média das {quantidade} notas é: {media:F2}");

        Console.ReadKey();
    }
}

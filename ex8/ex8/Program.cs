using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para calcular seu fatorial.");
            double n = double.Parse(Console.ReadLine());
            double total = 1;
            for (double e = 1; e <= n; e++)
            {
                total *= e;
            }
            Console.WriteLine($"O fatorial de {n} é igual a: {total}" );
        }
    }
}
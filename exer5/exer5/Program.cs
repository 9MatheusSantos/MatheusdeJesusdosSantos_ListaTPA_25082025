using System;

class Program
{
    static void Main()
    {
        int maior;

        Console.Write("Digite o 1º número: ");
        maior = int.Parse(Console.ReadLine()); 

        for (int i = 2; i <= 15; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\nO maior número digitado foi: {maior}");

        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        int maior, menor;

        if (n1 > n2)
        {
            maior = n1;
            menor = n2;
        }
        else
        {
            maior = n2;
            menor = n1;
        }

        Console.WriteLine($"\nNúmeros ímpares entre {n1} e {n2} (em ordem decrescente):");

        for (int i = maior; i >= menor; i--)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}

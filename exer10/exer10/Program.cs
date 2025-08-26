using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite o código do operário: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int N = int.Parse(Console.ReadLine());

            int salarioNormal = 0;
            int excedente = 0;

            if (N <= 50)
            {
                salarioNormal = N * 10;
                excedente = 0;
            }
            else
            {
                salarioNormal = 50 * 10; 
                excedente = (N - 50) * 20; 
            }

            int salarioTotal = salarioNormal + excedente;

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine("Salário total: R$ " + salarioTotal);
            Console.WriteLine("Salário excedente: R$ " + excedente);


            Console.Write("\nDeseja encerrar o programa? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta == "S")
            {
                break;
            }
            else
            {
                continue; 
            }
        }

        Console.ReadKey();
    }
}

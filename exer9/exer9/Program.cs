using System;

class Program
{
    static void Main()
    {
        int pares = 0, impares = 0, positivos = 0, negativos = 0;

        while (true)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());


            if (numero % 2 == 0)
                pares++;
            else
                impares++;


            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;

            Console.Write("Deseja encerrar o programa? (S/N): ");
            string resposta = Console.ReadLine();


            if (resposta == "S")
                break;
        }

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"Quantidade de pares: {pares}");
        Console.WriteLine($"Quantidade de ímpares: {impares}");
        Console.WriteLine($"Quantidade de positivos: {positivos}");
        Console.WriteLine($"Quantidade de negativos: {negativos}");

        Console.ReadKey();
    }
}

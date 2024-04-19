using System;

class Program
{
    static void Main()
    {
        int menorQue21 = 0;
        int maiorQue50 = 0;

        Console.WriteLine("Digite a idade da pessoa (ou pressione Enter para encerrar):");

        string idade;
        while (!string.IsNullOrWhiteSpace(idade = Console.ReadLine()))
        {
            if (int.TryParse(idade, out int valor))
            {
                if (valor < 21)
                {
                    menorQue21++;
                }
                else if (valor > 50)
                {
                    maiorQue50++;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro ou pressione Enter para encerrar.");
            }

            Console.WriteLine("Digite a idade da próxima pessoa (ou pressione Enter para encerrar):");
        }

        Console.WriteLine($"Total de pessoas com menos de 21 anos: {menorQue21}");
        Console.WriteLine($"Total de pessoas com mais de 50 anos: {maiorQue50}");
    }
}

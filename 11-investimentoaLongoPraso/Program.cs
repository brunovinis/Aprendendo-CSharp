using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento a longo praso");

        double fatordeRendimento = 1.005;
        double investimento = 1000;
        int mes;
        for (int anos = 1; anos <= 5; anos++)
        {
            for (mes = 1; mes <= 12; mes++)
            {
                investimento *= fatordeRendimento;
                Console.WriteLine("No mês " + mes + "você tem R$ " + investimento);
            }

            fatordeRendimento += 0.001;

        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);


        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();
    }
}


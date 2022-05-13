using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 2 - For");

        double investimento = 1000;



        for (int mes = 1; mes <= 12; mes++)
        {
            //investimento = investimento + investimento * 0.005;
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

        }

        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();
    }
}
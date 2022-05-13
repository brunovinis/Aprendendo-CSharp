using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;
        // rendimento de 0,5% (0,005) ao mês 

        //mes 1
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        //mes 2
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        //mes 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes += 1;//incremento com valor maior que 1 se usa +=
            // mes = mes + 1
        }

        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();
    }
}

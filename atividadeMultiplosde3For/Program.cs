using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividades 3 - Multiplos de 3 for");

        for (int i = 3; i <= 100; i += 3)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();
    }
}

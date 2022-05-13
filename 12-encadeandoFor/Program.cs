using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - encadeando for");
        //com break
        for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
        {
            for (int contadorColuna = 1; contadorColuna <= 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)

                    break;



            }
            Console.WriteLine();
        }
        // sem break
        for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
        {
            for (int contadorColuna = 1; contadorColuna <= 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)

                    break;



            }
            Console.WriteLine();
        }

        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();
    }
}

using System;

class Programa
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        Console.Write("Digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        double media;
        media = res / 4.0;

        Console.WriteLine("A soma das notas é: " + res);
        Console.WriteLine("A media das notas é: " + (double)media, 2f);

        if (media >= 6)
        {
            Console.WriteLine("Parabéns você passou");
        }
        else
        {
            if (media >= 5.0)
            {
                Console.WriteLine("Que pena você esta de recuperação");
            }
            else
            {
                Console.WriteLine("Sinto muito você reprovou");
            }
        }



        Console.WriteLine("Precione ENTER para fechar");
        Console.ReadLine();

    }
}

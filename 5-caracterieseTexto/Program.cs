using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra = 'a';
        //Console.WriteLine(letra);

        letra = (char)66;
        Console.WriteLine(letra);

        letra = (char)82;
        Console.WriteLine(letra);

        letra = (char)85;
        Console.WriteLine(letra);

        letra = (char)78;
        Console.WriteLine(letra);

        letra = (char)79;
        Console.WriteLine(letra);

        Console.WriteLine();

        letra = (char)66;
        Console.Write(letra);

        letra = (char)82;
        Console.Write(letra);

        letra = (char)85;
        Console.Write(letra);

        letra = (char)78;
        Console.Write(letra);

        letra = (char)79;
        Console.WriteLine(letra);

        Console.WriteLine();

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        Console.WriteLine();

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        Console.WriteLine();

        string cursos = @"Cursos disponiveis: 
-C 
-C++
-HTML
-CSharp";
        Console.WriteLine(cursos);



        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}

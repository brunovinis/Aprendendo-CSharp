using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo");

        int idadeRafael = 17;
        int quantidadedePessoas = 2;

        bool acompanhado = quantidadedePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "Rafael está acompahado";
        }
        else
        {
            textoAdicional = "Rafael não está acompanhado";
        }
        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("pode entrar");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }
        Console.WriteLine("Precione ENTER para encerrar");
        Console.ReadLine();

    }
}
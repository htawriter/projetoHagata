using System;
using tabuleiro;

namespace projetoHagata
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new tabuleiro.Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}

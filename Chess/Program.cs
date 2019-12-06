using System;
using Chess.Tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p;

            p = new Position(3 , 4);

            Console.WriteLine("Posição: " + p);
        }
    }
}

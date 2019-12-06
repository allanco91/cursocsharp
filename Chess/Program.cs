using System;
using Chess.ChessBoard;
using Chess.Chess;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame game = new ChessGame();

                while (!game.Finished)
                {
                    try
                    {
                        Screen.PrintGame(game);
                        
                        Console.Write("Origem: ");
                        Position source = Screen.ReadChessPosition().ToPosition();
                        game.ValidateSourcePosition(source);

                        bool[,] posibleMovements = game.Board.Piece(source).PossibleMovements();

                        Console.Clear();
                        Screen.PrintBoard(game.Board, posibleMovements);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Position destination = Screen.ReadChessPosition().ToPosition();
                        game.ValidateDestinationPosition(source, destination);

                        game.MakePlay(source, destination);
                    }
                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            //ChessPosition pos = new ChessPosition('a', 1);

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.ToPosition());

        }
    }
}

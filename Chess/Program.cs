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
                    Console.Clear();
                    Screen.PrintBoard(game.Board);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position source = Screen.ReadChessPosition().ToPosition();

                    bool[,] posibleMovements = game.Board.Piece(source).PossibleMovements();

                    Console.Clear();
                    Screen.PrintBoard(game.Board, posibleMovements);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Position destination = Screen.ReadChessPosition().ToPosition();

                    game.MovePiece(source, destination);
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

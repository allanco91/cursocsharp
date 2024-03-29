﻿using System;
using System.Collections.Generic;
using Chess.Chess;
using Chess.ChessBoard;

namespace Chess
{
    class Screen
    {
        public static void PrintGame(ChessGame game)
        {
            Console.Clear();
            PrintBoard(game.Board);
            Console.WriteLine();
            PrintCaughtPieces(game);

            Console.WriteLine();

            if (!game.Finished)
            {
                Console.WriteLine("Turno: " + game.Turn);
                Console.WriteLine("Aguardando jogada: " + game.CurrentPlayer);

                if (game.IsInCheck(game.CurrentPlayer))
                    Console.WriteLine("XEQUE!");
            }
            else
            {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor: " + game.CurrentPlayer);
            }
            
        }

        public static void PrintCaughtPieces(ChessGame game)
        {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            PrintSet(game.CaughtPieces(Color.White));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSet(game.CaughtPieces(Color.Black));
            Console.ForegroundColor = aux;
            Console.WriteLine();

        }

        public static void PrintSet(HashSet<Piece> set)
        {
            Console.Write("[ ");
            foreach (Piece piece in set)
            {
                Console.Write(piece + " ");
            }
            Console.Write("]");
        }

        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < board.Columns; j++)
                {
                    PrintPiece(board.Piece(i, j));
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintBoard(Board board, bool[,] possibleMovements)
        {
            ConsoleColor defaultBackground = Console.BackgroundColor;
            ConsoleColor darkGrayBackground = ConsoleColor.DarkGray;
            
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < board.Columns; j++)
                {
                    if (possibleMovements[i, j])
                        Console.BackgroundColor = darkGrayBackground;
                    else
                        Console.BackgroundColor = defaultBackground;

                    PrintPiece(board.Piece(i, j));
                    Console.BackgroundColor = defaultBackground;
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = defaultBackground;
        }

        public static ChessPosition ReadChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.Color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor consoleColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = consoleColor;
                }

                Console.Write(" ");
            }
        }
    }
}

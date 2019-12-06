﻿using System;
using Chess.ChessBoard;
using Chess.Chess;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PutPiece(new Rook(board, Color.Black), new Position(0, 0));
            board.PutPiece(new Rook(board, Color.Black), new Position(1, 3));
            board.PutPiece(new King(board, Color.Black), new Position(2, 4));

            Screen.printBoard(board);
        }
    }
}

using System;
using Chess.ChessBoard;

namespace Chess.Chess
{
    class ChessGame
    {
        public Board Board { get; private set; }
        private int _turn;
        private Color _currentPlayer;
        public bool Finished { get; private set; }

        public ChessGame()
        {
            Board = new Board(8, 8);
            _turn = 1;
            _currentPlayer = Color.White;
            Finished = false;
            PutPieces();
        }

        public void MovePiece(Position source, Position dest)
        {
            Piece p = Board.RemovePiece(source);
            p.IncrementQntMoves();
            Piece capturedPiece = Board.RemovePiece(dest);
            Board.PutPiece(p, dest);
        }

        private void PutPieces()
        {
            Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('c', 2).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('d', 2).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('e', 2).ToPosition());
            Board.PutPiece(new Rook(Board, Color.White), new ChessPosition('e', 1).ToPosition());
            Board.PutPiece(new King(Board, Color.White), new ChessPosition('d', 1).ToPosition());

            Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('c', 7).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('c', 8).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('d', 7).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('e', 7).ToPosition());
            Board.PutPiece(new Rook(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
            Board.PutPiece(new King(Board, Color.Black), new ChessPosition('d', 8).ToPosition());
        }
    }
}

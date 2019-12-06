using System.Collections.Generic;
using Chess.ChessBoard;

namespace Chess.Chess
{
    class ChessGame
    {
        public Board Board { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool Finished { get; private set; }
        private HashSet<Piece> Pieces;
        private HashSet<Piece> Caught;

        public ChessGame()
        {
            Board = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            Pieces = new HashSet<Piece>();
            Caught = new HashSet<Piece>();
            PutPieces();
        }

        public void MovePiece(Position source, Position dest)
        {
            Piece p = Board.RemovePiece(source);
            p.IncrementQntMoves();
            Piece capturedPiece = Board.RemovePiece(dest);
            Board.PutPiece(p, dest);

            if (capturedPiece != null)
                Caught.Add(capturedPiece);
        }

        public void MakePlay(Position source, Position dest)
        {
            MovePiece(source, dest);
            Turn++;
            ChangePlayer(); 

        }

        public void ValidateSourcePosition(Position pos)
        {
            if (Board.Piece(pos) == null)
            {
                throw new BoardException("Não existe peça na posição de origem escolhida.");
            }
            if (CurrentPlayer != Board.Piece(pos).Color)
            {
                throw new BoardException("A peça de origem escolhida não é sua.");
            }
            if (!Board.Piece(pos).ThereArePossibleMovements())
            {
                throw new BoardException("Não há movimentos possíveis para a peça de origem escolhida.");
            }
        }

        public void ValidateDestinationPosition(Position source, Position destination)
        {
            if (!Board.Piece(source).CanMoveTo(destination))
            {
                throw new BoardException("Posição de destino inválida.");
            }
        }

        private void ChangePlayer()
        {
            if (CurrentPlayer == Color.White)
                CurrentPlayer = Color.Black;
            else
                CurrentPlayer = Color.White;
        }

        public HashSet<Piece> CaughtPieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();

            foreach (Piece x in Caught)
            {
                if (x.Color == color)
                {
                    aux.Add(x);
                }
            }

            return aux;
        }

        public HashSet<Piece> PiecesInGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();

            foreach (Piece x in Pieces)
            {
                if (x.Color == color)
                {
                    aux.Add(x);
                }
            }

            aux.ExceptWith(CaughtPieces(color));

            return aux;
        }

        public void PutNewPiece(char column, int row, Piece piece)
        {
            Board.PutPiece(piece, new ChessPosition(column, row).ToPosition());
            Pieces.Add(piece);
        }

        private void PutPieces()
        {
            PutNewPiece('c', 1, new Rook(Board, Color.White));
            PutNewPiece('c', 2, new Rook(Board, Color.White));
            PutNewPiece('d', 2, new Rook(Board, Color.White));
            PutNewPiece('e', 2, new Rook(Board, Color.White));
            PutNewPiece('e', 1, new Rook(Board, Color.White));
            PutNewPiece('d', 1, new King(Board, Color.White));

            PutNewPiece('c', 7, new Rook(Board, Color.Black));
            PutNewPiece('c', 8, new Rook(Board, Color.Black));
            PutNewPiece('d', 7, new Rook(Board, Color.Black));
            PutNewPiece('e', 7, new Rook(Board, Color.Black));
            PutNewPiece('e', 8, new Rook(Board, Color.Black));
            PutNewPiece('d', 8, new King(Board, Color.Black));
        }
    }
}

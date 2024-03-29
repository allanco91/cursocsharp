﻿using System.Collections.Generic;
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
        public bool Check { get; private set; }
        public Piece EnPassantVulnerability { get; private set; }

        public ChessGame()
        {
            Board = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            Check = false;
            EnPassantVulnerability = null;
            Pieces = new HashSet<Piece>();
            Caught = new HashSet<Piece>();
            PutPieces();
        }

        public Piece MovePiece(Position source, Position dest)
        {
            Piece p = Board.RemovePiece(source);
            p.IncrementQntMoves();
            Piece capturedPiece = Board.RemovePiece(dest);
            Board.PutPiece(p, dest);

            //#jogada especial roque pequeno castle kingside
            if (p is King && dest.Column == source.Column + 2)
            {
                Position sourceR = new Position(source.Row, source.Column + 3);
                Position destinationR = new Position(source.Row, source.Column + 1);
                Piece R = Board.RemovePiece(sourceR);
                R.IncrementQntMoves();
                Board.PutPiece(R, destinationR);
            }

            //#jogada especial roque grande castle queenside
            if (p is King && dest.Column == source.Column - 2)
            {
                Position sourceR = new Position(source.Row, source.Column - 4);
                Position destinationR = new Position(source.Row, source.Column - 1);
                Piece R = Board.RemovePiece(sourceR);
                R.IncrementQntMoves();
                Board.PutPiece(R, destinationR);
            }

            //#jogada especial en passant
            if (p is Pawn && dest.Column != source.Column && capturedPiece == null)
            {
                Position enemyPawn;

                if (p.Color == Color.White)
                    enemyPawn = new Position(dest.Row + 1, dest.Column);
                else
                    enemyPawn = new Position(dest.Row - 1, dest.Column);

                capturedPiece = Board.RemovePiece(enemyPawn);
            }

            if (capturedPiece != null)
                Caught.Add(capturedPiece);

            return capturedPiece;
        }

        public void UndoMove(Position source, Position dest, Piece capturedPiece)
        {
            Piece p = Board.RemovePiece(dest);
            p.DecrementQntMoves();

            if (capturedPiece != null)
            {
                Board.PutPiece(capturedPiece, dest);
                Caught.Remove(capturedPiece);
            }
            Board.PutPiece(p, source);

            //#jogada especial roque pequeno castle kingside
            if (p is King && dest.Column == source.Column + 2)
            {
                Position sourceR = new Position(source.Row, source.Column + 3);
                Position destinationR = new Position(source.Row, source.Column + 1);
                Piece R = Board.RemovePiece(destinationR);
                R.DecrementQntMoves();
                Board.PutPiece(R, sourceR);
            }

            //#jogada especial roque grande castle queenside
            if (p is King && dest.Column == source.Column - 2)
            {
                Position sourceR = new Position(source.Row, source.Column - 4);
                Position destinationR = new Position(source.Row, source.Column - 1);
                Piece R = Board.RemovePiece(destinationR);
                R.DecrementQntMoves();
                Board.PutPiece(R, sourceR);
            }

            //#jogada especial en passant
            if (p is Pawn && dest.Column != source.Column && capturedPiece == EnPassantVulnerability)
            {
                Piece pawn = Board.RemovePiece(dest);
                Position posEnemyPawn;

                if (p.Color == Color.White)
                    posEnemyPawn = new Position(3, dest.Column);
                else
                    posEnemyPawn = new Position(4, dest.Column);

                Board.PutPiece(pawn, posEnemyPawn);
            }
        }

        public void MakePlay(Position source, Position dest)
        {
            Piece capturedPiece = MovePiece(source, dest);

            Piece p = Board.Piece(dest);

            //#jogada especial promocao
            if (p is Pawn && (p.Color == Color.White && dest.Row == 0) || (p.Color == Color.Black && dest.Row == 7))
            {
                p = Board.RemovePiece(dest);
                Pieces.Remove(p);

                Piece queen = new Queen(Board, p.Color);
                Board.PutPiece(queen, dest);
                Pieces.Add(queen);
            }

            if (IsInCheck(CurrentPlayer))
            {
                UndoMove(source, dest, capturedPiece);
                throw new BoardException("Você não pode se colocar em xeque.");
            }

            Check = IsInCheck(Enemy(CurrentPlayer));

            if (IsCheckmate(Enemy(CurrentPlayer)))
                Finished = true;
            else
            {
                Turn++;
                ChangePlayer();
            }

            //#jogada especial en passant
            if (p is Pawn && (dest.Row == source.Row - 2 || dest.Row == source.Row + 2))
                EnPassantVulnerability = p;
            else
                EnPassantVulnerability = null;
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
            if (!Board.Piece(source).PossibleMovement(destination))
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

        private Color Enemy(Color color)
        {
            if (color == Color.White)
                return Color.Black;
            else
                return Color.White;
        }

        private Piece King(Color color)
        {
            foreach (Piece p in PiecesInGame(color))
            {
                if (p is King)
                    return p;
            }

            return null;
        }

        public bool IsInCheck(Color color)
        {
            Piece K = King(color);
            if (K == null)
            {
                throw new BoardException("Não existe rei da cor " + color + " no tabuleiro.");
            }

            foreach (Piece p in PiecesInGame(Enemy(color)))
            {
                bool[,] mat = p.PossibleMovements();

                if (mat[K.Position.Row, K.Position.Column])
                    return true;
            }

            return false;
        }

        public bool IsCheckmate(Color color)
        {
            if (!IsInCheck(color))
                return false;

            foreach (Piece p in PiecesInGame(color))
            {
                bool[,] mat = p.PossibleMovements();

                for (int i = 0; i < Board.Rows; i++)
                {
                    for (int j = 0; j < Board.Columns; j++)
                    {
                        if (mat[i, j])
                        {
                            Position source = p.Position;
                            Position destination = new Position(i, j);
                            Piece capturedPiece = MovePiece(source, destination);
                            bool testCheck = IsInCheck(color);
                            UndoMove(source, destination, capturedPiece);
                            if (!testCheck)
                                return false;
                        }
                    }
                }
            }

            return true;
        }

        public void PutNewPiece(char column, int row, Piece piece)
        {
            Board.PutPiece(piece, new ChessPosition(column, row).ToPosition());
            Pieces.Add(piece);
        }

        private void PutPieces()
        {
            //PutNewPiece('c', 1, new Rook(Board, Color.White));
            //PutNewPiece('c', 2, new Rook(Board, Color.White));
            //PutNewPiece('d', 2, new Rook(Board, Color.White));
            //PutNewPiece('e', 2, new Rook(Board, Color.White));
            //PutNewPiece('g', 7, new Rook(Board, Color.White));
            //PutNewPiece('d', 1, new King(Board, Color.White));

            //PutNewPiece('b', 8, new Rook(Board, Color.Black));
            //PutNewPiece('a', 8, new King(Board, Color.Black));

            PutNewPiece('a', 8, new Rook(Board, Color.Black));
            PutNewPiece('b', 8, new Knight(Board, Color.Black));
            PutNewPiece('c', 8, new Bishop(Board, Color.Black));
            PutNewPiece('d', 8, new Queen(Board, Color.Black));
            PutNewPiece('e', 8, new King(Board, Color.Black, this));
            PutNewPiece('f', 8, new Bishop(Board, Color.Black));
            PutNewPiece('g', 8, new Knight(Board, Color.Black));
            PutNewPiece('h', 8, new Rook(Board, Color.Black));
            PutNewPiece('a', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('b', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('c', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('d', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('e', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('f', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('g', 7, new Pawn(Board, Color.Black, this));
            PutNewPiece('h', 7, new Pawn(Board, Color.Black, this));

            PutNewPiece('a', 1, new Rook(Board, Color.White));
            PutNewPiece('b', 1, new Knight(Board, Color.White));
            PutNewPiece('c', 1, new Bishop(Board, Color.White));
            PutNewPiece('d', 1, new Queen(Board, Color.White));
            PutNewPiece('e', 1, new King(Board, Color.White, this));
            PutNewPiece('f', 1, new Bishop(Board, Color.White));
            PutNewPiece('g', 1, new Knight(Board, Color.White));
            PutNewPiece('h', 1, new Rook(Board, Color.White));
            PutNewPiece('a', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('b', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('c', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('d', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('e', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('f', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('g', 2, new Pawn(Board, Color.White, this));
            PutNewPiece('h', 2, new Pawn(Board, Color.White, this));
        }
    }
}

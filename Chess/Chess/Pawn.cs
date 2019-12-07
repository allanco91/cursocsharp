using Chess.ChessBoard;

namespace Chess.Chess
{
    class Pawn : Piece
    {

        private ChessGame _game;
        public Pawn(Board board, Color color, ChessGame game) : base(board, color)
        {
            _game = game;
        }

        private bool CanMove(Position pos)
        {
            Piece p = Board.Piece(pos);
            return p == null;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];

            Position pos = new Position(0, 0);

            if (Color == Color.White)
            {
                pos.SetPosition(Position.Row - 1, Position.Column);
                if (Board.ValidPosition(pos) && CanMove(pos))
                    mat[pos.Row, pos.Column] = true;

                Position pos2 = new Position(Position.Row - 2, Position.Column);
                if (Board.ValidPosition(pos) && CanMove(pos) && Board.ValidPosition(pos2) && CanMove(pos2) && QntMoves == 0)
                    mat[pos2.Row, pos2.Column] = true;

                pos.SetPosition(Position.Row - 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && EnemyExists(pos))
                    mat[pos.Row, pos.Column] = true;

                pos.SetPosition(Position.Row - 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && EnemyExists(pos))
                    mat[pos.Row, pos.Column] = true;

                //#jogadaespecial en passant Branca
                if (Position.Row == 3)
                {
                    Position left = new Position(Position.Row, Position.Column - 1);
                    if (Board.ValidPosition(left) && EnemyExists(left) && Board.Piece(left) == _game.EnPassantVulnerability)
                    {
                        mat[left.Row - 1, left.Column] = true;
                    }

                    Position right = new Position(Position.Row, Position.Column + 1);
                    if (Board.ValidPosition(right) && EnemyExists(right) && Board.Piece(right) == _game.EnPassantVulnerability)
                    {
                        mat[right.Row - 1, right.Column] = true;
                    }
                }
            }
            else
            {
                pos.SetPosition(Position.Row + 1, Position.Column);
                if (Board.ValidPosition(pos) && CanMove(pos))
                    mat[pos.Row, pos.Column] = true;

                Position pos2 = new Position(Position.Row + 2, Position.Column);
                if (Board.ValidPosition(pos) && CanMove(pos) && Board.ValidPosition(pos2) && CanMove(pos2) && QntMoves == 0)
                    mat[pos2.Row, pos2.Column] = true;

                pos.SetPosition(Position.Row + 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && EnemyExists(pos))
                    mat[pos.Row, pos.Column] = true;

                pos.SetPosition(Position.Row + 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && EnemyExists(pos))
                    mat[pos.Row, pos.Column] = true;

                //#jogadaespecial en passant Preta
                if (Position.Row == 4)
                {
                    Position left = new Position(Position.Row, Position.Column - 1);
                    if (Board.ValidPosition(left) && EnemyExists(left) && Board.Piece(left) == _game.EnPassantVulnerability)
                    {
                        mat[left.Row + 1, left.Column] = true;
                    }

                    Position right = new Position(Position.Row, Position.Column + 1);
                    if (Board.ValidPosition(right) && EnemyExists(right) && Board.Piece(right) == _game.EnPassantVulnerability)
                    {
                        mat[right.Row + 1, right.Column] = true;
                    }
                }
            }

            return mat;
        }

        private bool EnemyExists(Position pos)
        {
            Piece p = Board.Piece(pos);
            return p != null && p.Color != Color;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}

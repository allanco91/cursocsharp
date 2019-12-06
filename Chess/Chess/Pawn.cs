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
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];

            Position pos = new Position(0, 0);

            //Up
            pos.SetPosition(Position.Row - 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Ne
            pos.SetPosition(Position.Row - 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Right
            pos.SetPosition(Position.Row, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Se
            pos.SetPosition(Position.Row + 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Down
            pos.SetPosition(Position.Row + 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Sw
            pos.SetPosition(Position.Row + 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Down
            pos.SetPosition(Position.Row, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //Nw
            pos.SetPosition(Position.Row - 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //#jogadaespecial en passant Branca
            if (Position.Row == 3)
            {
                Position left = new Position(Position.Row, Position.Column - 1);
                if (Board.ValidPosition(left) && EnemyExists(left) && Board.Piece(left) == _game.EnPassantVulnerability)
                {
                    mat[left.Row, left.Column] = true;
                }

                Position right = new Position(Position.Row, Position.Column + 1);
                if (Board.ValidPosition(right) && EnemyExists(right) && Board.Piece(right) == _game.EnPassantVulnerability)
                {
                    mat[right.Row, right.Column] = true;
                }
            }

            //#jogadaespecial en passant Preta
            if (Position.Row == 4)
            {
                Position left = new Position(Position.Row, Position.Column - 1);
                if (Board.ValidPosition(left) && EnemyExists(left) && Board.Piece(left) == _game.EnPassantVulnerability)
                {
                    mat[left.Row, left.Column] = true;
                }

                Position right = new Position(Position.Row, Position.Column + 1);
                if (Board.ValidPosition(right) && EnemyExists(right) && Board.Piece(right) == _game.EnPassantVulnerability)
                {
                    mat[right.Row, right.Column] = true;
                }
            }

            return mat;
        }

        private bool EnemyExists(Position pos)
        {
            Piece p = Board.Piece(pos);
            if (p != null && p.Color != Color)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}

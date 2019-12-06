
namespace Chess.ChessBoard
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QntMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            QntMoves = 0;
        }

        public void IncrementQntMoves()
        {
            QntMoves++;
        }

        public bool ThereArePossibleMovements()
        {
            bool[,] mat = PossibleMovements();

            for (int i = 0; i < Board.Rows; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (mat[i, j])
                        return true;
                }
            }

            return false;
        }

        public bool CanMoveTo(Position pos)
        {
            return PossibleMovements()[pos.Row, pos.Column];
        }
        public abstract bool[,] PossibleMovements();
    }
}

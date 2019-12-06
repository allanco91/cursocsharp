
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

        public abstract bool[,] PossibleMovements();
    }
}


namespace Chess.ChessBoard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int qntMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            qntMoves = 0;
        }
    }
}

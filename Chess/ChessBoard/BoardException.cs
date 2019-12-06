using System;

namespace Chess.ChessBoard
{
    class BoardException : ApplicationException
    {
        public BoardException(string message) : base(message)
        {

        }
    }
}

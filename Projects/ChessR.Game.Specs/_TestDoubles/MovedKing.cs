using ChessR.Game.Pieces;

namespace ChessR.Game.Specs._TestDoubles
{
    public class MovedKing: King
    {
        public MovedKing(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
            HasMoved = true;
        }
    }
}

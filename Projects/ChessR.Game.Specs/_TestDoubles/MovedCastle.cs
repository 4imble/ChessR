using ChessR.Game.Pieces;

namespace ChessR.Game.Specs._TestDoubles
{
    public class MovedCastle: Castle
    {
        public MovedCastle(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
            HasMoved = true;
        }
    }
}

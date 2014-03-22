using System.Linq;
using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
        }

        protected override bool CanMoveToLocation(Location to)
        {
            return (CurrentLocation.IsDiagonalFrom(to)) && LocationsBetweenAreEmpty(to) && CanTakeLocation(to);
        }

        bool LocationsBetweenAreEmpty(Location to)
        {
            return CurrentLocation.GetBetween(to).All(x => CurrentGame.GetPiece(x) == null);
        }
    }
}

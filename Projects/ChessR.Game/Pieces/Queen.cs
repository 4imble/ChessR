using System.Linq;
using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
        }

        protected override bool CanMoveToLocation(Location to)
        {
            return (CurrentLocation.IsDiagonalFrom(to) 
                    || CurrentLocation.IsHorizontalFrom(to) 
                    || CurrentLocation.IsVerticalFrom(to)) 
                        && LocationsBetweenAreEmpty(to) 
                        && CanTakeLocation(to);
        }

        bool LocationsBetweenAreEmpty(Location to)
        {
            return CurrentLocation.GetBetween(to).All(x => CurrentGame.GetPiece(x) == null);
        }
    }
}

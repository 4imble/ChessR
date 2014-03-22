using System.Linq;
using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces
{
    public class Castle : Piece
    {
        public Castle(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
        }

        public bool HasMoved { get; protected set; }

        public override void MoveTo(Location location)
        {
            base.MoveTo(location);
            HasMoved = true;
        }

        public void CastleRight()
        {
            CurrentLocation = CurrentLocation.Right().Right().Right();
        }

        public void CastleLeft()
        {
            CurrentLocation = CurrentLocation.Left().Left();
        }

        protected override bool CanMoveToLocation(Location to)
        {
            return (CurrentLocation.IsHorizontalFrom(to) || CurrentLocation.IsVerticalFrom(to)) && LocationsBetweenAreEmpty(to) && CanTakeLocation(to);
        }

        bool LocationsBetweenAreEmpty(Location to)
        {
            return CurrentLocation.GetBetween(to).All(x => CurrentGame.GetPiece(x) == null);
        }
    }
}

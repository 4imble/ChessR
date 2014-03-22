using System.Linq;
using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces
{
    public class King : Piece
    {
        public King(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
        }

        public bool HasMoved { get; protected set; }

        public override void MoveTo(Location location)
        {
            var isCastlingQueenSide = IsCastlingQueenSide(location);
            var isCastlingKingSide = IsCastlingKingSide(location);

            base.MoveTo(location);

            if (isCastlingQueenSide)
            {
                ((Castle)CurrentGame.GetPiece(CurrentLocation.Left().Left())).CastleRight();
            }

            if (isCastlingKingSide)
            {
                ((Castle)CurrentGame.GetPiece(CurrentLocation.Right())).CastleLeft();
            }

            HasMoved = true;
        }

        protected override bool CanMoveToLocation(Location to)
        {
            if (IsCastling(to))
                return true;

            if (CurrentLocation.DistanceTravelled(to) > 1)
                return false;

            return (CurrentLocation.IsDiagonalFrom(to) 
                    || CurrentLocation.IsHorizontalFrom(to) 
                    || CurrentLocation.IsVerticalFrom(to)) 
                        && LocationsBetweenAreEmpty(to) 
                        && CanTakeLocation(to);
        }

        bool IsCastling(Location to)
        {
            return !HasMoved && (IsCastlingQueenSide(to) || IsCastlingKingSide(to));
        }

        bool IsCastlingQueenSide(Location to)
        {
            if (HasMoved)
                return false;
            
            var castle = (Castle)CurrentGame.GetPiece(CurrentLocation.Left().Left().Left().Left());

            return castle != null
                && !castle.HasMoved 
                && CurrentLocation.Left().Left().Equals(to) 
                && LocationsBetweenAreEmpty(castle.CurrentLocation);
        }

        bool IsCastlingKingSide(Location to)
        {
            if (HasMoved)
                return false;

            var castle = (Castle)CurrentGame.GetPiece(CurrentLocation.Right().Right().Right());

            return castle != null
                && !castle.HasMoved 
                && CurrentLocation.Right().Right().Equals(to) 
                && LocationsBetweenAreEmpty(castle.CurrentLocation);
        }

        bool LocationsBetweenAreEmpty(Location to)
        {
            return CurrentLocation.GetBetween(to).All(x => CurrentGame.GetPiece(x) == null);
        }
    }
}

using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame)
        {
        }

        protected override bool CanMoveToLocation(Location to)
        {
            return CurrentLocation.IsKnightMove(to) && CanTakeLocation(to);
        }

        //private bool IsUpUpLeft(Location to)
        //{
        //    return CurrentLocation.Up().Up().Left().Equals(to);
        //}

        //private bool IsUpUpRight(Location to)
        //{
        //    return CurrentLocation.Up().Up().Right().Equals(to);
        //}

        //private bool IsRightRightUp(Location to)
        //{
        //    return CurrentLocation.Right().Right().Up().Equals(to);
        //}

        //private bool IsRightRightDown(Location to)
        //{
        //    return CurrentLocation.Right().Right().Down().Equals(to);
        //}

        //private bool IsDownDownRight(Location to)
        //{
        //    return CurrentLocation.Down().Down().Right().Equals(to);
        //}
        
        //private bool IsDownDownLeft(Location to)
        //{
        //    return CurrentLocation.Down().Down().Left().Equals(to);
        //}
    }
}

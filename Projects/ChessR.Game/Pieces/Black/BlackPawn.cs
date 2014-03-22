using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces.Black
{
    public class BlackPawn : Pawn
    {
        public BlackPawn(Location location, Game currentGame)
            : base(Player.Black, location, currentGame) { }

        protected override bool IsDoubleMove(Location to)
        {
            if (HasMoved) return false;

            return CurrentLocation.Down().Down().Equals(to) && !LocationIsOccupied(to);
        }

        protected override bool IsForwardOneSquare(Location to)
        {
            return CurrentLocation.Down().Equals(to) && !LocationIsOccupied(to);
        }

        protected override bool IsDiagonalTake(Location to)
        {
            var isAdjacentDiagonal = CurrentLocation.BottomLeft().Equals(to) || CurrentLocation.BottomRight().Equals(to);
            var pieceInTargetLocation = CurrentGame.GetPiece(to, Player.White);
            return isAdjacentDiagonal && pieceInTargetLocation != null;
        }
    }
}

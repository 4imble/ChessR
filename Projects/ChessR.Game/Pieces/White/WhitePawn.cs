using ChessR.Game.Helpers;

namespace ChessR.Game.Pieces.White
{
    public class WhitePawn : Pawn
    {
        public WhitePawn(Location location, Game currentGame)
            : base(Player.White, location, currentGame) { }

        protected override bool IsDoubleMove(Location to)
        {
            if (HasMoved) return false;

            return CurrentLocation.Up().Up().Equals(to) && !LocationIsOccupied(to);
        }

        protected override bool IsForwardOneSquare(Location to)
        {
            return CurrentLocation.Up().Equals(to) && !LocationIsOccupied(to);
        }

        protected override bool IsDiagonalTake(Location to)
        {
            var isAdjacentDiagonal = CurrentLocation.TopLeft().Equals(to) || CurrentLocation.TopRight().Equals(to);
            var pieceInTargetLocation = CurrentGame.GetPiece(to, Player.Black);
            return isAdjacentDiagonal && pieceInTargetLocation != null;
        }
    }
}

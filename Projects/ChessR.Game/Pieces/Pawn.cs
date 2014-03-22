namespace ChessR.Game.Pieces
{
    public abstract class Pawn : Piece
    {
        protected Pawn(Player owner, Location location, Game currentGame)
            : base(owner, location, currentGame) { }

        protected bool HasMoved { get; private set; }

        public override void MoveTo(Location location)
        {
            base.MoveTo(location);
            HasMoved = true;
        }

        protected override bool CanMoveToLocation(Location to)
        {
            return IsForwardOneSquare(to) || IsDoubleMove(to) || IsDiagonalTake(to);
        }

        protected abstract bool IsDoubleMove(Location to);

        protected abstract bool IsForwardOneSquare(Location to);

        protected abstract bool IsDiagonalTake(Location to);

        protected bool LocationIsOccupied(Location to)
        {
            return CurrentGame.GetPiece(to) != null;
        }
    }
}

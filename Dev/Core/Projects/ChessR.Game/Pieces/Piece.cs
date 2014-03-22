namespace ChessR.Game.Pieces
{
    public abstract class Piece
    {
        public Player Owner { get; private set; }
        public Location CurrentLocation { get; protected set; }
        protected Game CurrentGame { get; private set; }

        protected Piece(Player owner, Location location, Game currentGame)
        {
            Owner = owner;
            CurrentLocation = location;
            CurrentGame = currentGame;
        }

        public virtual void MoveTo(Location location)
        {
            if (!CanMoveToLocation(location)) return;

            TakePieceIfAvailable(location);
            CurrentLocation = location;
        }

        void TakePieceIfAvailable(Location location)
        {
            var piece = CurrentGame.GetPiece(location);
            if (piece != null)
                CurrentGame.TakePiece(piece);
        }

        protected bool CanTakeLocation(Location to)
        {
            var pieceAtLocation = CurrentGame.GetPiece(to);
            return pieceAtLocation == null || pieceAtLocation.Owner != Owner;
        }

        protected abstract bool CanMoveToLocation(Location to);
    }
}

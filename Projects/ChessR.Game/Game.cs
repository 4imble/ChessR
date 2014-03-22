using System.Collections.Generic;
using System.Linq;
using ChessR.Game.Pieces;

namespace ChessR.Game
{
    public class Game
    {
        public IList<Piece> ActivePieces { get; private set; }
        public IList<Piece> TakenPieces { get; private set; }

        public Game()
        {
            ActivePieces = new List<Piece>();
            TakenPieces = new List<Piece>();
        }

        public void AddPiece(Piece piece)
        {
            ActivePieces.Add(piece);
        }

        public Piece GetPiece(string coords)
        {
            return GetPiece(new Location(coords));
        }

        public Piece GetPiece(Location location)
        {
            return ActivePieces.SingleOrDefault(x => x.CurrentLocation.Equals(location));
        }

        public Piece GetPiece(Location location, Player owner)
        {
            var piece = GetPiece(location);
            return piece != null && piece.Owner == owner ? piece : null;
        }

        public void TakePiece(Piece takenPiece)
        {
            ActivePieces.Remove(takenPiece);
            TakenPieces.Add(takenPiece);
        }
    }
}

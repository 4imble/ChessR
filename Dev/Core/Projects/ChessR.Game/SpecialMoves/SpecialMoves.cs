using ChessR.Game.Pieces;

namespace ChessR.Game.SpecialMoves
{
    public static class Castling
    {
        public static bool CanCastle(this King king, Game game)
        {
            if (king.HasMoved)
                return false;

            if ((GetLeftCastleOfKing(king) == null || GetLeftCastleOfKing(king).HasMoved) && (GetRightCastleOfKing(king) == null || GetRightCastleOfKing(king).HasMoved))
                return false;

            return true;
            //!king.HasMoved && (IsCastlingQueenSide(to) || IsCastlingKingSide(to));
        }

        static bool IsCastlingQueenSide(Location to)
        {
            //if (king.HasMoved)
            //    return false;

            //var castle = (Castle)CurrentGame.GetPiece(CurrentLocation.Left().Left().Left().Left());

            //return castle != null
            //    && !castle.HasMoved
            //    && CurrentLocation.Left().Left().Equals(to)
            //    && LocationsBetweenAreEmpty(castle.CurrentLocation);
            return false;
        }

        static bool IsCastlingKingSide(Location to)
        {
            //if (HasMoved)
            //    return false;

            //var castle = (Castle)CurrentGame.GetPiece(CurrentLocation.Right().Right().Right());

            //return castle != null
            //    && !castle.HasMoved
            //    && CurrentLocation.Right().Right().Equals(to)
            //    && LocationsBetweenAreEmpty(castle.CurrentLocation);
            return false;
        }

        static Castle GetLeftCastleOfKing(King king)
        {
            return 
        }


        static Castle GetRightCastleOfKing(King king)
        {
            return null;
        }
    }
}

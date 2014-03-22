using ChessR.Game.Pieces;
using Machine.Specifications;

namespace ChessR.Game.Specs.Subjects
{
    public class KnightAtE5Subject : GameSubject
    {
        protected static Knight knight;

        Establish context = () =>
        {
            knight = new Knight(Player.Black, new Location("E5"), game);

            game.AddPiece(knight);
        };

    }
}

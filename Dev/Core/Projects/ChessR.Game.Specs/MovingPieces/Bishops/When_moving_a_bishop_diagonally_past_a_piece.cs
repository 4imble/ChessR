using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Bishops
{
    [Subject("MovingPieces")]
    public class When_moving_a_bishop_diagonally_past_a_piece : GameSubject
    {
        static Bishop bishop;
        static Pawn conflictingPiece;

        Establish context = () =>
            {
                bishop = new Bishop(Player.Black, new Location("B7"), game);
                conflictingPiece = new BlackPawn(new Location("D5"), game);

                game.AddPiece(bishop);
                game.AddPiece(conflictingPiece);
            };

        Because of = () => bishop.MoveTo(new Location("E4"));

        It should_not_move_the_bishop_diagonally = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(bishop);
    }
}

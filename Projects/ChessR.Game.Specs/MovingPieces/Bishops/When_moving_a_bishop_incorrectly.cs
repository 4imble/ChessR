using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Bishops
{
    [Subject("MovingPieces")]
    public class When_moving_a_bishop_incorrectly : GameSubject
    {
        static Bishop bishop;

        Establish context = () =>
            {
                bishop = new Bishop(Player.Black, new Location("B7"), game);

                game.AddPiece(bishop);
            };

        Because of = () => bishop.MoveTo(new Location("D6"));

        It should_not_move_the_bishop_diagonally = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(bishop);
    }
}

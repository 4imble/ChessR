using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Queens
{
    [Subject("MovingPieces")]
    public class When_moving_a_queen_incorrectly : GameSubject
    {
        static Queen queen;

        Establish context = () =>
            {
                queen = new Queen(Player.Black, new Location("B7"), game);

                game.AddPiece(queen);
            };

        Because of = () => queen.MoveTo(new Location("D6"));

        It should_not_move_the_queen = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(queen);
    }
}

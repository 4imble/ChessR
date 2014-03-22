using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_down_down_right : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("F3"));

        It should_move_the_knight = () =>
            game.GetPiece("F3").ShouldBeEquivalentTo(knight);
    }
}

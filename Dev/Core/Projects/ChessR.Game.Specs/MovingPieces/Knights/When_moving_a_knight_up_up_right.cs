using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_up_up_right : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("F7"));

        It should_move_the_knight = () =>
            game.GetPiece("F7").ShouldBeEquivalentTo(knight);
    }
}

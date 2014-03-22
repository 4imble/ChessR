using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_left_left_up : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("C6"));

        It should_move_the_knight = () =>
            game.GetPiece("C6").ShouldBeEquivalentTo(knight);
    }
}

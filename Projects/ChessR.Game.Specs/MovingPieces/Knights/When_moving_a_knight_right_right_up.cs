using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_right_right_up : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("G6"));

        It should_move_the_knight = () =>
            game.GetPiece("G6").ShouldBeEquivalentTo(knight);
    }
}

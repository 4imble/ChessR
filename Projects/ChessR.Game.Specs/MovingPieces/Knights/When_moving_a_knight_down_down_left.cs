using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_down_down_left : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("D3"));

        It should_move_the_knight = () =>
            game.GetPiece("D3").ShouldBeEquivalentTo(knight);
    }
}

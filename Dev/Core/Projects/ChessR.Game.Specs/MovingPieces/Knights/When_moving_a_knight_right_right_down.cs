using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Knights
{
    [Subject("MovingPieces")]
    public class When_moving_a_knight_right_right_down : KnightAtE5Subject
    {
        Because of = () => knight.MoveTo(new Location("G4"));

        It should_move_the_knight = () =>
            game.GetPiece("G4").ShouldBeEquivalentTo(knight);
    }
}

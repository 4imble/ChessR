using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings
{
    [Subject("MovingPieces")]
    public class When_moving_a_king : GameSubject
    {
        static King king;

        Establish context = () =>
            {
                king = new King(Player.Black, new Location("E8"), game);

                game.AddPiece(king);
            };

        Because of = () => king.MoveTo(new Location("D7"));

        It should_know_the_king_has_moved = () =>
            king.HasMoved.Should().BeTrue();
    }
}

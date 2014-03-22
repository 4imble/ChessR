using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.MoveTo(new Location("F7"));

        It should_know_the_castle_has_moved = () =>
            castle.HasMoved.Should().BeTrue();
    }
}

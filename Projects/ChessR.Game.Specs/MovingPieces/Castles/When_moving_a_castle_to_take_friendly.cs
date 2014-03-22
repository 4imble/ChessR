using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_to_take_friendly : GameSubject
    {
        static Castle castle;
        static Castle friendlyCastle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);
                friendlyCastle = new Castle(Player.Black, new Location("E7"), game);

                game.AddPiece(castle);
                game.AddPiece(friendlyCastle);
            };

        Because of = () => castle.MoveTo(new Location("E7"));

        It should_not_move_to_the_location = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(castle);

        It should_not_take_the_friendly_castle = () =>
            game.TakenPieces.Should().NotContain(friendlyCastle);
    }
}

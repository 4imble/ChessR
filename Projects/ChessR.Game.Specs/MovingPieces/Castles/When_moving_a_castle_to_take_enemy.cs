using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_to_take_enemy : GameSubject
    {
        static Castle castle;
        static Castle enemyCastle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);
                enemyCastle = new Castle(Player.White, new Location("E7"), game);

                game.AddPiece(castle);
                game.AddPiece(enemyCastle);
            };

        Because of = () => castle.MoveTo(new Location("E7"));

        It should_move_to_the_location = () =>
            game.GetPiece("E7").ShouldBeEquivalentTo(castle);

        It should_take_the_enemy_castle = () =>
            game.TakenPieces.Should().Contain(enemyCastle);
    }
}

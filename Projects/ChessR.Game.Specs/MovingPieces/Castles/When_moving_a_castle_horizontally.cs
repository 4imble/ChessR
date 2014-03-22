using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_horizontally : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.MoveTo(new Location("F7"));

        It should_move_the_castle_horizontally_successfully = () =>
            game.GetPiece("F7").ShouldBeEquivalentTo(castle);
    }
}

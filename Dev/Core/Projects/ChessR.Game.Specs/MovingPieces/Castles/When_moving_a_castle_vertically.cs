using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_vertically : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.MoveTo(new Location("B2"));

        It should_move_the_castle_vertically_successfully = () =>
            game.GetPiece("B2").ShouldBeEquivalentTo(castle);
    }
}

using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_diagonally : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.MoveTo(new Location("C6"));

        It should_not_move_the_castle_diagonally = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(castle);
    }
}

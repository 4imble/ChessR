using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles
{
    [Subject("MovingPieces")]
    public class When_moving_a_castle_vertically_past_a_piece : GameSubject
    {
        static Castle castle;
        static Castle conflictingCastle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("B7"), game);
                conflictingCastle = new Castle(Player.White, new Location("B6"), game);

                game.AddPiece(castle);
                game.AddPiece(conflictingCastle);
            };

        Because of = () => castle.MoveTo(new Location("B2"));

        It should_not_move_the_castle_horizontally = () =>
            castle.CurrentLocation.XY.ShouldBeEquivalentTo("B7", "because there is a piece in the way");
    }
}

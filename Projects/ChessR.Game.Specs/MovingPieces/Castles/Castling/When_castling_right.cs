using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles.Castling
{
    [Subject("MovingPieces")]
    public class When_castling_right : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("A1"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.CastleRight();

        It should_move_the_castle_left_two_spaces = () =>
            game.GetPiece("D1").ShouldBeEquivalentTo(castle);
    }
}

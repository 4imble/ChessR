using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Castles.Castling
{
    [Subject("MovingPieces")]
    public class When_castling_left : GameSubject
    {
        static Castle castle;

        Establish context = () =>
            {
                castle = new Castle(Player.Black, new Location("H1"), game);

                game.AddPiece(castle);
            };

        Because of = () => castle.CastleLeft();

        It should_move_the_castle_left_two_spaces = () =>
            game.GetPiece("F1").ShouldBeEquivalentTo(castle);
    }
}

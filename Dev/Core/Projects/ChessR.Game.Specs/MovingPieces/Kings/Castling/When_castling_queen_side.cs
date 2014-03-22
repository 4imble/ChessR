using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings.Castling
{
    [Subject("MovingPieces")]
    public class When_castling_queen_side : GameSubject
    {
        static King king;
        static Castle castle;

        Establish context = () =>
            {
                king = new King(Player.White, new Location("E1"), game);
                castle = new Castle(Player.White, new Location("A1"), game);

                game.AddPiece(king);
                game.AddPiece(castle);
            };

        Because of = () => king.MoveTo(new Location("C1"));

        It should_move_the_king = () =>
            game.GetPiece("C1").ShouldBeEquivalentTo(king);

        It should_move_the_castle = () =>
            game.GetPiece("D1").ShouldBeEquivalentTo(castle);
    }
}

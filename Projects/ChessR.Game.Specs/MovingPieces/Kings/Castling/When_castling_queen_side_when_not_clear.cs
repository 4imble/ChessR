using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings.Castling
{
    [Subject("MovingPieces")]
    public class When_castling_queen_side_when_not_clear : GameSubject
    {
        static King king;
        static Castle castle;
        static Knight knight;

        Establish context = () =>
            {
                king = new King(Player.White, new Location("E1"), game);
                castle = new Castle(Player.White, new Location("A1"), game);
                knight = new Knight(Player.White, new Location("B1"), game);

                game.AddPiece(king);
                game.AddPiece(castle);
                game.AddPiece(knight);
            };

        Because of = () => king.MoveTo(new Location("C1"));

        It should_not_move_the_king = () =>
            game.GetPiece("E1").ShouldBeEquivalentTo(king);

        It should_not_move_the_castle = () =>
            game.GetPiece("A1").ShouldBeEquivalentTo(castle);
    }
}

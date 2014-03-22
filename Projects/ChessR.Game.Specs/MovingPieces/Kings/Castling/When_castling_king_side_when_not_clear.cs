using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings.Castling
{
    [Subject("MovingPieces")]
    public class When_castling_king_side_when_not_clear : GameSubject
    {
        static King king;
        static Castle castle;
        static Bishop bishop;

        Establish context = () =>
            {
                king = new King(Player.White, new Location("E1"), game);
                castle = new Castle(Player.White, new Location("H1"), game);
                bishop = new Bishop(Player.White, new Location("F1"), game);

                game.AddPiece(king);
                game.AddPiece(castle);
                game.AddPiece(bishop);
            };

        Because of = () => king.MoveTo(new Location("G1"));

        It should_not_move_the_king = () =>
            game.GetPiece("E1").ShouldBeEquivalentTo(king);

        It should_not_move_the_castle = () =>
            game.GetPiece("H1").ShouldBeEquivalentTo(castle);
    }
}

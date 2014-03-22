using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using ChessR.Game.Specs._TestDoubles;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings.Castling
{
    [Subject("MovingPieces")]
    internal class When_castling_queen_side_but_king_has_moved : GameSubject
    {
        static King king;
        static Castle castle;

        Establish context = () =>
        {
            king = new MovedKing(Player.White, new Location("E1"), game);
            castle = new Castle(Player.White, new Location("A1"), game);

            game.AddPiece(king);
            game.AddPiece(castle);
        };

        Because of = () => king.MoveTo(new Location("C1"));

        It should_not_move_the_king = () =>
            game.GetPiece("E1").ShouldBeEquivalentTo(king);

        It should_not_move_the_castle = () =>
            game.GetPiece("A1").ShouldBeEquivalentTo(castle);
    }
}

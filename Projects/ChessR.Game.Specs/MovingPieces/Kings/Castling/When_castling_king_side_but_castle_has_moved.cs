using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using ChessR.Game.Specs._TestDoubles;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings.Castling
{
    [Subject("MovingPieces")]
    internal class When_castling_king_side_but_castle_has_moved : GameSubject
    {
        static King king;
        static Castle castle;

        Establish context = () =>
        {
            king = new King(Player.White, new Location("E1"), game);
            castle = new MovedCastle(Player.White, new Location("H1"), game);

            game.AddPiece(king);
            game.AddPiece(castle);
        };

        Because of = () => king.MoveTo(new Location("G1"));

        It should_not_move_the_king = () =>
            game.GetPiece("E1").ShouldBeEquivalentTo(king);

        It should_not_move_the_castle = () =>
            game.GetPiece("H1").ShouldBeEquivalentTo(castle);
    }
}

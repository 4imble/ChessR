using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Pawns
{
    [Subject("MovingPieces")]
    public class When_moving_a_pawn_diagonally_with_nothing_to_take : GameSubject
    {
        static Pawn blackPawn;
        static Pawn whitePawn;

        Establish context = () =>
        {
            blackPawn = new BlackPawn(new Location("F7"), game);
            whitePawn = new WhitePawn(new Location("C2"), game);

            game.AddPiece(blackPawn);
            game.AddPiece(whitePawn);
        };

        Because of = () =>
            {
                blackPawn.MoveTo(new Location("G6"));
                whitePawn.MoveTo(new Location("D3"));
            };

        It should_not_move_the_black_pawn_diagonally = () =>
            game.GetPiece("F7").ShouldBeEquivalentTo(blackPawn);

        It should_not_move_the_white_pawn_diagonally = () =>
            game.GetPiece("C2").ShouldBeEquivalentTo(whitePawn);
    }
}

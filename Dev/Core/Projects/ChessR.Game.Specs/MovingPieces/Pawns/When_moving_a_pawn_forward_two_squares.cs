using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Pawns
{
    [Subject("MovingPieces")]
    public class When_moving_a_pawn_forward_two_squares : GameSubject
    {
        static Pawn blackPawn;
        static Pawn whitePawn;

        Establish context = () =>
        {
            blackPawn = new BlackPawn(new Location("B7"), game);
            whitePawn = new WhitePawn(new Location("B2"), game);

            game.AddPiece(blackPawn);
            game.AddPiece(whitePawn);
        };

        Because of = () =>
        {
            game.GetPiece("B7").MoveTo(new Location("B5"));
            game.GetPiece("B2").MoveTo(new Location("B4"));
        };

        It should_move_the_black_pawn_forward_two_square_successfully = () =>
            game.GetPiece("B5").ShouldBeEquivalentTo(blackPawn);

        It should_move_the_white_pawn_forward_two_square_successfully = () =>
            game.GetPiece("B4").ShouldBeEquivalentTo(whitePawn);
    }
}

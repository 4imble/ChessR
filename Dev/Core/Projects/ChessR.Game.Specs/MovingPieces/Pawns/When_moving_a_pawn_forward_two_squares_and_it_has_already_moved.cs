using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Pawns
{
    [Subject("MovingPieces")]
    public class When_moving_a_pawn_forward_two_squares_and_it_has_already_moved : GameSubject
    {
        static Pawn blackPawn;
        static Pawn whitePawn;

        Establish context = () =>
        {
            blackPawn = new BlackPawn(new Location("B7"), game);
            whitePawn = new WhitePawn(new Location("C2"), game);

            blackPawn.MoveTo(new Location("B6"));
            whitePawn.MoveTo(new Location("C3"));

            game.AddPiece(blackPawn);
            game.AddPiece(whitePawn);
        };

        Because of = () =>
        {
            blackPawn.MoveTo(new Location("B4"));
            whitePawn.MoveTo(new Location("C5"));
        };

        It should_not_move_the_black_pawn_forward_two_square = () =>
            game.GetPiece("B6").ShouldBeEquivalentTo(blackPawn);

        It should_not_move_the_white_pawn_forward_two_square = () =>
            game.GetPiece("C3").ShouldBeEquivalentTo(whitePawn);
    }
}

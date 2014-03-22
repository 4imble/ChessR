using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Pawns
{
    [Subject("MovingPieces")]
    public class When_moving_a_pawn_to_a_conflicting_square : GameSubject
    {
        static Pawn blackPawn;
        static Pawn whitePawn;
        static Pawn conflictingPawn1;
        static Pawn conflictingPawn2;

        Establish context = () =>
        {
            blackPawn = new BlackPawn(new Location("B7"), game);
            whitePawn = new WhitePawn(new Location("B2"), game);

            conflictingPawn1 = new BlackPawn(new Location("B5"), game);
            conflictingPawn2 = new WhitePawn(new Location("B3"), game);
            
            game.AddPiece(blackPawn);
            game.AddPiece(whitePawn);
            game.AddPiece(conflictingPawn1);
            game.AddPiece(conflictingPawn2);
        };

        Because of = () =>
            {
                game.GetPiece("B7").MoveTo(new Location("B5"));
                game.GetPiece("B2").MoveTo(new Location("B3"));
            };

        It should_not_move_the_pawn_forward_two_square = () =>
            game.GetPiece("B7").ShouldBeEquivalentTo(blackPawn);

        It should_not_move_the_white_pawn_forward_one_square = () =>
            game.GetPiece("B2").ShouldBeEquivalentTo(whitePawn);
    }
}

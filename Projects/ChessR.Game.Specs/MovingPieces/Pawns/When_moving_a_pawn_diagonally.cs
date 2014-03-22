using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Pawns
{
    [Subject("MovingPieces")]
    public class When_moving_a_pawn_diagonally : GameSubject
    {
        static Pawn blackPawn;
        static Pawn whitePawn;
        static Pawn blackPawnToTake;
        static Pawn whitePawnToTake;

        Establish context = () =>
        {
            blackPawn = new BlackPawn(new Location("F7"), game);
            whitePawn = new WhitePawn(new Location("C2"), game);

            whitePawnToTake = new WhitePawn(new Location("G6"), game);
            blackPawnToTake = new BlackPawn(new Location("D3"), game);

            game.AddPiece(blackPawn);
            game.AddPiece(whitePawn);
            game.AddPiece(blackPawnToTake);
            game.AddPiece(whitePawnToTake);
        };

        Because of = () =>
            {
                blackPawn.MoveTo(new Location("G6"));
                whitePawn.MoveTo(new Location("D3"));
            };

        It should_move_the_black_pawn_diagonally_successfully = () =>
            game.GetPiece("G6").ShouldBeEquivalentTo(blackPawn);

        It should_move_the_white_pawn_diagonally_successfully = () =>
            game.GetPiece("D3").ShouldBeEquivalentTo(whitePawn);
    }
}

using ChessR.Game.Pieces;
using ChessR.Game.Pieces.Black;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.AddingPiecesToSquares
{
    [Subject("AddingPiecesToSquares")]
    public class When_adding_pieces_to_the_board : GameSubject
    {
        static Pawn expectedBlackPawn;
        static Pawn expectedWhitePawn;

        Establish context = () =>
        {
            expectedBlackPawn = new BlackPawn(new Location("B1"), game);
            expectedWhitePawn = new WhitePawn(new Location("B2"), game);
        };

        Because of = () =>
            {
                game.AddPiece(expectedBlackPawn);
                game.AddPiece(expectedWhitePawn);
            };

        It should_have_a_black_pawn_at_square_b1 = () =>
            game.GetPiece("B1").ShouldBeEquivalentTo(expectedBlackPawn);

        It should_have_a_white_pawn_at_square_b2 = () =>
            game.GetPiece("B2").ShouldBeEquivalentTo(expectedWhitePawn);

    }
}

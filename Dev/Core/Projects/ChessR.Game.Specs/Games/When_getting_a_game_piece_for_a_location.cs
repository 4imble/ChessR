using ChessR.Game.Pieces;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Games
{
    [Subject("Games")]
    public class When_getting_a_game_piece_for_a_location : GameSubject
    {
        static Piece piece;
        static Piece expectedPiece;

        Establish context = () =>
            {
                expectedPiece = new WhitePawn(new Location("B2"), game);
                game.AddPiece(expectedPiece);
            };

        Because of = () => piece = game.GetPiece("B2");

        It should_get_the_expected_piece = () => 
            piece.Should().Be(expectedPiece);
    }
}

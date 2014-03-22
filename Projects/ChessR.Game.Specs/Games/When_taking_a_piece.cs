using ChessR.Game.Pieces;
using ChessR.Game.Pieces.White;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Games
{
    [Subject("Games")]
    public class When_taking_a_piece : GameSubject
    {
        static Piece takenPiece;

        Establish context = () =>
            {
                takenPiece = new WhitePawn(new Location("B2"), game);
                game.AddPiece(takenPiece);
            };

        Because of = () => game.TakePiece(takenPiece);

        It should_remove_the_piece_from_active_pieces = () =>
            game.ActivePieces.Should().NotContain(takenPiece);

        It should_add_the_piece_to_the_taken_pieces = () =>
            game.TakenPieces.Should().Contain(takenPiece);
    }
}

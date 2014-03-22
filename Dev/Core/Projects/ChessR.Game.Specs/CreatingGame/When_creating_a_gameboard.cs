using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.CreatingGame
{
    [Subject("CreatingGameBoard")]
    public class When_creating_a_gameboard : GameSubject
    {
        It should_have_a_list_of_active_pieces = () =>
            game.ActivePieces.Should().NotBeNull();

        It should_have_a_list_of_taken_pieces = () =>
            game.TakenPieces.Should().NotBeNull();
    }
}

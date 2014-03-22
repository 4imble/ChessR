using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Queens
{
    [Subject("MovingPieces")]
    public class When_moving_a_queen_diagonally : GameSubject
    {
        static Queen queen;

        Establish context = () =>
            {
                queen = new Queen(Player.Black, new Location("B7"), game);

                game.AddPiece(queen);
            };

        Because of = () => queen.MoveTo(new Location("D5"));

        It should_move_the_queen_diagonally = () =>
            game.GetPiece("D5").ShouldBeEquivalentTo(queen);
    }
}

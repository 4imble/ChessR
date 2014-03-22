using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Queens
{
    [Subject("MovingPieces")]
    public class When_moving_a_queen_vertically : GameSubject
    {
        static Queen queen;

        Establish context = () =>
            {
                queen = new Queen(Player.Black, new Location("G7"), game);

                game.AddPiece(queen);
            };

        Because of = () => queen.MoveTo(new Location("G2"));

        It should_move_the_queen_vertically = () =>
            game.GetPiece("G2").ShouldBeEquivalentTo(queen);
    }
}

using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using ChessR.Game.Specs._TestDoubles;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings
{
    [Subject("MovingPieces")]
    public class When_moving_a_king_horizontally : GameSubject
    {
        static King king;

        Establish context = () =>
            {
                king = new MovedKing(Player.Black, new Location("G7"), game);

                game.AddPiece(king);
            };

        Because of = () => king.MoveTo(new Location("H7"));

        It should_move_the_king_horizonatlly = () =>
            game.GetPiece("H7").ShouldBeEquivalentTo(king);
    }
}

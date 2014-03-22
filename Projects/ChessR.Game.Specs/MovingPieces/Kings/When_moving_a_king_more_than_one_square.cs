using ChessR.Game.Pieces;
using ChessR.Game.Specs.Subjects;
using ChessR.Game.Specs._TestDoubles;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.MovingPieces.Kings
{
    [Subject("MovingPieces")]
    public class When_moving_a_king_more_than_one_square : GameSubject
    {
        static King king1;
        static King king2;
        static King king3;

        Establish context = () =>
            {
                king1 = new MovedKing(Player.Black, new Location("A1"), game);
                king2 = new MovedKing(Player.Black, new Location("E2"), game);
                king3 = new MovedKing(Player.Black, new Location("H8"), game);
                game.AddPiece(king1);
                game.AddPiece(king2);
                game.AddPiece(king3);
            };

        Because of = () =>
            {
                king1.MoveTo(new Location("D4"));
                king2.MoveTo(new Location("E5"));
                king3.MoveTo(new Location("D8"));
            };

        It should_not_move_the_king_diagonally = () =>
            {
                game.GetPiece("A1").ShouldBeEquivalentTo(king1);
                game.GetPiece("D4").Should().BeNull();
            };

        It should_not_move_the_king_vertically = () =>
            {
                game.GetPiece("E2").ShouldBeEquivalentTo(king2);
                game.GetPiece("E5").Should().BeNull();
            };

        It should_not_move_the_king_horizontally = () =>
            {
                game.GetPiece("H8").ShouldBeEquivalentTo(king3);
                game.GetPiece("D8").Should().BeNull();
            };
    }
}

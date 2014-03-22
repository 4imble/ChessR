using ChessR.Game.Helpers;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Helpers.LocationExtensions
{
    [Subject("Locations")]
    public class When_checking_if_move_is_diagonal
    {
        static Location locationFrom;
        static Location locationTo;
        static bool isDiagonal;

        Establish context = () =>
            {
                locationFrom = new Location("B2");
                locationTo = new Location("E5");
            };

        Because of = () => { isDiagonal = locationFrom.IsDiagonalFrom(locationTo); };

        It should_return_return_true = () =>
            isDiagonal.Should().BeTrue();
    }
}

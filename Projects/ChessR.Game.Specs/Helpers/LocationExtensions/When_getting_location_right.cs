using ChessR.Game.Helpers;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Helpers.LocationExtensions
{
    [Subject("Locations")]
    public class When_getting_location_right
    {
        static Location location;

        Establish context = () => location = new Location("D2");

        Because of = () => { location = location.Right(); };

        It should_have_x_coord_of_e = () =>
            location.X.Should().Be("E");

        It should_have_y_coord_of_2 = () =>
            location.Y.Should().Be("2");
    }
}

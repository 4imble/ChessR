using ChessR.Game.Helpers;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Helpers.LocationExtensions
{
    [Subject("Locations")]
    public class When_getting_location_left
    {
        static Location location;

        Establish context = () => location = new Location("D2");

        Because of = () => { location = location.Left(); };

        It should_have_x_coord_of_c = () =>
            location.X.Should().Be("C");

        It should_have_y_coord_of_2 = () =>
            location.Y.Should().Be("2");
    }
}

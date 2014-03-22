using ChessR.Game.Helpers;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Helpers.LocationExtensions
{
    [Subject("Locations")]
    public class When_getting_location_top_left

{
    static Location location;

    Establish context = () => location = new Location("B2");

    Because of = () => { location = location.TopLeft(); };

    It should_have_x_coord_of_a = () =>
        location.X.Should().Be("A");

    It should_have_y_coord_of_3 = () =>
        location.Y.Should().Be("3");
}
}

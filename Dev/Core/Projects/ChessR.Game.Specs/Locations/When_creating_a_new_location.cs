using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Locations
{
    [Subject("Locations")]
    public class When_creating_a_new_location
    {
        static Location location;

        Because of = () => location = new Location("b2");

        It should_have_x_coord_of_b = () =>
            location.X.Should().Be("B");

        It should_have_y_coord_of_2 = () =>
            location.Y.Should().Be("2");
    }
}

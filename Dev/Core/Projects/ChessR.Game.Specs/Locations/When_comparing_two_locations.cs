using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Locations
{
    [Subject("Locations")]
    public class When_comparing_two_locations
    {
        static Location location1;
        static Location location2;

        static bool match;

        Establish context = () =>
            {
                location1 = new Location("B2");
                location2 = new Location("B2");
            };

        Because of = () => match = location1.Equals(location2);

        It should_be_equal = () => match.Should().BeTrue("because the coords are the same");
    }
}

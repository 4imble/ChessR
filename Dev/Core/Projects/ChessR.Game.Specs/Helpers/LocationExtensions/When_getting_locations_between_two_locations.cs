using System.Collections.Generic;
using ChessR.Game.Helpers;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Helpers.LocationExtensions
{
    [Subject("Locations")]
    public class When_getting_locations_between_two_locations
    {
        static Location locationFrom;
        static Location locationTo;
        static IList<Location> locationsBetween;
        static IList<Location> expectedLocationsBetween;

        Establish context = () =>
            {
                locationFrom = new Location("D4");
                locationTo = new Location("H4");

                expectedLocationsBetween = new List<Location>
                    {
                        new Location("E4"), 
                        new Location("F4"), 
                        new Location("G4")
                    };
            };

        Because of = () => { locationsBetween = locationFrom.GetBetween(locationTo); };

        It should_have_the_correct_locations = () =>
            locationsBetween.Should().Equal(expectedLocationsBetween);
    }
}

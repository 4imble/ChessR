using System;
using DesignByContract;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Locations
{
    [Subject("Locations")]
    public class When_creating_an_invalid_location
    {
        static Action location1;
        static Action location2;

        Because of = () =>
            {
                location1 = () => new Location("I7");
                location2 = () => new Location("A9");
            };

        It should_throw_exception_due_to_x_location = () =>
            location1.ShouldThrow<DbcException>().WithMessage("Failed Requires test. Not a valid rank location.");

        It should_throw_exception_due_to_y_location = () =>
            location2.ShouldThrow<DbcException>().WithMessage("Failed Requires test. Not a valid file location.");
    }
}

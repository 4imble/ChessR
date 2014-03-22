using System;
using ChessR.Game.Helpers;
using DesignByContract;
using FluentAssertions;
using Machine.Specifications;

namespace ChessR.Game.Specs.Locations
{
    [Subject("Locations")]
    public class When_moving_to_an_invalid_location
    {
        static Action action1;
        static Action action2;

        Because of = () =>
            {
                action1 = () => new Location("A1").Down();
                action2 = () => new Location("H8").Right();
            };

        It should_throw_exception_due_to_y_location = () =>
            action1.ShouldThrow<DbcException>().WithMessage("Failed Requires test. Not a valid file location.");

        It should_throw_exception_due_to_x_location = () =>
            action2.ShouldThrow<DbcException>().WithMessage("Failed Requires test. Not a valid rank location.");
    }
}

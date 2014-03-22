using Machine.Specifications;

namespace ChessR.Game.Specs.Subjects
{
    public class GameSubject
    {
        protected static Game game;

        Establish context = () =>
            {
                game = new Game();
            };
    }
}

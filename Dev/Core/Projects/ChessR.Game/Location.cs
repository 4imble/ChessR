using ChessR.Game.Helpers;
using DesignByContract;

namespace ChessR.Game
{
    public class Location
    {
        public bool Equals(Location other)
        {
            return string.Equals(XY, other.XY);
        }

        public override bool Equals(object obj)
        {
            return Equals((Location)obj);
        }

        public override int GetHashCode()
        {
            return (XY != null ? XY.GetHashCode() : 0);
        }

        public Location(string coords)
        {
            XY = coords.ToUpper();
            Dbc.Requires(X.RankLetterToNumber() > 0 && X.RankLetterToNumber() < 9, "Not a valid rank location.");
            Dbc.Requires(Y.FileNumberToNumber() > 0 && Y.FileNumberToNumber() < 9, "Not a valid file location.");
        }

        public string XY { get; private set; }

        public string X { get { return XY.ToCharArray()[0].ToString(); } }
        public string Y { get { return XY.ToCharArray()[1].ToString(); } }
    }
}

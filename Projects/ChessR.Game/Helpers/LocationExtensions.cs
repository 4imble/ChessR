using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ChessR.Game.Helpers
{
    public static class LocationExtensions
    {
        public static Location Up(this Location location)
        {
            var yPlus1 = location.Y.FileNumberToNumber() + 1;
            return new Location(location.X + yPlus1);
        }

        public static Location Down(this Location location)
        {
            var yMinus1 = location.Y.FileNumberToNumber() - 1;
            return new Location(location.X + yMinus1);
        }

        public static Location Left(this Location location)
        {
            var xMinus1 = location.X.RankLetterToNumber() - 1;
            return new Location(xMinus1.NumberToText() + location.Y);
        }

        public static Location Right(this Location location)
        {
            var xMinus1 = location.X.RankLetterToNumber() + 1;
            return new Location(xMinus1.NumberToText() + location.Y);
        }

        public static Location TopLeft(this Location location)
        {
            return location.Up().Left();
        }

        public static Location TopRight(this Location location)
        {
            return location.Up().Right();
        }

        public static Location BottomLeft(this Location location)
        {
            return location.Down().Left();
        }

        public static Location BottomRight(this Location location)
        {
            return location.Down().Right();
        }

        public static IList<Location> GetBetween(this Location fromLocation, Location toLocation)
        {
            return GetLocationsBetweenMovement(fromLocation, toLocation);
        }

        public static bool IsDiagonalFrom(this Location fromLocation, Location toLocation)
        {
            var xDiff = fromLocation.X.RankLetterToNumber() - toLocation.X.RankLetterToNumber();
            var yDiff = fromLocation.Y.FileNumberToNumber() - toLocation.Y.FileNumberToNumber();
            return Math.Abs(xDiff) == Math.Abs(yDiff);
        }

        public static bool IsHorizontalFrom(this Location fromLocation, Location to)
        {
            return fromLocation.Y == to.Y;
        }

        public static bool IsVerticalFrom(this Location fromLocation, Location to)
        {
            return fromLocation.X == to.X;
        }

        public static bool IsKnightMove(this Location fromLocation, Location toLocation)
        {
            var verticalDistance = Math.Abs(toLocation.Y.FileNumberToNumber() - fromLocation.Y.FileNumberToNumber());
            var horizontalDistance = Math.Abs(toLocation.X.RankLetterToNumber() - fromLocation.X.RankLetterToNumber());

            return (verticalDistance == 2 && horizontalDistance == 1) || (verticalDistance == 1 && horizontalDistance == 2);
        }

        public static int DistanceTravelled(this Location fromLocation, Location toLocation)
        {
            var verticalDifference = toLocation.Y.FileNumberToNumber() - fromLocation.Y.FileNumberToNumber();
            var horizontalDifference = toLocation.X.RankLetterToNumber() - fromLocation.X.RankLetterToNumber();

            return Math.Max(Math.Abs(verticalDifference), Math.Abs(horizontalDifference));
        }

        public static int RankLetterToNumber(this string text)
        {
            return text[0] - 'A' + 1;
        }

        public static int FileNumberToNumber(this string text)
        {
            return Convert.ToInt32(text);
        }

        public static string NumberToText(this int number)
        {
            return ((char)(number + 'A' - 1)).ToString();
        }

        static IList<Location> GetLocationsBetweenMovement(Location fromLocation, Location toLocation)
        {
            var locations = new List<Location>();

            var verticalDifference = toLocation.Y.FileNumberToNumber() - fromLocation.Y.FileNumberToNumber();
            var verticalDirection = Math.Sign(verticalDifference);

            var horizontalDifference = toLocation.X.RankLetterToNumber() - fromLocation.X.RankLetterToNumber();
            var horizontalDirection = Math.Sign(horizontalDifference);

            var distance = DistanceTravelled(fromLocation, toLocation);

            var locationToAdd = fromLocation;
            for (var i = 1; i < distance; i++)
            {
                if(verticalDirection != 0)
                    locationToAdd = verticalDirection == 1 ? locationToAdd.Up() : locationToAdd.Down();

                if (horizontalDirection != 0)
                    locationToAdd = horizontalDirection == 1 ? locationToAdd.Right() : locationToAdd.Left();

                locations.Add(locationToAdd);
            }

            return locations;
        }


    }
}

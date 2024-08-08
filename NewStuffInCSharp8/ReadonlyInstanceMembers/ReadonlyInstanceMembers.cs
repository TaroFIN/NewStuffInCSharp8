using System;

namespace NewStuffInCSharp8
{
    class ReadonlyInstanceMembers
    {
        public static void Output()
        {
            Point_Readonly point = new Point_Readonly();
            point.X = 2;
            point.Y = 4;
            Console.WriteLine(point.DisplayPosition());
        }
    }
    public struct Point_Readonly
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);
        //If we remove readonly, it will raise warning

        public readonly string DisplayPosition() =>
            $"({X},{Y}) is {Distance} from origin";
    }
}

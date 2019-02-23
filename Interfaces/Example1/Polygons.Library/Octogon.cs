using System;
namespace Polygons.Library
{
    public class Octogon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octogon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetArea()
        {
            return NumberOfSides * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}

using System;
namespace Polygons.Library
{
    public class Square : RegularPolygon
    {
        public Square(int length) : base(4, length)
        {

        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}

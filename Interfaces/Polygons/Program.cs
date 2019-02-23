using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octogon = new Octogon(5);
            DisplayPolygon("Octogon", octogon);
        }

        private static void DisplayPolygon(string shape, dynamic square)
        {
            Console.WriteLine($"{shape} Number of sides : {square.NumberOfSides}");
            Console.WriteLine($"{shape} Side Length : {square.SideLength}");
            Console.WriteLine($"{shape} Perimeter : {square.GetPerimeter()}");
            Console.WriteLine($"{shape} Area : {square.GetArea()}");
        }
    }
}

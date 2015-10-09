using System;
using static System.Math;

namespace Test.Static
{
    public class Point
    {

        public int X { get; set; } = 2;
        public int Y { get; set; } = 3;

        // Exemplo antigo
        public double FindDistance(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(this.X - otherPoint.X, 2) + Math.Pow(this.Y - otherPoint.Y, 2));
        }
        
        // Usando static + bodiedexpression
        public double FindDistance2(Point p) => Sqrt(Pow(this.X - p.X, 2) + Pow(this.Y - p.Y, 2));

        public double GenericFunction(double x)
        {
            var first = 3 * (x * Math.Pow(Math.E, 3 * x) - 54 * Math.Pow(x, 5) + 9 * (Math.Pow(x, 5) * Math.Pow(Math.E, x) + 4 * Math.Pow(x, 3) * Math.Pow(Math.E, x)) - 3 * (2 * Math.Pow(x, 3) * Math.Pow(Math.E, 2 * x) + 2 * x * Math.Pow(Math.E, 2 * x)));
            var sec = 3 * (x * Pow(E, 3 * x) - 54 * Pow(x, 5) + 9 * (Pow(x, 5) * Pow(E, x) + 4 * Pow(x, 3) * Pow(E, x)) - 3 * (2 * Pow(x, 3) * Pow(E, 2 * x) + 2 * x * Pow(E, 2 * x)));
            return sec;
        }

    }
}

using Geometry.Interfaces;

namespace Geometry.Models
{
    public class Circle : ICircle
    {
        public double Radius { get; }
        public double Square { get; }

        public Circle(double radius)
        {
            ValidateOfRadius(radius);
            Radius = radius;
            Square = GetSquare(radius);
        }

        public static void ValidateOfRadius(in double radius)
        {
            if (radius <= 0)
                throw new Exception("radius must be >0");
        }

        public static double GetSquare(in double radius)
        {
            return Math.PI * Math.Pow(radius,2d);
        }
    }
}

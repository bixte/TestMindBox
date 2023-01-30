using Geometry.Interfaces;
using System.Reflection.Metadata;

namespace Geometry.Models
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Perimeter { get; }
        public double Square { get; }
        public bool IsRectangular { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateOfSides(sideA, sideB, sideC);
            var maxSide = Math.Max(sideC, Math.Max(sideA, sideB));
            var perimeter = GetPerimeter(sideA, sideB, sideC);
            ValidateOfSides(perimeter, maxSide);
            Perimeter = perimeter;
            Square = GetSquare(sideA, sideB, sideC);
            IsRectangular = GetIsRectangular(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public static double GetPerimeter(in double a, in double b, in double c) => a + b + c;
        public static double GetSquare(in double a, in double b, in double c)
        {
            var halfPerimeter = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(
                halfPerimeter
                * (halfPerimeter - a)
                * (halfPerimeter - b)
                * (halfPerimeter - c));
        }
        public static bool GetIsRectangular(in double a, in double b, in double c)
        {
            return a == b || a == c || b == c;
        }
        private static void ValidateOfSides(in double a, in double b, in double c)
        {

            if (a <= 0)
                throw new ArgumentException("Неверно указана сторона.", nameof(a));

            if (b <= 0)
                throw new ArgumentException("Неверно указана сторона.", nameof(b));

            if (c <= 0)
                throw new ArgumentException("Неверно указана сторона.", nameof(c));
        }
        private static void ValidateOfSides(in double perimeter, in double maxSide)
        {
            if (maxSide > perimeter - maxSide)
                throw new Exception("The largest side must be less that sum of other sides");
        }
    }
}

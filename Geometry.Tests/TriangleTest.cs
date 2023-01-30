using Geometry.Models;

namespace Geometry.Tests
{
    public class TriangleTest
    {
        [Test]
        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 1, 1)]
        [TestCase(0, 0, 0)]
        public void InitTriangle(double a, double b, double c)
        {
            Assert.Catch<Exception>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetSquare()
        {
            double a = 3d, b = 4d, c = 5d;
            double expected = 6d;
            var triangle = new Triangle(a, b, c);
            var square = triangle.Square;
            Assert.That(square, Is.EqualTo(expected));
        }
        [Test]
        public void GetPerimeter()
        {
            double a = 3d, b = 4d, c = 5d;
            double expected = 12d;
            var triangle = new Triangle(a, b, c);
            var perimeter = triangle.Perimeter;
            Assert.That(perimeter, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(5,10,10)]
        [TestCase(10,10,10)]
        [TestCase(20,15,15)]
        public void IsRectangular(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRectangular, Is.True);
        }
    }
}
using Geometry.Models;

namespace Geometry.Tests
{
    public class CircleTest
    {
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void InitCircle(double radius)
        {
            Assert.Catch<Exception>(() => new Circle(radius));
        }

        [Test]
        public void GetSquare()
        {
            double radius = 2d;
            double expected = 12.566370614359172;
            var triangle = new Circle(radius);
            var square = triangle.Square;
            Assert.That(square, Is.EqualTo(expected));
        }
    }
}

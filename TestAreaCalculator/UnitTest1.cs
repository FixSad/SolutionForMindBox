using AreaCalculator.Interfaces;
using AreaCalculator.Shapes;

namespace TestAreaCalculator
{
    public class UnitTest1
    {
        //SQUARE TESTING
        [Fact]
        public void Square_TryPositiveSide_WithDot()
        {
            IShape square = new Square(3.5);
            double area = square.CalculateArea();
            Assert.Equal(12.25, area);
        }

        [Fact]
        public void Square_TryNegativeSide()
        {
            IShape square = new Square(-4);
            square.CalculateArea();
            double area = square.Area;
            Assert.Equal(16, area);
        }

        [Fact]
        public void Square_TryToString()
        {
            IShape square = new Square(16);
            square.CalculateArea();
            string expected = "Shape: Square, Area: 256";
            string actual = square.ToString();
            Assert.Equal(expected, actual);
        }

        // CIRCLE TESTING
        [Fact]
        public void Circle_TryPositiveSide_WithDot()
        {
            IShape circle = new Circle(3.7);
            circle.CalculateArea();
            double area = Math.Round(circle.Area);
            Assert.Equal(43, area);
        }

        [Fact]
        public void Circle_TryNegativeSide()
        {
            IShape circle = new Circle(-5);
            double area = Math.Round(circle.CalculateArea());
            Assert.Equal(79, area);
        }

        [Fact]
        public void Circle_TryToString()
        {
            IShape circle = new Circle(2);
            circle.CalculateArea();
            string expected = "Shape: Circle, Area: 12,566370614359172";
            Assert.Equal(expected, circle.ToString());
        }

        // TRIANGLE TESTING
        [Fact]
        public void Triangle_AreaTryPositiveSide()
        {
            IShape triangle = new Triangle(4, 3, 3);
            triangle.CalculateArea();
            double area = triangle.Area;
            Assert.Equal(4.47213595499958, area);
        }

        [Fact]
        public void Triangle_RectangularTryNegativeSide()
        {
            Triangle triangle = new Triangle(-4, -3, -5);
            Assert.True(triangle.IsRectangular);
        }

        [Fact]
        public void Triangle_TryToString()
        {
            IShape triangle = new Triangle(6, 8, 10);
            triangle.CalculateArea();
            string expected = "Shape: Triangle, Area: 24, Is Rectangular: True";
            Assert.Equal(expected, triangle.ToString());
        }
    }
}

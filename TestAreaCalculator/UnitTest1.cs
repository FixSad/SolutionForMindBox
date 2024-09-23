using AreaCalculator.Interfaces;
using AreaCalculator.Shapes;

namespace TestAreaCalculator
{
    public class UnitTest1
    {
        //SQUARE TESTING
        [Fact]
        public void Square_TryPositiveSideWithDot()
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
    }
}

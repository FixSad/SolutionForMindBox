using AreaCalculator.Interfaces;

namespace AreaCalculator.Shapes
{
    public class Square : IShape
    {
        private readonly double _a;
        public double Area { get; private set; }

        public Square(double a) => _a = Math.Abs(a); 

        public double CalculateArea() => Area = Math.Pow(_a, 2);

        public override string ToString()
        {
            return $"Shape: {this.GetType().Name}, Area: {Area}";
        }
    }
}

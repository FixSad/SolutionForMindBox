using AreaCalculator.Interfaces;

namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public readonly double _radius;
        public double Area { get; private set; }

        public Circle(double radius) => _radius = Math.Abs(radius);
        
        public double CalculateArea() => Area = Math.PI * Math.Pow(_radius, 2);

        public override string ToString() => $"Shape: {this.GetType().Name}, Area: {Area}";
    }
}

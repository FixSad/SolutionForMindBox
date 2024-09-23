using AreaCalculator.Interfaces;
using AreaCalculator.Shapes;

IShape circle = new Circle(3);
circle.CalculateArea();
Console.WriteLine(circle);
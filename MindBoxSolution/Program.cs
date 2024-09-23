using AreaCalculator.Interfaces;
using AreaCalculator.Shapes;

IShape triangle = new Triangle(4, 3 ,6);
triangle.CalculateArea();
Console.WriteLine(triangle);
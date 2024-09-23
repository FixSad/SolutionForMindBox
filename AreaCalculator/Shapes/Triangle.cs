using AreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _a, _b, _c;
        public bool IsRectangular { get ; private set; }
        public double Area { get; private set; } 

        public Triangle(double a, double b, double c)
        {
            _a = a; _b = b; _c = c;
            IsRectangular = CalculateIsRectangular();
        }

        private bool CalculateIsRectangular()
        {
            if(Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2))
                return true;
            return false;
        }

        public void CalculateArea()
        {
            double p = (_a + _b + _c) / 2;
            Area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override string ToString()
        {
            return $"Shape: {this.GetType().Name}, " +
                $"Area: {Area}, " +
                $"Is Rectangular: {IsRectangular}";
        }
    }
}

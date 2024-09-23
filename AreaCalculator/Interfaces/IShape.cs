using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AreaCalculator.Interfaces
{
    public interface IShape
    {
        public double Area { get; }
        public void CalculateArea();
    }
}

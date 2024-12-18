using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Part02.Abstract
{
    internal abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
}

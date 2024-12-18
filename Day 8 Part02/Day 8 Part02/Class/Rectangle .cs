using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Part02.Abstract;

namespace Day_8_Part02.Class
{
    internal class Rectangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }
}

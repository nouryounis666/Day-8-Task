﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Part02.Abstract;

namespace Day_8_Part02.Class
{
    internal class Triangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Part02.Interface;

namespace Day_8_Part02.Class
{
    internal class SquareSeries : IShapeSeries
    {
        private int sideLength = 1;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = sideLength * sideLength;
            sideLength++;
        }

        public void ResetSeries()
        {
            sideLength = 1;
            CurrentShapeArea = 0;
        }
    }
}

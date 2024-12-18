using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Part02.Interface;

namespace Day_8_Part02.Class
{
    internal class CircleSeries : IShapeSeries
    {
        private int radius = 1;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = (int)(Math.PI * radius * radius);
            radius++;
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = 0;
        }
        
    }
}

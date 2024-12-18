using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Part02.Class
{
    internal class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(Shape other)
        {
            return this.Area.CompareTo(other.Area);
        }
    }
}

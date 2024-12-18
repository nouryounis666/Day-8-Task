using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Task.Abstract
{
    internal abstract class Shape
    {
        public abstract double GetArea(); 
        public void Display() 
        { 
            Console.WriteLine("Displaying shape");
        }
    }
}

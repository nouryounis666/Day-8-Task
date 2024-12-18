using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Task.Interface;

namespace Day_8_Task
{
    public class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking (interface implementation).");
        }

        public void Walk()
        {
            Console.WriteLine("Robot is walking (own method).");
        }
    }
}

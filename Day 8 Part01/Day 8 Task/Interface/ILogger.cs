using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Task.Interface
{
    internal interface ILogger
    {
        void Log()
        {
            Console.WriteLine("Default log implementation.");
        }
    }
}

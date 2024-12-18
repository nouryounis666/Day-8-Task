using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Task.Interface;

namespace Day_8_Task
{
    internal class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Console log implementation.");
        }
    }
}

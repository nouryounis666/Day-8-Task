using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_8_Task.Interface;

namespace Day_8_Task
{
    internal class Car : IVehicle
    {
        public void StartEngine() 
        {
            Console.WriteLine("Car engine started");
        }
        public void StopEngine() 
        {
            Console.WriteLine("Car engine stopped"); 
        }
    }
}

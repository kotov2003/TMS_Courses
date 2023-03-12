using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7
{
    internal class HomeTask7
    {
        public static void Task_CarPark()
        {
            Bus bus_A = new Bus();
            Console.WriteLine($" Properties value of \"{nameof(bus_A)}\" are: {bus_A.Destination}, {bus_A.Number}, {bus_A.DepartureTime}, {bus_A.DepartureTime}");
        }
    }
}

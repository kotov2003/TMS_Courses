using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.CarPark
{
    internal static class TransportService
    {
        public static void PrintTransportType (Transports transport)
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine($"{transport.GetType().Name} types:");
            Console.WriteLine(new string('-', 20));
            foreach (TransportType type in transport.GetTransportType())
            {
                Console.WriteLine(type.ToString());
            }
            Console.WriteLine(new string('=', 20));
        }
    }
}

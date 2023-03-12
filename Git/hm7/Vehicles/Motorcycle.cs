using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Vehicles
{
    internal class Motorcycle : Auto
    {
        public bool HasSideCar { get; set; }

        public override void PrintAutoInfo()
        {
            base.PrintAutoInfo();
            Console.WriteLine($"HasSideCar = {HasSideCar}");
        }

        public override int GetLoadCapacity()
        {
            return HasSideCar ? this.LoadCapacity : 0;
        }
    }
}

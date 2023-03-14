using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Vehicles
{
    internal class Truck : Auto
    {
        public bool HasTrailer { get; set; }

        public override void PrintAutoInfo()
        {
            base.PrintAutoInfo();
            Console.WriteLine($"HasTrailer = {HasTrailer}");
        }

        public override int GetLoadCapacity()
        {
            return HasTrailer ? this.LoadCapacity * 2 : this.LoadCapacity;
        }
    }
}

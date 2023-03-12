using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Vehicles
{
    internal class Car : Auto
    {
        public override int GetLoadCapacity()
        {
            return this.LoadCapacity;
        }
    }
}

using Git.hm7.CarPark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Vehicles
{
    internal abstract class Auto
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int LoadCapacity { get; set; }

        public virtual void PrintAutoInfo()
        {
                Console.WriteLine(new string('=', 20));
                Console.WriteLine(new string('=', 20));
                Console.WriteLine($"{this.GetType().Name} details:"); ;
                Console.WriteLine($"Brand = {Brand}");
                Console.WriteLine($"Number = {Number}");
                Console.WriteLine($"Speed = {Speed}");
                Console.WriteLine($"LoadCapacity = {GetLoadCapacity()}");
        }

        public abstract int GetLoadCapacity();
    }
}

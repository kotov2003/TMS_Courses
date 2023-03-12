using Git.hm7.CarPark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Vehicles
{
    internal static class SearchService
    {
        public static IEnumerable<Auto> SearchAuto(IEnumerable<Auto> autos, int neededLoadCapacity)
        {
            return from auto in autos
                   where auto.LoadCapacity >= neededLoadCapacity
                   select auto;
        }
    }
}

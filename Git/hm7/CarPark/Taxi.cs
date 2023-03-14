using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.CarPark
{
    internal class Taxi : Transports
    {
        public override List<TransportType> GetTransportType()
        {
            return new List<TransportType> { TransportType.Wheeled, TransportType.Electric };
        }
    }
}

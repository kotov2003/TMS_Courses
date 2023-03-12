using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Transport
{
    internal class CityTrain : Transports
    {
        public override List<TransportType> GetTransportType()
        {
            return new List<TransportType> { TransportType.Rail, TransportType.Electric };
        }
    }
}

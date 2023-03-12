using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.Transport
{
    internal abstract class Transports
    {
        private string destination = "Default destination";
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string Number { get; set; } = "Default number";
        public DateTime DepartureTime { get; set; } = default;
        public int SeatsNumber { get; set; } = 0;

        public abstract List<TransportType> GetTransportType();


    }
}

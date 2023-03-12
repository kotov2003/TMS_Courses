using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7
{
    internal class Bus
    {
        private string destination = "Default destination";
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        } 
        public string Number { get; set; } = "Default number";
        public string DepartureTime { get; set; } = "Default departure time";
        public string SeatsNumber { get; set; } = "Default seats number";
    }
}

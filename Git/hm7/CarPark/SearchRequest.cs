using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7.CarPark
{
    internal class SearchRequest
    {
        public string? Destination { get; set; }
        public string? DepartureDate { get; set; }
        public SearchRequest(string? destination, string? date)
        {
            Destination = destination;
            DepartureDate = date;
        }
    }
}

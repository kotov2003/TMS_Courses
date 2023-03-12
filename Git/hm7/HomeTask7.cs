using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Git.hm7.Transport;

namespace Git.hm7
{
    internal class HomeTask7
    {
        public static void Task_CarPark()
        {
            Bus bus_A = new Bus();
            Console.WriteLine($" Properties value of \"{nameof(bus_A)}\" are:\n {bus_A.Destination}, {bus_A.Number}, {bus_A.DepartureTime}, {bus_A.SeatsNumber}");

            List<Transports> transportsList = new List<Transports>()
            {
                new Bus(){Number ="1", SeatsNumber=7, DepartureTime = new DateTime(2022, 11, 22, 06, 15, 00), Destination = "London"},
                new CityTrain(){Number ="2",SeatsNumber=3, DepartureTime = new DateTime(2022, 11, 22, 07, 15, 00), Destination = "London"},
                new Metro(){Number ="3",SeatsNumber=1, DepartureTime = new DateTime(2022, 11, 22, 06, 05, 00), Destination = "London"},
                new Taxi() {Number ="4", SeatsNumber = 8 , DepartureTime = new DateTime(2020, 11, 23, 09, 00, 00), Destination = "Paris"},
                new Tram(){Number ="5",SeatsNumber=0, DepartureTime = new DateTime(2022, 11, 24, 06, 08, 00), Destination = "London"},
                new Trolleybus{Number ="6",SeatsNumber=99, DepartureTime = new DateTime(2021, 11, 25, 06, 15, 00), Destination = "New York"}
            };

            var orderedBySeatsNumbertList = from item in transportsList
                                            orderby item.SeatsNumber
                                            select item;
            Console.WriteLine($"\n\n{new string('=', 20)}\nTransport sorted by seats number:");
            PrintTransportInfo(orderedBySeatsNumbertList);


            var searchRequest1 = new SearchRequest("London", "2022-11-22 06:15:00");
            var searchRequest2 = new SearchRequest(null, "2021-11-25 06:15:00");
            var searchRequest3 = new SearchRequest("London", null);
            var searchRequest4 = new SearchRequest(null, "2022-11-22 06:10:00");
            var searchResult1 = SearchTransportByDistinationAndDepartureTime(transportsList, searchRequest1.Destination, searchRequest1.DepartureDate);
            var searchResult2 = SearchTransportByDepartureTime(transportsList, searchRequest2.DepartureDate);
            var searchResult3 = SearchTransportByDistination(transportsList, searchRequest3.Destination);
            var searchResult4 = SearchTransportAfterSpecificDepartureTime(transportsList, searchRequest4.DepartureDate);

            Console.WriteLine($"\n\n{new string('=', 20)}\nSerach By Destination number ({searchRequest1.Destination}) and Departure time '{searchRequest1.DepartureDate}':");
            PrintTransportInfo(searchResult1);
            Console.WriteLine($"\n\n{new string('=', 20)}\nSerach By Departure time '{searchRequest1.DepartureDate}':");
            PrintTransportInfo(searchResult2);
            Console.WriteLine($"\n\n{new string('=', 20)}\nSerach By Destination number '{searchRequest3.Destination}':");
            PrintTransportInfo(searchResult3);
            Console.WriteLine($"\n\n{new string('=', 20)}\nSerach By Departure time later than '{searchRequest4.DepartureDate}':");
            PrintTransportInfo(searchResult4);

            Console.WriteLine($"\n\n{new string('=', 20)}\nTransport types:");
            TransportService.PrintTransportType(new Bus() { Number = "1", SeatsNumber = 7, DepartureTime = new DateTime(2022, 11, 22, 06, 15, 00), Destination = "London" });
            TransportService.PrintTransportType(new CityTrain() { Number = "2", SeatsNumber = 3, DepartureTime = new DateTime(2022, 11, 22, 07, 15, 00), Destination = "London" });
            TransportService.PrintTransportType(new Trolleybus { Number = "6", SeatsNumber = 99, DepartureTime = new DateTime(2021, 11, 25, 06, 15, 00), Destination = "New York" });

        }


        private static IEnumerable<Transports> SearchTransportByDistinationAndDepartureTime(IEnumerable<Transports> transportList, string destination, string departureTime)
        {
            DateTime departureTimeUpdated = DateTime.ParseExact(departureTime, "yyyy-MM-dd HH:mm:ss",
        System.Globalization.CultureInfo.InvariantCulture);

            return from item in transportList
                   where item.Destination == destination && item.DepartureTime == departureTimeUpdated
                   select item;
            Thread.Sleep(5000);
        }


        private static IEnumerable<Transports> SearchTransportByDistination(IEnumerable<Transports> transportList, string destination)
        {
            return from item in transportList
                   where item.Destination == destination
                   select item;
        }


        private static IEnumerable<Transports> SearchTransportByDepartureTime(IEnumerable<Transports> transportList, string departureTime)
        {
            DateTime departureTimeUpdated = DateTime.ParseExact(departureTime, "yyyy-MM-dd HH:mm:ss",
        System.Globalization.CultureInfo.InvariantCulture);

            return from item in transportList
                   where item.DepartureTime == departureTimeUpdated
                   select item;
        }

        private static IEnumerable<Transports> SearchTransportAfterSpecificDepartureTime(IEnumerable<Transports> transportList, string departureTimeLaterThan)
        {
            DateTime departureTimeUpdated = DateTime.ParseExact(departureTimeLaterThan, "yyyy-MM-dd HH:mm:ss",
        System.Globalization.CultureInfo.InvariantCulture);

            return from item in transportList
                   where item.DepartureTime > departureTimeUpdated
                   select item;
        }

        private static void PrintTransportInfo(IEnumerable<Transports> transportList)
        {
            foreach (Transports transport in transportList)
            {
                Console.WriteLine(new string('=', 20));
                Console.WriteLine(new string('=', 20));
                Console.WriteLine($"{transport.GetType().Name} № {transport.Number}:"); ;
                Console.WriteLine($"Seats Number = {transport.SeatsNumber}");
                Console.WriteLine($"Destination = {transport.Destination}");
                Console.WriteLine($"DepartureTime = {transport.DepartureTime}");
            }
        }
    }
}

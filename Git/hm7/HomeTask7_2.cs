using Git.hm7.CarPark;
using Git.hm7.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm7
{
    internal class HomeTask7_2
    {
        public static void Task_Vehicles()
        {
            var car_1 = new Car() { Number = "1", Brand = "Volvo", Speed = 200, LoadCapacity = 2000 };
            var car_2 = new Car() { Number = "2", Brand = "BMW", Speed = 250, LoadCapacity = 2500 };
            var truck_1 = new Truck() { Number = "3", Brand = "MAN", Speed = 150, LoadCapacity = 5000 };
            var truck_2 = new Truck() { Number = "4", Brand = "IVECO", Speed = 170, LoadCapacity = 7000, HasTrailer = true };
            var moto_1 = new Motorcycle() { Number = "5", Brand = "Suzuki", Speed = 270, LoadCapacity = 300 };
            var moto_2 = new Motorcycle { Number = "6", Brand = "Kawasaki", Speed = 300, LoadCapacity = 500, HasSideCar = true };
            List<Auto> transportsList = new List<Auto>()
            {
                car_1,
                car_2,
                truck_1,
                truck_2,
                moto_1,
                moto_2
            };


            Console.WriteLine($"\n\n{new string('=', 20)}\nThe list of vehicles: ");
            foreach (var item in transportsList)
            {
                item.PrintAutoInfo();
            }


            Console.WriteLine($"\n\n{new string('=', 20)}\nSerach By LoadCapacity which is more or equal to  '1000': ");
            var result = SearchService.SearchAuto(transportsList, 1000);
            foreach (var item in result)
            {
                item.PrintAutoInfo();
            }
        }
    }
}

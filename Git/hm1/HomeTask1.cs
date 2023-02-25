using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm1
{
    public class HomeTask1
    {
        public static void Welcome()
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!\n");

        }
    }
}

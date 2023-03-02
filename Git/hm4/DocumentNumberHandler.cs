using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm4
{
    public class DocumentNumberHandler
    {
        static public void Task_DocumentNumber_1()
        {
            Console.WriteLine("Enter document number in the following format \"xxxx-yyy-xxxx-yyy-xyxy\", where x is a number and y is a letter): ");

            string? documentNumber = Console.ReadLine();

            var result = documentNumber.Split('-');


            Console.WriteLine($"\n{new string('=', 55)}\n#1 Welcome to \'Task_DocumentNumber_1!\'\n{new string('=', 55)}");
            Console.WriteLine($"TASKS:\nInitial number:{documentNumber}\n");
            Console.WriteLine($"RESULT:");
            Console.WriteLine($"{result[0]}{result[2]}");
            Console.WriteLine($"{new string('=', 55)}\n\n\n");
        }
    }
}

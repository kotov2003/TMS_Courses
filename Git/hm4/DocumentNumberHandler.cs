using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Git.hm4
{
    public class DocumentNumberHandler
    {
        static private string? EnterDocumentNumber()
        {
            Console.WriteLine($"\n{new string('=', 55)}\n#1 Welcome to \'Task_DocumentNumber_1!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter document number in the following format \"xxxx-yyy-xxxx-yyy-xyxy\", where x is a number and y is a letter): ");
            string? documentNumber = Console.ReadLine();
            return documentNumber;
        }

        static public void Task_DocumentNumber_1()
        {
            string? documentNumber = EnterDocumentNumber();
            Regex regex = new Regex("[0-9]{4}");
            MatchCollection matches = regex.Matches(documentNumber);

            Console.WriteLine($"\nRESULT:");
            foreach (Match match in matches)
            {
                Console.Write($"{match.Value}");
            }
            Console.WriteLine();
        }

        static public void Task_DocumentNumber_2()
        {
            string? documentNumber = EnterDocumentNumber();
            var result = Regex.Replace(documentNumber, @"[a-zA-Z]{3}", "***");

            Console.WriteLine($"\n{new string('=', 55)}\n#1 Welcome to \'Task_DocumentNumber_2!\'\n{new string('=', 55)}");
            Console.WriteLine($"TASKS:\nInitial number:{documentNumber}\n");
            Console.WriteLine($"RESULT:");
            Console.WriteLine($"{result}");
            Console.WriteLine($"{new string('=', 55)}\n\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Git.hm4
{
    public class DocumentNumberHandler
    {
        static private string? EnterDocumentNumber(string methodName)
        {
            Console.WriteLine($"\n{new string('=', 55)}\n#Welcome to \'{methodName}!\'#\n{new string('=', 55)}");
            Console.WriteLine("Enter document number in the following format \"xxxx-yyy-xxxx-yyy-xyxy\", where x is a number and y is a letter): ");
            string? documentNumber = Console.ReadLine();
            return documentNumber;
        }

        static public void Task_DocumentNumber_1()
        {
            string? documentNumber = EnterDocumentNumber(MethodBase.GetCurrentMethod().Name);
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
            string? documentNumber = EnterDocumentNumber(MethodBase.GetCurrentMethod().Name);
            var result = Regex.Replace(documentNumber, @"[a-zA-Z]{3}", "***");

            Console.WriteLine($"\nRESULT:");
            Console.WriteLine($"{result}");
            Console.WriteLine($"{new string('=', 55)}\n");
        }

        static public void Task_DocumentNumber_3()
        {
            string? documentNumber = EnterDocumentNumber(MethodBase.GetCurrentMethod().Name);
            var result_1 = Regex.Replace(documentNumber, @"[0-9]{4}-", @"/");
            var result_2 = Regex.Replace(result_1, @"[0-9]", @"/");
            var result = Regex.Replace(result_2, @"[-]", "");

            Console.WriteLine($"\nRESULT:");
            Console.WriteLine($"{result}".ToLower());
            Console.WriteLine($"{new string('=', 55)}\n");
        }

        static public void Task_DocumentNumber_4()
        {
            string? documentNumber = EnterDocumentNumber(MethodBase.GetCurrentMethod().Name);

            var sb = new StringBuilder(documentNumber);
            sb.Remove(0,5);
            sb.Remove(3, 6);
            sb.Remove(6, 2);
            sb.Remove(7, 1);
            sb.Insert(3, "/");
            sb.Insert(7, "/");
            sb.Insert(9, "/");

            Console.WriteLine($"\nRESULT:");
            Console.WriteLine($"{sb}".ToUpper());
            Console.WriteLine($"{new string('=', 55)}\n");
        }

        static public void Task_DocumentNumber_5()
        {
            string? documentNumber = EnterDocumentNumber(MethodBase.GetCurrentMethod().Name);

            string substring = "abc";  
            bool existIgnoreCase = documentNumber.Contains(substring, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"\nRESULT:");
            if (existIgnoreCase)
            {
                Console.WriteLine($"Document number contains {substring}.\n");
            }
            else
            {
                Console.WriteLine($"Document number doesn't contain {substring}.\n");
            }
            Console.WriteLine($"{new string('=', 55)}\n");
        }
    }
}

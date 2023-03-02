using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm4
{
    public class HomeTask4
    {
        static public void Task_IsNumberInTheRange()
        {
            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_ReplaceAndRemoveFromString!\'\n{new string('=', 55)}\n");
            Console.WriteLine($"TASKS:\n{new string('-', 55)}\n#0 Initial string.\n");
            Console.WriteLine($"#1 Result string:'test' changed to 'testing'.\n");
            Console.WriteLine($"#2 Result string: numbers removed.\n");

            var initialString = " test 1 wefefe4 dcd testd 3testing 34 456";

            var resultString_1 = initialString.Replace("test", "testing");

            var resultString_1_charArray = resultString_1.ToArray();

            var resultString_2 = string.Empty;

            foreach (var charItem in resultString_1_charArray)
            {
                if (!char.IsNumber(charItem))
                {
                    resultString_2 += charItem;
                }
            }

            Console.WriteLine($"\nRESULT DATA:\n{new string('-', 55)}\n#0:{initialString}\n");
            Console.WriteLine($"#1:{resultString_1}\n");
            Console.WriteLine($"#2:{resultString_2}\n{new string('-', 55)}\n{new string('=', 55)}\n");
        }

        static public void Task_WelcomуToTheTMSlesons()
        {
            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_ReplaceAndRemoveFromString!\'\n{new string('=', 55)}\n");
            Console.WriteLine($"RESULT:\n");
            Console.WriteLine($"Welcome" + " " + "to" + " " + "the" + " " + "TMS" + " " + "lesons" + ".");
            Console.WriteLine($"\n{new string('-', 55)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm4
{
    public class HomeTask4
    {
        static public void Task_IsNumberInTheRange()
        {
            var initialString = " test 1 wefefe4 dcd testd 3testing 34 456";
            var resultString_1 = initialString.Replace("test", "testing");
            var resultString_1_charArray = resultString_1.ToCharArray();
            var resultString_2 = string.Empty;

            foreach (var charItem in resultString_1_charArray)
            {
                if (!char.IsNumber(charItem))
                {
                    resultString_2 += charItem;
                }
            }

            Console.WriteLine($"\n{new string('=', 55)}\n#1 Welcome to \'Task_ReplaceAndRemoveFromString!\'\n{new string('=', 55)}");
            Console.WriteLine($"TASKS:\n#0 Initial string.\n");
            Console.WriteLine($"#1 Result string:'test' changed to 'testing'.\n");
            Console.WriteLine($"#2 Result string: numbers removed.\n");
            Console.WriteLine($"\nRESULT DATA:\n#0:{initialString}\n");
            Console.WriteLine($"#1:{resultString_1}\n");
            Console.WriteLine($"#2:{resultString_2}\n{new string('=', 55)}\n\n\n");
        }

        static public void Task_WelcomуToTheTMSlesons()
        {
            Console.WriteLine($"{new string('=', 55)}\n#2 Welcome to \'Task_ReplaceAndRemoveFromString!\'\n{new string('=', 55)}");
            Console.WriteLine($"RESULT:\n");
            Console.WriteLine($"Welcome" + " " + "to" + " " + "the" + " " + "TMS" + " " + "lesons" + ".");
            Console.WriteLine($"{new string('=', 55)}\n\n\n");
        }

        static public void Task_StringDevidedToTwoParts()
        {
            var initialString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string delimiter = "abc";
            var firstPart = initialString.Split(delimiter).First();
            var secondPart = initialString.Split(delimiter).Last();

            Console.WriteLine($"\n{new string('=', 55)}\n#3 Welcome to \' Task_StringDevidedToTwoParts!\'\n{new string('=', 55)}");
            Console.WriteLine($"INITIAL STRING:\n{initialString}");
            Console.WriteLine($"\nRESULT DATA:\n{firstPart}\n{secondPart}");
            Console.WriteLine($"{new string('=', 55)}\n\n\n");
        }

        static public void Task_BadGoodDay()
        {
            var initialString = "Плохой день";
            var withoutBad = initialString.Substring(6, initialString.Length - 6);
            var goodAdded = withoutBad.Insert(0, "Хороший");
            var exclamationAdded = goodAdded.Insert(goodAdded.Length, "!!!!!!!!!");
            var questionAdded = exclamationAdded.ToCharArray();
            questionAdded[^1] = '?';
            var result_1 = new string(questionAdded);
            var result_2 = exclamationAdded.Remove(exclamationAdded.Length - 1).Insert(exclamationAdded.Length - 1, "?");

            Console.WriteLine($"\n{new string('=', 55)}\n#4 Welcome to \'Task_BadGoodDay!\'\n{new string('=', 55)}");
            Console.WriteLine($"INITIAL STRING: {initialString}");
            Console.WriteLine($"\nRESULT DATA:");
            Console.WriteLine($"First way: {result_1}");
            Console.WriteLine($"Second way: {result_2}");
            Console.WriteLine($"{new string('=', 55)}\n\n\n");
        }
    }
}

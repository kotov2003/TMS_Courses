using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm3
{
    public class HomeTask3
    {
        static public void Task_IsNumberInTheRange()
        {
            int[] intArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_IsNumberInTheRange!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter any numnber: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            bool isItInArray = false;

            foreach (var item in intArray)
            {
                if(item == guessNumber)
                {
                    isItInArray= true;
                    Console.WriteLine($"{new string('-', 55)}\nResult: array contains the number\n{new string('-', 55)}\n");
                }
            }

            if (!isItInArray)
            {
                Console.WriteLine($"{new string('-', 55)}\nResult: array doesn't contain such a number\n{new string('-', 55)}\n");
            }
        }

    }
}

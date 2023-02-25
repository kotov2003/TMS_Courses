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
                if (item == guessNumber)
                {
                    isItInArray = true;
                    Console.WriteLine($"{new string('-', 55)}\nResult: array contains the number\n{new string('-', 55)}\n");
                }
            }

            if (!isItInArray)
            {
                Console.WriteLine($"{new string('-', 55)}\nResult: array doesn't contain such a number\n{new string('-', 55)}\n");
            }
        }

        static public void Task_RemoveFromTheRange()
        {
            int[] intArray = new int[10] { 1, 2, 3, 4, 2, 6, 7, 8, 3, 3 };

            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_RemoveFromTheRange!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter any numnber: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            int numberOfFOundElements = 0, count = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == guessNumber)
                {
                    numberOfFOundElements += 1;
                }
            }

            int[] newArray = new int[intArray.Length - numberOfFOundElements];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] != guessNumber)
                {
                    newArray[count] = intArray[i];
                    count += 1;
                }
            }

            if (numberOfFOundElements == 0)
            {
                Console.WriteLine($"{new string('-', 55)}\nResult: array doesn't contain such a number\n{new string('-', 55)}\n");
            }
            else
            {
                Console.WriteLine($"{new string('-', 55)}\nResult: \"{guessNumber}\" number has been removed from the array: \n{new string('-', 55)}\n");
                foreach (var item in newArray)
                {
                    Console.WriteLine($"{item}\n");
                }
            }
        }

        static public void Task_RandomElementsArray()
        {
            Random random = new Random();

            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_RandomElementsArray!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] intArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                intArray[i] = (int)random.NextInt64(-100, 100);
            }

            Console.WriteLine($"\nArray: \n");
            foreach (var item in intArray)
            {
                Console.WriteLine($"{item}\n");
            }
            Console.WriteLine($"{new string('-', 55)}\nResult: MAX = {intArray.Max()}, MIN = {intArray.Min()}, AVG = {intArray.Average()};\n{new string('-', 55)}\n");
        }
    }
}

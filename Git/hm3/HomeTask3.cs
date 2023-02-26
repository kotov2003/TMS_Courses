using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        static public void Task_CompareAVG2Arrays()
        {
            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_CompareAVG2Arrays!\'\n{new string('=', 55)}");

            int[] intArray_1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] intArray_2 = new int[5] { 1, 2, 3, 4, 5 };
            int count_1 = 0;
            int count_2 = 0;

            for (int i = 0; i < 5; i++)
            {
                count_1 += intArray_1[i];
            }

            for (int i = 0; i < 5; i++)
            {
                count_2 += intArray_2[i];
            }

            switch (count_1 - count_2)
            {
                case 0:
                    Console.WriteLine($"Result: AVGs are equal \n{new string('-', 55)}\n");
                    break;
                case < 0:
                    Console.WriteLine($"Result: Second Array AVG is bigger\n{new string('-', 55)}\n");
                    break;
                default:
                    Console.WriteLine($"Result: First Array AVG is bigger\n{new string('-', 55)}\n");
                    break;
            }
        }

        static public void Task_Additional_4()
        {
            int length = default;
            int count = 0, numberOfFOundElements = 0;
            Random random = new Random();

            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_Additional_4!\'\n{new string('=', 55)}");
            do
            {
                Console.WriteLine("Enter the length of the array: ");
                length = int.Parse(Console.ReadLine());
                if (length > 5 && length <= 10)
                {
                    break;
                }
                Console.WriteLine("Warning: the length of the array should be more than five and less or equal to 10.");
            } while (true);
            Console.WriteLine("");

            int[] intArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                intArray[i] = (int)random.NextInt64(-100, 100);
                Console.WriteLine($"{intArray[i]}");
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if ((intArray[i] % 2) == 0)
                {
                    numberOfFOundElements += 1;
                }
            }

            Console.WriteLine($"\n\nRESULT: ");
            int[] newArray = new int[numberOfFOundElements];
            for (int i = 0; i < intArray.Length; i++)
            {
                if ((intArray[i] % 2) == 0)
                {
                    newArray[count] = intArray[i];
                    Console.WriteLine($"{newArray[count]}");
                    count++;
                }
            }
        }

        static public void Task_Additional_5()
        {
            int count = 0, numberOfFOundElements = 0;
            Random random = new Random();

            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_Additional_5!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] intArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                intArray[i] = (int)random.NextInt64(-100, 100);
                Console.Write($"{intArray[i]} ");
            }

            Console.WriteLine($"\n\nRESULT: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                if ((i % 2) != 0)
                {
                    intArray[i] = 0;
                }
                Console.Write($"{intArray[i]} ");
            }
        }

        static public void Task_Additional_6()
        {
            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_Additional_6!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter arbitrary people's names separated by commas: ");
            string[] words = Console.ReadLine().Split(new char[] { ',' });

            Array.Sort(words, StringComparer.InvariantCulture);

            Console.WriteLine($"\n\nRESULT: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{words[i]} ");
            }
        }

        static public void Task_Additional_7()
        {
            Console.WriteLine($"\n{new string('=', 55)}\nWelcome to \'Task_Additional_7!\'\n{new string('=', 55)}");
            Console.WriteLine("Enter numbers separated by commas: ");
            string[] numbers = Console.ReadLine().Split(new char[] { ',' });

            int[] numberArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numberArray[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < numberArray.Length; i++)
                for (int j = 0; j < numberArray.Length - i - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temp;
                    }
                }

            Console.WriteLine("\nRESULT: \n");
            foreach (int value in numberArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}

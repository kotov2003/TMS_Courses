using Git.hm9.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hmAd
{
    public class HomeTaskAdditinal
    {
        public static void Task_2()
        {
            int[] intArray = { 0, 1, 0, 1, 1, 0 };

            Console.WriteLine("Initial array:");

            foreach (int i in intArray)
            {
                Console.Write($"{i} ");

            }

            SortArray(intArray, 0, intArray.Length - 1);

            Console.WriteLine("\nResult array:");

            foreach (int i in intArray)
            {
                Console.Write($"{i} ");

            }
        }

        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
    }
}

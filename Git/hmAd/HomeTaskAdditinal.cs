﻿using Git.hm9.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hmAd
{
    public class HomeTaskAdditinal
    {
        public static void Task_1()
        {
            int[] intArray = {2, 1, 5, 3, 4, 5 };

            Console.WriteLine("Initial array:");

            foreach (int i in intArray)
            {
                Console.Write($"{i} ");

            }

            int max = 0;
            int premax = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == max)
                {
                    continue;
                }

                if (intArray[i] > max)
                {
                    premax = max;
                    max = intArray[i];
                }
                else if (intArray[i] > premax)
                {
                    premax = intArray[i];
                }
            }

            Console.WriteLine($"\nSecond max is: {premax}");
        }

        public static void Task_2()
        {
            int[] intArray = { 0, 1, 0, 1, 1, 0 };

            Console.WriteLine("Initial array:");

            foreach (int i in intArray)
            {
                Console.Write($"{i} ");

            }

            SortArray(intArray, 0, intArray.Length - 1);
            //var sortedArray = intArray.Select(i => i).OrderBy(i => i);

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

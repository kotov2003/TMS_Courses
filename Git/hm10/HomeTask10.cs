namespace Git.hm10
{
    public class HomeTask10
    {
        public static void Task_Generic_1()
        {
            int[] elementsIntForArray = new int[] { 6, 7, 8 };

            string[] elementsStringForArray1 = new string[] { "ab", "cd", "ef" };

            var genericIntArray = new Generic<int>(new int[] { 1, 2, 2, 4, 2 });

            var genericStriingArray = new Generic<string>(new string[] { "xy", "yz", "yz" });


            printArray("Int array after adding elements:\n", genericIntArray.AddElements(elementsIntForArray));
            printArray("String array after adding elements:\n", genericStriingArray.AddElements(elementsStringForArray1));

            printArray("Int array after deleting element:\n", genericIntArray.DeleteElements(2));
            printArray("String array after deleting element:\n", genericStriingArray.DeleteElements("yz"));

            printElementValue("Int array element found by index:\n", genericIntArray.GetElementByIndex(2));
            printElementValue("String array element found by index:\n", genericStriingArray.GetElementByIndex(3));

            printElementValue("Int array length found by index:\n", genericIntArray.GetArrayLength());
            printElementValue("String array length found by index:\n", genericStriingArray.GetArrayLength());
        }

        private static void printArray<T>(string title, T[] genericArray)
        {
            Console.WriteLine(title);

            foreach (var element in genericArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }

        private static void printElementValue<T>(string title, T element)
        {
            Console.WriteLine(title + element);
        }
    }
}

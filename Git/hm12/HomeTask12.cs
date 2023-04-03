using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm12
{
    public class HomeTask12
    {
        public static void Task_OneLetterWord()
        {
            var list_1 = new List<string>() { "word", "word_1", "e", "t", "wert", "1" };
            var list_2 = "word word_1 e t wert 1";

            Console.WriteLine("String sequence:");

            foreach (var item in list_1)
            {
                Console.Write(item + " ");
            }

            var test = list_2.Split(' ');

            var result = list_1.Where(x => x.Count() == 1).First();
            var result2 = test.Where(x => x.Count() == 1).First();

            Console.WriteLine($"\nFirst One Letter Word Is: '{result}'");
            Console.WriteLine($"First One Letter Word Is: '{result2}'");
        }
    }
}

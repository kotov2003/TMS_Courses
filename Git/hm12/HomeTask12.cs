using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm12
{
    public class HomeTask12
    {
        public static void Task_OneLetterWord()
        {
            var list = new List<string>() { "word", "word_1", "e", "t", "wert", "1" };
            var words = "word word_1 e t wert 1";

            PrintSequence(list);

            var listString = words.Split(' ');
            var resultList1 = list.Where(x => x.Length == 1).First();
            var resultList2 = listString.Where(x => x.Length == 1).First();

            Console.WriteLine($"\nFirst One Letter Word Is: '{resultList1}'");
            Console.WriteLine($"First One Letter Word Is: '{resultList2}'\n");
        }

        public static void Task_LastWordWithSubstring()
        {
            var list = new List<string>() { "word", "ee", "word_1", "eett", "tee", "wert", "peer" };
            string subString = "ee";

            PrintSequence(list);

            var result = list.FindLast(x => x.Contains(subString));

            Console.WriteLine($"\nLast Word That Contains '{subString}' Is: '{result}'\n");
        }

        public static void Task_LastWordWithConditions()
        {
            var listPassedSearch = new List<string>() { "word", "ee", "word_1", "eett", "tee", "wert", "we", "peertt" };
            var listFailedSearch = new List<string>() { "worddd", "w" };
            int min = 3;
            int max = 5;

            PrintSequence(listPassedSearch);
            PrintSequence(listFailedSearch);

            ShowResult(WordSerachFunctionByСriterion(listPassedSearch, min, max), min, max);
            ShowResult(WordSerachFunctionByСriterion(listFailedSearch, min, max), min, max);
        }

        public static void Task_UniqueValue()
        {
            var listUniq = new List<string>() { "word", "we", "word_1", "eett", "word","we", "word" };

            Console.WriteLine($"Number of unique values is {listUniq.Distinct().Count()}");
        }





        public static string WordSerachFunctionByСriterion(List<string> list, int min, int max)
        {
            return list.FindLast(x => x.Length >= min && x.Length <= max);
        }

        public static void PrintSequence(List<string> list)
        {
            Console.WriteLine("String sequence:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        public static void ShowResult(string result, int min, int max)
        {
            if (result != null)
            {
                Console.WriteLine($"\nLast Word With Length less than {max} and more than {min} Is: '{result}'\n");
            }
            else
            {
                Console.WriteLine($"\nNo matching words found (less than {max} and more than {min})\n");
            }
        }
    }
}

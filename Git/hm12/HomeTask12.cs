namespace Git.hm12
{
    public class HomeTask12
    {
        public static void Task_OneLetterWord()
        {
            var list = new List<string>() { "word", "word_1", "e", "t", "wert", "1" };
            var words = "word word_1 e t wert 1";
            var listString = words.Split(' ');

            PrintSequence(list);

            Console.WriteLine($"\nFirst One Letter Word Is: '{list.Where(x => x.Length == 1).First()}'");
            Console.WriteLine($"First One Letter Word Is: '{listString.Where(x => x.Length == 1).First()}'\n");
        }

        public static void Task_LastWordWithSubstring()
        {
            var list = new List<string>() { "word", "ee", "word_1", "eett", "tee", "wert", "peer" };
            string subString = "ee";

            PrintSequence(list);

            Console.WriteLine($"\nLast Word That Contains '{subString}' Is: '{list.FindLast(x => x.Contains(subString))}'\n");
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
            var listUniq = new List<string>() { "word", "we", "word_1", "eett", "word", "we", "word" };
            PrintSequence(listUniq);

            Console.WriteLine($"\nNumber of unique values is {listUniq.Distinct().Count()}");
        }

        public static void Task_ContainsNumber()
        {
            var list = new List<string>() { "word", "ee", "word_1", "ee3tt", "tee", "wer33t", "3we", "peertt", "3" };
            PrintSequence(list);

            var resultList = list.Skip(4).Where(x => x.Contains('3')).ToList();

            Console.WriteLine($"\nWord Sequence containing '3' since fifth element");
            PrintSequence(resultList);
        }

        public static void Task_LengthOfTheShortestWord()
        {
            var list = new List<string>() { "word", "ee3", "word_1", "ee3tt", "tee", "wert", "e", "peertt", "5qrt" };
            PrintSequence(list);

            Console.WriteLine($"\nThe shortest wird has length {list.Select(x => x.Length).Min()}");
        }

        public static void Task_Dictionary()
        {
            var dictionary = new Dictionary<string, string>() {
                {"white", "house"},
                {"blue", "see"},
                {"black", "jack"}
            };
            PrintDictionary(dictionary);

            PrintDictionary(dictionary.ToList().ToDictionary(x => x.Value, x => x.Key));
        }

        public static void Task_GetNames()
        {
            var user1 = new User("Zak", "Ivanovich", "Alexov");
            var user2 = new User("Paul", "", "McCartney");
            var user3 = new User("Smith", "", "Smithov");
            var user4 = new User("Winni", "Sergeyevich", "Borisov");
            List<User> users = new List<User>() { user1, user2, user3, user4 };

            var orderedList = users.OrderByDescending(p => p.LastName);
            foreach (var item in orderedList)
            {
                item.ShowNames();
            }
        }

        private static string WordSerachFunctionByСriterion(List<string> list, int min, int max)
        {
            return list.FindLast(x => x.Length >= min && x.Length <= max);
        }

        private static void PrintSequence(List<string> list)
        {
            Console.WriteLine("\nString sequence:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        private static void PrintDictionary(Dictionary<string, string> list)
        {
            Console.WriteLine("\nDictionary: ");
            foreach (var item in list)
            {
                Console.Write($"KEY: '{item.Key}'; VALUE: '{item.Value}';\n");
            }
        }

        private static void ShowResult(string result, int min, int max)
        {
            if (result != null)
            {
                Console.WriteLine($"\nLast Word With Length less than {max} and more than {min} Is: '{result}'");
            }
            else
            {
                Console.WriteLine($"\nNo matching words found (less than {max} and more than {min})\n");
            }
        }
    }
}

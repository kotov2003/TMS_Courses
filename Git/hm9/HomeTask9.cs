using Git.hm6.Triangles;
using Git.hm9.Products;
using System.Collections;
using System.Security.Cryptography;

namespace Git.hm9
{
    public class HomeTask9
    {
        static public void Task_ArrayList()
        {
            ArrayList list = new ArrayList();
            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception of {ex.GetType()} type: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Task done!");
            }
        }

        static public void Task_Dictionary()
        {
            var people = new Dictionary<int, string>()
            {
                { 5, "Tom"},
                { 3, "Sam"},
                { 11, "Bob"},
                { 2, "Ron"},
                { 12, "Snon"},
                { 17, "Carl"},
                { 1, "Mike"},
                { 14, "Jane"},
                { 6, "Bill"},
                { 10, "Pall"},
            };

            foreach (var person in people)
            {
                Console.WriteLine($"Key: {person.Key}  Value: {person.Value}");
            }
        }

        static public void Task_ProductsStore_1_1()
        {
            List<Product> productBase = new List<Product>()
            {
                new Fruit("apple",10, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Fruit("lemon",20, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Fruit("pear",30, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Vegetable("tomato",40, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Vegetable("cucumber",50, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Vegetable("pepper",60, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };

            foreach (var item in productBase)
            {
                item.ShowInfo();
            }


            Console.WriteLine($"\nThese products are expired:");

            var expiredItems = from item in productBase where item.ExpirationDate < DateTime.Now select item;

            foreach (var item in expiredItems)
            {
                item.ShowInfo();
            }


            Сonsignment batch = new Сonsignment("batch #1", productBase.First(), 100, 10);

            Console.WriteLine();

            batch.ShowInfo();


            ProductKit kit = new ProductKit("kit #1", 50, productBase.GetRange(2, 2));

            Console.WriteLine();

            kit.ShowInfo();


            productBase[2].Price += 100;

            productBase.Remove(productBase.Last());

            foreach (var item in productBase)
            {
                item.ShowInfo();
            }

            productBase.Clear();
        }

        static public void Task_ProductsStore_1_2()
        {
            Console.WriteLine($"Product list:");

            List<Product> productBase = new List<Product>()
            {
                new Fruit("snickers",100, new DateTime(2015, 7, 19), new DateTime(2022, 7, 20)),
                new Fruit("mars",200, new DateTime(2013, 8, 19), new DateTime(2021, 8, 20)),
                new Fruit("dove",300, new DateTime(2017, 9, 19), new DateTime(2023, 9, 20)),
                new Vegetable("bounty",400, new DateTime(2016, 7, 20), new DateTime(2022, 7, 21)),
                new Vegetable("twix",500, new DateTime(2014, 8, 20), new DateTime(2021, 8, 21)),
                new Vegetable("picnic",600, new DateTime(2018, 9, 20), new DateTime(2023, 9, 21)),
            };

            foreach (var item in productBase)
            {
                item.ShowInfo();
            }

            var newCollection = from product in productBase where product.Price > 300 select product;

            var minValue = (from product in newCollection select product.Price).Min();

            Console.WriteLine($"Min value: {minValue}");
        }

        static public void Task_ProductDictionary()
        {
            var people = new Dictionary<string, int>()
            {
                { "snickers",5},
                { "mars",6},
                { "dove",3},
                { "bounty",8},
                { "twix",1},
                { "picnic",9}
            };
            ShowNameAndCounts(people);
            ShowName(people);
            ShowCounts(people);

        }

        private static void ShowNameAndCounts(Dictionary<string, int> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Key}  Value: {person.Value}");
            }
        }

        private static void ShowName(Dictionary<string, int> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Key}");
            }
        }

        private static void ShowCounts(Dictionary<string, int> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Count: {person.Value}");
            }
        }
    }
}

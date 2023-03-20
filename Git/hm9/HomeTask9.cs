using Git.hm6.Triangles;
using Git.hm9.Products;
using System.Collections;

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

        static public void Task_ProductsStore()
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


            Сonsignment batch = new Сonsignment( "batch #1", productBase.First(), 100, 10);

            Console.WriteLine(); 
            batch.ShowInfo();



            ProductKit kit = new ProductKit("kit #1", 50, productBase.GetRange(2, 2));

            Console.WriteLine();
            kit.ShowInfo();
        }
    }
}

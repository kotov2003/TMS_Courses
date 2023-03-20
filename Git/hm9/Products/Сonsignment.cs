using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm9.Products
{
    internal class Сonsignment:Product
    {
        public string СonsignmentName { get; set; }
        public Product Product { get; set; }
        public int СonsignmentPrice { get; set; }
        public int Quantity { get; set; }

        public Сonsignment(string name, Product product, int price, int quantity)
        {
            Name = name;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public Сonsignment()
        {
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Сonsignment info: Сonsignment Name = {СonsignmentName}, Сonsignment Price = {СonsignmentPrice}, Quantity = {Quantity}. \nProduct discription:");
            base.ShowInfo();
        }
    }
}

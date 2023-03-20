using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm9.Products
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Product(string name, int price, DateTime productionDate, DateTime expirationDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
        }

        public Product()
        {
            
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name = {Name}, Price = {Price}, Production Date = {ProductionDate.ToString("dd/MM/yyyy")}, Expiration Date = {ExpirationDate.ToString("dd/MM/yyyy")}, Is Profuct Expired ={IsProductExpired()}");
        }

        public bool IsProductExpired()
        {
            return this.ExpirationDate < DateTime.Today;
        }
    }
}

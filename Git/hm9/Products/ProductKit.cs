namespace Git.hm9.Products
{
    public class ProductKit : Product
    {
        public string ProductKitName { get; set; }
        public int ProductKitPrice { get; set; }
        public List<Product> ProductList { get; set; }

        public ProductKit(string name, int price, List<Product> productList)
        {
            ProductKitName = name;
            ProductKitPrice = price;
            ProductList = productList;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ProductKit info: ProductKit Name = {ProductKitName}, ProductKit Price = {ProductKitPrice}. \nKit consists of:");
            foreach (var item in ProductList)
            {
                item.ShowInfo();
            }
        }

    }
}

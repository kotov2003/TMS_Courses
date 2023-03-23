namespace Git.hm9.Products
{
    public class Fruit : Product
    {
        public Fruit(string name, int price, DateTime productionDate, DateTime expirationDate) : base(name, price, productionDate, expirationDate)
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Product info: {base.ShowInfo}");
        }
    }
}

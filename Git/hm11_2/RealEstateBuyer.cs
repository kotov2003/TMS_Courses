namespace Git.hm11_2
{
    public class RealEstateBuyer : IObserver
    {
        public string Name { get; set; }
        IObservable monitor;

        public RealEstateBuyer(string name, IObservable obs)
        {
            this.Name = name;
            monitor = obs;
            monitor.AddObserver(this);
        }

        public void Update(int price)
        {
            Console.WriteLine($"REALTOR_ESTATE_BUYER: I've got info about PriceDrop less than 50. Average price is {price}");
        }

        public void Subscribe()
        {
            monitor.AddObserver(this);
        }

        public void Unsubscribe()
        {
            monitor.RemoveObserver(this);
            monitor = null;
        }
    }
}

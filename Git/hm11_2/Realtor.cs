using System.Diagnostics;

namespace Git.hm11_2
{
    class Realtor : IObserver
    {
        public string Name { get; set; }
        IObservable monitor;

        public Realtor(string name, IObservable obs)
        {
            this.Name = name;
            monitor = obs;
            monitor.AddObserver(this);
        }

        public void Update(int price)
        {
                Console.WriteLine($"REALTOR: I've got info about PriceDrop less than 50. Average price is {price}");
        }

        public void Subscribe()
        {
            monitor.AddObserver(this);
        }

        public void Unsubscribe()
        {
            monitor.RemoveObserver(this);
            monitor = null;
            Console.WriteLine($"WARNING: REALTOR IS UNSUBSCRIBED!\n");
        }
    }
}

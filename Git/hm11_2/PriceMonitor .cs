namespace Git.hm11_2
{
    public class PriceMonitor:IObservable
    {
        private int averagePrice;
        private int numberOfPricesToGenerate = 4;
        private List<IObserver> observers;

        public PriceMonitor()
        {
            observers = new List<IObserver>();
        }

        public void GetAveragePrice()
        {
            averagePrice = (int)new PriceGenerator().GeneratePrice(numberOfPricesToGenerate).Average();
            if (averagePrice < 50)
            {
                Console.WriteLine("MONITOR: Hurry up to buy it! Average price JUST fell below 50!");
                NotifyObservers();
            }
            else
            {
                Console.WriteLine("MONITOR: Average price has not dropped");
            }
            Console.WriteLine();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(averagePrice);
        }
    }
}

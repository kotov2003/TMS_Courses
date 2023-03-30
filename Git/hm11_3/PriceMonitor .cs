using System.Runtime.CompilerServices;

namespace Git.hm11_3
{
    public class PriceMonitor
    {
        private int averagePrice;
        private int numberOfPricesToGenerate = 4;
        public delegate void PriceDropSubscription(int price);
        public event PriceDropSubscription? subscription; 

        public PriceMonitor(PriceDropSubscription subscription)
        {
            this.subscription += subscription;
        }

        public PriceMonitor()
        {
        }

        public void GetAveragePrice()
        {
            averagePrice = (int)new PriceGenerator().GeneratePrice(numberOfPricesToGenerate).Average();
            if (averagePrice < 50)
            {
                Console.WriteLine("MONITOR: Hurry up to buy it! Average price JUST fell below 50!");
                subscription(averagePrice);
            }
            else
            {
                Console.WriteLine("MONITOR: Average price has not dropped");
            }
            Console.WriteLine();
        }
    }
}

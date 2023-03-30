namespace Git.hm11
{
    public class PriceMonitor
    {
        public delegate void ShowAveragePrice(int averagePrice);
        public static ShowAveragePrice? showAveragePrice;
        private static int averagePrice;
        private static int numberOfPricesToGenerate = 4;

        public PriceMonitor(ShowAveragePrice showPrice)
        {
            showAveragePrice += showPrice;
            GetPrice();
        }

        public static void ShowPrice() => showAveragePrice(averagePrice);

        private static void GetPrice()
        {
            averagePrice = (int)new PriceGenerator().GeneratePrice(numberOfPricesToGenerate).Average();
        }
    }
}

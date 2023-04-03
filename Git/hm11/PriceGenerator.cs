namespace Git.hm11
{
    internal class PriceGenerator
    {
        public PriceGenerator() { }

        public List<int> GeneratePrice(int numberOfPrices)
        {
            List<int> priceList = new List<int>();
            Random random = new Random();
            for (int i = 0; i < numberOfPrices; i++)
            {
                var price = random.Next(0, 100);
                Console.WriteLine($"Price number {i}: {price};");
                priceList.Add(price);
            }
            return priceList;
        }
    }
}

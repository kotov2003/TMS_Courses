namespace Git.hm11
{
    public class HomeTask11
    {
        public static void Task_PriceMonitoring()
        {
            PriceMonitor pm1 = new PriceMonitor(ShowFirstWay);
            PriceMonitor.ShowPrice();
            PriceMonitor pm2 = new PriceMonitor(ShowSecondWay);
            PriceMonitor.ShowPrice();
        }
        public static void ShowFirstWay(int result)
        {
            Console.WriteLine($"The first way of average price showing: {result}");
        }

        public static void ShowSecondWay(int result)
        {
            Console.WriteLine($"The second way of average price showing: {result}");
        }
    }
}

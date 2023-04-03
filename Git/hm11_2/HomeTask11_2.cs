namespace Git.hm11_2
{
    public class HomeTask11_2
    {
        public static void Task_PriceMonitoring_Observer()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Using Observer template implementation");
            Console.WriteLine(new string('=', 30));

            PriceMonitor monitor = new PriceMonitor();
            RealEstateBuyer listener_A = new RealEstateBuyer("Some Person", monitor);
            Realtor listener_B = new Realtor("Some Realtor", monitor);

            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
            
            listener_B.Unsubscribe();

            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
        }
    }
}

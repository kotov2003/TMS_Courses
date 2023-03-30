namespace Git.hm11_3
{
    public class HomeTask11_3
    {
        public static void Task_PriceMonitoring_Events()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Using Events implementation");
            Console.WriteLine(new string('=', 30));

            PriceMonitor monitor = new PriceMonitor();
            var buyerListner = new RealEstateBuyer("Some Person");
            var realtorListner = new Realtor("Some Realtor");

            monitor.subscription += buyerListner.Update;
            monitor.subscription += realtorListner.Update;
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();

            monitor.subscription -= realtorListner.Update;
            Console.WriteLine("$WARNING: REALTOR IS UNSUBSCRIBED!\n");
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
            monitor.GetAveragePrice();
        }
    }
}

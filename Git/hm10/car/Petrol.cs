namespace Git.hm10.car
{
    internal class Petrol : Engine
    {
        public override void Move()
        {
            Console.WriteLine("Move like a petrol car");
        }
        public override void Fill()
        {
            Console.WriteLine("Fill a petrol car");
        }
    }
}

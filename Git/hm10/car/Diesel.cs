namespace Git.hm10.car
{
    internal class Diesel : Engine
    {
        public override void Move()
        {
            Console.WriteLine("Move like a diesel car");
        }
        public override void Fill()
        {
            Console.WriteLine("Fill a diesel car");
        }
    }
}

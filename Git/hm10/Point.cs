namespace Git.hm10
{
    public class Point<T> /*where T : struct*/
    {
        private T x;
        private T y;
        public T X
        {
            get
            {
                return x;
            }
        }
        public T Y
        {
            get
            {
                return y;
            }
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowPointСoordinate()
        {
            Console.WriteLine($"Point: x = {x}, y = {y}");
        }

        public double GetDistanceToPoint(Point<T> point)
        {
            return Math.Sqrt(Math.Pow(Convert.ToDouble(point.X) - Convert.ToDouble(x), 2) + Math.Pow(Convert.ToDouble(point.Y) - Convert.ToDouble(y), 2));           
        }
    }
}

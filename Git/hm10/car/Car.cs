namespace Git.hm10.car
{
    public class Car<T> where T : Engine
    {
        private T engine;

        public Car(T motor)
        {
            engine = motor;
        }

        public void Movement()
        {
            engine.Move();
        }

        public void RefillingCar()
        {
            engine.Fill();
        }
    }
}

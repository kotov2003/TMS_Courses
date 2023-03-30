namespace Git.hm11_3
{
    class Realtor
    {
        public string Name { get; set; }

        public Realtor(string name)
        {
            this.Name = name;
        }

        public void Update(int price)
        {
                Console.WriteLine($"REALTOR: I've got info about PriceDrop less than 50. Average price is {price}");
        }
    }
}

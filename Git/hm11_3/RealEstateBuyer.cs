namespace Git.hm11_3
{
    public class RealEstateBuyer
    {
        public string Name { get; set; }

        public RealEstateBuyer(string name)
        {
            this.Name = name;
        }

        public void Update(int price)
        {
            Console.WriteLine($"REALTOR_ESTATE_BUYER: I've got info about PriceDrop less than 50. Average price is {price}");
        }
    }
}

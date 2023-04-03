namespace Git.hm12
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string ShowNames()
        {
            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"{FirstName} {LastName}");
                return FirstName + LastName;
            }
            else
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
                return FirstName + MiddleName + LastName;

            }
        }
    }
}

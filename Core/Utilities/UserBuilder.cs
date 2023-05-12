using Bogus;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public static class UserBuilder
    {
        static Faker Faker = new Faker();
        public static User GetStandartUser => new User
        {
            Name = TestContext.Parameters.Get("UserName"),
            Password = TestContext.Parameters.Get("UserPassword")
        };

        public static User GetInvalidWrongPasswordUser => new User
        {
            Name = TestContext.Parameters.Get("UserName"),
            Password = TestContext.Parameters.Get("wrongPassword")
        };

        public static User GetRandomUser => new User
        {
            Name = Faker.Internet.Email(uniqueSuffix:"VA_TEST"),
            Password = Faker.Internet.Password(10)
        }; 
    }
}

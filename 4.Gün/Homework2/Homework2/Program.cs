using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 1,
                FirstName = "Berkcan",
                LastName = "Gümüşışık",
                City = "Ankara"
            };
            Customer customer2 = new Customer(2, "Engin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);

        }


    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

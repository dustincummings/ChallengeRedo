using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGreeting2
{
    public enum CustomerType { Past=1, Present, Potential }

    class Customer
    {
        public CustomerType Type { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Greeting { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, CustomerType type, string greeting, string email)
        {
            Type = type;
            CustomerFirstName = firstName;
            CustomerLastName = lastName;
            Greeting = greeting;
            Email = email;
        }
        public Customer() { }
    }
}

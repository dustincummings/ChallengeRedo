using System;
using System.Collections.Generic;
using System.Text;

namespace EmailGreeting
{
        enum CustomerType { Past = 1, Present, Potential }
    class Customer
    {
        public CustomerType  Type { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Greeting { get; set; }

        public Customer( string firstName, string lastName, CustomerType type, string greeting)
        {
            this.Type = type;
            this.CustomerFirstName = firstName;
            this.CustomerLastName = lastName;
            this.Greeting = greeting;
        }
        public Customer() { }
    }
}

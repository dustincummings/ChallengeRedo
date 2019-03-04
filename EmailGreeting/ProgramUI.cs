using System;
using System.Collections.Generic;

namespace EmailGreeting
{
    class ProgramUI
    {

        CustomerRepo _customerRepo = new CustomerRepo();
        Customer customer = new Customer();
        public void Run()
        {
            Customer ron = new Customer("Ron", "Cooper", CustomerType.Past, "We miss you, Please consider coming back to us.");
            Customer jack = new Customer("Jack", "Black", CustomerType.Present, "Thank you for being such a loyal customer!! We are going to take $10 off your monthly premium");
            Customer homer = new Customer("Homer", " Simpson", CustomerType.Potential, "We would like you to consider us for all of your insurance needs. Here is a coupon for $50 off your 1st year's premium");

            _customerRepo.AddCustomer(jack);
            _customerRepo.AddCustomer(ron);
            _customerRepo.AddCustomer(homer);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome, what action would you like to take:\n\t" +
                    "1. Add Customer Info \n\t" +
                    "2. View the List of All Your Customers \n\t" +
                    "3. Update Customer Info \n\t" +
                    "4. Delete Customer From List" +
                    "5. Exit Program");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ShowCustomerList();
                        break;
                    case 3:
                        //UpdateCustomer();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        Console.WriteLine("Have a Good Day");
                        isRunning = false;
                        break;


                    default:
                        break;
                }
            }
        }
        public void AddCustomer()
        {
            Customer newCustomer = new Customer();
            Console.Clear();
            Console.WriteLine("What is the customer's first name?");
            newCustomer.CustomerFirstName = Console.ReadLine();
            Console.WriteLine("What is the customer's last name?");
            newCustomer.CustomerLastName = Console.ReadLine();
            Console.WriteLine("Please type in if this is a Past, Present, or Potential customer?");
            string type = Console.ReadLine().ToLower();
            switch (type)
            {
                case "past":
                    newCustomer.Type = CustomerType.Past;
                    newCustomer.Greeting = $"We miss you {newCustomer.CustomerFirstName}, Please consider coming back to us.";
                    break;
                case "present":
                    newCustomer.Type = CustomerType.Present;
                    newCustomer.Greeting = $"Thank you {newCustomer.CustomerFirstName} for being such a loyal customer!! We are going to take $10 off your monthly premium";
                    break;
                case "potential":
                    newCustomer.Type = CustomerType.Potential;
                    newCustomer.Greeting = $"Hello {newCustomer.CustomerFirstName}, We would like you to consider us for all of your insurance needs. Here is a coupon for $50 off your 1st year's premium";
                    break;
            }
            _customerRepo.AddCustomer(newCustomer);
        }
        public void RemoveCustomer()
        {

        }
        public void ShowCustomerList()
        {
            Console.Clear();
            List<Customer> customerList = _customerRepo.GetCustomerList();

            IEnumerable<Customer> sortedCustomers=
                from customer in customerList
                orderb

            Console.WriteLine("Last Name\t First Name\t Status\t\t Email");
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerLastName,-15}{customer.CustomerFirstName,-15}{customer.Type,-15}{customer.Greeting,-15}");
            }
            Console.ReadLine();
        }
    }
}
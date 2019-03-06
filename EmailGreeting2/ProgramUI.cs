using System;
using System.Collections.Generic;

namespace EmailGreeting2
{
    class ProgramUI
    {

        CustomerRepo _customerRepo = new CustomerRepo();

        public void Run()
        {
            Customer ron = new Customer("Ron", "Cooper", CustomerType.Past, "We miss you Ron , Please consider coming back to us.", "ron@ron.com");
            Customer dale = new Customer("Dale", "Cooper", CustomerType.Past, "We miss you Dale , Please consider coming back to us.", "dale@dale.com");
            Customer chase = new Customer("Chase", "Cooper", CustomerType.Past, "We miss you Chase , Please consider coming back to us.", "chase@chase.com");
            Customer jack = new Customer("Jack", "Black", CustomerType.Present, "Thank you, Jack, for being such a loyal customer!! We are going to take $10 off your monthly premium", "jack@jack.com");
            Customer homer = new Customer("Homer", "Simpson", CustomerType.Potential, "Homer, We would like you to consider us for all of your insurance needs. Here is a coupon for $50 off your 1st year's premium", "homer@homer.com");

            _customerRepo.AddCustomer(ron);
            _customerRepo.AddCustomer(homer);
            _customerRepo.AddCustomer(jack);
            _customerRepo.AddCustomer(dale);
            _customerRepo.AddCustomer(chase);

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome, what action would you like to take:\n\t" +
                    "1. Add Customer Info \n\t" +
                    "2. View the List of All Your Customers \n\t" +
                    "3. Update Customer Info \n\t" +
                    "4. Delete Customer From List\n\t" +
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
                        UpdateCustomerInfo();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        Console.WriteLine("Have a Good Day");
                        Console.ReadLine();
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
            Console.WriteLine("What is the customer's email address?");
            newCustomer.Email = Console.ReadLine();
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
            List<Customer> customerList = _customerRepo.ShowCustomerList();
            Console.Clear();

            Console.WriteLine("\nPlease type in the email address of the customer that you would like");
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerLastName,-15}\t{customer.CustomerFirstName,-10}\t{customer.Email,-20}");
            }
            var removedItem = Console.ReadLine();
            foreach (var customer in customerList)
            {
                if (removedItem == customer.Email)
                {
                    _customerRepo.DeleteCustomer(customer);
                    break;
                }
            }
        }
        public void ShowCustomerList()
        {
            Console.Clear();
            List<Customer> customerList = _customerRepo.ShowCustomerList();

            Console.WriteLine("Last Name\t First Name\t Status\t\t Email");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerLastName,-15}{customer.CustomerFirstName,-15}{customer.Type,-15}{customer.Greeting,-15}");
            }
            Console.ReadLine();
        }
        public void UpdateCustomerInfo()
        {
            List<Customer> customerList = _customerRepo.ShowCustomerList();
            Console.Clear();
            Console.WriteLine("Which customer would you like to update? Please enter in their email address");
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.CustomerLastName,-15}{customer.CustomerFirstName,-15}{customer.Email,-15}{customer.Type}");
            }
            var updateCustomer = Console.ReadLine();
            foreach (var customer in customerList)
            {
                if (updateCustomer == customer.Email)
                {
                    Console.WriteLine("What is the customer's first name?");
                    customer.CustomerFirstName = Console.ReadLine();
                    Console.WriteLine("What is the customer's last name?");
                    customer.CustomerLastName = Console.ReadLine();
                    Console.WriteLine("What is the customer's email address?");
                    customer.Email = Console.ReadLine();
                    Console.WriteLine("Please type in if this is a Past, Present, or Potential customer?");
                    string type = Console.ReadLine().ToLower();
                    switch (type)
                    {
                        case "past":
                            customer.Type = CustomerType.Past;
                            customer.Greeting = $"We miss you {customer.CustomerFirstName}, Please consider coming back to us.";
                            break;
                        case "present":
                            customer.Type = CustomerType.Present;
                            customer.Greeting = $"Thank you {customer.CustomerFirstName} for being such a loyal customer!! We are going to take $10 off your monthly premium";
                            break;
                        case "potential":
                            customer.Type = CustomerType.Potential;
                            customer.Greeting = $"Hello {customer.CustomerFirstName}, We would like you to consider us for all of your insurance needs. Here is a coupon for $50 off your 1st year's premium";
                            break;
                    }
                }
            }
        }
    }
}
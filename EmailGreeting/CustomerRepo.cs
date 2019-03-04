using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailGreeting
{
    class CustomerRepo
    {
        List<Customer> _customerList = new List<Customer>();
        

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
        public List<Customer> GetCustomerList()
        {
            return _customerList;
        }
        
    }
}

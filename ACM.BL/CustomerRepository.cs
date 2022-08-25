using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieve the defined customers

            // Temporary hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        // Saves the current customer
        public bool Save(Customer customer)
        {
            // Code that saves the defined customer

            return true;
        }
    }
}

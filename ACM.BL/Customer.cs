﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        
        public string EmailAddress { get; set; }

        public string FullName 
        { 
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Code that retrieve the defined customer

            return new Customer();
        }

        // Retrieve all customers
        public List<Customer> Retrieve()
        {
            // Code that retrieve all of the customers

            return new List<Customer>();
        }

        // Saves the current customer
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        // Validates the customer data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}

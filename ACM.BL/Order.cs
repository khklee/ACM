using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        // Validates the order data
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        // Retrieve one order
        public Order Retrieve(int orderId)
        {
            // Code that retrieve the defined order

            return new Order();
        }

        // Retrieve all orders
        public List<Order> Retrieve()
        {
            // Code that retrieve all of the orders

            return new List<Order>();
        }

        // Saves the current order
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }
    }
}

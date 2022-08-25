using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Retrieve one order
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieve the defined order

            // Temporary hard-coded values to return a populated order
            if (orderId == 3)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        // Saves the current order
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }
    }
}

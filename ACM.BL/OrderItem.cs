using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        // Validates the order item
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false; 


            return isValid;
        }

        // Retrieve one order item
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieve the defined order item

            return new OrderItem();
        }

        // Retrieve all order items
        public List<OrderItem> Retrieve()
        {
            // Code that retrieve all of the order items

            return new List<OrderItem>();
        }

        // Saves the current order item
        public bool Save()
        {
            // Code that saves the defined order item

            return true;
        }
    }
}

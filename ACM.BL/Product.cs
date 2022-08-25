using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        // Validates the product data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        // Retrieve one product
        public Product Retrieve(int productId)
        {
            // Code that retrieve the defined product

            return new Product();
        }

        // Retrieve all products
        public List<Product> Retrieve()
        {
            // Code that retrieve all of the products

            return new List<Product>();
        }

        // Saves the current product
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }
    }
}

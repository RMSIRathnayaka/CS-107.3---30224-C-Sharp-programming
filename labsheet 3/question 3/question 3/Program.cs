using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    public class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        //constructor

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }
        public String getProductName()
        {
            return productName;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantityInStock()
        {
            return quantityInStock;
        }

        public void AddProduct(int quantity)
        {
            this.quantityInStock += quantity;
        }

        public void BuyProduct(int quantity)
        {
            this.quantityInStock -= quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product lap = new Product(101, "Laptop", 800, 10);
            Console.WriteLine("Product Name: " + lap.getProductName());
            Console.WriteLine("Price: " + lap.getPrice());
            Console.WriteLine("Quantity: "+ lap.getQuantityInStock());
        }
    }
}

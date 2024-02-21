using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Parameterized constructor
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects using the constructor
            Product product1 = new Product("Laptop", 999.99m);
            Product product2 = new Product("Smartphone", 599.99m);
            Product product3 = new Product("Headphones", 99.99m);

        }
        // Display product details
        Console.WriteLine("Product 1:");
        Console.WriteLine($"Name: {product1.ProductName}, Price: {product1.Price:C}");

        Console.WriteLine("\nProduct 2:");
        Console.WriteLine($"Name: {product2.ProductName}, Price: {product2.Price:C}");

        Console.WriteLine("\nProduct 3:");
        Console.WriteLine($"Name: {product3.ProductName}, Price: {product3.Price:C}");
    }
}

using System;

namespace ECommerceSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Mobile", Category = "Electronics" },
                new Product { ProductId = 3, ProductName = "Tablet", Category = "Electronics" }
            };

            Product linearResult =
                SearchService.LinearSearch(products, "Mobile");

            if (linearResult != null)
            {
                Console.WriteLine("Linear Search Found: " +
                                  linearResult.ProductName);
            }

            Array.Sort(products,
                (x, y) => x.ProductName.CompareTo(y.ProductName));

            Product binaryResult =
                SearchService.BinarySearch(products, "Mobile");

            if (binaryResult != null)
            {
                Console.WriteLine("Binary Search Found: " +
                                  binaryResult.ProductName);
            }
        }
    }
}
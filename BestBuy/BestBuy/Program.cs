using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Name = "Xbox";
            product.Price = 250.00;

            Console.WriteLine($"Name: {product.Name} Price: {product.Price} Price w/ tax: {product.PriceWithTax()}");
        }
    }
}

using System;
using System.IO;
using System.Text.Json;

namespace ProductenLaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            string text = File.ReadAllText("Product.json");
            Product product = JsonSerializer.Deserialize<Product>(text);

            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Price: {product.Price}");
        }

        internal void RunProducten()
        {
            string text = File.ReadAllText("Producten.json");
            Product[] products = JsonSerializer.Deserialize<Product[]>(text);

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}

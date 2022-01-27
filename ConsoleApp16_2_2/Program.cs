using System;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp16_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Elizaveta\\source\repos\\ConsoleApp16_1_1\\ConsoleApp16_1_1\bin\\Debug\\Products.json";
            string jsonstring = File.ReadAllText(path);
            Product[] arrayProduct = JsonSerializer.Deserialize<Product[]>(jsonstring);
            Product productWithMaxPrice = arrayProduct[0];
            foreach (Product p in arrayProduct)
            {
                if (p.Price > productWithMaxPrice.Price)
                {
                    productWithMaxPrice = p;
                }
            }
            Console.WriteLine("Самый дорогой товар:");
            Console.WriteLine($"{productWithMaxPrice.Code} {productWithMaxPrice.Name} {productWithMaxPrice.Price}");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int Code { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}

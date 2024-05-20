using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
namespace ConsoleApplication5
{
    class Product
    {
        public int number;
        public string name;
        public string category;
        public int count;
        public double price;
        public string stock;
        public Product(int number, string name, string category, int count, double price, string stock)
        {
            this.number = number;
            this.name = name;
            this.category = category;
            this.count = count;
            this.price = price;
            this.stock = stock;
        }
    }
    class Program
    {
        static void Main()
        {
            Product cheese = new Product(1, "cheese", "milk product", 20, 299, "sklad 1");
            Product beer = new Product(2, "beer", "alcohol", 44, 89, "sklad 2");
            Product mayonaise = new Product(3, "Mayonaise", "milk product", 59, 344, "sklad 1");
            Product cucumber = new Product(20, "Cucumber", "Groceries", 100, 50, "sklad 3");
            Product whiskey = new Product(44, "Whiskey", "alcohol", 10, 1000, "sklad 2");
            Product missingn = new Product(4, "??????", "none", 10, 10000, "sklad 4");
            Product fridge = new Product(145, "Fridge", "none", 1, 50000, "sklad 4");
            List<Product> list = new List<Product>() { cheese, beer, mayonaise, cucumber, whiskey, missingn, fridge };
            var amount = from l in list group l by l.stock into g select new { Stock = g.Key, Count = g.Sum(p => p.count) };
            foreach (var item in amount)
            {
                Console.WriteLine(item.Stock + " " + item.Count);
            }
            Console.WriteLine("===============");
            var maxincat = from l in list group l by l.category into g select new { Category = g.Key, MaxPrice = g.Max(p => p.price) };
            foreach(var item in maxincat)
            {
                Console.WriteLine(item.Category + " " + item.MaxPrice);
            }
            Console.WriteLine("===============");
            double noneaverage = list.Where(l => l.category == "none").Average(l => l.price);
            Console.WriteLine(noneaverage);
            Console.WriteLine("===============");
            var cheapest = from l in list where l.price == list.Min(l=>l.price) select l;
            foreach(var item in cheapest)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("===============");
            double everything = list.Sum(l => l.price * l.count);
            Console.WriteLine(everything);
            Console.ReadKey();
        }
    }
}
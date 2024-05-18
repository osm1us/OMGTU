using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Что", "вершит", "судьбу", "человечества", "в", "этом", "мире?" };
            var EvenElements1 = list.Where(str => str.Length % 2 == 0);
            foreach (var str in EvenElements1) Console.WriteLine(str);
            Console.WriteLine("_________________________________");
            list.Add("Некое"); list.Add("незримое"); list.Add("существо?");
            list = list.Where(str => list.IndexOf(str) % 2 != 0).ToList();
            var EvenElements2 = list.Where(str => str.Length % 2 == 0);
            foreach (var str in EvenElements2) Console.WriteLine(str);
        }
    }
}

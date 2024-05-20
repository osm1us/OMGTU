using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace lul
{
    class Worker
    {
        public int number;
        public string name;
        public string education;
        public string job;
        public double salary;
        public int amount;
        public double price;
        public Worker(int number, string name, string education, string job, double salary, int amount, double price)
        {
            this.number = number;
            this.name = name;
            this.education = education;
            this.job = job;
            this.salary = salary;
            this.amount = amount;
            this.price = price;
        }
    }
    class Program
    {
        static void Main()
        {
            Worker oleg = new Worker(1, "Никотинов Олег Геннадьевич", "2 высших", "Слесарь", 100000, 1000, 50);
            Worker sergei = new Worker(2, "Бумажкин Сергей Константинович", "8 классов", "Фрилансер", 100000, 5000, 1000);
            Worker dmitrii = new Worker(3, "Матвеев Дмитрий Андреевич", "Среднее образование", "СММ", 90000, 1000, 1000);
            Worker ilya = new Worker(4, "Коровкин Илья Сулейманович", "2 высших", "Фрезеровщик", 30000, 1000, 200);
            Worker David = new Worker(5, "Тильт Давид", "4.5 класса", "Курьер", 11250, 100, 100);
            List<Worker> list = new List<Worker>() { oleg, sergei, dmitrii, ilya, David };
            var lessthanproducts = from l in list where l.salary < l.amount*l.price select l;
            foreach ( var l in lessthanproducts)
            {
                Console.WriteLine(l.name);
            }
            Console.WriteLine("===============");
            var overallamount = from l in list group l by l.name into g select new { Name = g.Key, Amount = g.Sum(l => l.amount) };
            foreach ( var l in overallamount)
            {
                Console.WriteLine(l.Name + " " + l.Amount);
            }
            Console.WriteLine("===============");
            double overallprice = list.Sum(l=>l.amount * l.price) ;
            Console.WriteLine(overallprice);
            Console.WriteLine("===============");
            int num = list.Count(l=> 0.5 *l.salary >= l.amount * l.price);
            Console.WriteLine(num);
            Console.ReadKey(); 
        }
    }
}

       
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApplication5
{
    class BankClient
    {
        public string number;
        public string name;
        public string phone_number;
        public double income;
        public double outcome;
        public double tax;
        public BankClient(string number, string name, string phone_number, double income, double outcome)
        {
            this.number = number;
            this.name = name;
            this.phone_number = phone_number;
            this.income = income;
            this.outcome = outcome;
            this.tax = income *0.05;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankClient Serega = new BankClient("45678397462386", "Serega", "+795088872323", 40000, 30000);
            BankClient Denis_Ivanov = new BankClient("4578723548234523423", "Denis", "+7950723487234", 40000, 20000);
            BankClient Kondakov_Nikolai = new BankClient("83453928472834728", "Nikolai", "+79586444559", 5000, 20000);
            BankClient Vanya = new BankClient("7863492876347234", "Vanya", "+79536473377", 20000, 20000);
            BankClient David_Thiel = new BankClient("2384728934722333", "David", "+795367743567", 0, 86000);
            List<BankClient> list = new List<BankClient>() { Serega, Denis_Ivanov, Kondakov_Nikolai, Vanya, David_Thiel};
            var broke = from c in list where c.income - (c.outcome + c.tax) < 0 select c;
            Console.WriteLine("Количество людей с отрицательным балансом:" + broke.Count());
            var rich = from c in list let max = list.Max(client => client.income) where c.income == max select c;
            Console.WriteLine("Количество людей с максимальным балансом: " + rich.Count());
            double mid_income = list.Average(client => client.income);
            Console.WriteLine("Средний доход: " + mid_income);
            double tax_sum = list.Sum(client => client.tax);
            Console.WriteLine("Сумма налогов: " + tax_sum);
            Console.ReadKey();
        }

    }
}

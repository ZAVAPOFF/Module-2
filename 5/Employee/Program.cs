using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string name;
        public int age;
        public string job;
        public decimal money;
        public Employee(string name, int age, string job, decimal money)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.money = money;
        }
        public decimal YearMoney()
        {
            return 12 * money;
        }

        public void Print()
        {
            Console.WriteLine("Имя: {0} Возраст: {1} Должность: {2} Зарплата: {3} Годовой заработок: {4}", name,age,job,money,YearMoney());
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
         Employee emp1 = new Employee("Даниил Клименков",17,"Программист",2000);
         emp1.Print();
         Employee emp2 = new Employee("Арсений Близнецов",17,"Торговец",1500);
         emp2.Print();         
         Employee emp3 = new Employee("Глеб Герасименко",17,"Садовник", 1000.73m);
         emp3.Print();
         Console.ReadLine();
        }
    }
}

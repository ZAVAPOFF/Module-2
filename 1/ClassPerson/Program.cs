using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Person
    {
        public string Name;
        public int Age;
        public string Address;
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
            public void Print()
            {
            Console.WriteLine("Имя: {0} \nВозраст: {1} \nАдрес: {2}",Name, Age, Address);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
         Person person = new Person("Даниил",17,"1 мая");
            person.Print();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Destructor
{
    class MyClass
    {
        private int variable1;
        private int variable2;

        // Конструктор с входными параметрами
        public MyClass(int var1, int var2)
        {
            variable1 = var1;
            variable2 = var2;
        }
        // Конструктор инициализирующий члены класса по умолчанию
        public MyClass()
        {
            variable1 = 0;
            variable2 = 0;
        }
        ~MyClass()
        {
            Console.WriteLine("Объект был удалён");
        }
        public void Dispose()
        {
            Console.WriteLine($"{variable1} has been disposed");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
          MyClass myClass = new MyClass(10,20);
            myClass.Dispose();
        }
    }

}

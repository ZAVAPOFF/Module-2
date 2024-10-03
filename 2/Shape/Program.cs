using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }

    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Площадь круга: {circle.Area()}");
            Console.WriteLine($"Периметр круга: {circle.Perimeter()}");

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter()}");
        }
    }

}

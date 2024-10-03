using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{

    interface IDrawable
    {
         void Draw();
    }

    class Circle: IDrawable
    {
        public int x;
        public void Draw() 
        {
            Console.WriteLine("Круг");
        }
    }
    class Rectangle:IDrawable
    {
        public int x;
        public void Draw()
        {
            Console.WriteLine("Прямоугольник");
        }
    }
    class Triangle: IDrawable
    {
       
        public void Draw()
        {
            Console.WriteLine("Треугольник");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] drawables = {new Circle(),new Rectangle(), new Triangle()};
            foreach (IDrawable drawable in drawables)
            {
               drawable.Draw();
            }
            Console.ReadLine();
        }
    }
}

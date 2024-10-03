using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Author
    {
        public int birthday;
        public string nickname;
        public Author(int birthday, string nickname)
        {
            this.birthday = birthday;
            this.nickname = nickname;
        }
    }
    class Book
    {
        public int year;
        public string name;
        public Author author;
        public void Print(string name, int year, Author author)
        {
            Console.WriteLine("Название книги: {0} \nГод выпуска: {1} \nАвтор: {2} \nГод рождения автора: {3}",  name, year, author.nickname, author.birthday);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Author author1 = new Author(1799, "А.С.Пушкин");
            book.year = 1836;
            book.name = "Капитанская дочка";
            book.Print(book.name,book.year, author1);

            Console.WriteLine();
            Author author2 = new Author(1814, "М.Ю.Лермонтов");
            book.year = 1837;
            book.name = "Бородино";
            book.Print(book.name, book.year, author2);

            Console.WriteLine();
            Author author3 = new Author(1809, "Н.В.Гоголь");
            book.year = 1842;
            book.name = "Мёртвые души";
            book.Print(book.name, book.year, author3);
            Console.ReadLine();

        }
    }
}

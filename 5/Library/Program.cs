using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public Author(string firstName, string lastName, int birthyear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthyear;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (род. {BirthYear})";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author BookAuthor { get; set; }
        public int YearPublished { get; set; }

        public Book(string title, Author author, int yearPublished)
        {
            Title = title;
            BookAuthor = author;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return $"{Title}, автор: {BookAuthor}, год издания: {YearPublished}";
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" добавлена в библиотеку.");
        }

        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine($"Книга \"{book.Title}\" удалена из библиотеки.");
            }
            else
            {
                Console.WriteLine($"Книга \"{book.Title}\" не найдена в библиотеке.");
            }
        }

        public List<Book> FindBooksByAuthor(string firstName, string lastName)
        {
            return books.Where(b => b.BookAuthor.FirstName == firstName && b.BookAuthor.LastName == lastName).ToList();
        }

        public List<Book> FindBooksByYear(int year)
        {
            return books.Where(b => b.YearPublished == year).ToList();
        }

        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста.");
            }
            else
            {
                Console.WriteLine("Книги в библиотеке:");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем авторов

            Author author1 = new Author("Лев", "Толстой", 1828);
            Author author2 = new Author("Федор", "Достоевский", 1821);

            // Создаем книги
            Book book1 = new Book("Война и мир", author1, 1869);
            Book book2 = new Book("Преступление и наказание", author2, 1866);
            Book book3 = new Book("Анна Каренина", author1, 1877);

            // Создаем библиотеку
            Library library = new Library();

            // Добавляем книги в библиотеку
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Список книг в библиотеке
            library.ListBooks();

            // Поиск книг по автору
            var tolstoyBooks = library.FindBooksByAuthor("Лев", "Толстой");
            Console.WriteLine("\nКниги Льва Толстого:");
            foreach (var book in tolstoyBooks)
            {
                Console.WriteLine(book);
            }

            // Поиск книг по году издания
            var booksFrom1866 = library.FindBooksByYear(1866);
            Console.WriteLine("\nКниги, изданные в 1866 году:");
            foreach (var book in booksFrom1866)
            {
                Console.WriteLine(book);
            }

            // Удаление книги
            library.RemoveBook(book2);

            // Список книг после удаления
            library.ListBooks();
        }
    }
}
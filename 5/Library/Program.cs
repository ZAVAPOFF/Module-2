using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthday { get; set; }

        public Author(string firstName, string lastName, int birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Birthday})";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Publication { get; set; }

        public Book(string title, Author author, int publication)
        {
            Title = title;
            Author = author;
            Publication = publication;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Publication})";
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> FindBooksByAuthor(string authorLastName)
        {
            return books.Where(b => b.Author.LastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> FindBooksByYear(int year)
        {
            return books.Where(b => b.Publication == year).ToList();
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Author author1 = new Author("Leo", "Tolstoy", 1828);
            Author author2 = new Author("Fyodor", "Dostoevsky", 1821);

            Book book1 = new Book("War and Peace", author1, 1869);
            Book book2 = new Book("Anna Karenina", author1, 1877);
            Book book3 = new Book("Crime and Punishment", author2, 1866);

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("All books in the library:");
            library.DisplayBooks();

            Console.WriteLine("\nBooks by Tolstoy:");
            var tolstoyBooks = library.FindBooksByAuthor("Tolstoy");
            foreach (var book in tolstoyBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nBooks published in 1866:");
            var books1866 = library.FindBooksByYear(1866);
            foreach (var book in books1866)
            {
                Console.WriteLine(book);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author, bool isAvailable)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    class Program16
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", true));
            library.AddBook(new Book(2, "1984", "George Orwell", false));
            library.AddBook(new Book(3, "To Kill a Mockingbird", "Harper Lee", true));
            library.AddBook(new Book(4, "Moby Dick", "Herman Melville", true));
            library.AddBook(new Book(5, "Brave New World", "Aldous Huxley", false));

            Console.WriteLine("Search by author (George Orwell):");
            var searchByAuthor = library.SearchByAuthor("George Orwell");
            foreach (var book in searchByAuthor)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
            }

            Console.WriteLine("\nSearch by title (1984):");
            var searchByTitle = library.SearchByTitle("1984");
            foreach (var book in searchByTitle)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
            }
        }
    }
   
}
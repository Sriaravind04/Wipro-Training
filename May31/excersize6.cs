using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Available: {IsAvailable}";
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<(Book Book, DateTime DueDate)> BorrowedBooks { get; set; } = new List<(Book, DateTime)>();

        public Student(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book, DateTime dueDate)
        {
            BorrowedBooks.Add((book, dueDate));
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.RemoveAll(b => b.Book == book);
        }

        public void ListBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s Borrowed Books:");
            foreach (var borrowed in BorrowedBooks)
            {
                Console.WriteLine($"{borrowed.Book.Title} - Due Date: {borrowed.DueDate.ToShortDateString()}");
            }
        }
    }

    class Library
    {
        private List<Book> Books { get; set; } = new List<Book>();
        private List<Student> Students { get; set; } = new List<Student>();

        // Add a new book to the library
        public void AddBook(string title, string author)
        {
            var book = new Book(title, author);
            Books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        // Remove a book from the library
        public void RemoveBook(string title)
        {
            var bookToRemove = Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                Console.WriteLine($"Book removed: {bookToRemove.Title}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // Borrow a book
        public void BorrowBook(string studentName, string bookTitle, DateTime dueDate)
        {
            var student = Students.Find(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));
            var book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            if (book == null || !book.IsAvailable)
            {
                Console.WriteLine($"Book '{bookTitle}' is not available for borrowing.");
                return;
            }

            student.BorrowBook(book, dueDate);
            book.IsAvailable = false;
            Console.WriteLine($"{studentName} borrowed '{bookTitle}' with due date {dueDate.ToShortDateString()}.");
        }

        // Return a borrowed book
        public void ReturnBook(string studentName, string bookTitle)
        {
            var student = Students.Find(s => s.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase));
            var book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

            if (student == null || book == null)
            {
                Console.WriteLine("Student or Book not found.");
                return;
            }

            student.ReturnBook(book);
            book.IsAvailable = true;
            Console.WriteLine($"{studentName} returned '{bookTitle}'.");
        }

        // Add a student to the system
        public void AddStudent(string name)
        {
            Students.Add(new Student(name));
            Console.WriteLine($"Student {name} added to the system.");
        }

        // List all books in the library
        public void ListBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }

        // List all students in the system
        public void ListStudents()
        {
            Console.WriteLine("Students in Library System:");
            foreach (var student in Students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    class Program6
    {
        public static void Main()
        {
            Library library = new Library();

            library.AddBook("The Great Gatsby", "F. Scott Fitzgerald");
            library.AddBook("1984", "George Orwell");
            library.AddBook("To Kill a Mockingbird", "Harper Lee");

            library.AddStudent("Alice");
            library.AddStudent("Bob");

            library.ListBooks();

            library.BorrowBook("Alice", "The Great Gatsby", DateTime.Now.AddDays(14));
            library.BorrowBook("Bob", "1984", DateTime.Now.AddDays(7));

            Console.WriteLine();
            var alice = new Student("Alice");
            alice.ListBorrowedBooks();
            var bob = new Student("Bob");
            bob.ListBorrowedBooks();

            library.ReturnBook("Alice", "The Great Gatsby");

            library.RemoveBook("1984");

            library.ListStudents();
        }
    }
}

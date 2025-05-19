using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Book {
        public string Title {  get; set; }
        public string Author { get; set; }

        public Book(string title, string author) {
            Title = title;
            Author = author;
        }
    }
    class Program2
    {
        static void Main(String[] args) { 
            Queue<Book> list = new Queue<Book>();
            list.Enqueue(new Book ("first chapter","first author"));
            list.Enqueue(new Book("second chapter", "second author"));
            list.Enqueue(new Book("third chapter", "third AUthor"));
            list.Enqueue(new Book("fourth chapter", "fourth author"));
            list.Enqueue(new Book("fifth chapter", "fifth author"));

            Console.WriteLine("next book");
            Book nextbook = list.Peek();
            Console.WriteLine($"{nextbook.Title} by {nextbook.Author}");

            Console.WriteLine("returning the book");
            list.Dequeue();

            Stack<Book> stack = new Stack<Book>();
            stack.Push(new Book("newbook1","newauthor1"));
            stack.Push(new Book("newbook2", "newauthor2"));
            stack.Push(new Book("newbook3", "newauthor3"));

            Book books = stack.Peek();
            Console.WriteLine($"recent book {books.Title}");

            stack.Pop();
            Console.WriteLine("remaing borrowed books");
            foreach (var a in list) {
                Console.WriteLine(a.Title);
            }

            Console.WriteLine("stack remaining");

            foreach (var b in stack) { 
                Console.WriteLine(b.Title);
            }
        }
    }
}
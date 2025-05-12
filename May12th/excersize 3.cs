using System;

abstract class Book {
    public abstract void Read();

    public void GetInfo() {
        Console.WriteLine("this is a book");
    }
}

class FictionBook : Book {
    public override void Read() {
        Console.WriteLine("Reading a fiction book");
    }
    
}

class ScienceBook : Book {
    public override void Read() {
        Console.WriteLine("reading a science book");
    }
}

class Program
{
    static void Main() { 
        Book fic = new FictionBook();
        Book scifi = new ScienceBook();

        fic.Read();
        fic.GetInfo();


        scifi.Read();

        scifi.GetInfo();
    }
}
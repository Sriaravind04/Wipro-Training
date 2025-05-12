using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "anil", "sharma", "abdullah","imran", "Naresh", "suresh", "suman" };

        //using LINQ Queries
        UsingLinq(names);
    }
    private static void UsingLinq(string[] names)
    {
        IEnumerable<string> query = from s in names
                                    where s.Length == 5
                                    orderby s
                                    select s.ToUpper();

        //select * from

        foreach(string itenm in query)
            Console.WriteLine(itenm);

        Console.Read();
    }
     private static void UsingLINQExtensions(string[] names) {
     IEnumerable<string> query = names
                                 .Where(s => s.Length == 5)
                                 .OrderBy(s => s)
                                 .Select(s=> s.ToUpper());

     foreach(string itenm in query)
         Console.WriteLine(itenm);
     Console.Read();
 }
}
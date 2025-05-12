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
 //another method
private static void UsingLINQFunctions(string[] names) { 
    Func<string, bool> filter = s => s.Length == 5;
    Func<string, string> extract = s => s;
    Func<string, string> project = s => s.ToUpper();

    IEnumerable<string> query = names.Where(filter)
                                      .OrderBy(extract)
                                      .Select(project);

    foreach (string itenm in query)
        Console.WriteLine(itenm);
    Console.Read();
}
 private static void UsingAnonymousMethods(string[] names) {
     Func<string, bool> filter = delegate (string s)
     {
         //more lines of code
         return s.Length == 5;
     };
     Func<string, string> extract = delegate (string s)
     {
         return s;
     };

     Func<string, string> project = delegate (string s)
     {
         return s.ToUpper();
     };

     IEnumerable<string> query = names.Where(filter)
                                      .OrderBy(extract)
                                      .Select(project);

     foreach(string itenm in query)
         Console.WriteLine(itenm);
 }
}
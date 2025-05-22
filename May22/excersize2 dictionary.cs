using System;
using System.ComponentModel;
using System.Collections;

class Program {
   
    //excersize 2 
    static void Main(string[] args) { 
        Dictionary<string,string> dic = new Dictionary<string,string>();
        dic.Add("sri", "1234567890");
        dic.Add("aravind", "1234567891");
        dic.Add("sam", "1234567892");

        foreach (var dics in dic) {
            Console.WriteLine($"Names are: {dics.Key} , Phone Number are: {dics.Value}");
        }

        Console.WriteLine("Enter a name for search: ");
        string search = Console.ReadLine();

        if (dic.ContainsKey(search))
        {
            Console.WriteLine("Phone number" + dic[search]);

        }
        else {
            Console.WriteLine("not found");
        }
           
            
        
    }

}
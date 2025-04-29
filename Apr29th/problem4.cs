using System;

public class HelloWorld
{
    //  public static void Main(string[] args)
    //  {
        static void Main() {
            Console.WriteLine("enter a no:");
            int no = Convert.ToInt32(Console.ReadLine());
            
            switch(no) {
                case 1:
                Console.WriteLine("Monday");
                break;
                case 2:
                Console.WriteLine("Tuesday");
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;
                case 4:
                Console.WriteLine("thursday");
                break;
                case 5:
                Console.WriteLine("friday");
                break;
                case 6:
                Console.WriteLine("Saturday");
                break;
                case 7:
                Console.WriteLine("sunday");
                break;
            }
        }
        }
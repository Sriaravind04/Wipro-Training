using System;

public class HelloWorld
{
    
        static String sample1(int a) {
            if(a%2==0){
                return "even";
            }
            else {
                return "odd";
            }
        }
        static void Main() {
            Console.WriteLine("answer is: "+sample1(9));
        }
         
       
     
}
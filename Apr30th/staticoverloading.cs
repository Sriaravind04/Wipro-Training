using System;

public class HelloWorld
{
   //static overloading
      static int Add(int a,int b) {
          return a + b;
      }
      static double Add(double a,double b) {
          return a + b;
      }
      
      static void Main() {
          Console.WriteLine("Int Add: "+Add(3,4));
          Console.WriteLine("Double Add: "+ Add(2.5,4.3));
      }
      
    }
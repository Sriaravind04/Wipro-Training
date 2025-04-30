using System;

public class HelloWorld
{
   //static overloading
   //static overloading
      static int Add(int a,int b) {
          return a + b;
      }
      static double Add(double a,double b) {
          return a + b;
      }
      static int Sub(int a,int b) {
          return a-b;
      }
      static int multiply(int a, int b){
          return a*b;
      }
      
      static void Main() {
          Console.WriteLine("Int Add: "+Add(3,4));
          Console.WriteLine("Double Add: "+ Add(2.5,4.3));
          Console.WriteLine("subtract: " +Sub(3,10));
          Console.WriteLine("Multiply: " +multiply(234,34));
      }
      
    
}
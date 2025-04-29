using System;

public class HelloWorld
{
    static int Add(int a,int b) {
            return a + b;
        }
        static int Mul(int a,int b) {
            return a*b;
        }
        static int Div(int a,int b) {
            return a/b;
        }
        static int Sub(int a,int b){
            return a-b;
        }
        static void Main()
        {
            int num1 = 20;
            int num2 = 10;
            
            //int result = Add(num1,num2);this is not an efficient way to create many variable
            //calling the methods
            Console.WriteLine("Addition: " +Add(num1,num2));
            Console.WriteLine("Multiplication: " +Mul(num1,num2));
            Console.WriteLine("Division: " +Div(num1,num2));
            Console.WriteLine("Subtraction: " +Sub(num1,num2));
        }
    // }
}
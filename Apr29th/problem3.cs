using System;

public class HelloWorld
{
    
        static string sample2(int a,int b,int c) {
            if(a>=b && a>=c) {
                return "a is largest";
            }
            else if(b>=a && b>=c){
                return "b is largest";
            }
            else {
                return "c is largest";
            }
        }
        static void Main(String[] args) {
            Console.WriteLine("largest is: "+sample2(1,2,3));
           }
        }
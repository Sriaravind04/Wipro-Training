using System;

public class HelloWorld
{
    static void PrintArray(int[]numbers, int search) {
        bool a = false;
        for(int i=0;i<numbers.Length;i++) {
            if(numbers[i]==search) {
                Console.WriteLine("found");
                a = true;
                break;
            }
        
        }
        if(!a) {
            Console.WriteLine("not found");
        }
    }
    static void Main() {
        int[] numbers = {3,5,7,8,2,9,10};
        int search = 7;
        PrintArray(numbers,search);
    }
}

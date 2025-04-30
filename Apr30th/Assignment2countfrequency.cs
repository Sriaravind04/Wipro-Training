using System;

public class HelloWorld
{
    static void PrintArray(int[]numbers) {
        for(int i=0;i<numbers.Length;i++) {
            bool isCounted = false;
           for(int j=0;j<i;j++) {
               if(numbers[i]==numbers[j]) {
                   isCounted = true;
                   break;
               }
           }
           if(isCounted)
                continue;
            int count =1;
            for(int k =i+1;k<numbers.Length;k++) {
                if(numbers[i] == numbers[k]) {
                    count++;
                }
            }
           Console.WriteLine(numbers[i]+" occurs "+ count);
    }
    }
    static void Main() {
        int[] numbers = {1,2,1,3,2,1,4,4,4};
        PrintArray(numbers);
    }
}

using System;

public class HelloWorld
{
    static void Main() {
  string a = "racecar";
  char[] b = a.ToCharArray();
  
  bool isPalindrome = true;
  for(int i =0;i<b.Length/2;i++) 
  {
      if(b[i] != b[b.Length - i -1]) 
      {
          isPalindrome = false;
          break;
      }
  }
  if(isPalindrome == true) {
      Console.WriteLine("yes");
  }
  else {
      Console.WriteLine("no");
  }

  
    }
}

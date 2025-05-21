using System;

class Program
{
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1) { 
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;

        }
        //Move n-1 from source to auxillary
        TowerOfHanoi(n - 1, from, aux, to);

        //Move the nth disk from source to destination
        Console.WriteLine($"Move disk {n} from {from} to{to}");

        //Move the n-1 disks from auxillary to destination
        TowerOfHanoi(n - 1, aux, to, from);

      
    }
    static void Main(string[] args)
    {

        int n = 3;

        TowerOfHanoi(n, 'A', 'C', 'B'); //A: source, B: auxiliary , C: destination
    }
}
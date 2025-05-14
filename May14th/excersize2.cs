using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IBankAccount {
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}
class SavingsAccount :IBankAccount {
    public void Deposit(double amount) {
        Console.WriteLine("your deposit amount is " + amount);
    }
    public void Withdraw(double amount) { Console.WriteLine("your withdraw amount is "+amount); }
    
    public void CheckBalance() { Console.WriteLine("your balance is "); }
}
class CurrentAccount : IBankAccount {
    public void Deposit(double amount) { Console.WriteLine("your current deposit amount is " + amount); }
    public void Withdraw(double amount) { Console.WriteLine("your withdraw amount is " + amount); }
    public void CheckBalance() { Console.WriteLine("your account balance is "); }

}
namespace ConsoleApp5
{
    internal class Program1
    {
        static void Main(string[] args) { 
           

            IBankAccount account2 = new SavingsAccount();
            account2.Deposit(20000);
            account2.Withdraw(500);
            account2.CheckBalance();

            IBankAccount account = new CurrentAccount();
            account.Deposit(10000);
            account.Withdraw(5000);
            account.CheckBalance();

        }
    }
}
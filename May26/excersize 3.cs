using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }  // "Deposit" or "Withdraw"
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Date.ToString("yyyy-MM-dd HH:mm:ss")} - {Type} - {Amount:C}";
        }
    }

    public class BankAccount
    {
        private decimal balance;
        public List<Transaction> Transactions { get; private set; }
        private const string TransactionHistoryFile = "transaction_history.txt";

        public BankAccount()
        {
            balance = 0;
            Transactions = new List<Transaction>();
            LoadTransactions();
        }

        // Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balance += amount;
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Type = "Deposit",
                Amount = amount
            };
            Transactions.Add(transaction);
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");

            SaveTransactions();
        }

        // Withdraw Method
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (balance < amount)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
                return;
            }

            balance -= amount;
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Type = "Withdraw",
                Amount = amount
            };
            Transactions.Add(transaction);
            Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");

            SaveTransactions();
        }

        // Display Transaction Summary
        public void DisplaySummary()
        {
            Console.WriteLine("\nTransaction Summary:");
            Console.WriteLine($"Current Balance: {balance:C}");

            Console.WriteLine("\nTransaction History:");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        // Save Transaction History to a file
        private void SaveTransactions()
        {
            using (StreamWriter writer = new StreamWriter(TransactionHistoryFile))
            {
                foreach (var transaction in Transactions)
                {
                    writer.WriteLine($"{transaction.Date.ToString("yyyy-MM-dd HH:mm:ss")},{transaction.Type},{transaction.Amount}");
                }
            }
        }

        // Load Transaction History from a file
        private void LoadTransactions()
        {
            if (File.Exists(TransactionHistoryFile))
            {
                using (StreamReader reader = new StreamReader(TransactionHistoryFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        var transaction = new Transaction
                        {
                            Date = DateTime.Parse(parts[0]),
                            Type = parts[1],
                            Amount = decimal.Parse(parts[2])
                        };

                        Transactions.Add(transaction);

                        // Update balance based on the transaction type
                        if (transaction.Type == "Deposit")
                        {
                            balance += transaction.Amount;
                        }
                        else if (transaction.Type == "Withdraw")
                        {
                            balance -= transaction.Amount;
                        }
                    }
                }
            }
        }
    }

    public class Program2
    {
        public static void Main()
        {
            BankAccount account = new BankAccount();

            // Display the transaction history on restart
            account.DisplaySummary();

            // Example transactions
            account.Deposit(500);
            account.Withdraw(200);
            account.Deposit(1000);
            account.Withdraw(50);

            // Display updated summary
            account.DisplaySummary();
        }
    }
   
}
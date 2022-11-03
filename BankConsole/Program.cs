using System;
using System.Collections.Generic;

namespace BankConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new bank account
            BankLibrary.BankAccount account = new BankLibrary.BankAccount("123456789", "John Doe", 1000);
            //create a new savings account
            BankLibrary.SavingsAccount savingsAccount = new BankLibrary.SavingsAccount("987654321", "Jane Doe", 1000, 5);
            //create a new deposit account
            BankLibrary.DebetAccount depositAccount = new BankLibrary.DebetAccount("123456789", "John Doe", 1000, 1000);
            //create a new list of accounts
            List<BankLibrary.BankAccount> accounts = new List<BankLibrary.BankAccount>();
            //add the accounts to the list
            accounts.Add(account);
            accounts.Add(savingsAccount);
            accounts.Add(depositAccount);
            //loop through the list and print the accounts
            foreach (BankLibrary.BankAccount acc in accounts)
            {
                Console.WriteLine(acc);
            }
            //deposit 1000 to the first account
            Console.WriteLine(account.Deposit(1000));
            //withdraw 500 from the second account
            Console.WriteLine(savingsAccount.Withdraw(500));
            //withdraw 500 from the third account
            Console.WriteLine(depositAccount.Withdraw(500));
            //add interest to the second account
            Console.WriteLine(savingsAccount.AddInterest());
            //loop through the list and print the accounts
            foreach (BankLibrary.BankAccount acc in accounts)
            {
                Console.WriteLine(acc);
            }
            Console.ReadLine();
        }
    }
}

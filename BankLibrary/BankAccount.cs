using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankAccount
    {
        private readonly int BANKID = 1234;
        protected string accountNum;
        protected string owner;
        protected double balance;

        public BankAccount(string accountNum, string owner, double balance)
        {
            this.accountNum = accountNum;
            this.owner = owner;
            this.balance = balance;
        }

        public BankAccount(string accountNum, string owner)
        {
            this.accountNum = accountNum;
            this.owner = owner;
        }
        
        public string Deposit(double amount)
        {
            balance += amount;
            return string.Format("You have successfully deposited ${0}.\nYour new balance is ${1}", amount, balance);
        }
        
        public string Withdraw(double amount)
        {
            if (balance < amount)
            {
                return "You're trying to withdraw more than your current balance.";
            }
            balance -= amount;
            return string.Format("You have successfully withdrawn ${0}.\nYour new balance is ${1}", amount, balance);
        }
        
        public string GetWholeAccountNum()
        {
            return string.Format("{0}/{1}", accountNum, BANKID);
        }

        public override string ToString()
        {
            return string.Format("Regular account [{0}, owner: {1}, balance: ${2}]", GetWholeAccountNum(), owner, balance);
        }
    }
}

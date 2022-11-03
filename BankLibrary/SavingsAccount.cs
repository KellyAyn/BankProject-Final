using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SavingsAccount : BankAccount
    {
        private double interest;

        //generate constructors
        public SavingsAccount(string accountNum, string owner, double balance, double interest) : base(accountNum, owner, balance)
        {
            this.interest = interest;
        }

        //constructor numero dos
        public SavingsAccount(string accountNum, string owner, double interest) : base(accountNum, owner)
        {
            this.interest = interest;
        }

        //a method to convert interest to percentage, calculate interest and add it to balance and return a string
        public string AddInterest()
        {
            double interestPercentage = interest / 100;
            double interestAmount = balance * interestPercentage;
            balance += interestAmount;
            return string.Format("You have successfully added ${0} interest to your account.\nYour new balance is ${1}", interestAmount, balance);
        }

        //override toString
        public override string ToString()
        {
            return string.Format("Savings account [{0}, owner: {1}, balance: ${2}, interest: {3}%]", GetWholeAccountNum(), owner, balance, interest);
        }
    }
}

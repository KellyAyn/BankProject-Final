using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class DebetAccount : BankAccount
    {
        private double debet;
        //consturctor
        public DebetAccount(string accountNum, string owner, double balance, double debet) : base(accountNum, owner, balance)
        {
            this.debet = debet;
        }
        //constructor
        public DebetAccount(string accountNum, string owner, double debet) : base(accountNum, owner)
        {
            this.debet = debet;
        }
        //withdraw override
        public new string Withdraw(double amount)
        {
            //if balance - amount is less than negative debet return
            if ((balance - amount) < -debet)
            {
                return "You're trying to withdraw more than your current balance.";
            }
            //subtract amount from balance and return a string
            balance -= amount;
            return string.Format("You have successfully withdrawn ${0}.\nYour new balance is ${1}", amount, balance);
        }

        //toString override
        public override string ToString()
        {
            return string.Format("Deposit account [{0}, owner: {1}, balance: ${2}, debet: ${3}]", GetWholeAccountNum(), owner, balance, debet);
        }
    }
}

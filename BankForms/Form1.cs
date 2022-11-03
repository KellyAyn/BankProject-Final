using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace BankForms
{
    public partial class Form1 : Form
    {
        BindingList<BankAccount> accounts = new BindingList<BankAccount>();
        public Form1()
        {
            InitializeComponent();
            lbAccounts.DataSource = accounts;
            
        }

        private void withdraw()
        {
            int index = lbAccounts.SelectedIndex;
            double amount = 0;
            double.TryParse(transactionAmount.Text, out amount);
            accounts[index].Withdraw(amount);
            lbAccounts.DataSource = null;
            lbAccounts.DataSource = accounts;

        }

        private void deposit()
        {
            int index = lbAccounts.SelectedIndex;
            double amount = 0;
            double.TryParse(transactionAmount.Text, out amount);
            accounts[index].Deposit(amount);
            lbAccounts.DataSource = null;
            lbAccounts.DataSource = accounts;
        }

        private void applyInterest()
        {
            int index = lbAccounts.SelectedIndex;
            if (accounts[index].GetType() != typeof(SavingsAccount))
            {
                MessageBox.Show("You can only apply interest to a savings account");
            }
            else
            {
                SavingsAccount account = accounts[index] as SavingsAccount;
                account.AddInterest();
            }
            lbAccounts.DataSource = null;
            lbAccounts.DataSource = accounts;

        }

        private void clearTextBoxes()
        {
            accountNum.Clear();
            accountOwner.Clear();
            accountBalance.Clear();
            debet.Text = "2000";
            interestRate.Text = "3.6";
        }
        private  BankAccount constructAccount()
        {
            string accNumber = accountNum.Text;
            string accOwner = accountOwner.Text;
            double accBalance = 0;
            if (!String.IsNullOrEmpty(accountBalance.Text))
            {
                double.TryParse(accountBalance.Text, out accBalance);
            }
            double accDebet = Convert.ToDouble(debet.Text);
            double interest = Convert.ToDouble(interestRate.Text);

            if (regularAccount.Checked)
            {
                BankAccount account = new BankAccount(accNumber, accOwner, accBalance);
                return account;
            }
            
            if (debetAccount.Checked)
            {
                DebetAccount account = new DebetAccount(accNumber, accOwner, accBalance, accDebet);
                return account;
            }
            else {
                SavingsAccount account = new SavingsAccount(accNumber, accOwner, accBalance, interest);
                return account;
            }
        }
        
        private void disableTextBoxes(object sender)
        {
            if (sender == regularAccount)
            {
                debet.Enabled = false;
                interestRate.Enabled = false;
                return;
            }
            else if (sender == debetAccount)
            {
                interestRate.Enabled = false;
                debet.Enabled = true;
                return;
            }
            else if (sender == savingsAccount)
            {
                interestRate.Enabled = true;
                debet.Enabled = false;
                return;
            }
        }

        private void regularAccount_CheckedChanged(object sender, EventArgs e)
        {
            disableTextBoxes(sender);
            
        }

        private void debetAccount_CheckedChanged(object sender, EventArgs e)
        {
            disableTextBoxes(sender);
        }

        private void savingsAccount_CheckedChanged(object sender, EventArgs e)
        {
            disableTextBoxes(sender);
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            BankAccount account = constructAccount();
            Console.WriteLine(account.GetType());
            accounts.Add(account);
            clearTextBoxes();
        }

        private void createTransaction_Click(object sender, EventArgs e)
        {
            if (transactionType.Text == "Withdraw")
            {
                withdraw();
            }
            else if (transactionType.Text == "Deposit")
            {
                deposit();
                
            }
            else if (transactionType.Text == "Apply Interest")
            {
                applyInterest();
            }
        }

        private void transactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)transactionType.SelectedItem == "Apply Interest")
            {
                transactionAmount.Enabled = false;
                return;
            } else
            {
                transactionAmount.Enabled = true;
                return;
            }
        }

        private void accountBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void interestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void accountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void transactionAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

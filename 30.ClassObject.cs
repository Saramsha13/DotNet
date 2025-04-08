using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    internal class Account
    {
        private string accNumber = "";
        private string accType = "";
        private double balance = 0;
        private string accHolderName = "";
        private string accHolderAddress = "";
        private string accHolderPhone = "";
        private string accHolderEmail = "";

        public void SetAccountDetails(string number, string type, double bal, string name, string address, string phone, string email)
        {
            accNumber = number;
            accType = type;
            balance = bal;
            accHolderName = name;
            accHolderAddress = address;
            accHolderPhone = phone;
            accHolderEmail = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Number: " + accNumber);
            Console.WriteLine("Account Type: " + accType);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Account Holder Address: " + accHolderAddress);
            Console.WriteLine("Account Holder Phone: " + accHolderPhone);
            Console.WriteLine("Account Holder Email: " + accHolderEmail + "\n");
        }
        public void ShowBalance()
        {
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Balance: " + balance + "\n");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount + "\n");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.\n");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount + "\n");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.\n");
            }
        }
    }
}

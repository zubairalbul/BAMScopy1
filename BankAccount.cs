using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMS
{
    public class BankAccount
    {
        // Variables to store account information
        private string accountNumber;
        private string accountHolderName;
        private decimal balance;

        // Constructor to create a new account with no initial deposit
        public BankAccount(string accountHolderName, string accountNumber)
        {
            // Set the account holder's name and account number
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;

            // Initialize the balance to zero
            this.balance = 0;
        }

        // Constructor to create a new account with an initial deposit
        public BankAccount(string accountHolderName, string accountNumber, decimal initialDeposit)
        {
            // Set the account holder's name, account number, and initial balance
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.balance = initialDeposit;
        }

        // Properties to access account information
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            // Check if the deposit amount is valid
            if (amount > 0)
            {
                // Add the deposit amount to the balance
                balance += amount;
            }
            else
            {
                // Display an error message if the deposit amount is invalid
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            // Check if the withdrawal amount is valid and if there are sufficient funds
            if (amount > 0 && amount <= balance)
            {
                // Subtract the withdrawal amount from the balance
                balance -= amount;
            }
            else
            {
                // Display an error message if the withdrawal is invalid or if there are insufficient funds
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }

        // Method to get the account information as a string
        public string GetAccountInfo()
        {
            // Return a string containing the account number, holder name, and balance
            return $"Account Number: {accountNumber}\nAccount Holder: {accountHolderName}\nBalance: {balance}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMS
{
    public class Bank
    {
        private List<BankAccount> accounts;

        public Bank()
        {
            accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public BankAccount
     GetAccountByNumber(string accountNumber)
        {
            return accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }

        public void DisplayAllAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine(account.GetAccountInfo());
            }
        }
    }
}

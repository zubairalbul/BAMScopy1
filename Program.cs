using System.Security.Principal;

namespace BAMS
{
    class Program
    {
        public static void Main()
        {
            Bank bank = new Bank();

            // Create accounts
            bank.AddAccount(new BankAccount("Alice", "12345"));
            bank.AddAccount(new BankAccount("Bob", "67890", 1000));

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Check account balance");
                Console.WriteLine("5. DisplayAllAccounts");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Enter account holder name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter account number: ");
    
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter initial deposit(optional): ");
    
                        decimal initialDeposit = 0;
                        string br;
                        if (!string.IsNullOrEmpty(br=Console.ReadLine()))
                        {
                            initialDeposit = decimal.Parse(br);
                        }
                        bank.AddAccount(new BankAccount(name, accountNumber, initialDeposit));
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Enter account number: ");
                        accountNumber = Console.ReadLine();
                        BankAccount depositAccount = bank.GetAccountByNumber(accountNumber);
                        if (depositAccount != null)
                        {
                            Console.Write("Enter deposit amount: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            depositAccount.Deposit(depositAmount);

                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Enter account number: ");
                        accountNumber = Console.ReadLine();
                        BankAccount withdrawAccount = bank.GetAccountByNumber(accountNumber);
                        if (withdrawAccount != null)
                        {
                            Console.Write("Enter withdrawal amount: ");
                            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                            withdrawAccount.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter account number: ");
                        string AccountNumber = Console.ReadLine();
                        BankAccount balanceAccount = bank.GetAccountByNumber(AccountNumber);

                        if (balanceAccount != null)
                        {
                            Console.Write("Account Number: " + balanceAccount.AccountNumber);
                            Console.WriteLine("||Account Holder: " + balanceAccount.AccountHolderName);


                            Console.WriteLine("Solve The Riddle to view balance:\nI manage users, control access, and keep the system secure. Without me, chaos would ensue. What am I? ");
                            string password = Console.ReadLine();

                            if (password.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Balance: $"+balanceAccount.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect password.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("All accounts and account holders:");
                        bank.DisplayAllAccounts();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
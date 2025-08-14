using System;
class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }
    public BankAccount(string accountHolder, decimal initialBalance = 0)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
                public void DisplayBalance()
            {
                Console.WriteLine($"Current balance for {AccountHolder}: ${Balance}");
            }
            }
               class Program
            {
            static void Main()
            {
                BankAccount account = new BankAccount("Chinmay Poojary", 1000);
                account.Withdraw(300);
                account.Deposit(500);
                account.DisplayBalance();
            }
        }
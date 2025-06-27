using System;
using System.Threading;

class Bank
{
    public double Balance { get; set; }
}

class Program
{
    static Bank account = new Bank();

    static void Main()
    {
        Console.WriteLine("=== Welcome to HDFC ATM ===\n");
        Console.WriteLine("Please insert your ATM card...");
        Thread.Sleep(2000);
        Console.WriteLine("Processing your request...");
        Thread.Sleep(2000);

        Console.Write("\nEnter your ATM PIN: ");
        int pin = Convert.ToInt32(Console.ReadLine());

        if (pin != 1234)
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\n---- User Menu ----");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "0":
                    Console.WriteLine("Thank you for using HDFC ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"\nYour Current Balance: ₹{account.Balance:F2}");
        if (account.Balance == 0)
        {
            Console.WriteLine("Note: Your balance is zero. Please deposit funds.");
        }
    }

    static void Deposit()
    {
        Console.Write("\nEnter amount to deposit: ₹");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > 0)
        {
            account.Balance += amount;
            Console.WriteLine($"Deposit successful. Updated Balance: ₹{account.Balance:F2} at {DateTime.Now}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a value greater than zero.");
        }
    }

    static void Withdraw()
    {
        Console.Write("\nEnter amount to withdraw: ₹");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (amount > account.Balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        Thread.Sleep(1500);
        Console.WriteLine("Processing your withdrawal...");
        Thread.Sleep(1500);

        account.Balance -= amount;
        Console.WriteLine($"Withdrawal successful. ₹{amount:F2} withdrawn.");
        Console.WriteLine($"Remaining Balance: ₹{account.Balance:F2}");
    }
}

using System;
using System.Collections.Generic;

class Expense
{
    public string Category;
    public double Amount;
}

class Program
{
    static List<Expense> expenses = new List<Expense>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Expense Tracker ---");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View All Expenses");
            Console.WriteLine("3. View Total Spending");
            Console.WriteLine("4. View Expenses by Category");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddExpense();
                    break;
                case "2":
                    ViewExpenses();
                    break;
                case "3":
                    ViewTotalSpending();
                    break;
                case "4":
                    ViewExpensesByCategory();
                    break;
                case "0":
                    Console.WriteLine("Thank you for using Expense Tracker!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddExpense()
    {
        Console.Write("Enter category (e.g., Food, Transport): ");
        string category = Console.ReadLine().ToLower().Trim();

        Console.Write("Enter amount: ");
        bool isValid = double.TryParse(Console.ReadLine(), out double amount);

        if (!isValid || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        Expense expense = new Expense { Category = category, Amount = amount };
        expenses.Add(expense);

        Console.WriteLine("✅ Expense added successfully!");
    }

    static void ViewExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }

        Console.WriteLine("\n--- Expense List ---");
        foreach (var expense in expenses)
        {
            Console.WriteLine($"Category: {expense.Category}, Amount: ₹{expense.Amount}");
        }
    }

    static void ViewTotalSpending()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses to calculate total.");
            return;
        }

        double total = 0;
        foreach (var expense in expenses)
        {
            total += expense.Amount;
        }

        Console.WriteLine($"\n💰 Total Amount Spent: ₹{total}");
    }

    static void ViewExpensesByCategory()
    {
        Console.Write("Enter category to view: ");
        string inputCategory = Console.ReadLine().ToLower().Trim();

        bool found = false;
        double totalInCategory = 0;

        foreach (var expense in expenses)
        {
            if (expense.Category.Contains(inputCategory))
            {
                Console.WriteLine($"Category: {expense.Category}, Amount: ₹{expense.Amount}");
                totalInCategory += expense.Amount;
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine($"🧾 Total spent in '{inputCategory}': ₹{totalInCategory}");
        }
        else
        {
            Console.WriteLine($"No expenses found in category '{inputCategory}'.");
        }
    }
}

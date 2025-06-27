using System;
using System.Collections.Generic;
using System.Threading;

class Book
{
    public string Title;
    public string Author;
    public int Stock;
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Library Management System ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Borrow Book");
            Console.WriteLine("5. Return Book");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an Option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewAllBooks();
                    break;
                case "3":
                    SearchBook();
                    break;
                case "4":
                    BorrowBook();
                    break;
                case "5":
                    ReturnBook();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("\n--- Add New Book ---");

        Book book = new Book();

        Console.Write("Enter Book Title: ");
        book.Title = Console.ReadLine().Trim();

        Console.Write("Enter Author Name: ");
        book.Author = Console.ReadLine().Trim();

        Console.Write("Enter Quantity: ");
        book.Stock = Convert.ToInt32(Console.ReadLine());

        books.Add(book);

        Console.WriteLine("✅ Book added successfully!");
    }

    static void ViewAllBooks()
    {
        Console.WriteLine("\n--- All Available Books ---");

        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine($"📘 Title: {book.Title}, Author: {book.Author}, Stock: {book.Stock}");
        }
    }

    static void SearchBook()
    {
        Console.WriteLine("\n--- Search Book ---");
        Console.Write("Enter Book Title to search: ");
        string keyword = Console.ReadLine().ToLower().Trim();

        bool found = false;

        foreach (var book in books)
        {
            if (book.Title.ToLower().Contains(keyword))
            {
                Console.WriteLine($"🔍 Found: Title: {book.Title}, Author: {book.Author}, Stock: {book.Stock}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"❌ No book found with title '{keyword}'.");
        }
    }

    static void BorrowBook()
    {
        Console.WriteLine("\n--- Borrow Book ---");
        Console.Write("Enter Book Title to Borrow: ");
        string title = Console.ReadLine().ToLower().Trim();

        Console.Write("Enter Quantity to Borrow: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        foreach (var book in books)
        {
            if (book.Title.ToLower().Contains(title))
            {
                if (book.Stock >= quantity)
                {
                    book.Stock -= quantity;
                    Console.WriteLine($"📚 {quantity} copy/copies of '{book.Title}' borrowed successfully at {DateTime.Now}.");
                    return;
                }
                else
                {
                    Console.WriteLine("⚠️ Not enough stock available.");
                    return;
                }
            }
        }

        Console.WriteLine("❌ Book not found.");
    }

    static void ReturnBook()
    {
        Console.WriteLine("\n--- Return Book ---");
        Console.Write("Enter Book Title to Return: ");
        string title = Console.ReadLine().ToLower().Trim();

        Console.Write("Enter Quantity to Return: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        foreach (var book in books)
        {
            if (book.Title.ToLower().Contains(title))
            {
                book.Stock += quantity;
                Console.WriteLine($"✅ {quantity} copy/copies of '{book.Title}' returned successfully at {DateTime.Now}.");
                return;
            }
        }

        Console.WriteLine("❌ Book not found.");
    }
}

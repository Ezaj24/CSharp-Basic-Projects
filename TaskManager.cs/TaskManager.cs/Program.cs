using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            Console.WriteLine("\n=== Task Manager ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("0. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter task name: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("✅ Task added.");
                    break;

                case "2":
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks added.");
                    }
                    else
                    {
                        Console.WriteLine("Tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Enter task number to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                    {
                        Console.WriteLine($"Deleted task: {tasks[index - 1]}");
                        tasks.RemoveAt(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

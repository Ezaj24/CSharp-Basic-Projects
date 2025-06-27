using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===");

        while (true)
        {
            Console.WriteLine("\nEnter 1 to Calculate, 0 to Exit:");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /, %): ");
            string op = Console.ReadLine();

            double result = 0;
            bool valid = true;

            switch (op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num2 != 0 ? num1 / num2 : throw new DivideByZeroException(); break;
                case "%": result = num1 % num2; break;
                default:
                    Console.WriteLine("Invalid Operator");
                    valid = false;
                    break;
            }

            if (valid)
                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("Goodbye!");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BMI Calculator ===");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your height (meters): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        string status = bmi switch
        {
            < 18.5 => "Underweight",
            < 25 => "Normal weight",
            < 30 => "Overweight",
            _ => "Obese"
        };

        Console.WriteLine($"\n{name}'s BMI Report");
        Console.WriteLine($"BMI: {bmi:F2}");
        Console.WriteLine($"Status: {status}");
    }
}

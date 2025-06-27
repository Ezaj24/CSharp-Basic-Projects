using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Unit Converter ===");
            Console.WriteLine("1. Kilometers to Miles");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("3. Kilograms to Pounds");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertKilometersToMiles();
                    break;
                case "2":
                    ConvertCelsiusToFahrenheit();
                    break;
                case "3":
                    ConvertKilogramsToPounds();
                    break;
                case "0":
                    Console.WriteLine("Thank you for using the Unit Converter!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ConvertKilometersToMiles()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km * 0.621371;
        Console.WriteLine($"{km} kilometers is equal to {miles:F2} miles.");
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit:F2}°F.");
    }

    static void ConvertKilogramsToPounds()
    {
        Console.Write("Enter weight in kilograms: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        double pounds = kg * 2.20462;
        Console.WriteLine($"{kg} kilograms is equal to {pounds:F2} pounds.");
    }
}

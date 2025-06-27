using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Grade Evaluator ===");

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter English Marks: ");
        int english = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Maths Marks: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Science Marks: ");
        int science = Convert.ToInt32(Console.ReadLine());

        int total = english + maths + science;
        double average = total / 3.0;
        string grade;

        if (average >= 90)
            grade = "A+";
        else if (average >= 80)
            grade = "A";
        else if (average >= 70)
            grade = "B";
        else if (average >= 60)
            grade = "C";
        else
            grade = "Fail";

        Console.WriteLine($"\n--- Report for {name} ---");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {grade}");
    }
}

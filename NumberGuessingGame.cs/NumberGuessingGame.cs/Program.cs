using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Number Guessing Game ===");

        Random random = new Random();
        int secret = random.Next(1, 11);
        int attempts = 0, maxAttempts = 5;

        Console.WriteLine("Guess a number between 1 and 10");

        while (attempts < maxAttempts)
        {
            Console.Write($"Attempt {attempts + 1}: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secret)
            {
                Console.WriteLine("🎉 You guessed it right!");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect. Try again.");
            }

            attempts++;
        }

        Console.WriteLine($"❌ You've used all attempts. The number was");
    }
}

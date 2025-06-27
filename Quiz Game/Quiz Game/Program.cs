using System;
using System.Collections.Generic;

class Question
{
    public string Text;
    public string OptionA;
    public string OptionB;
    public string OptionC;
    public string OptionD;
    public string CorrectOption;
}

class Program
{
    static List<Question> questions = new List<Question>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Quiz Game!");
        Console.WriteLine("Rules:");
        Console.WriteLine("- 5 Questions Total");
        Console.WriteLine("- Each question has 4 options (A, B, C, D)");
        Console.WriteLine("- Each correct answer gives you 10 points");
        Console.WriteLine("- You need at least 30 points to win\n");

        LoadQuestions();

        int score = 0;

        foreach (var q in questions)
        {
            Console.WriteLine("Question: " + q.Text);
            Console.WriteLine("A. " + q.OptionA);
            Console.WriteLine("B. " + q.OptionB);
            Console.WriteLine("C. " + q.OptionC);
            Console.WriteLine("D. " + q.OptionD);
            Console.Write("Your answer (A/B/C/D): ");
            string answer = Console.ReadLine().ToUpper().Trim();

            if (answer == q.CorrectOption.ToUpper())
            {
                Console.WriteLine("✅ Correct!\n");
                score += 10;
            }
            else
            {
                Console.WriteLine($"❌ Wrong! Correct answer was {q.CorrectOption}\n");
            }
        }

        Console.WriteLine("Your Final Score: " + score);
        if (score >= 30)
        {
            Console.WriteLine("🎉 Congratulations! You win!");
        }
        else
        {
            Console.WriteLine("💡 Better luck next time.");
        }
    }

    static void LoadQuestions()
    {
        questions.Add(new Question
        {
            Text = "What is the capital of France?",
            OptionA = "Berlin",
            OptionB = "Madrid",
            OptionC = "Paris",
            OptionD = "London",
            CorrectOption = "C"
        });

        questions.Add(new Question
        {
            Text = "Which planet is known as the Red Planet?",
            OptionA = "Mars",
            OptionB = "Venus",
            OptionC = "Jupiter",
            OptionD = "Saturn",
            CorrectOption = "A"
        });

        questions.Add(new Question
        {
            Text = "What is the square root of 64?",
            OptionA = "6",
            OptionB = "8",
            OptionC = "7",
            OptionD = "9",
            CorrectOption = "B"
        });

        questions.Add(new Question
        {
            Text = "Who wrote 'Romeo and Juliet'?",
            OptionA = "William Wordsworth",
            OptionB = "William Shakespeare",
            OptionC = "John Keats",
            OptionD = "Leo Tolstoy",
            CorrectOption = "B"
        });

        questions.Add(new Question
        {
            Text = "Which gas do plants absorb from the atmosphere?",
            OptionA = "Oxygen",
            OptionB = "Nitrogen",
            OptionC = "Carbon Dioxide",
            OptionD = "Helium",
            CorrectOption = "C"
        });
    }
}

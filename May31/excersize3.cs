using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, List<string> options, string correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }

    class Program3
    {
        public static void Main()
        {
            List<Question> questions = new List<Question>
        {
            new Question("What is 2 + 2?", new List<string> { "3", "4", "5" }, "4"),
            new Question("What is the capital of France?", new List<string> { "Berlin", "Paris", "Madrid" }, "Paris"),
            new Question("Which color is the sky?", new List<string> { "Blue", "Green", "Red" }, "Blue")
        };

            int score = 0;

            foreach (var question in questions)
            {
                // Display the question and options
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                // Get the user's answer
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                // Check if the answer is correct
                if (userAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Your score: {score}/{questions.Count}");
        }
    }
   
}

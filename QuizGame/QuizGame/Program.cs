namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CorrectAnswers = 0;
            string[] Questions = new string[]
            {

                "[1] Which city is known as the 'Eternal City'?",
                "[2] Which planet is famously called the 'Red Planet'?",
                "[3] What is the largest animal on Earth?",
                "[4] Which musical instrument has black and white keys?",
                "[5] In which country is the Eiffel Tower located?",
                "[6] What organ is responsible for thinking and decision making?",
                "[7] What natural phenomenon is caused by electrical discharge in the sky?",
                "[8] Which animal is often referred to as man's best friend?",
                "[9] What do we call a person who writes books?",
                "[10] What is the name of the largest ocean on Earth?"
            };

            string[] Answers = new string[]
            {
                 "Rome",
                 "Mars",
                 "Blue whale",
                 "Piano",
                 "France",
                 "Brain",
                 "Lightning",
                 "Dog",
                 "Author",
                 "Pacific Ocean"
            };

            Console.WriteLine("========================================");
            Console.WriteLine("\t((Welcome to the Game))");
            Console.WriteLine("========================================");
            Console.WriteLine("Please answer the following qestions...");
            Console.WriteLine("========================================");


            for (int i = 0; i < Questions.Length; i++)
            {
                try
                {
                    Console.WriteLine(Questions[i]);
                    string UserAnswer = Console.ReadLine();
                    bool result = IsTheAnswerCorrect(UserAnswer, Answers[i]);
                    if (result == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct Answer !");
                        ++CorrectAnswers;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, Incorrect Answer...");
                        Console.WriteLine($"The Correct Answer is : {Answers[i]}");
                        Console.WriteLine("----------------------------------------");

                    }
                    Console.ResetColor();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);


                }

            }


            double ScorePercentage = CorrectAnswers / Questions.Length * 100;

            Console.WriteLine($"Your Score is {CorrectAnswers} of {Questions.Length}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Your percentage of Score is {Math.Round(ScorePercentage, 2)}%");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Quiz Completed ,Thank You For Playing.. ");
            Console.WriteLine("========================================");



        }
        private static bool IsTheAnswerCorrect(string userInput, string correctAnswer)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer Is Empty");
            }
            //the answer is right
            if (string.Equals(userInput, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

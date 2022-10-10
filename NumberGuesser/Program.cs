using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo(); //run GetAppInfo method

            GreetUserName(); //run GreetUserName method


            while (true)
            {


                // init correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();
                //  init correct number
                int correctNumber = random.Next(1, 10);

                // Init gusse var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10 ");

                //  While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {

                        //  Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");

                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //  Match Guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number please try again...");

                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Your Number is Correct!!!");


                // Ask to play agian
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    PrintColorMessage(ConsoleColor.Magenta, "Thanks for play!!! Come Again!!");
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Curtrick Walton";

            PrintColorMessage(ConsoleColor.Cyan, $"{appName}: \nVersion {appVersion} \n{appAuthor}");
            //  Change text color
            // Console.ForegroundColor = ConsoleColor.Cyan;

            // //  Write out app info
            // Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // // Reset text color
            // Console.ResetColor();
        }
        static void GreetUserName()
        {
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        //  Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            //  Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
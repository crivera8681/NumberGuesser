using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNum = random.Next(1, 11);
                int guessNum = 0;

                Console.WriteLine("\nGuess a number between 1 and 10");

                while (correctNum != guessNum)
                {
                    string inputNum = Console.ReadLine();

                    //making sure it is a number

                    if (!int.TryParse(inputNum, out guessNum))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please pick a number!");
                        continue;
                    }

                    //Cast to int and put in guess var

                    guessNum = Int32.Parse(inputNum);

                    //Match guess to correct Number

                    if (guessNum != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Congrats! You guessed the correct number!");

                PrintColorMessage(ConsoleColor.Yellow, "Want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
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
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appCreator = "Carlos Rivera";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} \nVersion: {1} \nBy: {2} \n", appName, appVersion, appCreator);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            string userName;

            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();

            Console.WriteLine("\nHello {0}, let's play a game...", userName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

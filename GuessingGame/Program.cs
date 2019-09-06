using System;

namespace GuessingGame
{
    class Program
    {
        // Generate a random number between two numbers
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        static void Main(string[] args)
        {
            int secretNumber = Program.RandomNumber(0, 10);

            bool done = false;

            while (!done)
            {
                Console.WriteLine("Guess a Number");
                string guessedNumber = Console.ReadLine();
                int convertedGuess = Convert.ToInt32(guessedNumber);
                bool userGuessedCorrect = secretNumber == convertedGuess;// guessedNumber.Equals("7");
                bool userGuessedZero = convertedGuess == 0; //guessedNumber.Equals("0");
                bool userGuessedNegOne = convertedGuess == -1; //guessedNumber.Equals("-1");

                if (userGuessedCorrect)
                {
                    Console.WriteLine("You Won");
                    done = true;
                }
                else if (userGuessedZero)
                {
                    Console.WriteLine("Please guess a number between 1-10 until you have Won");
                }
                else if (userGuessedNegOne)
                {
                    Environment.Exit(0);
                }
                else if (convertedGuess < secretNumber)
                {
                    Console.WriteLine("Your Guess Is Lower than the secret number");
                }
                else if (convertedGuess > secretNumber)
                {
                    Console.WriteLine("Your Guess Is Greater than the secret number");
                }
                Console.WriteLine("hit enter to continue");
                Console.ReadLine();
            }


            //this is where we can add more code so the user has one more chance to guess correctly
            //Ask the user to guess again
            //Use a ReadLine() to read the number they typed and Save their guess in the guessedNumber variable
            //If guessedNumber.Equals("7"), tell user they won
            //else.....tell user they lost
        }
    }
}
